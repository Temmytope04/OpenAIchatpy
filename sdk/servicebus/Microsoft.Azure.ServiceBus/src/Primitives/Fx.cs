﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.ServiceBus.Primitives
{
    using System;
    using System.Diagnostics;

    internal static class Fx
    {
	    private static ExceptionUtility _exceptionUtility;

        public static ExceptionUtility Exception
        {
            get
            {
                if (_exceptionUtility == null)
                {
                    _exceptionUtility = new ExceptionUtility();
                }

                return _exceptionUtility;
            }
        }

        public static class Tag
        {
            public enum CacheAttrition
            {
                None,
                ElementOnTimer,

                // A finalizer/WeakReference based cache, where the elements are held by WeakReferences (or hold an
                // inner object by a WeakReference), and the weakly-referenced object has a finalizer which cleans the
                // item from the cache.
                ElementOnGC,

                // A cache that provides a per-element token, delegate, interface, or other piece of context that can
                // be used to remove the element (such as IDisposable).
                ElementOnCallback,

                FullPurgeOnTimer,
                FullPurgeOnEachAccess,
                PartialPurgeOnTimer,
                PartialPurgeOnEachAccess,
            }

            public enum Location
            {
                InProcess,
                OutOfProcess,
                LocalSystem,
                LocalOrRemoteSystem, // as in a file that might live on a share
                RemoteSystem,
            }

            public enum SynchronizationKind
            {
                LockStatement,
                MonitorWait,
                MonitorExplicit,
                InterlockedNoSpin,
                InterlockedWithSpin,

                // Same as LockStatement if the field type is object.
                FromFieldType,
            }

            [Flags]
            public enum BlocksUsing
            {
                MonitorEnter,
                MonitorWait,
                ManualResetEvent,
                AutoResetEvent,
                AsyncResult,
                IAsyncResult,
                PInvoke,
                InputQueue,
                ThreadNeutralSemaphore,
                PrivatePrimitive,
                OtherInternalPrimitive,
                OtherFrameworkPrimitive,
                OtherInterop,
                Other,

                NonBlocking, // For use by non-blocking SynchronizationPrimitives such as IOThreadScheduler
            }

            public static class Strings
            {
                internal const string ExternallyManaged = "externally managed";
                internal const string AppDomain = "AppDomain";
                internal const string DeclaringInstance = "instance of declaring class";
                internal const string Unbounded = "unbounded";
                internal const string Infinite = "infinite";
            }

            [AttributeUsage(
                AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Constructor,
                AllowMultiple = true,
                Inherited = false)]
            [Conditional("CODE_ANALYSIS")]
            public sealed class ExternalResourceAttribute : Attribute
            {
	            private readonly Location _location;
	            private readonly string _description;

                public ExternalResourceAttribute(Location location, string description)
                {
                    this._location = location;
                    this._description = description;
                }

                public Location Location => _location;

                public string Description => _description;
            }

            [AttributeUsage(AttributeTargets.Field)]
            [Conditional("CODE_ANALYSIS")]
            public sealed class CacheAttribute : Attribute
            {
	            private readonly Type _elementType;
	            private readonly CacheAttrition _cacheAttrition;

                public CacheAttribute(Type elementType, CacheAttrition cacheAttrition)
                {
                    Scope = Strings.DeclaringInstance;
                    SizeLimit = Strings.Unbounded;
                    Timeout = Strings.Infinite;

                    if (elementType == null)
                    {
                        throw Exception.ArgumentNull(nameof(elementType));
                    }

                    this._elementType = elementType;
                    this._cacheAttrition = cacheAttrition;
                }

                public Type ElementType => _elementType;

                public CacheAttrition CacheAttrition => _cacheAttrition;

                public string Scope { get; set; }

                public string SizeLimit { get; set; }

                public string Timeout { get; set; }
            }

            [AttributeUsage(AttributeTargets.Field)]
            [Conditional("CODE_ANALYSIS")]
            public sealed class QueueAttribute : Attribute
            {
	            private readonly Type _elementType;

                public QueueAttribute(Type elementType)
                {
                    Scope = Strings.DeclaringInstance;
                    SizeLimit = Strings.Unbounded;

                    if (elementType == null)
                    {
                        throw Exception.ArgumentNull(nameof(elementType));
                    }

                    this._elementType = elementType;
                }

                public Type ElementType => _elementType;

                public string Scope { get; set; }

                public string SizeLimit { get; set; }

                public bool StaleElementsRemovedImmediately { get; set; }

                public bool EnqueueThrowsIfFull { get; set; }
            }

            // Set on a class when that class uses lock (this) - acts as though it were on a field
            //     object this;
            [AttributeUsage(AttributeTargets.Field | AttributeTargets.Class, Inherited = false)]
            [Conditional("CODE_ANALYSIS")]
            public sealed class SynchronizationObjectAttribute : Attribute
            {
                public SynchronizationObjectAttribute()
                {
                    Blocking = true;
                    Scope = Strings.DeclaringInstance;
                    Kind = SynchronizationKind.FromFieldType;
                }

                public bool Blocking { get; set; }

                public string Scope { get; set; }

                public SynchronizationKind Kind { get; set; }
            }

            [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = true)]
            [Conditional("CODE_ANALYSIS")]
            public sealed class SynchronizationPrimitiveAttribute : Attribute
            {
	            private readonly BlocksUsing _blocksUsing;

                public SynchronizationPrimitiveAttribute(BlocksUsing blocksUsing)
                {
                    this._blocksUsing = blocksUsing;
                }

                public BlocksUsing BlocksUsing => _blocksUsing;

                public bool SupportsAsync { get; set; }

                public bool Spins { get; set; }

                public string ReleaseMethod { get; set; }

                [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor, Inherited = false)]
                [Conditional("CODE_ANALYSIS")]
                public sealed class BlockingAttribute : Attribute
                {
                    public string CancelMethod { get; set; }

                    public Type CancelDeclaringType { get; set; }

                    public string Conditional { get; set; }
                }

                // Sometime a method will call a conditionally-blocking method in such a way that it is guaranteed
                // not to block (i.e. the condition can be Asserted false).  Such a method can be marked as
                // GuaranteeNonBlocking as an assertion that the method doesn't block despite calling a blocking method.
                //
                // Methods that don't call blocking methods and aren't marked as Blocking are assumed not to block, so
                // they do not require this attribute.
                [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor, Inherited = false)]
                [Conditional("CODE_ANALYSIS")]
                public sealed class GuaranteeNonBlockingAttribute : Attribute
                {
                }

                [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor, Inherited = false)]
                [Conditional("CODE_ANALYSIS")]
                public sealed class NonThrowingAttribute : Attribute
                {
                }

                [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor, AllowMultiple = true, Inherited = false)]
                [Conditional("CODE_ANALYSIS")]
                public class ThrowsAttribute : Attribute
                {
	                private readonly Type _exceptionType;
	                private readonly string _diagnosis;

                    public ThrowsAttribute(Type exceptionType, string diagnosis)
                    {
                        if (exceptionType == null)
                        {
                            throw Exception.ArgumentNull(nameof(exceptionType));
                        }
                        if (string.IsNullOrEmpty(diagnosis))
                        {
                            ////throw Fx.Exception.ArgumentNullOrEmpty("diagnosis");
                            throw new ArgumentNullException(nameof(diagnosis));
                        }

                        this._exceptionType = exceptionType;
                        this._diagnosis = diagnosis;
                    }

                    public Type ExceptionType => _exceptionType;

                    public string Diagnosis => _diagnosis;
                }

                [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor, Inherited = false)]
                [Conditional("CODE_ANALYSIS")]
                public sealed class InheritThrowsAttribute : Attribute
                {
                    public Type FromDeclaringType { get; set; }

                    public string From { get; set; }
                }

                [AttributeUsage(
                    AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class |
                    AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method |
                    AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface |
                    AttributeTargets.Delegate, AllowMultiple = false,
                    Inherited = false)]
                [Conditional("CODE_ANALYSIS")]
                public sealed class SecurityNoteAttribute : Attribute
                {
                    public string Critical { get; set; }

                    public string Safe { get; set; }

                    public string Miscellaneous { get; set; }
                }
            }
        }
    }
}