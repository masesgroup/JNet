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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

namespace Java.Rmi
{
    #region AccessException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/AccessException.html"/>
    /// </summary>
    public partial class AccessException : Java.Rmi.RemoteException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.AccessException";

        // TODO: complete the class

    }
    #endregion

    #region AlreadyBoundException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/AlreadyBoundException.html"/>
    /// </summary>
    public partial class AlreadyBoundException : Java.Lang.Exception
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.AlreadyBoundException";

        // TODO: complete the class

    }
    #endregion

    #region ConnectException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/ConnectException.html"/>
    /// </summary>
    public partial class ConnectException : Java.Rmi.RemoteException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.ConnectException";

        // TODO: complete the class

    }
    #endregion

    #region ConnectIOException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/ConnectIOException.html"/>
    /// </summary>
    public partial class ConnectIOException : Java.Rmi.RemoteException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.ConnectIOException";

        // TODO: complete the class

    }
    #endregion

    #region MarshalException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/MarshalException.html"/>
    /// </summary>
    public partial class MarshalException : Java.Rmi.RemoteException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.MarshalException";

        // TODO: complete the class

    }
    #endregion

    #region MarshalledObject
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/MarshalledObject.html"/>
    /// </summary>
    public partial class MarshalledObject : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MarshalledObject>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MarshalledObject() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MarshalledObject(params object[] args) : base(args) { }

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.MarshalledObject";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region MarshalledObject<T>
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/MarshalledObject.html"/>
    /// </summary>
    public partial class MarshalledObject<T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MarshalledObject<T>>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MarshalledObject() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MarshalledObject(params object[] args) : base(args) { }

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.MarshalledObject";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region Naming
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/Naming.html"/>
    /// </summary>
    public partial class Naming : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Naming>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Naming() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Naming(params object[] args) : base(args) { }

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.Naming";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region NoSuchObjectException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/NoSuchObjectException.html"/>
    /// </summary>
    public partial class NoSuchObjectException : Java.Rmi.RemoteException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.NoSuchObjectException";

        // TODO: complete the class

    }
    #endregion

    #region NotBoundException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/NotBoundException.html"/>
    /// </summary>
    public partial class NotBoundException : Java.Lang.Exception
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.NotBoundException";

        // TODO: complete the class

    }
    #endregion

    #region Remote
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/Remote.html"/>
    /// </summary>
    public partial class Remote : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Remote>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Remote() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Remote(params object[] args) : base(args) { }

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.Remote";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region RemoteException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/RemoteException.html"/>
    /// </summary>
    public partial class RemoteException : Java.Io.IOException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.RemoteException";

        // TODO: complete the class

    }
    #endregion

    #region ServerError
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/ServerError.html"/>
    /// </summary>
    public partial class ServerError : Java.Rmi.RemoteException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.ServerError";

        // TODO: complete the class

    }
    #endregion

    #region ServerException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/ServerException.html"/>
    /// </summary>
    public partial class ServerException : Java.Rmi.RemoteException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.ServerException";

        // TODO: complete the class

    }
    #endregion

    #region StubNotFoundException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/StubNotFoundException.html"/>
    /// </summary>
    public partial class StubNotFoundException : Java.Rmi.RemoteException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.StubNotFoundException";

        // TODO: complete the class

    }
    #endregion

    #region UnexpectedException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/UnexpectedException.html"/>
    /// </summary>
    public partial class UnexpectedException : Java.Rmi.RemoteException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.UnexpectedException";

        // TODO: complete the class

    }
    #endregion

    #region UnknownHostException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/UnknownHostException.html"/>
    /// </summary>
    public partial class UnknownHostException : Java.Rmi.RemoteException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.UnknownHostException";

        // TODO: complete the class

    }
    #endregion

    #region UnmarshalException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/UnmarshalException.html"/>
    /// </summary>
    public partial class UnmarshalException : Java.Rmi.RemoteException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.rmi.UnmarshalException";

        // TODO: complete the class

    }
    #endregion


}