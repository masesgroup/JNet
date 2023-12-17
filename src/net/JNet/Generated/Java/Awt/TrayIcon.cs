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

namespace Java.Awt
{
    #region TrayIcon
    public partial class TrayIcon
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#%3Cinit%3E(java.awt.Image,java.lang.String,java.awt.PopupMenu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Awt.PopupMenu"/></param>
        public TrayIcon(Java.Awt.Image arg0, string arg1, Java.Awt.PopupMenu arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#%3Cinit%3E(java.awt.Image,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public TrayIcon(Java.Awt.Image arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#%3Cinit%3E(java.awt.Image)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        public TrayIcon(Java.Awt.Image arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getActionCommand()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#setActionCommand(java.lang.String)"/>
        /// </summary>
        public string ActionCommand
        {
            get { return IExecute<string>("getActionCommand"); } set { IExecute("setActionCommand", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getActionListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ActionListener[] ActionListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.ActionListener>("getActionListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getImage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#setImage(java.awt.Image)"/>
        /// </summary>
        public Java.Awt.Image Image
        {
            get { return IExecute<Java.Awt.Image>("getImage"); } set { IExecute("setImage", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getMouseListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.MouseListener[] MouseListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.MouseListener>("getMouseListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getMouseMotionListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.MouseMotionListener[] MouseMotionListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.MouseMotionListener>("getMouseMotionListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getPopupMenu()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#setPopupMenu(java.awt.PopupMenu)"/>
        /// </summary>
        public Java.Awt.PopupMenu PopupMenu
        {
            get { return IExecute<Java.Awt.PopupMenu>("getPopupMenu"); } set { IExecute("setPopupMenu", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getSize()"/> 
        /// </summary>
        public Java.Awt.Dimension Size
        {
            get { return IExecute<Java.Awt.Dimension>("getSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#getToolTip()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#setToolTip(java.lang.String)"/>
        /// </summary>
        public string ToolTip
        {
            get { return IExecute<string>("getToolTip"); } set { IExecute("setToolTip", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#isImageAutoSize()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsImageAutoSize()
        {
            return IExecute<bool>("isImageAutoSize");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#addActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void AddActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("addActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#addMouseListener(java.awt.event.MouseListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseListener"/></param>
        public void AddMouseListener(Java.Awt.EventNs.MouseListener arg0)
        {
            IExecute("addMouseListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#addMouseMotionListener(java.awt.event.MouseMotionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseMotionListener"/></param>
        public void AddMouseMotionListener(Java.Awt.EventNs.MouseMotionListener arg0)
        {
            IExecute("addMouseMotionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#removeActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void RemoveActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecute("removeActionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#removeMouseListener(java.awt.event.MouseListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseListener"/></param>
        public void RemoveMouseListener(Java.Awt.EventNs.MouseListener arg0)
        {
            IExecute("removeMouseListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#removeMouseMotionListener(java.awt.event.MouseMotionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseMotionListener"/></param>
        public void RemoveMouseMotionListener(Java.Awt.EventNs.MouseMotionListener arg0)
        {
            IExecute("removeMouseMotionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#displayMessage(java.lang.String,java.lang.String,java.awt.TrayIcon.MessageType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Awt.TrayIcon.MessageType"/></param>
        public void DisplayMessage(string arg0, string arg1, Java.Awt.TrayIcon.MessageType arg2)
        {
            IExecute("displayMessage", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.html#setImageAutoSize(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetImageAutoSize(bool arg0)
        {
            IExecute("setImageAutoSize", arg0);
        }

        #endregion

        #region Nested classes
        #region MessageType
        public partial class MessageType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.MessageType.html#ERROR"/>
            /// </summary>
            public static Java.Awt.TrayIcon.MessageType ERROR { get { return SGetField<Java.Awt.TrayIcon.MessageType>(LocalBridgeClazz, "ERROR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.MessageType.html#INFO"/>
            /// </summary>
            public static Java.Awt.TrayIcon.MessageType INFO { get { return SGetField<Java.Awt.TrayIcon.MessageType>(LocalBridgeClazz, "INFO"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.MessageType.html#NONE"/>
            /// </summary>
            public static Java.Awt.TrayIcon.MessageType NONE { get { return SGetField<Java.Awt.TrayIcon.MessageType>(LocalBridgeClazz, "NONE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.MessageType.html#WARNING"/>
            /// </summary>
            public static Java.Awt.TrayIcon.MessageType WARNING { get { return SGetField<Java.Awt.TrayIcon.MessageType>(LocalBridgeClazz, "WARNING"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.MessageType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Awt.TrayIcon.MessageType"/></returns>
            public static Java.Awt.TrayIcon.MessageType ValueOf(string arg0)
            {
                return SExecute<Java.Awt.TrayIcon.MessageType>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TrayIcon.MessageType.html#values()"/>
            /// </summary>

            /// <returns><see cref="Java.Awt.TrayIcon.MessageType"/></returns>
            public static Java.Awt.TrayIcon.MessageType[] Values()
            {
                return SExecuteArray<Java.Awt.TrayIcon.MessageType>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}