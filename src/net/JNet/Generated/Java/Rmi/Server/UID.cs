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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Rmi.Server
{
    #region UID
    public partial class UID
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/UID.html#%3Cinit%3E(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        public UID(short arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/UID.html#read(java.io.DataInput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.DataInput"/></param>
        /// <returns><see cref="Java.Rmi.Server.UID"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Rmi.Server.UID Read(Java.Io.DataInput arg0)
        {
            return SExecute<Java.Rmi.Server.UID>(LocalBridgeClazz, "read", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/UID.html#write(java.io.DataOutput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.DataOutput"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(Java.Io.DataOutput arg0)
        {
            IExecute("write", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}