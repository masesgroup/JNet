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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Accessibility
{
    #region IAccessibleAction
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAccessibleAction
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#getAccessibleActionCount()"/> 
        /// </summary>
        int AccessibleActionCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#doAccessibleAction(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool DoAccessibleAction(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#getAccessibleActionDescription(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        string GetAccessibleActionDescription(int arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AccessibleAction
    public partial class AccessibleAction : Javax.Accessibility.IAccessibleAction
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#CLICK"/>
        /// </summary>
        public static string CLICK { get { if (!_CLICKReady) { _CLICKContent = SGetField<string>(LocalBridgeClazz, "CLICK"); _CLICKReady = true; } return _CLICKContent; } }
        private static string _CLICKContent = default;
        private static bool _CLICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#DECREMENT"/>
        /// </summary>
        public static string DECREMENT { get { if (!_DECREMENTReady) { _DECREMENTContent = SGetField<string>(LocalBridgeClazz, "DECREMENT"); _DECREMENTReady = true; } return _DECREMENTContent; } }
        private static string _DECREMENTContent = default;
        private static bool _DECREMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#INCREMENT"/>
        /// </summary>
        public static string INCREMENT { get { if (!_INCREMENTReady) { _INCREMENTContent = SGetField<string>(LocalBridgeClazz, "INCREMENT"); _INCREMENTReady = true; } return _INCREMENTContent; } }
        private static string _INCREMENTContent = default;
        private static bool _INCREMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#TOGGLE_EXPAND"/>
        /// </summary>
        public static string TOGGLE_EXPAND { get { if (!_TOGGLE_EXPANDReady) { _TOGGLE_EXPANDContent = SGetField<string>(LocalBridgeClazz, "TOGGLE_EXPAND"); _TOGGLE_EXPANDReady = true; } return _TOGGLE_EXPANDContent; } }
        private static string _TOGGLE_EXPANDContent = default;
        private static bool _TOGGLE_EXPANDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#TOGGLE_POPUP"/>
        /// </summary>
        public static string TOGGLE_POPUP { get { if (!_TOGGLE_POPUPReady) { _TOGGLE_POPUPContent = SGetField<string>(LocalBridgeClazz, "TOGGLE_POPUP"); _TOGGLE_POPUPReady = true; } return _TOGGLE_POPUPContent; } }
        private static string _TOGGLE_POPUPContent = default;
        private static bool _TOGGLE_POPUPReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#getAccessibleActionCount()"/> 
        /// </summary>
        public int AccessibleActionCount
        {
            get { return IExecute<int>("getAccessibleActionCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#doAccessibleAction(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DoAccessibleAction(int arg0)
        {
            return IExecute<bool>("doAccessibleAction", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleAction.html#getAccessibleActionDescription(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
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