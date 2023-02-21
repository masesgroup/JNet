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

namespace Java.Rmi.Server
{
    #region ObjID
    public partial class ObjID
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ObjID.html#<init>(int)
        /// </summary>
        public ObjID(int arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Io.Serializable(Java.Rmi.Server.ObjID t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ObjID.html#REGISTRY_ID
        /// </summary>
        public static int REGISTRY_ID => Clazz.GetField<int>("REGISTRY_ID");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ObjID.html#ACTIVATOR_ID
        /// </summary>
        public static int ACTIVATOR_ID => Clazz.GetField<int>("ACTIVATOR_ID");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ObjID.html#DGC_ID
        /// </summary>
        public static int DGC_ID => Clazz.GetField<int>("DGC_ID");
        
        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ObjID.html#read(java.io.ObjectInput) throws java.io.IOException
        /// </summary>
        public static Java.Rmi.Server.ObjID Read(Java.Io.ObjectInput arg0)
        {
            return SExecute<Java.Rmi.Server.ObjID>("read", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/ObjID.html#write(java.io.ObjectOutput) throws java.io.IOException
        /// </summary>
        public void Write(Java.Io.ObjectOutput arg0)
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