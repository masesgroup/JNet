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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region AsyncBoxView
    public partial class AsyncBoxView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#%3Cinit%3E(javax.swing.text.Element,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public AsyncBoxView(Javax.Swing.Text.Element arg0, int arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#getBottomInset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#setBottomInset(float)"/>
        /// </summary>
        public float BottomInset
        {
            get { return IExecuteWithSignature<float>("getBottomInset", "()F"); } set { IExecuteWithSignature("setBottomInset", "(F)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#getLeftInset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#setLeftInset(float)"/>
        /// </summary>
        public float LeftInset
        {
            get { return IExecuteWithSignature<float>("getLeftInset", "()F"); } set { IExecuteWithSignature("setLeftInset", "(F)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#getMajorAxis()"/> 
        /// </summary>
        public int MajorAxis
        {
            get { return IExecuteWithSignature<int>("getMajorAxis", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#getMinorAxis()"/> 
        /// </summary>
        public int MinorAxis
        {
            get { return IExecuteWithSignature<int>("getMinorAxis", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#getRightInset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#setRightInset(float)"/>
        /// </summary>
        public float RightInset
        {
            get { return IExecuteWithSignature<float>("getRightInset", "()F"); } set { IExecuteWithSignature("setRightInset", "(F)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#getTopInset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#setTopInset(float)"/>
        /// </summary>
        public float TopInset
        {
            get { return IExecuteWithSignature<float>("getTopInset", "()F"); } set { IExecuteWithSignature("setTopInset", "(F)V", value); }
        }

        #endregion

        #region Nested classes
        #region ChildLocator
        public partial class ChildLocator
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildLocator.html#%3Cinit%3E(javax.swing.text.AsyncBoxView)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.AsyncBoxView"/></param>
            public ChildLocator(Javax.Swing.Text.AsyncBoxView arg0)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildLocator.html#getViewIndexAtPoint(float,float,java.awt.Shape)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Shape"/></param>
            /// <returns><see cref="int"/></returns>
            public int GetViewIndexAtPoint(float arg0, float arg1, Java.Awt.Shape arg2)
            {
                return IExecute<int>("getViewIndexAtPoint", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildLocator.html#getChildAllocation(int,java.awt.Shape)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Shape"/></param>
            /// <returns><see cref="Java.Awt.Shape"/></returns>
            public Java.Awt.Shape GetChildAllocation(int arg0, Java.Awt.Shape arg1)
            {
                return IExecute<Java.Awt.Shape>("getChildAllocation", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildLocator.html#childChanged(javax.swing.text.AsyncBoxView.ChildState)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.AsyncBoxView.ChildState"/></param>
            public void ChildChanged(Javax.Swing.Text.AsyncBoxView.ChildState arg0)
            {
                IExecuteWithSignature("childChanged", "(Ljavax/swing/text/AsyncBoxView$ChildState;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildLocator.html#paintChildren(java.awt.Graphics)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
            public void PaintChildren(Java.Awt.Graphics arg0)
            {
                IExecuteWithSignature("paintChildren", "(Ljava/awt/Graphics;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ChildState
        public partial class ChildState
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#%3Cinit%3E(javax.swing.text.AsyncBoxView,javax.swing.text.View)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.AsyncBoxView"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.View"/></param>
            public ChildState(Javax.Swing.Text.AsyncBoxView arg0, Javax.Swing.Text.View arg1)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#getChildView()"/> 
            /// </summary>
            public Javax.Swing.Text.View ChildView
            {
                get { return IExecuteWithSignature<Javax.Swing.Text.View>("getChildView", "()Ljavax/swing/text/View;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#getMajorOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#setMajorOffset(float)"/>
            /// </summary>
            public float MajorOffset
            {
                get { return IExecuteWithSignature<float>("getMajorOffset", "()F"); } set { IExecuteWithSignature("setMajorOffset", "(F)V", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#getMajorSpan()"/> 
            /// </summary>
            public float MajorSpan
            {
                get { return IExecuteWithSignature<float>("getMajorSpan", "()F"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#getMinorOffset()"/> 
            /// </summary>
            public float MinorOffset
            {
                get { return IExecuteWithSignature<float>("getMinorOffset", "()F"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#getMinorSpan()"/> 
            /// </summary>
            public float MinorSpan
            {
                get { return IExecuteWithSignature<float>("getMinorSpan", "()F"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#isLayoutValid()"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool IsLayoutValid()
            {
                return IExecuteWithSignature<bool>("isLayoutValid", "()Z");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#preferenceChanged(boolean,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public void PreferenceChanged(bool arg0, bool arg1)
            {
                IExecute("preferenceChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#run()"/>
            /// </summary>
            public void Run()
            {
                IExecuteWithSignature("run", "()V");
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