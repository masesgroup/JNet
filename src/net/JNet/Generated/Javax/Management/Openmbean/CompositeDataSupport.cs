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

namespace Javax.Management.Openmbean
{
    #region CompositeDataSupport
    public partial class CompositeDataSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/CompositeDataSupport.html#%3Cinit%3E(javax.management.openmbean.CompositeType,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeType"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Javax.Management.Openmbean.OpenDataException"/>
        public CompositeDataSupport(Javax.Management.Openmbean.CompositeType arg0, Java.Util.Map<string, object> arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Openmbean.CompositeDataSupport"/> to <see cref="Javax.Management.Openmbean.CompositeData"/>
        /// </summary>
        public static implicit operator Javax.Management.Openmbean.CompositeData(Javax.Management.Openmbean.CompositeDataSupport t) => t.Cast<Javax.Management.Openmbean.CompositeData>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Openmbean.CompositeDataSupport"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Management.Openmbean.CompositeDataSupport t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/CompositeDataSupport.html#getCompositeType()"/> 
        /// </summary>
        public Javax.Management.Openmbean.CompositeType CompositeType
        {
            get { return IExecute<Javax.Management.Openmbean.CompositeType>("getCompositeType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/CompositeDataSupport.html#containsKey(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(string arg0)
        {
            return IExecute<bool>("containsKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/CompositeDataSupport.html#containsValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsValue(object arg0)
        {
            return IExecute<bool>("containsValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/CompositeDataSupport.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(string arg0)
        {
            return IExecute("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/CompositeDataSupport.html#getAll(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] GetAll(string[] arg0)
        {
            return IExecuteArray<object>("getAll", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/CompositeDataSupport.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<object> Values()
        {
            return IExecute<Java.Util.Collection<object>>("values");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}