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

namespace Javax.Swing.Plaf
{
    #region TextUI
    public partial class TextUI
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TextUI.html#getNextVisualPositionFrom(javax.swing.text.JTextComponent,int,javax.swing.text.Position.Bias,int,javax.swing.text.Position.Bias[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public int GetNextVisualPositionFrom(Javax.Swing.Text.JTextComponent arg0, int arg1, Javax.Swing.Text.Position.Bias arg2, int arg3, Javax.Swing.Text.Position.Bias[] arg4)
        {
            return IExecute<int>("getNextVisualPositionFrom", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TextUI.html#getEditorKit(javax.swing.text.JTextComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <returns><see cref="Javax.Swing.Text.EditorKit"/></returns>
        public Javax.Swing.Text.EditorKit GetEditorKit(Javax.Swing.Text.JTextComponent arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.EditorKit>("getEditorKit", "(Ljavax/swing/text/JTextComponent;)Ljavax/swing/text/EditorKit;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TextUI.html#getRootView(javax.swing.text.JTextComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <returns><see cref="Javax.Swing.Text.View"/></returns>
        public Javax.Swing.Text.View GetRootView(Javax.Swing.Text.JTextComponent arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.View>("getRootView", "(Ljavax/swing/text/JTextComponent;)Ljavax/swing/text/View;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TextUI.html#damageRange(javax.swing.text.JTextComponent,int,int,javax.swing.text.Position.Bias,javax.swing.text.Position.Bias)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        public void DamageRange(Javax.Swing.Text.JTextComponent arg0, int arg1, int arg2, Javax.Swing.Text.Position.Bias arg3, Javax.Swing.Text.Position.Bias arg4)
        {
            IExecute("damageRange", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TextUI.html#damageRange(javax.swing.text.JTextComponent,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void DamageRange(Javax.Swing.Text.JTextComponent arg0, int arg1, int arg2)
        {
            IExecute("damageRange", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TextUI.html#viewToModel2D(javax.swing.text.JTextComponent,java.awt.geom.Point2D,javax.swing.text.Position.Bias[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <returns><see cref="int"/></returns>
        public int ViewToModel2D(Javax.Swing.Text.JTextComponent arg0, Java.Awt.Geom.Point2D arg1, Javax.Swing.Text.Position.Bias[] arg2)
        {
            return IExecute<int>("viewToModel2D", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TextUI.html#modelToView2D(javax.swing.text.JTextComponent,int,javax.swing.text.Position.Bias)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public Java.Awt.Geom.Rectangle2D ModelToView2D(Javax.Swing.Text.JTextComponent arg0, int arg1, Javax.Swing.Text.Position.Bias arg2)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("modelToView2D", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/TextUI.html#getToolTipText2D(javax.swing.text.JTextComponent,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetToolTipText2D(Javax.Swing.Text.JTextComponent arg0, Java.Awt.Geom.Point2D arg1)
        {
            return IExecute<Java.Lang.String>("getToolTipText2D", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}