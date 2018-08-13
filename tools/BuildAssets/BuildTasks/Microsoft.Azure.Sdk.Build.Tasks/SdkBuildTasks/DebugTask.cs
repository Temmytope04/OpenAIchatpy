﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Build.Tasks
{
    using Microsoft.Build.Utilities;
    using System;
    using System.Diagnostics;
    using System.Reflection;
    using ThreadTask = System.Threading.Tasks;



    /// <summary>
    /// Utility task to help debug
    /// </summary>
    public class DebugTask : Task
    {
        /// <summary>
        /// Default timeout
        /// </summary>
        const int DEFAULT_TASK_TIMEOUT = 30000;

        /// <summary>
        /// Task Timeout
        /// </summary>
        public int Timeoutmiliseconds { get; set; }

        public override bool Execute()
        {
            if (Timeoutmiliseconds == 0) Timeoutmiliseconds = DEFAULT_TASK_TIMEOUT;

            ThreadTask.Task waitingTask = ThreadTask.Task.Run(() =>
            {
                Console.WriteLine("Press any key to continue or it will continue in {0} seconds", (Timeoutmiliseconds / 1000));
                GetProcessInfo();
                Console.ReadLine();
            });

            waitingTask.Wait(TimeSpan.FromMilliseconds(Timeoutmiliseconds));
            return true;
        }

        public virtual bool ExecWithInfo(string info)
        {
            Console.WriteLine("Debugging {0}", info);
            return Execute();
        }

        private void GetProcessInfo()
        {
            Process proc = Process.GetCurrentProcess();
            Console.WriteLine("{0}: {1}", proc.ProcessName, proc.Id.ToString());
        }
    }
}
