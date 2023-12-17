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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Openmbean
{
    #region IOpenMBeanParameterInfo
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IOpenMBeanParameterInfo
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getDefaultValue()"/> 
        /// </summary>
        object DefaultValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getDescription()"/> 
        /// </summary>
        string Description { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getLegalValues()"/> 
        /// </summary>
        Java.Util.Set<object> LegalValues { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getMaxValue()"/> 
        /// </summary>
        Java.Lang.Comparable<object> MaxValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getMinValue()"/> 
        /// </summary>
        Java.Lang.Comparable<object> MinValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getName()"/> 
        /// </summary>
        string Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getOpenType()"/> 
        /// </summary>
        Javax.Management.Openmbean.OpenType<object> OpenType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasDefaultValue()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool HasDefaultValue();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasLegalValues()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool HasLegalValues();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasMaxValue()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool HasMaxValue();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasMinValue()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool HasMinValue();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#isValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsValue(object arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OpenMBeanParameterInfo
    public partial class OpenMBeanParameterInfo : Javax.Management.Openmbean.IOpenMBeanParameterInfo
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getDefaultValue()"/> 
        /// </summary>
        public object DefaultValue
        {
            get { return IExecute("getDefaultValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getDescription()"/> 
        /// </summary>
        public string Description
        {
            get { return IExecute<string>("getDescription"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getLegalValues()"/> 
        /// </summary>
        public Java.Util.Set<object> LegalValues
        {
            get { return IExecute<Java.Util.Set<object>>("getLegalValues"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getMaxValue()"/> 
        /// </summary>
        public Java.Lang.Comparable<object> MaxValue
        {
            get { return IExecute<Java.Lang.Comparable<object>>("getMaxValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getMinValue()"/> 
        /// </summary>
        public Java.Lang.Comparable<object> MinValue
        {
            get { return IExecute<Java.Lang.Comparable<object>>("getMinValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getOpenType()"/> 
        /// </summary>
        public Javax.Management.Openmbean.OpenType<object> OpenType
        {
            get { return IExecute<Javax.Management.Openmbean.OpenType<object>>("getOpenType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasDefaultValue()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasDefaultValue()
        {
            return IExecute<bool>("hasDefaultValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasLegalValues()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasLegalValues()
        {
            return IExecute<bool>("hasLegalValues");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasMaxValue()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasMaxValue()
        {
            return IExecute<bool>("hasMaxValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasMinValue()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasMinValue()
        {
            return IExecute<bool>("hasMinValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#isValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsValue(object arg0)
        {
            return IExecute<bool>("isValue", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}