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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region Utilities
    public partial class Utilities
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Utilities.html#drawTabbedText(javax.swing.text.Segment,float,float,java.awt.Graphics2D,javax.swing.text.TabExpander,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Segment"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Graphics2D"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Text.TabExpander"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public static float DrawTabbedText(Javax.Swing.Text.Segment arg0, float arg1, float arg2, Java.Awt.Graphics2D arg3, Javax.Swing.Text.TabExpander arg4, int arg5)
        {
            return SExecute<float>(LocalBridgeClazz, "drawTabbedText", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Utilities.html#getTabbedTextWidth(javax.swing.text.Segment,java.awt.FontMetrics,float,javax.swing.text.TabExpander,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Segment"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontMetrics"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Text.TabExpander"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public static float GetTabbedTextWidth(Javax.Swing.Text.Segment arg0, Java.Awt.FontMetrics arg1, float arg2, Javax.Swing.Text.TabExpander arg3, int arg4)
        {
            return SExecute<float>(LocalBridgeClazz, "getTabbedTextWidth", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Utilities.html#getBreakLocation(javax.swing.text.Segment,java.awt.FontMetrics,float,float,javax.swing.text.TabExpander,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Segment"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontMetrics"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Text.TabExpander"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetBreakLocation(Javax.Swing.Text.Segment arg0, Java.Awt.FontMetrics arg1, float arg2, float arg3, Javax.Swing.Text.TabExpander arg4, int arg5)
        {
            return SExecute<int>(LocalBridgeClazz, "getBreakLocation", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Utilities.html#getNextWord(javax.swing.text.JTextComponent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public static int GetNextWord(Javax.Swing.Text.JTextComponent arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getNextWord", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Utilities.html#getPositionAbove(javax.swing.text.JTextComponent,int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public static int GetPositionAbove(Javax.Swing.Text.JTextComponent arg0, int arg1, float arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "getPositionAbove", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Utilities.html#getPositionBelow(javax.swing.text.JTextComponent,int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public static int GetPositionBelow(Javax.Swing.Text.JTextComponent arg0, int arg1, float arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "getPositionBelow", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Utilities.html#getPreviousWord(javax.swing.text.JTextComponent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public static int GetPreviousWord(Javax.Swing.Text.JTextComponent arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getPreviousWord", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Utilities.html#getRowEnd(javax.swing.text.JTextComponent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public static int GetRowEnd(Javax.Swing.Text.JTextComponent arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getRowEnd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Utilities.html#getRowStart(javax.swing.text.JTextComponent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public static int GetRowStart(Javax.Swing.Text.JTextComponent arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getRowStart", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Utilities.html#getTabbedTextOffset(javax.swing.text.Segment,java.awt.FontMetrics,float,float,javax.swing.text.TabExpander,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Segment"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontMetrics"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Text.TabExpander"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetTabbedTextOffset(Javax.Swing.Text.Segment arg0, Java.Awt.FontMetrics arg1, float arg2, float arg3, Javax.Swing.Text.TabExpander arg4, int arg5, bool arg6)
        {
            return SExecute<int>(LocalBridgeClazz, "getTabbedTextOffset", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Utilities.html#getWordEnd(javax.swing.text.JTextComponent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public static int GetWordEnd(Javax.Swing.Text.JTextComponent arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getWordEnd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Utilities.html#getWordStart(javax.swing.text.JTextComponent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public static int GetWordStart(Javax.Swing.Text.JTextComponent arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getWordStart", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Utilities.html#getParagraphElement(javax.swing.text.JTextComponent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Element"/></returns>
        public static Javax.Swing.Text.Element GetParagraphElement(Javax.Swing.Text.JTextComponent arg0, int arg1)
        {
            return SExecute<Javax.Swing.Text.Element>(LocalBridgeClazz, "getParagraphElement", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}