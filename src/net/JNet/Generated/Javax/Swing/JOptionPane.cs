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
    #region JOptionPane
    public partial class JOptionPane
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#%3Cinit%3E(java.lang.Object,int,int,javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Icon"/></param>
        public JOptionPane(object arg0, int arg1, int arg2, Javax.Swing.Icon arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#%3Cinit%3E(java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public JOptionPane(object arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#%3Cinit%3E(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public JOptionPane(object arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#%3Cinit%3E(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public JOptionPane(object arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JOptionPane"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JOptionPane t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#CANCEL_OPTION"/>
        /// </summary>
        public static int CANCEL_OPTION => Clazz.GetField<int>("CANCEL_OPTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#CLOSED_OPTION"/>
        /// </summary>
        public static int CLOSED_OPTION => Clazz.GetField<int>("CLOSED_OPTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#DEFAULT_OPTION"/>
        /// </summary>
        public static int DEFAULT_OPTION => Clazz.GetField<int>("DEFAULT_OPTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#ERROR_MESSAGE"/>
        /// </summary>
        public static int ERROR_MESSAGE => Clazz.GetField<int>("ERROR_MESSAGE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#INFORMATION_MESSAGE"/>
        /// </summary>
        public static int INFORMATION_MESSAGE => Clazz.GetField<int>("INFORMATION_MESSAGE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#NO_OPTION"/>
        /// </summary>
        public static int NO_OPTION => Clazz.GetField<int>("NO_OPTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#OK_CANCEL_OPTION"/>
        /// </summary>
        public static int OK_CANCEL_OPTION => Clazz.GetField<int>("OK_CANCEL_OPTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#OK_OPTION"/>
        /// </summary>
        public static int OK_OPTION => Clazz.GetField<int>("OK_OPTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#PLAIN_MESSAGE"/>
        /// </summary>
        public static int PLAIN_MESSAGE => Clazz.GetField<int>("PLAIN_MESSAGE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#QUESTION_MESSAGE"/>
        /// </summary>
        public static int QUESTION_MESSAGE => Clazz.GetField<int>("QUESTION_MESSAGE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#WARNING_MESSAGE"/>
        /// </summary>
        public static int WARNING_MESSAGE => Clazz.GetField<int>("WARNING_MESSAGE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#YES_NO_CANCEL_OPTION"/>
        /// </summary>
        public static int YES_NO_CANCEL_OPTION => Clazz.GetField<int>("YES_NO_CANCEL_OPTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#YES_NO_OPTION"/>
        /// </summary>
        public static int YES_NO_OPTION => Clazz.GetField<int>("YES_NO_OPTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#YES_OPTION"/>
        /// </summary>
        public static int YES_OPTION => Clazz.GetField<int>("YES_OPTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#UNINITIALIZED_VALUE"/>
        /// </summary>
        public static object UNINITIALIZED_VALUE => Clazz.GetField("UNINITIALIZED_VALUE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#ICON_PROPERTY"/>
        /// </summary>
        public static string ICON_PROPERTY => Clazz.GetField<string>("ICON_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#INITIAL_SELECTION_VALUE_PROPERTY"/>
        /// </summary>
        public static string INITIAL_SELECTION_VALUE_PROPERTY => Clazz.GetField<string>("INITIAL_SELECTION_VALUE_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#INITIAL_VALUE_PROPERTY"/>
        /// </summary>
        public static string INITIAL_VALUE_PROPERTY => Clazz.GetField<string>("INITIAL_VALUE_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#INPUT_VALUE_PROPERTY"/>
        /// </summary>
        public static string INPUT_VALUE_PROPERTY => Clazz.GetField<string>("INPUT_VALUE_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#MESSAGE_PROPERTY"/>
        /// </summary>
        public static string MESSAGE_PROPERTY => Clazz.GetField<string>("MESSAGE_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#MESSAGE_TYPE_PROPERTY"/>
        /// </summary>
        public static string MESSAGE_TYPE_PROPERTY => Clazz.GetField<string>("MESSAGE_TYPE_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#OPTION_TYPE_PROPERTY"/>
        /// </summary>
        public static string OPTION_TYPE_PROPERTY => Clazz.GetField<string>("OPTION_TYPE_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#OPTIONS_PROPERTY"/>
        /// </summary>
        public static string OPTIONS_PROPERTY => Clazz.GetField<string>("OPTIONS_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#SELECTION_VALUES_PROPERTY"/>
        /// </summary>
        public static string SELECTION_VALUES_PROPERTY => Clazz.GetField<string>("SELECTION_VALUES_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#VALUE_PROPERTY"/>
        /// </summary>
        public static string VALUE_PROPERTY => Clazz.GetField<string>("VALUE_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#WANTS_INPUT_PROPERTY"/>
        /// </summary>
        public static string WANTS_INPUT_PROPERTY => Clazz.GetField<string>("WANTS_INPUT_PROPERTY");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getRootFrame()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#setRootFrame(java.awt.Frame)"/>
        /// </summary>
        public static Java.Awt.Frame RootFrame
        {
            get { return SExecute<Java.Awt.Frame>("getRootFrame"); } set { SExecute("setRootFrame", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showConfirmDialog(java.awt.Component,java.lang.Object,java.lang.String,int,int,javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Javax.Swing.Icon"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static int ShowConfirmDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3, int arg4, Javax.Swing.Icon arg5)
        {
            return SExecute<int>("showConfirmDialog", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showConfirmDialog(java.awt.Component,java.lang.Object,java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static int ShowConfirmDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3, int arg4)
        {
            return SExecute<int>("showConfirmDialog", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showConfirmDialog(java.awt.Component,java.lang.Object,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static int ShowConfirmDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3)
        {
            return SExecute<int>("showConfirmDialog", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showConfirmDialog(java.awt.Component,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static int ShowConfirmDialog(Java.Awt.Component arg0, object arg1)
        {
            return SExecute<int>("showConfirmDialog", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInternalConfirmDialog(java.awt.Component,java.lang.Object,java.lang.String,int,int,javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Javax.Swing.Icon"/></param>
        /// <returns><see langword="int"/></returns>
        public static int ShowInternalConfirmDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3, int arg4, Javax.Swing.Icon arg5)
        {
            return SExecute<int>("showInternalConfirmDialog", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInternalConfirmDialog(java.awt.Component,java.lang.Object,java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        public static int ShowInternalConfirmDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3, int arg4)
        {
            return SExecute<int>("showInternalConfirmDialog", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInternalConfirmDialog(java.awt.Component,java.lang.Object,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        public static int ShowInternalConfirmDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3)
        {
            return SExecute<int>("showInternalConfirmDialog", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInternalConfirmDialog(java.awt.Component,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see langword="int"/></returns>
        public static int ShowInternalConfirmDialog(Java.Awt.Component arg0, object arg1)
        {
            return SExecute<int>("showInternalConfirmDialog", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInternalOptionDialog(java.awt.Component,java.lang.Object,java.lang.String,int,int,javax.swing.Icon,java.lang.Object[],java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <returns><see langword="int"/></returns>
        public static int ShowInternalOptionDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3, int arg4, Javax.Swing.Icon arg5, object[] arg6, object arg7)
        {
            return SExecute<int>("showInternalOptionDialog", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showOptionDialog(java.awt.Component,java.lang.Object,java.lang.String,int,int,javax.swing.Icon,java.lang.Object[],java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static int ShowOptionDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3, int arg4, Javax.Swing.Icon arg5, object[] arg6, object arg7)
        {
            return SExecute<int>("showOptionDialog", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getFrameForComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Frame"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static Java.Awt.Frame GetFrameForComponent(Java.Awt.Component arg0)
        {
            return SExecute<Java.Awt.Frame>("getFrameForComponent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInputDialog(java.awt.Component,java.lang.Object,java.lang.String,int,javax.swing.Icon,java.lang.Object[],java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <returns><see langword="object"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static object ShowInputDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3, Javax.Swing.Icon arg4, object[] arg5, object arg6)
        {
            return SExecute("showInputDialog", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInternalInputDialog(java.awt.Component,java.lang.Object,java.lang.String,int,javax.swing.Icon,java.lang.Object[],java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <returns><see langword="object"/></returns>
        public static object ShowInternalInputDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3, Javax.Swing.Icon arg4, object[] arg5, object arg6)
        {
            return SExecute("showInternalInputDialog", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInputDialog(java.awt.Component,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see langword="string"/></returns>
        public static string ShowInputDialog(Java.Awt.Component arg0, object arg1, object arg2)
        {
            return SExecute<string>("showInputDialog", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInputDialog(java.awt.Component,java.lang.Object,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see langword="string"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static string ShowInputDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3)
        {
            return SExecute<string>("showInputDialog", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInputDialog(java.awt.Component,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see langword="string"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static string ShowInputDialog(Java.Awt.Component arg0, object arg1)
        {
            return SExecute<string>("showInputDialog", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInputDialog(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see langword="string"/></returns>
        public static string ShowInputDialog(object arg0, object arg1)
        {
            return SExecute<string>("showInputDialog", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInputDialog(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="string"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static string ShowInputDialog(object arg0)
        {
            return SExecute<string>("showInputDialog", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInternalInputDialog(java.awt.Component,java.lang.Object,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see langword="string"/></returns>
        public static string ShowInternalInputDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3)
        {
            return SExecute<string>("showInternalInputDialog", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInternalInputDialog(java.awt.Component,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see langword="string"/></returns>
        public static string ShowInternalInputDialog(Java.Awt.Component arg0, object arg1)
        {
            return SExecute<string>("showInternalInputDialog", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getDesktopPaneForComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Javax.Swing.JDesktopPane"/></returns>
        public static Javax.Swing.JDesktopPane GetDesktopPaneForComponent(Java.Awt.Component arg0)
        {
            return SExecute<Javax.Swing.JDesktopPane>("getDesktopPaneForComponent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInternalMessageDialog(java.awt.Component,java.lang.Object,java.lang.String,int,javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Icon"/></param>
        public static void ShowInternalMessageDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3, Javax.Swing.Icon arg4)
        {
            SExecute("showInternalMessageDialog", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInternalMessageDialog(java.awt.Component,java.lang.Object,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public static void ShowInternalMessageDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3)
        {
            SExecute("showInternalMessageDialog", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showInternalMessageDialog(java.awt.Component,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public static void ShowInternalMessageDialog(Java.Awt.Component arg0, object arg1)
        {
            SExecute("showInternalMessageDialog", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showMessageDialog(java.awt.Component,java.lang.Object,java.lang.String,int,javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Icon"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static void ShowMessageDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3, Javax.Swing.Icon arg4)
        {
            SExecute("showMessageDialog", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showMessageDialog(java.awt.Component,java.lang.Object,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static void ShowMessageDialog(Java.Awt.Component arg0, object arg1, string arg2, int arg3)
        {
            SExecute("showMessageDialog", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#showMessageDialog(java.awt.Component,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static void ShowMessageDialog(Java.Awt.Component arg0, object arg1)
        {
            SExecute("showMessageDialog", arg0, arg1);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#setIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon Icon
        {
            get { return IExecute<Javax.Swing.Icon>("getIcon"); } set { IExecute("setIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getInitialSelectionValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#setInitialSelectionValue(java.lang.Object)"/>
        /// </summary>
        public object InitialSelectionValue
        {
            get { return IExecute("getInitialSelectionValue"); } set { IExecute("setInitialSelectionValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getInitialValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#setInitialValue(java.lang.Object)"/>
        /// </summary>
        public object InitialValue
        {
            get { return IExecute("getInitialValue"); } set { IExecute("setInitialValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getInputValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#setInputValue(java.lang.Object)"/>
        /// </summary>
        public object InputValue
        {
            get { return IExecute("getInputValue"); } set { IExecute("setInputValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getMaxCharactersPerLineCount()"/> 
        /// </summary>
        public int MaxCharactersPerLineCount
        {
            get { return IExecute<int>("getMaxCharactersPerLineCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getMessage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#setMessage(java.lang.Object)"/>
        /// </summary>
        public object Message
        {
            get { return IExecute("getMessage"); } set { IExecute("setMessage", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getMessageType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#setMessageType(int)"/>
        /// </summary>
        public int MessageType
        {
            get { return IExecute<int>("getMessageType"); } set { IExecute("setMessageType", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getOptions()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#setOptions(java.lang.Object[])"/>
        /// </summary>
        public object[] Options
        {
            get { return IExecuteArray<object>("getOptions"); } set { IExecute("setOptions", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getOptionType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#setOptionType(int)"/>
        /// </summary>
        public int OptionType
        {
            get { return IExecute<int>("getOptionType"); } set { IExecute("setOptionType", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getSelectionValues()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#setSelectionValues(java.lang.Object[])"/>
        /// </summary>
        public object[] SelectionValues
        {
            get { return IExecuteArray<object>("getSelectionValues"); } set { IExecute("setSelectionValues", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#setValue(java.lang.Object)"/>
        /// </summary>
        public object Value
        {
            get { return IExecute("getValue"); } set { IExecute("setValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#getWantsInput()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#setWantsInput(boolean)"/>
        /// </summary>
        public bool WantsInput
        {
            get { return IExecute<bool>("getWantsInput"); } set { IExecute("setWantsInput", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#createDialog(java.awt.Component,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.JDialog"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Javax.Swing.JDialog CreateDialog(Java.Awt.Component arg0, string arg1)
        {
            return IExecute<Javax.Swing.JDialog>("createDialog", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#createDialog(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.JDialog"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Javax.Swing.JDialog CreateDialog(string arg0)
        {
            return IExecute<Javax.Swing.JDialog>("createDialog", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#createInternalFrame(java.awt.Component,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.JInternalFrame"/></returns>
        public Javax.Swing.JInternalFrame CreateInternalFrame(Java.Awt.Component arg0, string arg1)
        {
            return IExecute<Javax.Swing.JInternalFrame>("createInternalFrame", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#selectInitialValue()"/>
        /// </summary>
        public void SelectInitialValue()
        {
            IExecute("selectInitialValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JOptionPane.html#setUI(javax.swing.plaf.OptionPaneUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.OptionPaneUI"/></param>
        public void SetUI(Javax.Swing.Plaf.OptionPaneUI arg0)
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