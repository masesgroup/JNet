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

namespace Java.Beans
{
    #region FeatureDescriptor
    public partial class FeatureDescriptor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#attributeNames()"/> 
        /// </summary>
        public Java.Util.Enumeration<string> AttributeNames
        {
            get { return IExecute<Java.Util.Enumeration<string>>("attributeNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#getDisplayName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#setDisplayName(java.lang.String)"/>
        /// </summary>
        public string DisplayName
        {
            get { return IExecute<string>("getDisplayName"); } set { IExecute("setDisplayName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#isExpert()"/> 
        /// </summary>
        public bool IsExpert
        {
            get { return IExecute<bool>("isExpert"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#isHidden()"/> 
        /// </summary>
        public bool IsHidden
        {
            get { return IExecute<bool>("isHidden"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#isPreferred()"/> 
        /// </summary>
        public bool IsPreferred
        {
            get { return IExecute<bool>("isPreferred"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#setName(java.lang.String)"/>
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); } set { IExecute("setName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#getShortDescription()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#setShortDescription(java.lang.String)"/>
        /// </summary>
        public string ShortDescription
        {
            get { return IExecute<string>("getShortDescription"); } set { IExecute("setShortDescription", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetValue(string arg0)
        {
            return IExecute("getValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#setExpert(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetExpert(bool arg0)
        {
            IExecute("setExpert", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#setHidden(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetHidden(bool arg0)
        {
            IExecute("setHidden", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#setPreferred(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPreferred(bool arg0)
        {
            IExecute("setPreferred", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/FeatureDescriptor.html#setValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void SetValue(string arg0, object arg1)
        {
            IExecute("setValue", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}