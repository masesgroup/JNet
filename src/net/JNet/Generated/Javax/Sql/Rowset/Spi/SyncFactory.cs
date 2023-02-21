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

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql.Rowset.Spi
{
    #region SyncFactory
    public partial class SyncFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncFactory.html#ROWSET_SYNC_PROVIDER
        /// </summary>
        public static string ROWSET_SYNC_PROVIDER => Clazz.GetField<string>("ROWSET_SYNC_PROVIDER");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncFactory.html#ROWSET_SYNC_VENDOR
        /// </summary>
        public static string ROWSET_SYNC_VENDOR => Clazz.GetField<string>("ROWSET_SYNC_VENDOR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncFactory.html#ROWSET_SYNC_PROVIDER_VERSION
        /// </summary>
        public static string ROWSET_SYNC_PROVIDER_VERSION => Clazz.GetField<string>("ROWSET_SYNC_PROVIDER_VERSION");
        
        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncFactory.html#getLogger() throws javax.sql.rowset.spi.SyncFactoryException https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncFactory.html#setLogger(java.util.logging.Logger)
        /// </summary>
        public static Java.Util.Logging.Logger Logger
        {
            get { return SExecute<Java.Util.Logging.Logger>("getLogger"); } set { SExecute("setLogger", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncFactory.html#getSyncFactory()
        /// </summary>
        public static Javax.Sql.Rowset.Spi.SyncFactory GetSyncFactory()
        {
            return SExecute<Javax.Sql.Rowset.Spi.SyncFactory>("getSyncFactory");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncFactory.html#getInstance(java.lang.String) throws javax.sql.rowset.spi.SyncFactoryException
        /// </summary>
        public static Javax.Sql.Rowset.Spi.SyncProvider GetInstance(string arg0)
        {
            return SExecute<Javax.Sql.Rowset.Spi.SyncProvider>("getInstance", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncFactory.html#registerProvider(java.lang.String) throws javax.sql.rowset.spi.SyncFactoryException
        /// </summary>
        public static void RegisterProvider(string arg0)
        {
            SExecute("registerProvider", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncFactory.html#setJNDIContext(javax.naming.Context) throws javax.sql.rowset.spi.SyncFactoryException
        /// </summary>
        public static void SetJNDIContext(Javax.Naming.Context arg0)
        {
            SExecute("setJNDIContext", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncFactory.html#unregisterProvider(java.lang.String) throws javax.sql.rowset.spi.SyncFactoryException
        /// </summary>
        public static void UnregisterProvider(string arg0)
        {
            SExecute("unregisterProvider", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncFactory.html#setLogger(java.util.logging.Logger,java.util.logging.Level)
        /// </summary>
        public static void SetLogger(Java.Util.Logging.Logger arg0, Java.Util.Logging.Level arg1)
        {
            SExecute("setLogger", arg0, arg1);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}