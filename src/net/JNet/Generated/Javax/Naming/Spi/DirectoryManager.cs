/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Spi
{
    #region DirectoryManager
    public partial class DirectoryManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirectoryManager.html#getObjectInstance(java.lang.Object,javax.naming.Name,javax.naming.Context,java.util.Hashtable,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Context"/></param>
        /// <param name="arg3"><see cref="Java.Util.Hashtable"/></param>
        /// <param name="arg4"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        public static object GetObjectInstance(object arg0, Javax.Naming.Name arg1, Javax.Naming.Context arg2, Java.Util.Hashtable<object, object> arg3, Javax.Naming.Directory.Attributes arg4)
        {
            return SExecute(LocalBridgeClazz, "getObjectInstance", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirectoryManager.html#getContinuationDirContext(javax.naming.CannotProceedException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.CannotProceedException"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public static Javax.Naming.Directory.DirContext GetContinuationDirContext(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            return SExecute<Javax.Naming.Directory.DirContext>(LocalBridgeClazz, "getContinuationDirContext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirectoryManager.html#getStateToBind(java.lang.Object,javax.naming.Name,javax.naming.Context,java.util.Hashtable,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Context"/></param>
        /// <param name="arg3"><see cref="Java.Util.Hashtable"/></param>
        /// <param name="arg4"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <returns><see cref="Javax.Naming.Spi.DirStateFactory.Result"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public static Javax.Naming.Spi.DirStateFactory.Result GetStateToBind(object arg0, Javax.Naming.Name arg1, Javax.Naming.Context arg2, Java.Util.Hashtable<object, object> arg3, Javax.Naming.Directory.Attributes arg4)
        {
            return SExecute<Javax.Naming.Spi.DirStateFactory.Result>(LocalBridgeClazz, "getStateToBind", arg0, arg1, arg2, arg3, arg4);
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