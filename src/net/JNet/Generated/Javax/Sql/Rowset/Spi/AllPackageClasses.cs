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

using MASES.JCOBridge.C2JBridge.JVMInterop;

namespace Javax.Sql.Rowset.Spi
{
    #region SyncFactory
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncFactory.html"/>
    /// </summary>
    public partial class SyncFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SyncFactory>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SyncFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SyncFactory(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("javax.sql.rowset.spi.SyncFactory");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.sql.rowset.spi.SyncFactory";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region SyncFactoryException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncFactoryException.html"/>
    /// </summary>
    public partial class SyncFactoryException : Java.Sql.SQLException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.sql.rowset.spi.SyncFactoryException";

        // TODO: complete the class

    }
    #endregion

    #region SyncProvider
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html"/>
    /// </summary>
    public partial class SyncProvider : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SyncProvider>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SyncProvider() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SyncProvider(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("javax.sql.rowset.spi.SyncProvider");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.sql.rowset.spi.SyncProvider";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region SyncProviderException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProviderException.html"/>
    /// </summary>
    public partial class SyncProviderException : Java.Sql.SQLException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.sql.rowset.spi.SyncProviderException";

        // TODO: complete the class

    }
    #endregion

    #region SyncResolver
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html"/>
    /// </summary>
    public partial class SyncResolver : Javax.Sql.RowSet
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SyncResolver() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SyncResolver(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("javax.sql.rowset.spi.SyncResolver");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.sql.rowset.spi.SyncResolver";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region TransactionalWriter
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/TransactionalWriter.html"/>
    /// </summary>
    public partial class TransactionalWriter : Javax.Sql.RowSetWriter
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TransactionalWriter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TransactionalWriter(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("javax.sql.rowset.spi.TransactionalWriter");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.sql.rowset.spi.TransactionalWriter";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region XmlReader
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/XmlReader.html"/>
    /// </summary>
    public partial class XmlReader : Javax.Sql.RowSetReader
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public XmlReader() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public XmlReader(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("javax.sql.rowset.spi.XmlReader");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.sql.rowset.spi.XmlReader";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region XmlWriter
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/XmlWriter.html"/>
    /// </summary>
    public partial class XmlWriter : Javax.Sql.RowSetWriter
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public XmlWriter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public XmlWriter(params object[] args) : base(args) { }

        private static IJavaType LocalClazz = ClazzOf("javax.sql.rowset.spi.XmlWriter");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.sql.rowset.spi.XmlWriter";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion


}