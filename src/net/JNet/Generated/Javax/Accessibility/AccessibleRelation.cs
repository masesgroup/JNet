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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Accessibility
{
    #region AccessibleRelation
    public partial class AccessibleRelation
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#%3Cinit%3E(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public AccessibleRelation(string arg0, object arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public AccessibleRelation(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CHILD_NODE_OF"/>
        /// </summary>
        public static string CHILD_NODE_OF { get { if (!_CHILD_NODE_OFReady) { _CHILD_NODE_OFContent = SGetField<string>(LocalBridgeClazz, "CHILD_NODE_OF"); _CHILD_NODE_OFReady = true; } return _CHILD_NODE_OFContent; } }
        private static string _CHILD_NODE_OFContent = default;
        private static bool _CHILD_NODE_OFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CHILD_NODE_OF_PROPERTY"/>
        /// </summary>
        public static string CHILD_NODE_OF_PROPERTY { get { if (!_CHILD_NODE_OF_PROPERTYReady) { _CHILD_NODE_OF_PROPERTYContent = SGetField<string>(LocalBridgeClazz, "CHILD_NODE_OF_PROPERTY"); _CHILD_NODE_OF_PROPERTYReady = true; } return _CHILD_NODE_OF_PROPERTYContent; } }
        private static string _CHILD_NODE_OF_PROPERTYContent = default;
        private static bool _CHILD_NODE_OF_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CONTROLLED_BY"/>
        /// </summary>
        public static string CONTROLLED_BY { get { if (!_CONTROLLED_BYReady) { _CONTROLLED_BYContent = SGetField<string>(LocalBridgeClazz, "CONTROLLED_BY"); _CONTROLLED_BYReady = true; } return _CONTROLLED_BYContent; } }
        private static string _CONTROLLED_BYContent = default;
        private static bool _CONTROLLED_BYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CONTROLLED_BY_PROPERTY"/>
        /// </summary>
        public static string CONTROLLED_BY_PROPERTY { get { if (!_CONTROLLED_BY_PROPERTYReady) { _CONTROLLED_BY_PROPERTYContent = SGetField<string>(LocalBridgeClazz, "CONTROLLED_BY_PROPERTY"); _CONTROLLED_BY_PROPERTYReady = true; } return _CONTROLLED_BY_PROPERTYContent; } }
        private static string _CONTROLLED_BY_PROPERTYContent = default;
        private static bool _CONTROLLED_BY_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CONTROLLER_FOR"/>
        /// </summary>
        public static string CONTROLLER_FOR { get { if (!_CONTROLLER_FORReady) { _CONTROLLER_FORContent = SGetField<string>(LocalBridgeClazz, "CONTROLLER_FOR"); _CONTROLLER_FORReady = true; } return _CONTROLLER_FORContent; } }
        private static string _CONTROLLER_FORContent = default;
        private static bool _CONTROLLER_FORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CONTROLLER_FOR_PROPERTY"/>
        /// </summary>
        public static string CONTROLLER_FOR_PROPERTY { get { if (!_CONTROLLER_FOR_PROPERTYReady) { _CONTROLLER_FOR_PROPERTYContent = SGetField<string>(LocalBridgeClazz, "CONTROLLER_FOR_PROPERTY"); _CONTROLLER_FOR_PROPERTYReady = true; } return _CONTROLLER_FOR_PROPERTYContent; } }
        private static string _CONTROLLER_FOR_PROPERTYContent = default;
        private static bool _CONTROLLER_FOR_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#EMBEDDED_BY"/>
        /// </summary>
        public static string EMBEDDED_BY { get { if (!_EMBEDDED_BYReady) { _EMBEDDED_BYContent = SGetField<string>(LocalBridgeClazz, "EMBEDDED_BY"); _EMBEDDED_BYReady = true; } return _EMBEDDED_BYContent; } }
        private static string _EMBEDDED_BYContent = default;
        private static bool _EMBEDDED_BYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#EMBEDDED_BY_PROPERTY"/>
        /// </summary>
        public static string EMBEDDED_BY_PROPERTY { get { if (!_EMBEDDED_BY_PROPERTYReady) { _EMBEDDED_BY_PROPERTYContent = SGetField<string>(LocalBridgeClazz, "EMBEDDED_BY_PROPERTY"); _EMBEDDED_BY_PROPERTYReady = true; } return _EMBEDDED_BY_PROPERTYContent; } }
        private static string _EMBEDDED_BY_PROPERTYContent = default;
        private static bool _EMBEDDED_BY_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#EMBEDS"/>
        /// </summary>
        public static string EMBEDS { get { if (!_EMBEDSReady) { _EMBEDSContent = SGetField<string>(LocalBridgeClazz, "EMBEDS"); _EMBEDSReady = true; } return _EMBEDSContent; } }
        private static string _EMBEDSContent = default;
        private static bool _EMBEDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#EMBEDS_PROPERTY"/>
        /// </summary>
        public static string EMBEDS_PROPERTY { get { if (!_EMBEDS_PROPERTYReady) { _EMBEDS_PROPERTYContent = SGetField<string>(LocalBridgeClazz, "EMBEDS_PROPERTY"); _EMBEDS_PROPERTYReady = true; } return _EMBEDS_PROPERTYContent; } }
        private static string _EMBEDS_PROPERTYContent = default;
        private static bool _EMBEDS_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#FLOWS_FROM"/>
        /// </summary>
        public static string FLOWS_FROM { get { if (!_FLOWS_FROMReady) { _FLOWS_FROMContent = SGetField<string>(LocalBridgeClazz, "FLOWS_FROM"); _FLOWS_FROMReady = true; } return _FLOWS_FROMContent; } }
        private static string _FLOWS_FROMContent = default;
        private static bool _FLOWS_FROMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#FLOWS_FROM_PROPERTY"/>
        /// </summary>
        public static string FLOWS_FROM_PROPERTY { get { if (!_FLOWS_FROM_PROPERTYReady) { _FLOWS_FROM_PROPERTYContent = SGetField<string>(LocalBridgeClazz, "FLOWS_FROM_PROPERTY"); _FLOWS_FROM_PROPERTYReady = true; } return _FLOWS_FROM_PROPERTYContent; } }
        private static string _FLOWS_FROM_PROPERTYContent = default;
        private static bool _FLOWS_FROM_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#FLOWS_TO"/>
        /// </summary>
        public static string FLOWS_TO { get { if (!_FLOWS_TOReady) { _FLOWS_TOContent = SGetField<string>(LocalBridgeClazz, "FLOWS_TO"); _FLOWS_TOReady = true; } return _FLOWS_TOContent; } }
        private static string _FLOWS_TOContent = default;
        private static bool _FLOWS_TOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#FLOWS_TO_PROPERTY"/>
        /// </summary>
        public static string FLOWS_TO_PROPERTY { get { if (!_FLOWS_TO_PROPERTYReady) { _FLOWS_TO_PROPERTYContent = SGetField<string>(LocalBridgeClazz, "FLOWS_TO_PROPERTY"); _FLOWS_TO_PROPERTYReady = true; } return _FLOWS_TO_PROPERTYContent; } }
        private static string _FLOWS_TO_PROPERTYContent = default;
        private static bool _FLOWS_TO_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#LABEL_FOR"/>
        /// </summary>
        public static string LABEL_FOR { get { if (!_LABEL_FORReady) { _LABEL_FORContent = SGetField<string>(LocalBridgeClazz, "LABEL_FOR"); _LABEL_FORReady = true; } return _LABEL_FORContent; } }
        private static string _LABEL_FORContent = default;
        private static bool _LABEL_FORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#LABEL_FOR_PROPERTY"/>
        /// </summary>
        public static string LABEL_FOR_PROPERTY { get { if (!_LABEL_FOR_PROPERTYReady) { _LABEL_FOR_PROPERTYContent = SGetField<string>(LocalBridgeClazz, "LABEL_FOR_PROPERTY"); _LABEL_FOR_PROPERTYReady = true; } return _LABEL_FOR_PROPERTYContent; } }
        private static string _LABEL_FOR_PROPERTYContent = default;
        private static bool _LABEL_FOR_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#LABELED_BY"/>
        /// </summary>
        public static string LABELED_BY { get { if (!_LABELED_BYReady) { _LABELED_BYContent = SGetField<string>(LocalBridgeClazz, "LABELED_BY"); _LABELED_BYReady = true; } return _LABELED_BYContent; } }
        private static string _LABELED_BYContent = default;
        private static bool _LABELED_BYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#LABELED_BY_PROPERTY"/>
        /// </summary>
        public static string LABELED_BY_PROPERTY { get { if (!_LABELED_BY_PROPERTYReady) { _LABELED_BY_PROPERTYContent = SGetField<string>(LocalBridgeClazz, "LABELED_BY_PROPERTY"); _LABELED_BY_PROPERTYReady = true; } return _LABELED_BY_PROPERTYContent; } }
        private static string _LABELED_BY_PROPERTYContent = default;
        private static bool _LABELED_BY_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#MEMBER_OF"/>
        /// </summary>
        public static string MEMBER_OF { get { if (!_MEMBER_OFReady) { _MEMBER_OFContent = SGetField<string>(LocalBridgeClazz, "MEMBER_OF"); _MEMBER_OFReady = true; } return _MEMBER_OFContent; } }
        private static string _MEMBER_OFContent = default;
        private static bool _MEMBER_OFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#MEMBER_OF_PROPERTY"/>
        /// </summary>
        public static string MEMBER_OF_PROPERTY { get { if (!_MEMBER_OF_PROPERTYReady) { _MEMBER_OF_PROPERTYContent = SGetField<string>(LocalBridgeClazz, "MEMBER_OF_PROPERTY"); _MEMBER_OF_PROPERTYReady = true; } return _MEMBER_OF_PROPERTYContent; } }
        private static string _MEMBER_OF_PROPERTYContent = default;
        private static bool _MEMBER_OF_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#PARENT_WINDOW_OF"/>
        /// </summary>
        public static string PARENT_WINDOW_OF { get { if (!_PARENT_WINDOW_OFReady) { _PARENT_WINDOW_OFContent = SGetField<string>(LocalBridgeClazz, "PARENT_WINDOW_OF"); _PARENT_WINDOW_OFReady = true; } return _PARENT_WINDOW_OFContent; } }
        private static string _PARENT_WINDOW_OFContent = default;
        private static bool _PARENT_WINDOW_OFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#PARENT_WINDOW_OF_PROPERTY"/>
        /// </summary>
        public static string PARENT_WINDOW_OF_PROPERTY { get { if (!_PARENT_WINDOW_OF_PROPERTYReady) { _PARENT_WINDOW_OF_PROPERTYContent = SGetField<string>(LocalBridgeClazz, "PARENT_WINDOW_OF_PROPERTY"); _PARENT_WINDOW_OF_PROPERTYReady = true; } return _PARENT_WINDOW_OF_PROPERTYContent; } }
        private static string _PARENT_WINDOW_OF_PROPERTYContent = default;
        private static bool _PARENT_WINDOW_OF_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#SUBWINDOW_OF"/>
        /// </summary>
        public static string SUBWINDOW_OF { get { if (!_SUBWINDOW_OFReady) { _SUBWINDOW_OFContent = SGetField<string>(LocalBridgeClazz, "SUBWINDOW_OF"); _SUBWINDOW_OFReady = true; } return _SUBWINDOW_OFContent; } }
        private static string _SUBWINDOW_OFContent = default;
        private static bool _SUBWINDOW_OFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#SUBWINDOW_OF_PROPERTY"/>
        /// </summary>
        public static string SUBWINDOW_OF_PROPERTY { get { if (!_SUBWINDOW_OF_PROPERTYReady) { _SUBWINDOW_OF_PROPERTYContent = SGetField<string>(LocalBridgeClazz, "SUBWINDOW_OF_PROPERTY"); _SUBWINDOW_OF_PROPERTYReady = true; } return _SUBWINDOW_OF_PROPERTYContent; } }
        private static string _SUBWINDOW_OF_PROPERTYContent = default;
        private static bool _SUBWINDOW_OF_PROPERTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#getKey()"/> 
        /// </summary>
        public string Key
        {
            get { return IExecute<string>("getKey"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#getTarget()"/> 
        /// </summary>
        public object[] Target
        {
            get { return IExecuteArray<object>("getTarget"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#setTarget(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetTarget(object arg0)
        {
            IExecute("setTarget", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#setTarget(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetTarget(object[] arg0)
        {
            IExecute("setTarget", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}