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
    #region LookAndFeel
    public partial class LookAndFeel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getDesktopPropertyValue(java.lang.String,java.lang.Object)
        /// </summary>
        public static object GetDesktopPropertyValue(string arg0, object arg1)
        {
            return SExecute("getDesktopPropertyValue", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#makeComponentInputMap(javax.swing.JComponent,java.lang.Object[])
        /// </summary>
        public static Javax.Swing.ComponentInputMap MakeComponentInputMap(Javax.Swing.JComponent arg0, object[] arg1)
        {
            return SExecute<Javax.Swing.ComponentInputMap>("makeComponentInputMap", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#makeInputMap(java.lang.Object[])
        /// </summary>
        public static Javax.Swing.InputMap MakeInputMap(object[] arg0)
        {
            return SExecute<Javax.Swing.InputMap>("makeInputMap", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#makeKeyBindings(java.lang.Object[])
        /// </summary>
        public static Javax.Swing.Text.JTextComponent.KeyBinding[] MakeKeyBindings(object[] arg0)
        {
            return SExecuteArray<Javax.Swing.Text.JTextComponent.KeyBinding>("makeKeyBindings", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#installBorder(javax.swing.JComponent,java.lang.String)
        /// </summary>
        public static void InstallBorder(Javax.Swing.JComponent arg0, string arg1)
        {
            SExecute("installBorder", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#installColors(javax.swing.JComponent,java.lang.String,java.lang.String)
        /// </summary>
        public static void InstallColors(Javax.Swing.JComponent arg0, string arg1, string arg2)
        {
            SExecute("installColors", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#installColorsAndFont(javax.swing.JComponent,java.lang.String,java.lang.String,java.lang.String)
        /// </summary>
        public static void InstallColorsAndFont(Javax.Swing.JComponent arg0, string arg1, string arg2, string arg3)
        {
            SExecute("installColorsAndFont", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#installProperty(javax.swing.JComponent,java.lang.String,java.lang.Object)
        /// </summary>
        public static void InstallProperty(Javax.Swing.JComponent arg0, string arg1, object arg2)
        {
            SExecute("installProperty", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#loadKeyBindings(javax.swing.InputMap,java.lang.Object[])
        /// </summary>
        public static void LoadKeyBindings(Javax.Swing.InputMap arg0, object[] arg1)
        {
            SExecute("loadKeyBindings", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#uninstallBorder(javax.swing.JComponent)
        /// </summary>
        public static void UninstallBorder(Javax.Swing.JComponent arg0)
        {
            SExecute("uninstallBorder", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getDescription() 
        /// </summary>
        public string Description
        {
            get { return IExecute<string>("getDescription"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getID() 
        /// </summary>
        public string ID
        {
            get { return IExecute<string>("getID"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getLayoutStyle() 
        /// </summary>
        public Javax.Swing.LayoutStyle LayoutStyle
        {
            get { return IExecute<Javax.Swing.LayoutStyle>("getLayoutStyle"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getName() 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getSupportsWindowDecorations() 
        /// </summary>
        public bool SupportsWindowDecorations
        {
            get { return IExecute<bool>("getSupportsWindowDecorations"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#isNativeLookAndFeel()
        /// </summary>
        public bool IsNativeLookAndFeel()
        {
            return IExecute<bool>("isNativeLookAndFeel");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#isSupportedLookAndFeel()
        /// </summary>
        public bool IsSupportedLookAndFeel()
        {
            return IExecute<bool>("isSupportedLookAndFeel");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getDisabledIcon(javax.swing.JComponent,javax.swing.Icon)
        /// </summary>
        public Javax.Swing.Icon GetDisabledIcon(Javax.Swing.JComponent arg0, Javax.Swing.Icon arg1)
        {
            return IExecute<Javax.Swing.Icon>("getDisabledIcon", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#getDisabledSelectedIcon(javax.swing.JComponent,javax.swing.Icon)
        /// </summary>
        public Javax.Swing.Icon GetDisabledSelectedIcon(Javax.Swing.JComponent arg0, Javax.Swing.Icon arg1)
        {
            return IExecute<Javax.Swing.Icon>("getDisabledSelectedIcon", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#initialize()
        /// </summary>
        public void Initialize()
        {
            IExecute("initialize");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#provideErrorFeedback(java.awt.Component)
        /// </summary>
        public void ProvideErrorFeedback(Java.Awt.Component arg0)
        {
            IExecute("provideErrorFeedback", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LookAndFeel.html#uninitialize()
        /// </summary>
        public void Uninitialize()
        {
            IExecute("uninitialize");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}