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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region FlowView
    public partial class FlowView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/FlowView.html#%3Cinit%3E(javax.swing.text.Element,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public FlowView(Javax.Swing.Text.Element arg0, int arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/FlowView.html#getFlowAxis()"/> 
        /// </summary>
        public int FlowAxis
        {
            get { return IExecute<int>("getFlowAxis"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/FlowView.html#getFlowSpan(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetFlowSpan(int arg0)
        {
            return IExecute<int>("getFlowSpan", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/FlowView.html#getFlowStart(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetFlowStart(int arg0)
        {
            return IExecute<int>("getFlowStart", arg0);
        }

        #endregion

        #region Nested classes
        #region FlowStrategy
        public partial class FlowStrategy
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/FlowView.FlowStrategy.html#changedUpdate(javax.swing.text.FlowView,javax.swing.event.DocumentEvent,java.awt.Rectangle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.FlowView"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Rectangle"/></param>
            public void ChangedUpdate(Javax.Swing.Text.FlowView arg0, Javax.Swing.Event.DocumentEvent arg1, Java.Awt.Rectangle arg2)
            {
                IExecute("changedUpdate", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/FlowView.FlowStrategy.html#insertUpdate(javax.swing.text.FlowView,javax.swing.event.DocumentEvent,java.awt.Rectangle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.FlowView"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Rectangle"/></param>
            public void InsertUpdate(Javax.Swing.Text.FlowView arg0, Javax.Swing.Event.DocumentEvent arg1, Java.Awt.Rectangle arg2)
            {
                IExecute("insertUpdate", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/FlowView.FlowStrategy.html#layout(javax.swing.text.FlowView)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.FlowView"/></param>
            public void Layout(Javax.Swing.Text.FlowView arg0)
            {
                IExecute("layout", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/FlowView.FlowStrategy.html#removeUpdate(javax.swing.text.FlowView,javax.swing.event.DocumentEvent,java.awt.Rectangle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.FlowView"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Event.DocumentEvent"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Rectangle"/></param>
            public void RemoveUpdate(Javax.Swing.Text.FlowView arg0, Javax.Swing.Event.DocumentEvent arg1, Java.Awt.Rectangle arg2)
            {
                IExecute("removeUpdate", arg0, arg1, arg2);
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