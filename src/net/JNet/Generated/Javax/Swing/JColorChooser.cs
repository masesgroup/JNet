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

namespace Javax.Swing
{
    #region JColorChooser
    public partial class JColorChooser
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#<init>(java.awt.Color)
        /// </summary>
        public JColorChooser(Java.Awt.Color arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#<init>(javax.swing.colorchooser.ColorSelectionModel)
        /// </summary>
        public JColorChooser(Javax.Swing.Colorchooser.ColorSelectionModel arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JColorChooser t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#SELECTION_MODEL_PROPERTY
        /// </summary>
        public static string SELECTION_MODEL_PROPERTY => Clazz.GetField<string>("SELECTION_MODEL_PROPERTY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#PREVIEW_PANEL_PROPERTY
        /// </summary>
        public static string PREVIEW_PANEL_PROPERTY => Clazz.GetField<string>("PREVIEW_PANEL_PROPERTY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#CHOOSER_PANELS_PROPERTY
        /// </summary>
        public static string CHOOSER_PANELS_PROPERTY => Clazz.GetField<string>("CHOOSER_PANELS_PROPERTY");
        
        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#showDialog(java.awt.Component,java.lang.String,java.awt.Color,boolean) throws java.awt.HeadlessException
        /// </summary>
        public static Java.Awt.Color ShowDialog(Java.Awt.Component arg0, string arg1, Java.Awt.Color arg2, bool arg3)
        {
            return SExecute<Java.Awt.Color>("showDialog", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#showDialog(java.awt.Component,java.lang.String,java.awt.Color) throws java.awt.HeadlessException
        /// </summary>
        public static Java.Awt.Color ShowDialog(Java.Awt.Component arg0, string arg1, Java.Awt.Color arg2)
        {
            return SExecute<Java.Awt.Color>("showDialog", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#createDialog(java.awt.Component,java.lang.String,boolean,javax.swing.JColorChooser,java.awt.event.ActionListener,java.awt.event.ActionListener) throws java.awt.HeadlessException
        /// </summary>
        public static Javax.Swing.JDialog CreateDialog(Java.Awt.Component arg0, string arg1, bool arg2, Javax.Swing.JColorChooser arg3, Java.Awt.EventNs.ActionListener arg4, Java.Awt.EventNs.ActionListener arg5)
        {
            return SExecute<Javax.Swing.JDialog>("createDialog", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#getChooserPanels() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#setChooserPanels(javax.swing.colorchooser.AbstractColorChooserPanel[])
        /// </summary>
        public Javax.Swing.Colorchooser.AbstractColorChooserPanel[] ChooserPanels
        {
            get { return IExecuteArray<Javax.Swing.Colorchooser.AbstractColorChooserPanel>("getChooserPanels"); } set { IExecute("setChooserPanels", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#getColor() 
        /// </summary>
        public Java.Awt.Color Color
        {
            get { return IExecute<Java.Awt.Color>("getColor"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#getDragEnabled() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#setDragEnabled(boolean)
        /// </summary>
        public bool DragEnabled
        {
            get { return IExecute<bool>("getDragEnabled"); } set { IExecute("setDragEnabled", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#getPreviewPanel() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#setPreviewPanel(javax.swing.JComponent)
        /// </summary>
        public Javax.Swing.JComponent PreviewPanel
        {
            get { return IExecute<Javax.Swing.JComponent>("getPreviewPanel"); } set { IExecute("setPreviewPanel", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#getSelectionModel() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#setSelectionModel(javax.swing.colorchooser.ColorSelectionModel)
        /// </summary>
        public Javax.Swing.Colorchooser.ColorSelectionModel SelectionModel
        {
            get { return IExecute<Javax.Swing.Colorchooser.ColorSelectionModel>("getSelectionModel"); } set { IExecute("setSelectionModel", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#removeChooserPanel(javax.swing.colorchooser.AbstractColorChooserPanel)
        /// </summary>
        public Javax.Swing.Colorchooser.AbstractColorChooserPanel RemoveChooserPanel(Javax.Swing.Colorchooser.AbstractColorChooserPanel arg0)
        {
            return IExecute<Javax.Swing.Colorchooser.AbstractColorChooserPanel>("removeChooserPanel", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#addChooserPanel(javax.swing.colorchooser.AbstractColorChooserPanel)
        /// </summary>
        public void AddChooserPanel(Javax.Swing.Colorchooser.AbstractColorChooserPanel arg0)
        {
            IExecute("addChooserPanel", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#setColor(int,int,int)
        /// </summary>
        public void SetColor(int arg0, int arg1, int arg2)
        {
            IExecute("setColor", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#setColor(int)
        /// </summary>
        public void SetColor(int arg0)
        {
            IExecute("setColor", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#setColor(java.awt.Color)
        /// </summary>
        public void SetColor(Java.Awt.Color arg0)
        {
            IExecute("setColor", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JColorChooser.html#setUI(javax.swing.plaf.ColorChooserUI)
        /// </summary>
        public void SetUI(Javax.Swing.Plaf.ColorChooserUI arg0)
        {
            IExecute("setUI", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}