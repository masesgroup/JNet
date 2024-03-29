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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Basic
{
    #region BasicComboPopup
    public partial class BasicComboPopup
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboPopup.html#%3Cinit%3E(javax.swing.JComboBox)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComboBox"/></param>
        public BasicComboPopup(Javax.Swing.JComboBox<object> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicComboPopup"/> to <see cref="Javax.Swing.Plaf.Basic.ComboPopup"/>
        /// </summary>
        public static implicit operator Javax.Swing.Plaf.Basic.ComboPopup(Javax.Swing.Plaf.Basic.BasicComboPopup t) => t.Cast<Javax.Swing.Plaf.Basic.ComboPopup>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboPopup.html#getKeyListener()"/> 
        /// </summary>
        public Java.Awt.EventNs.KeyListener KeyListener
        {
            get { return IExecuteWithSignature<Java.Awt.EventNs.KeyListener>("getKeyListener", "()Ljava/awt/event/KeyListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboPopup.html#getList()"/> 
        /// </summary>
        public Javax.Swing.JList<object> List
        {
            get { return IExecuteWithSignature<Javax.Swing.JList<object>>("getList", "()Ljavax/swing/JList;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboPopup.html#getMouseListener()"/> 
        /// </summary>
        public Java.Awt.EventNs.MouseListener MouseListener
        {
            get { return IExecuteWithSignature<Java.Awt.EventNs.MouseListener>("getMouseListener", "()Ljava/awt/event/MouseListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboPopup.html#getMouseMotionListener()"/> 
        /// </summary>
        public Java.Awt.EventNs.MouseMotionListener MouseMotionListener
        {
            get { return IExecuteWithSignature<Java.Awt.EventNs.MouseMotionListener>("getMouseMotionListener", "()Ljava/awt/event/MouseMotionListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboPopup.html#uninstallingUI()"/>
        /// </summary>
        public void UninstallingUI()
        {
            IExecuteWithSignature("uninstallingUI", "()V");
        }

        #endregion

        #region Nested classes
        #region ListDataHandler
        public partial class ListDataHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboPopup.ListDataHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicComboPopup)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicComboPopup"/></param>
            public ListDataHandler(Javax.Swing.Plaf.Basic.BasicComboPopup arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicComboPopup.ListDataHandler"/> to <see cref="Javax.Swing.Event.ListDataListener"/>
            /// </summary>
            public static implicit operator Javax.Swing.Event.ListDataListener(Javax.Swing.Plaf.Basic.BasicComboPopup.ListDataHandler t) => t.Cast<Javax.Swing.Event.ListDataListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboPopup.ListDataHandler.html#contentsChanged(javax.swing.event.ListDataEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
            public void ContentsChanged(Javax.Swing.Event.ListDataEvent arg0)
            {
                IExecuteWithSignature("contentsChanged", "(Ljavax/swing/event/ListDataEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboPopup.ListDataHandler.html#intervalAdded(javax.swing.event.ListDataEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
            public void IntervalAdded(Javax.Swing.Event.ListDataEvent arg0)
            {
                IExecuteWithSignature("intervalAdded", "(Ljavax/swing/event/ListDataEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboPopup.ListDataHandler.html#intervalRemoved(javax.swing.event.ListDataEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
            public void IntervalRemoved(Javax.Swing.Event.ListDataEvent arg0)
            {
                IExecuteWithSignature("intervalRemoved", "(Ljavax/swing/event/ListDataEvent;)V", arg0);
            }

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