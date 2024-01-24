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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Io
{
    #region ObjectStreamClass
    public partial class ObjectStreamClass
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#NO_FIELDS"/>
        /// </summary>
        public static Java.Io.ObjectStreamField[] NO_FIELDS { get { if (!_NO_FIELDSReady) { _NO_FIELDSContent = SGetFieldArray<Java.Io.ObjectStreamField>(LocalBridgeClazz, "NO_FIELDS"); _NO_FIELDSReady = true; } return _NO_FIELDSContent; } }
        private static Java.Io.ObjectStreamField[] _NO_FIELDSContent = default;
        private static bool _NO_FIELDSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#lookup(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Io.ObjectStreamClass"/></returns>
        public static Java.Io.ObjectStreamClass Lookup(Java.Lang.Class arg0)
        {
            return SExecute<Java.Io.ObjectStreamClass>(LocalBridgeClazz, "lookup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#lookupAny(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Io.ObjectStreamClass"/></returns>
        public static Java.Io.ObjectStreamClass LookupAny(Java.Lang.Class arg0)
        {
            return SExecute<Java.Io.ObjectStreamClass>(LocalBridgeClazz, "lookupAny", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#getFields()"/> 
        /// </summary>
        public Java.Io.ObjectStreamField[] Fields
        {
            get { return IExecuteArray<Java.Io.ObjectStreamField>("getFields"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#getSerialVersionUID()"/> 
        /// </summary>
        public long SerialVersionUID
        {
            get { return IExecute<long>("getSerialVersionUID"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#getField(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Io.ObjectStreamField"/></returns>
        public Java.Io.ObjectStreamField GetField(string arg0)
        {
            return IExecute<Java.Io.ObjectStreamField>("getField", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#forClass()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class ForClass()
        {
            return IExecute<Java.Lang.Class>("forClass");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}