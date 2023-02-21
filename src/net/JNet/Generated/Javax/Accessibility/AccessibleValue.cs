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

namespace Javax.Accessibility
{
    #region AccessibleValue
    public partial class AccessibleValue
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleValue.html#getCurrentAccessibleValue() 
        /// </summary>
        public Java.Lang.Number CurrentAccessibleValue
        {
            get { return IExecute<Java.Lang.Number>("getCurrentAccessibleValue"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleValue.html#getMaximumAccessibleValue() 
        /// </summary>
        public Java.Lang.Number MaximumAccessibleValue
        {
            get { return IExecute<Java.Lang.Number>("getMaximumAccessibleValue"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleValue.html#getMinimumAccessibleValue() 
        /// </summary>
        public Java.Lang.Number MinimumAccessibleValue
        {
            get { return IExecute<Java.Lang.Number>("getMinimumAccessibleValue"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleValue.html#setCurrentAccessibleValue(java.lang.Number)
        /// </summary>
        public bool SetCurrentAccessibleValue(Java.Lang.Number arg0)
        {
            return IExecute<bool>("setCurrentAccessibleValue", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}