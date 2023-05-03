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
    #region OpenMBeanAttributeInfoSupport
    public partial class OpenMBeanAttributeInfoSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfoSupport.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.openmbean.OpenType,boolean,boolean,boolean,java.lang.Object,java.lang.Comparable,java.lang.Comparable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <param name="arg7"><see cref="Java.Lang.Comparable"/></param>
        /// <param name="arg8"><see cref="Java.Lang.Comparable"/></param>
        /// <exception cref="Javax.Management.Openmbean.OpenDataException"/>
        public OpenMBeanAttributeInfoSupport(string arg0, string arg1, Javax.Management.Openmbean.OpenType arg2, bool arg3, bool arg4, bool arg5, object arg6, Java.Lang.Comparable arg7, Java.Lang.Comparable arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfoSupport.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.openmbean.OpenType,boolean,boolean,boolean,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <exception cref="Javax.Management.Openmbean.OpenDataException"/>
        public OpenMBeanAttributeInfoSupport(string arg0, string arg1, Javax.Management.Openmbean.OpenType arg2, bool arg3, bool arg4, bool arg5, object arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfoSupport.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.openmbean.OpenType,boolean,boolean,boolean,javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        /// <param name="arg6"><see cref="Javax.Management.Descriptor"/></param>
        public OpenMBeanAttributeInfoSupport(string arg0, string arg1, Javax.Management.Openmbean.OpenType arg2, bool arg3, bool arg4, bool arg5, Javax.Management.Descriptor arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfoSupport.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.openmbean.OpenType,boolean,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        public OpenMBeanAttributeInfoSupport(string arg0, string arg1, Javax.Management.Openmbean.OpenType arg2, bool arg3, bool arg4, bool arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Openmbean.OpenMBeanAttributeInfoSupport"/> to <see cref="Javax.Management.Openmbean.OpenMBeanAttributeInfo"/>
        /// </summary>
        public static implicit operator Javax.Management.Openmbean.OpenMBeanAttributeInfo(Javax.Management.Openmbean.OpenMBeanAttributeInfoSupport t) => t.Cast<Javax.Management.Openmbean.OpenMBeanAttributeInfo>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfoSupport.html#getDefaultValue()"/> 
        /// </summary>
        public object DefaultValue
        {
            get { return IExecute("getDefaultValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfoSupport.html#hasDefaultValue()"/> 
        /// </summary>
        public bool HasDefaultValue
        {
            get { return IExecute<bool>("hasDefaultValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfoSupport.html#hasLegalValues()"/> 
        /// </summary>
        public bool HasLegalValues
        {
            get { return IExecute<bool>("hasLegalValues"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfoSupport.html#hasMaxValue()"/> 
        /// </summary>
        public bool HasMaxValue
        {
            get { return IExecute<bool>("hasMaxValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfoSupport.html#hasMinValue()"/> 
        /// </summary>
        public bool HasMinValue
        {
            get { return IExecute<bool>("hasMinValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfoSupport.html#getLegalValues()"/> 
        /// </summary>
        public Java.Util.Set LegalValues
        {
            get { return IExecute<Java.Util.Set>("getLegalValues"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfoSupport.html#getMaxValue()"/> 
        /// </summary>
        public Java.Lang.Comparable MaxValue
        {
            get { return IExecute<Java.Lang.Comparable>("getMaxValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfoSupport.html#getMinValue()"/> 
        /// </summary>
        public Java.Lang.Comparable MinValue
        {
            get { return IExecute<Java.Lang.Comparable>("getMinValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfoSupport.html#getOpenType()"/> 
        /// </summary>
        public Javax.Management.Openmbean.OpenType OpenType
        {
            get { return IExecute<Javax.Management.Openmbean.OpenType>("getOpenType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanAttributeInfoSupport.html#isValue(java.lang.Object)"/>
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