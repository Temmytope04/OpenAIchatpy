﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics;
using System.Threading;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Internals
{
    /// <summary>
    /// This partial class encapsulates the State Machine.
    /// This controls if we are in either the Ping or Post state.
    /// </summary>
    /// <remarks>
    /// RULES FOR BACKOFF:
    /// POST: We expect to Post once every second, but no longer than once every 20 seconds.
    /// If we exceed the 20 seconds, we consider this a failure and Stop Posting.
    /// We will wait 60 seconds before Pinging again.
    /// PING: We expect to Ping once every 5 seconds, but no longer than once every 60 seconds.
    /// If we exceed the 60 seconds, we will wait 60 seconds before Pinging again.
    /// </remarks>
    internal partial class Manager
    {
        private Thread? _thread;

        private readonly State _state = new();
        private TimeSpan _period;
        private bool _shouldCollect = false;
        private Action _callbackAction = () => { };
        private Func<bool> _evaluateBackoff = () => false;

        private readonly TimeSpan _pingPeriod = TimeSpan.FromSeconds(5);
        private readonly TimeSpan _postPeriod = TimeSpan.FromSeconds(1);
        private readonly TimeSpan _backoffPeriod = TimeSpan.FromMinutes(1);
        private readonly TimeSpan _maximumPingInterval = TimeSpan.FromSeconds(60);
        private readonly TimeSpan _maximumPostInterval = TimeSpan.FromSeconds(20);

        internal bool ShouldCollect() => _shouldCollect;

        private void InitializeState()
        {
            _thread = new Thread(() => Run())
            {
                Name = "LiveMetrics State Machine",
                IsBackground = true,
            };

            SetPingState();
            _thread.Start();
        }

        private void SetPingState()
        {
            _state.Update(LiveMetricsState.Ping);
            _shouldCollect = false;
            _callbackAction = OnPing;
            _period = _pingPeriod;
            _evaluateBackoff = () => DateTimeOffset.UtcNow - _lastSuccessfulPing > _maximumPingInterval;

            // Must reset the timestamp here.
            // This is used in determining if we should Backoff.
            // If we've been in another state for X amount of time, that may exceed our maximum interval and immediately trigger a Backoff.
            _lastSuccessfulPing = DateTimeOffset.UtcNow;
        }

        private void SetPostState()
        {
            _state.Update(LiveMetricsState.Post);
            _shouldCollect = true;
            _callbackAction = OnPost;
            _period = _postPeriod;
            _evaluateBackoff = () => DateTimeOffset.UtcNow - _lastSuccessfulPost > _maximumPostInterval;

            // Must reset the timestamp here.
            // This is used in determining if we should Backoff.
            // If we've been in another state for X amount of time, that may exceed our maximum interval and immediately trigger a Backoff.
            _lastSuccessfulPost = DateTimeOffset.UtcNow;
        }

        private void SetBackoffState()
        {
            _state.Update(LiveMetricsState.Backoff);
            _shouldCollect = false;
            _callbackAction = OnBackoffConcluded;
            _period = _backoffPeriod;
            _evaluateBackoff = () => false;
        }

        private void OnBackoffConcluded()
        {
            // when the backoff period is concluded, we switch to Ping.
            SetPingState();
        }

        /// <summary>
        /// This is the main loop that controls the State Machine and will run indefinitely.
        /// This State Machine uses delegates for the callback action and the backoff evaluation.
        /// These delegates are updated whenever a state is changed.
        /// </summary>
        private void Run()
        {
            while (true)
            {
                var callbackStarted = DateTimeOffset.UtcNow;

                _callbackAction.Invoke();

                var timeSpentInThisCallback = DateTimeOffset.UtcNow - callbackStarted;

                TimeSpan nextTick;

                // Check if we need to backoff.
                if (_evaluateBackoff.Invoke())
                {
                    Debug.WriteLine($"{DateTime.Now}: Backing off.");
                    SetBackoffState();
                    nextTick = _period;
                }
                else
                {
                    // Subtract the time spent in this tick when scheduling the next tick so that the average period is close to the intended.
                    nextTick = _period - timeSpentInThisCallback;
                    nextTick = nextTick > TimeSpan.Zero ? nextTick : TimeSpan.Zero;
                }

                _thread!.Join(nextTick);
            }
        }
    }
}
