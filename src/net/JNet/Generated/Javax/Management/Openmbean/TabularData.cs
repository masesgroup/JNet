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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Openmbean
{
    #region ITabularData
    public partial interface ITabularData
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#isEmpty()"/> 
        /// </summary>
        bool IsEmpty { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#keySet()"/> 
        /// </summary>
        Java.Util.Set KeySet { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#size()"/> 
        /// </summary>
        int Size { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#getTabularType()"/> 
        /// </summary>
        Javax.Management.Openmbean.TabularType TabularType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#values()"/> 
        /// </summary>
        Java.Util.Collection Values { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#containsKey(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        bool ContainsKey(object[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#containsValue(javax.management.openmbean.CompositeData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        /// <returns><see cref="bool"/></returns>
        bool ContainsValue(Javax.Management.Openmbean.CompositeData arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#calculateIndex(javax.management.openmbean.CompositeData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        /// <returns><see cref="object"/></returns>
        object[] CalculateIndex(Javax.Management.Openmbean.CompositeData arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#get(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Management.Openmbean.CompositeData"/></returns>
        Javax.Management.Openmbean.CompositeData Get(object[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#remove(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Management.Openmbean.CompositeData"/></returns>
        Javax.Management.Openmbean.CompositeData Remove(object[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#clear()"/>
        /// </summary>
        void Clear();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#put(javax.management.openmbean.CompositeData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        void Put(Javax.Management.Openmbean.CompositeData arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#putAll(javax.management.openmbean.CompositeData[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        void PutAll(Javax.Management.Openmbean.CompositeData[] arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TabularData
    public partial class TabularData : Javax.Management.Openmbean.ITabularData
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#keySet()"/> 
        /// </summary>
        public Java.Util.Set KeySet
        {
            get { return IExecute<Java.Util.Set>("keySet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#size()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecute<int>("size"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#getTabularType()"/> 
        /// </summary>
        public Javax.Management.Openmbean.TabularType TabularType
        {
            get { return IExecute<Javax.Management.Openmbean.TabularType>("getTabularType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#values()"/> 
        /// </summary>
        public Java.Util.Collection Values
        {
            get { return IExecute<Java.Util.Collection>("values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#containsKey(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(object[] arg0)
        {
            return IExecute<bool>("containsKey", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#containsValue(javax.management.openmbean.CompositeData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsValue(Javax.Management.Openmbean.CompositeData arg0)
        {
            return IExecute<bool>("containsValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#calculateIndex(javax.management.openmbean.CompositeData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] CalculateIndex(Javax.Management.Openmbean.CompositeData arg0)
        {
            return IExecuteArray<object>("calculateIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#get(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Management.Openmbean.CompositeData"/></returns>
        public Javax.Management.Openmbean.CompositeData Get(object[] arg0)
        {
            return IExecute<Javax.Management.Openmbean.CompositeData>("get", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#remove(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Management.Openmbean.CompositeData"/></returns>
        public Javax.Management.Openmbean.CompositeData Remove(object[] arg0)
        {
            return IExecute<Javax.Management.Openmbean.CompositeData>("remove", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#put(javax.management.openmbean.CompositeData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        public void Put(Javax.Management.Openmbean.CompositeData arg0)
        {
            IExecute("put", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularData.html#putAll(javax.management.openmbean.CompositeData[])"/>
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