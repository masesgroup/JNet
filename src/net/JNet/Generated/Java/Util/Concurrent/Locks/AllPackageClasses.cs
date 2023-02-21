/*
*  Copyright 2023 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

namespace Java.Util.Concurrent.Locks
{
    #region ReentrantLock
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html
    /// </summary>
    public partial class ReentrantLock : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ReentrantLock>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ReentrantLock() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ReentrantLock(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.concurrent.locks.ReentrantLock";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => false;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region LockSupport
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/LockSupport.html
    /// </summary>
    public partial class LockSupport : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LockSupport>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LockSupport() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LockSupport(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.concurrent.locks.LockSupport";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => false;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region StampedLock
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html
    /// </summary>
    public partial class StampedLock : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StampedLock>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StampedLock() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StampedLock(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.concurrent.locks.StampedLock";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => false;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ReentrantReadWriteLock
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html
    /// </summary>
    public partial class ReentrantReadWriteLock : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ReentrantReadWriteLock>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ReentrantReadWriteLock() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ReentrantReadWriteLock(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.concurrent.locks.ReentrantReadWriteLock";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => false;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class
        #region ReadLock
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.ReadLock.html
        /// </summary>
        public partial class ReadLock : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ReadLock>
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ReadLock() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ReadLock(params object[] args) : base(args) { }

            /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
            public override string ClassName => "java.util.concurrent.locks.ReentrantReadWriteLock$ReadLock";

            /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
            public override bool IsAbstract => false;
            
            /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
            public override bool IsCloseable => false;
            
            /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
            public override bool IsInterface => false;
            
            /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
            public override bool IsStatic => true;

            // TODO: complete the class
        }
        #endregion

        #region WriteLock
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html
        /// </summary>
        public partial class WriteLock : MASES.JCOBridge.C2JBridge.JVMBridgeBase<WriteLock>
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public WriteLock() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public WriteLock(params object[] args) : base(args) { }

            /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
            public override string ClassName => "java.util.concurrent.locks.ReentrantReadWriteLock$WriteLock";

            /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
            public override bool IsAbstract => false;
            
            /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
            public override bool IsCloseable => false;
            
            /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
            public override bool IsInterface => false;
            
            /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
            public override bool IsStatic => true;

            // TODO: complete the class
        }
        #endregion


    }
    #endregion

    #region AbstractOwnableSynchronizer
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractOwnableSynchronizer.html
    /// </summary>
    public partial class AbstractOwnableSynchronizer : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AbstractOwnableSynchronizer>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AbstractOwnableSynchronizer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AbstractOwnableSynchronizer(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.concurrent.locks.AbstractOwnableSynchronizer";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => true;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region AbstractQueuedSynchronizer
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.html
    /// </summary>
    public partial class AbstractQueuedSynchronizer : Java.Util.Concurrent.Locks.AbstractOwnableSynchronizer
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AbstractQueuedSynchronizer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AbstractQueuedSynchronizer(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.concurrent.locks.AbstractQueuedSynchronizer";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => true;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class
        #region ConditionObject
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedSynchronizer.ConditionObject.html
        /// </summary>
        public partial class ConditionObject : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConditionObject>
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ConditionObject() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ConditionObject(params object[] args) : base(args) { }

            /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
            public override string ClassName => "java.util.concurrent.locks.AbstractQueuedSynchronizer$ConditionObject";

            /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
            public override bool IsAbstract => false;
            
            /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
            public override bool IsCloseable => false;
            
            /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
            public override bool IsInterface => false;
            
            /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
            public override bool IsStatic => false;

            // TODO: complete the class
        }
        #endregion


    }
    #endregion

    #region AbstractQueuedLongSynchronizer
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html
    /// </summary>
    public partial class AbstractQueuedLongSynchronizer : Java.Util.Concurrent.Locks.AbstractOwnableSynchronizer
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AbstractQueuedLongSynchronizer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AbstractQueuedLongSynchronizer(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.concurrent.locks.AbstractQueuedLongSynchronizer";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => true;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class
        #region ConditionObject
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.ConditionObject.html
        /// </summary>
        public partial class ConditionObject : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConditionObject>
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ConditionObject() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ConditionObject(params object[] args) : base(args) { }

            /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
            public override string ClassName => "java.util.concurrent.locks.AbstractQueuedLongSynchronizer$ConditionObject";

            /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
            public override bool IsAbstract => false;
            
            /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
            public override bool IsCloseable => false;
            
            /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
            public override bool IsInterface => false;
            
            /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
            public override bool IsStatic => false;

            // TODO: complete the class
        }
        #endregion


    }
    #endregion

    #region Condition
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/Condition.html
    /// </summary>
    public partial class Condition : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Condition>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Condition() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Condition(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.concurrent.locks.Condition";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => true;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => true;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ReadWriteLock
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReadWriteLock.html
    /// </summary>
    public partial class ReadWriteLock : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ReadWriteLock>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ReadWriteLock() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ReadWriteLock(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.concurrent.locks.ReadWriteLock";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => true;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => true;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region Lock
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/Lock.html
    /// </summary>
    public partial class Lock : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Lock>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Lock() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Lock(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.concurrent.locks.Lock";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => true;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => true;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion


}