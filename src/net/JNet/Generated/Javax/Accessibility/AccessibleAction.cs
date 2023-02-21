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
    #region AccessibleAction
    public partial class AccessibleAction
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#TOGGLE_EXPAND
        /// </summary>
        public static string TOGGLE_EXPAND => Clazz.GetField<string>("TOGGLE_EXPAND");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#INCREMENT
        /// </summary>
        public static string INCREMENT => Clazz.GetField<string>("INCREMENT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#DECREMENT
        /// </summary>
        public static string DECREMENT => Clazz.GetField<string>("DECREMENT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#CLICK
        /// </summary>
        public static string CLICK => Clazz.GetField<string>("CLICK");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#TOGGLE_POPUP
        /// </summary>
        public static string TOGGLE_POPUP => Clazz.GetField<string>("TOGGLE_POPUP");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#getAccessibleActionCount() 
        /// </summary>
        public int AccessibleActionCount
        {
            get { return IExecute<int>("getAccessibleActionCount"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#doAccessibleAction(int)
        /// </summary>
        public bool DoAccessibleAction(int arg0)
        {
            return IExecute<bool>("doAccessibleAction", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#getAccessibleActionDescription(int)
        /// </summary>
        public string GetAccessibleActionDescription(int arg0)
        {
            return IExecute<string>("getAccessibleActionDescription", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}