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

namespace Javax.Swing.Text
{
    #region GlyphView
    public partial class GlyphView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.html#%3Cinit%3E(javax.swing.text.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        public GlyphView(Javax.Swing.Text.Element arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.GlyphView"/> to <see cref="Javax.Swing.Text.TabableView"/>
        /// </summary>
        public static implicit operator Javax.Swing.Text.TabableView(Javax.Swing.Text.GlyphView t) => t.Cast<Javax.Swing.Text.TabableView>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.GlyphView"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Swing.Text.GlyphView t) => t.Cast<Java.Lang.Cloneable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.html#getBackground()"/> 
        /// </summary>
        public Java.Awt.Color Background
        {
            get { return IExecute<Java.Awt.Color>("getBackground"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.html#getFont()"/> 
        /// </summary>
        public Java.Awt.Font Font
        {
            get { return IExecute<Java.Awt.Font>("getFont"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.html#getForeground()"/> 
        /// </summary>
        public Java.Awt.Color Foreground
        {
            get { return IExecute<Java.Awt.Color>("getForeground"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.html#getTabExpander()"/> 
        /// </summary>
        public Javax.Swing.Text.TabExpander TabExpander
        {
            get { return IExecute<Javax.Swing.Text.TabExpander>("getTabExpander"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.html#isStrikeThrough()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsStrikeThrough()
        {
            return IExecute<bool>("isStrikeThrough");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.html#isSubscript()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsSubscript()
        {
            return IExecute<bool>("isSubscript");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.html#isSuperscript()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsSuperscript()
        {
            return IExecute<bool>("isSuperscript");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.html#isUnderline()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsUnderline()
        {
            return IExecute<bool>("isUnderline");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.html#getPartialSpan(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetPartialSpan(int arg0, int arg1)
        {
            return IExecute<float>("getPartialSpan", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.html#getTabbedSpan(float,javax.swing.text.TabExpander)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.TabExpander"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetTabbedSpan(float arg0, Javax.Swing.Text.TabExpander arg1)
        {
            return IExecute<float>("getTabbedSpan", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.html#getGlyphPainter()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Swing.Text.GlyphView.GlyphPainter"/></returns>
        public Javax.Swing.Text.GlyphView.GlyphPainter GetGlyphPainter()
        {
            return IExecute<Javax.Swing.Text.GlyphView.GlyphPainter>("getGlyphPainter");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.html#getText(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Segment"/></returns>
        public Javax.Swing.Text.Segment GetText(int arg0, int arg1)
        {
            return IExecute<Javax.Swing.Text.Segment>("getText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.html#setGlyphPainter(javax.swing.text.GlyphView$GlyphPainter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.GlyphView.GlyphPainter"/></param>
        public void SetGlyphPainter(Javax.Swing.Text.GlyphView.GlyphPainter arg0)
        {
            IExecute("setGlyphPainter", arg0);
        }
        
        #endregion

        #region Nested classes
        #region GlyphPainter
        public partial class GlyphPainter
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.GlyphPainter.html#getAscent(javax.swing.text.GlyphView)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.GlyphView"/></param>
            /// <returns><see cref="float"/></returns>
            public float GetAscent(Javax.Swing.Text.GlyphView arg0)
            {
                return IExecute<float>("getAscent", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.GlyphPainter.html#getDescent(javax.swing.text.GlyphView)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.GlyphView"/></param>
            /// <returns><see cref="float"/></returns>
            public float GetDescent(Javax.Swing.Text.GlyphView arg0)
            {
                return IExecute<float>("getDescent", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.GlyphPainter.html#getHeight(javax.swing.text.GlyphView)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.GlyphView"/></param>
            /// <returns><see cref="float"/></returns>
            public float GetHeight(Javax.Swing.Text.GlyphView arg0)
            {
                return IExecute<float>("getHeight", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.GlyphPainter.html#getSpan(javax.swing.text.GlyphView,int,int,javax.swing.text.TabExpander,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.GlyphView"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="Javax.Swing.Text.TabExpander"/></param>
            /// <param name="arg4"><see cref="float"/></param>
            /// <returns><see cref="float"/></returns>
            public float GetSpan(Javax.Swing.Text.GlyphView arg0, int arg1, int arg2, Javax.Swing.Text.TabExpander arg3, float arg4)
            {
                return IExecute<float>("getSpan", arg0, arg1, arg2, arg3, arg4);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.GlyphPainter.html#getBoundedPosition(javax.swing.text.GlyphView,int,float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.GlyphView"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            /// <returns><see cref="int"/></returns>
            public int GetBoundedPosition(Javax.Swing.Text.GlyphView arg0, int arg1, float arg2, float arg3)
            {
                return IExecute<int>("getBoundedPosition", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.GlyphPainter.html#viewToModel(javax.swing.text.GlyphView,float,float,java.awt.Shape,javax.swing.text.Position$Bias[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.GlyphView"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="Java.Awt.Shape"/></param>
            /// <param name="arg4"><see cref="Javax.Swing.Text.Position.Bias"/></param>
            /// <returns><see cref="int"/></returns>
            public int ViewToModel(Javax.Swing.Text.GlyphView arg0, float arg1, float arg2, Java.Awt.Shape arg3, Javax.Swing.Text.Position.Bias[] arg4)
            {
                return IExecute<int>("viewToModel", arg0, arg1, arg2, arg3, arg4);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.GlyphPainter.html#modelToView(javax.swing.text.GlyphView,int,javax.swing.text.Position$Bias,java.awt.Shape)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.GlyphView"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Text.Position.Bias"/></param>
            /// <param name="arg3"><see cref="Java.Awt.Shape"/></param>
            /// <returns><see cref="Java.Awt.Shape"/></returns>
            /// <exception cref="Javax.Swing.Text.BadLocationException"/>
            public Java.Awt.Shape ModelToView(Javax.Swing.Text.GlyphView arg0, int arg1, Javax.Swing.Text.Position.Bias arg2, Java.Awt.Shape arg3)
            {
                return IExecute<Java.Awt.Shape>("modelToView", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.GlyphPainter.html#paint(javax.swing.text.GlyphView,java.awt.Graphics,java.awt.Shape,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.GlyphView"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Shape"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            public void Paint(Javax.Swing.Text.GlyphView arg0, Java.Awt.Graphics arg1, Java.Awt.Shape arg2, int arg3, int arg4)
            {
                IExecute("paint", arg0, arg1, arg2, arg3, arg4);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.GlyphPainter.html#getNextVisualPositionFrom(javax.swing.text.GlyphView,int,javax.swing.text.Position$Bias,java.awt.Shape,int,javax.swing.text.Position$Bias[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.GlyphView"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Text.Position.Bias"/></param>
            /// <param name="arg3"><see cref="Java.Awt.Shape"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            /// <param name="arg5"><see cref="Javax.Swing.Text.Position.Bias"/></param>
            /// <returns><see cref="int"/></returns>
            /// <exception cref="Javax.Swing.Text.BadLocationException"/>
            public int GetNextVisualPositionFrom(Javax.Swing.Text.GlyphView arg0, int arg1, Javax.Swing.Text.Position.Bias arg2, Java.Awt.Shape arg3, int arg4, Javax.Swing.Text.Position.Bias[] arg5)
            {
                return IExecute<int>("getNextVisualPositionFrom", arg0, arg1, arg2, arg3, arg4, arg5);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/GlyphView.GlyphPainter.html#getPainter(javax.swing.text.GlyphView,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.GlyphView"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.Text.GlyphView.GlyphPainter"/></returns>
            public Javax.Swing.Text.GlyphView.GlyphPainter GetPainter(Javax.Swing.Text.GlyphView arg0, int arg1, int arg2)
            {
                return IExecute<Javax.Swing.Text.GlyphView.GlyphPainter>("getPainter", arg0, arg1, arg2);
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