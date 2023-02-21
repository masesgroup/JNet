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

namespace Java.Rmi.Server
{
    #region RMISocketFactory
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMISocketFactory.html
    /// </summary>
    public partial class RMISocketFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RMISocketFactory>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RMISocketFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RMISocketFactory(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.RMISocketFactory";

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

    #region RMIFailureHandler
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIFailureHandler.html
    /// </summary>
    public partial class RMIFailureHandler : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RMIFailureHandler>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RMIFailureHandler() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RMIFailureHandler(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.RMIFailureHandler";

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

    #region RMIClientSocketFactory
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIClientSocketFactory.html
    /// </summary>
    public partial class RMIClientSocketFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RMIClientSocketFactory>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RMIClientSocketFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RMIClientSocketFactory(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.RMIClientSocketFactory";

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

    #region UnicastRemoteObject
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/UnicastRemoteObject.html
    /// </summary>
    public partial class UnicastRemoteObject : Java.Rmi.Server.RemoteServer
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UnicastRemoteObject() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public UnicastRemoteObject(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.UnicastRemoteObject";

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

    #region RemoteObjectInvocationHandler
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteObjectInvocationHandler.html
    /// </summary>
    public partial class RemoteObjectInvocationHandler : Java.Rmi.Server.RemoteObject
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RemoteObjectInvocationHandler() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RemoteObjectInvocationHandler(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.RemoteObjectInvocationHandler";

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

    #region RMIServerSocketFactory
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIServerSocketFactory.html
    /// </summary>
    public partial class RMIServerSocketFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RMIServerSocketFactory>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RMIServerSocketFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RMIServerSocketFactory(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.RMIServerSocketFactory";

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

    #region RemoteObject
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteObject.html
    /// </summary>
    public partial class RemoteObject : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RemoteObject>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RemoteObject() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RemoteObject(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.RemoteObject";

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

    #region RemoteRef
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteRef.html
    /// </summary>
    public partial class RemoteRef : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RemoteRef>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RemoteRef() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RemoteRef(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.RemoteRef";

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

    #region ServerCloneException
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ServerCloneException.html
    /// </summary>
    public partial class ServerCloneException : Java.Lang.CloneNotSupportedException
    {
        public ServerCloneException() { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.ServerCloneException";

        // TODO: complete the class

    }
    #endregion

    #region RemoteServer
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteServer.html
    /// </summary>
    public partial class RemoteServer : Java.Rmi.Server.RemoteObject
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RemoteServer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RemoteServer(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.RemoteServer";

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

    #region UID
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/UID.html
    /// </summary>
    public partial class UID : MASES.JCOBridge.C2JBridge.JVMBridgeBase<UID>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UID() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public UID(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.UID";

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

    #region ObjID
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ObjID.html
    /// </summary>
    public partial class ObjID : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ObjID>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ObjID() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ObjID(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.ObjID";

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

    #region RMIClassLoader
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIClassLoader.html
    /// </summary>
    public partial class RMIClassLoader : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RMIClassLoader>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RMIClassLoader() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RMIClassLoader(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.RMIClassLoader";

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

    #region RMIClassLoaderSpi
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIClassLoaderSpi.html
    /// </summary>
    public partial class RMIClassLoaderSpi : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RMIClassLoaderSpi>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RMIClassLoaderSpi() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RMIClassLoaderSpi(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.RMIClassLoaderSpi";

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

    #region ServerNotActiveException
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ServerNotActiveException.html
    /// </summary>
    public partial class ServerNotActiveException : Java.Lang.Exception
    {
        public ServerNotActiveException() { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.ServerNotActiveException";

        // TODO: complete the class

    }
    #endregion

    #region Unreferenced
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/Unreferenced.html
    /// </summary>
    public partial class Unreferenced : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Unreferenced>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Unreferenced() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Unreferenced(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.Unreferenced";

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

    #region ExportException
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ExportException.html
    /// </summary>
    public partial class ExportException : Java.Rmi.RemoteException
    {
        public ExportException() { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.rmi.server.ExportException";

        // TODO: complete the class

    }
    #endregion


}