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

namespace Javax.Swing.Plaf.Basic
{
    #region BasicTableUI
    public partial class BasicTableUI
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

        #endregion

        #region Nested classes
        #region MouseInputHandler
        public partial class MouseInputHandler
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#<init>(javax.swing.plaf.basic.BasicTableUI)
            /// </summary>
            public MouseInputHandler(Javax.Swing.Plaf.Basic.BasicTableUI arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Javax.Swing.Event.MouseInputListener(Javax.Swing.Plaf.Basic.BasicTableUI.MouseInputHandler t) => t.Cast<Javax.Swing.Event.MouseInputListener>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#mouseClicked(java.awt.event.MouseEvent)
            /// </summary>
            public void MouseClicked(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseClicked", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#mouseDragged(java.awt.event.MouseEvent)
            /// </summary>
            public void MouseDragged(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseDragged", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#mouseEntered(java.awt.event.MouseEvent)
            /// </summary>
            public void MouseEntered(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseEntered", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#mouseExited(java.awt.event.MouseEvent)
            /// </summary>
            public void MouseExited(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseExited", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#mouseMoved(java.awt.event.MouseEvent)
            /// </summary>
            public void MouseMoved(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseMoved", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#mousePressed(java.awt.event.MouseEvent)
            /// </summary>
            public void MousePressed(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mousePressed", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.MouseInputHandler.html#mouseReleased(java.awt.event.MouseEvent)
            /// </summary>
            public void MouseReleased(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseReleased", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region FocusHandler
        public partial class FocusHandler
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.FocusHandler.html#<init>(javax.swing.plaf.basic.BasicTableUI)
            /// </summary>
            public FocusHandler(Javax.Swing.Plaf.Basic.BasicTableUI arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Java.Awt.EventNs.FocusListener(Javax.Swing.Plaf.Basic.BasicTableUI.FocusHandler t) => t.Cast<Java.Awt.EventNs.FocusListener>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.FocusHandler.html#focusGained(java.awt.event.FocusEvent)
            /// </summary>
            public void FocusGained(Java.Awt.EventNs.FocusEvent arg0)
            {
                IExecute("focusGained", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.FocusHandler.html#focusLost(java.awt.event.FocusEvent)
            /// </summary>
            public void FocusLost(Java.Awt.EventNs.FocusEvent arg0)
            {
                IExecute("focusLost", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region KeyHandler
        public partial class KeyHandler
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.KeyHandler.html#<init>(javax.swing.plaf.basic.BasicTableUI)
            /// </summary>
            public KeyHandler(Javax.Swing.Plaf.Basic.BasicTableUI arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Java.Awt.EventNs.KeyListener(Javax.Swing.Plaf.Basic.BasicTableUI.KeyHandler t) => t.Cast<Java.Awt.EventNs.KeyListener>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.KeyHandler.html#keyPressed(java.awt.event.KeyEvent)
            /// </summary>
            public void KeyPressed(Java.Awt.EventNs.KeyEvent arg0)
            {
                IExecute("keyPressed", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.KeyHandler.html#keyReleased(java.awt.event.KeyEvent)
            /// </summary>
            public void KeyReleased(Java.Awt.EventNs.KeyEvent arg0)
            {
                IExecute("keyReleased", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTableUI.KeyHandler.html#keyTyped(java.awt.event.KeyEvent)
            /// </summary>
            public void KeyTyped(Java.Awt.EventNs.KeyEvent arg0)
            {
                IExecute("keyTyped", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}