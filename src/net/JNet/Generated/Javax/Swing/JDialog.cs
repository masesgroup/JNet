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
    #region JDialog
    public partial class JDialog
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#<init>(java.awt.Window)
        /// </summary>
        public JDialog(Java.Awt.Window arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#<init>(java.awt.Dialog,java.lang.String,boolean,java.awt.GraphicsConfiguration)
        /// </summary>
        public JDialog(Java.Awt.Dialog arg0, string arg1, bool arg2, Java.Awt.GraphicsConfiguration arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#<init>(java.awt.Dialog,java.lang.String,boolean)
        /// </summary>
        public JDialog(Java.Awt.Dialog arg0, string arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#<init>(java.awt.Dialog,java.lang.String)
        /// </summary>
        public JDialog(Java.Awt.Dialog arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#<init>(java.awt.Window,java.lang.String)
        /// </summary>
        public JDialog(Java.Awt.Window arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#<init>(java.awt.Frame,java.lang.String)
        /// </summary>
        public JDialog(Java.Awt.Frame arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#<init>(java.awt.Frame,boolean)
        /// </summary>
        public JDialog(Java.Awt.Frame arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#<init>(java.awt.Frame)
        /// </summary>
        public JDialog(Java.Awt.Frame arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#<init>(java.awt.Dialog,boolean)
        /// </summary>
        public JDialog(Java.Awt.Dialog arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#<init>(java.awt.Dialog)
        /// </summary>
        public JDialog(Java.Awt.Dialog arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#<init>(java.awt.Frame,java.lang.String,boolean,java.awt.GraphicsConfiguration)
        /// </summary>
        public JDialog(Java.Awt.Frame arg0, string arg1, bool arg2, Java.Awt.GraphicsConfiguration arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#<init>(java.awt.Frame,java.lang.String,boolean)
        /// </summary>
        public JDialog(Java.Awt.Frame arg0, string arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Swing.WindowConstants(Javax.Swing.JDialog t) => t.Cast<Javax.Swing.WindowConstants>();
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JDialog t) => t.Cast<Javax.Accessibility.Accessible>();
        public static implicit operator Javax.Swing.RootPaneContainer(Javax.Swing.JDialog t) => t.Cast<Javax.Swing.RootPaneContainer>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#isDefaultLookAndFeelDecorated()
        /// </summary>
        public static bool IsDefaultLookAndFeelDecorated()
        {
            return SExecute<bool>("isDefaultLookAndFeelDecorated");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#setDefaultLookAndFeelDecorated(boolean)
        /// </summary>
        public static void SetDefaultLookAndFeelDecorated(bool arg0)
        {
            SExecute("setDefaultLookAndFeelDecorated", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#getContentPane() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#setContentPane(java.awt.Container)
        /// </summary>
        public Java.Awt.Container ContentPane
        {
            get { return IExecute<Java.Awt.Container>("getContentPane"); } set { IExecute("setContentPane", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#getDefaultCloseOperation() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#setDefaultCloseOperation(int)
        /// </summary>
        public int DefaultCloseOperation
        {
            get { return IExecute<int>("getDefaultCloseOperation"); } set { IExecute("setDefaultCloseOperation", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#getGlassPane() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#setGlassPane(java.awt.Component)
        /// </summary>
        public Java.Awt.Component GlassPane
        {
            get { return IExecute<Java.Awt.Component>("getGlassPane"); } set { IExecute("setGlassPane", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#getJMenuBar() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#setJMenuBar(javax.swing.JMenuBar)
        /// </summary>
        public Javax.Swing.JMenuBar JMenuBar
        {
            get { return IExecute<Javax.Swing.JMenuBar>("getJMenuBar"); } set { IExecute("setJMenuBar", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#getLayeredPane() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#setLayeredPane(javax.swing.JLayeredPane)
        /// </summary>
        public Javax.Swing.JLayeredPane LayeredPane
        {
            get { return IExecute<Javax.Swing.JLayeredPane>("getLayeredPane"); } set { IExecute("setLayeredPane", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#getRootPane() 
        /// </summary>
        public Javax.Swing.JRootPane RootPane
        {
            get { return IExecute<Javax.Swing.JRootPane>("getRootPane"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#getTransferHandler() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JDialog.html#setTransferHandler(javax.swing.TransferHandler)
        /// </summary>
        public Javax.Swing.TransferHandler TransferHandler
        {
            get { return IExecute<Javax.Swing.TransferHandler>("getTransferHandler"); } set { IExecute("setTransferHandler", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}