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

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Openmbean
{
    #region TabularDataSupport
    public partial class TabularDataSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#%3Cinit%3E(javax.management.openmbean.TabularType,int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.TabularType"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public TabularDataSupport(Javax.Management.Openmbean.TabularType arg0, int arg1, float arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#%3Cinit%3E(javax.management.openmbean.TabularType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.TabularType"/></param>
        public TabularDataSupport(Javax.Management.Openmbean.TabularType arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Openmbean.TabularDataSupport"/> to <see cref="Javax.Management.Openmbean.TabularData"/>
        /// </summary>
        public static implicit operator Javax.Management.Openmbean.TabularData(Javax.Management.Openmbean.TabularDataSupport t) => t.Cast<Javax.Management.Openmbean.TabularData>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Openmbean.TabularDataSupport"/> to <see cref="Java.Util.Map"/>
        /// </summary>
        public static implicit operator Java.Util.Map(Javax.Management.Openmbean.TabularDataSupport t) => t.Cast<Java.Util.Map>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Openmbean.TabularDataSupport"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Management.Openmbean.TabularDataSupport t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Openmbean.TabularDataSupport"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Management.Openmbean.TabularDataSupport t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#entrySet()"/> 
        /// </summary>
        public Java.Util.Set<Java.Util.Map.Entry<object, object>> EntrySet
        {
            get { return IExecute<Java.Util.Set<Java.Util.Map.Entry<object, object>>>("entrySet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#keySet()"/> 
        /// </summary>
        public Java.Util.Set<object> KeySet
        {
            get { return IExecute<Java.Util.Set<object>>("keySet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#size()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecute<int>("size"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#getTabularType()"/> 
        /// </summary>
        public Javax.Management.Openmbean.TabularType TabularType
        {
            get { return IExecute<Javax.Management.Openmbean.TabularType>("getTabularType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#values()"/> 
        /// </summary>
        public Java.Util.Collection<object> Values
        {
            get { return IExecute<Java.Util.Collection<object>>("values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#containsKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(object arg0)
        {
            return IExecute<bool>("containsKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#containsKey(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(object[] arg0)
        {
            return IExecute<bool>("containsKey", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#containsValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsValue(object arg0)
        {
            return IExecute<bool>("containsValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#containsValue(javax.management.openmbean.CompositeData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsValue(Javax.Management.Openmbean.CompositeData arg0)
        {
            return IExecute<bool>("containsValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(object arg0)
        {
            return IExecute("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#put(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Put(object arg0, object arg1)
        {
            return IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Remove(object arg0)
        {
            return IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#calculateIndex(javax.management.openmbean.CompositeData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] CalculateIndex(Javax.Management.Openmbean.CompositeData arg0)
        {
            return IExecuteArray<object>("calculateIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#get(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Management.Openmbean.CompositeData"/></returns>
        public Javax.Management.Openmbean.CompositeData Get(object[] arg0)
        {
            return IExecute<Javax.Management.Openmbean.CompositeData>("get", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#remove(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Management.Openmbean.CompositeData"/></returns>
        public Javax.Management.Openmbean.CompositeData Remove(object[] arg0)
        {
            return IExecute<Javax.Management.Openmbean.CompositeData>("remove", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#put(javax.management.openmbean.CompositeData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        public void Put(Javax.Management.Openmbean.CompositeData arg0)
        {
            IExecute("put", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#putAll(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void PutAll<Arg0Extendsobject>(Java.Util.Map<Arg0Extendsobject, Arg0Extendsobject> arg0)
        {
            IExecute("putAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularDataSupport.html#putAll(javax.management.openmbean.CompositeData[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        public void PutAll(Javax.Management.Openmbean.CompositeData[] arg0)
        {
            IExecute("putAll", new object[] { arg0 });
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}