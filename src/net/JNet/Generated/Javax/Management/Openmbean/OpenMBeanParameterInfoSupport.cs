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

namespace Javax.Management.Openmbean
{
    #region OpenMBeanParameterInfoSupport
    public partial class OpenMBeanParameterInfoSupport
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Management.Openmbean.OpenMBeanParameterInfo(Javax.Management.Openmbean.OpenMBeanParameterInfoSupport t) => t.Cast<Javax.Management.Openmbean.OpenMBeanParameterInfo>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#getDefaultValue() 
        /// </summary>
        public object DefaultValue
        {
            get { return IExecute("getDefaultValue"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#hasDefaultValue()
        /// </summary>
        public bool HasDefaultValue()
        {
            return IExecute<bool>("hasDefaultValue");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#hasLegalValues()
        /// </summary>
        public bool HasLegalValues()
        {
            return IExecute<bool>("hasLegalValues");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#hasMaxValue()
        /// </summary>
        public bool HasMaxValue()
        {
            return IExecute<bool>("hasMaxValue");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#hasMinValue()
        /// </summary>
        public bool HasMinValue()
        {
            return IExecute<bool>("hasMinValue");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfoSupport.html#isValue(java.lang.Object)
        /// </summary>
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