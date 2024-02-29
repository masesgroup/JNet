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

namespace Javax.Swing
{
    #region JFormattedTextField
    public partial class JFormattedTextField
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#%3Cinit%3E(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public JFormattedTextField(object arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#%3Cinit%3E(java.text.Format)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.Format"/></param>
        public JFormattedTextField(Java.Text.Format arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#%3Cinit%3E(javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        public JFormattedTextField(Javax.Swing.JFormattedTextField.AbstractFormatter arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#%3Cinit%3E(javax.swing.JFormattedTextField.AbstractFormatterFactory,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatterFactory"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public JFormattedTextField(Javax.Swing.JFormattedTextField.AbstractFormatterFactory arg0, object arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#%3Cinit%3E(javax.swing.JFormattedTextField.AbstractFormatterFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatterFactory"/></param>
        public JFormattedTextField(Javax.Swing.JFormattedTextField.AbstractFormatterFactory arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#COMMIT"/>
        /// </summary>
        public static int COMMIT { get { if (!_COMMITReady) { _COMMITContent = SGetField<int>(LocalBridgeClazz, "COMMIT"); _COMMITReady = true; } return _COMMITContent; } }
        private static int _COMMITContent = default;
        private static bool _COMMITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#COMMIT_OR_REVERT"/>
        /// </summary>
        public static int COMMIT_OR_REVERT { get { if (!_COMMIT_OR_REVERTReady) { _COMMIT_OR_REVERTContent = SGetField<int>(LocalBridgeClazz, "COMMIT_OR_REVERT"); _COMMIT_OR_REVERTReady = true; } return _COMMIT_OR_REVERTContent; } }
        private static int _COMMIT_OR_REVERTContent = default;
        private static bool _COMMIT_OR_REVERTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#PERSIST"/>
        /// </summary>
        public static int PERSIST { get { if (!_PERSISTReady) { _PERSISTContent = SGetField<int>(LocalBridgeClazz, "PERSIST"); _PERSISTReady = true; } return _PERSISTContent; } }
        private static int _PERSISTContent = default;
        private static bool _PERSISTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#REVERT"/>
        /// </summary>
        public static int REVERT { get { if (!_REVERTReady) { _REVERTContent = SGetField<int>(LocalBridgeClazz, "REVERT"); _REVERTReady = true; } return _REVERTContent; } }
        private static int _REVERTContent = default;
        private static bool _REVERTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#getFocusLostBehavior()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#setFocusLostBehavior(int)"/>
        /// </summary>
        public int FocusLostBehavior
        {
            get { return IExecuteWithSignature<int>("getFocusLostBehavior", "()I"); } set { IExecuteWithSignature("setFocusLostBehavior", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#getFormatter()"/> 
        /// </summary>
        public Javax.Swing.JFormattedTextField.AbstractFormatter Formatter
        {
            get { return IExecuteWithSignature<Javax.Swing.JFormattedTextField.AbstractFormatter>("getFormatter", "()Ljavax/swing/JFormattedTextField$AbstractFormatter;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#getFormatterFactory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#setFormatterFactory(javax.swing.JFormattedTextField.AbstractFormatterFactory)"/>
        /// </summary>
        public Javax.Swing.JFormattedTextField.AbstractFormatterFactory FormatterFactory
        {
            get { return IExecuteWithSignature<Javax.Swing.JFormattedTextField.AbstractFormatterFactory>("getFormatterFactory", "()Ljavax/swing/JFormattedTextField$AbstractFormatterFactory;"); } set { IExecuteWithSignature("setFormatterFactory", "(Ljavax/swing/JFormattedTextField$AbstractFormatterFactory;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#setValue(java.lang.Object)"/>
        /// </summary>
        public object Value
        {
            get { return IExecuteWithSignature("getValue", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setValue", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#isEditValid()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEditValid()
        {
            return IExecuteWithSignature<bool>("isEditValid", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.html#commitEdit()"/>
        /// </summary>

        /// <exception cref="Java.Text.ParseException"/>
        public void CommitEdit()
        {
            IExecuteWithSignature("commitEdit", "()V");
        }

        #endregion

        #region Nested classes
        #region AbstractFormatter
        public partial class AbstractFormatter
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.AbstractFormatter.html#stringToValue(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="object"/></returns>
            /// <exception cref="Java.Text.ParseException"/>
            public object StringToValue(Java.Lang.String arg0)
            {
                return IExecuteWithSignature("stringToValue", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.AbstractFormatter.html#valueToString(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            /// <exception cref="Java.Text.ParseException"/>
            public Java.Lang.String ValueToString(object arg0)
            {
                return IExecuteWithSignature<Java.Lang.String>("valueToString", "(Ljava/lang/Object;)Ljava/lang/String;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.AbstractFormatter.html#install(javax.swing.JFormattedTextField)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField"/></param>
            public void Install(Javax.Swing.JFormattedTextField arg0)
            {
                IExecuteWithSignature("install", "(Ljavax/swing/JFormattedTextField;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.AbstractFormatter.html#uninstall()"/>
            /// </summary>
            public void Uninstall()
            {
                IExecuteWithSignature("uninstall", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AbstractFormatterFactory
        public partial class AbstractFormatterFactory
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JFormattedTextField.AbstractFormatterFactory.html#getFormatter(javax.swing.JFormattedTextField)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField"/></param>
            /// <returns><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></returns>
            public Javax.Swing.JFormattedTextField.AbstractFormatter GetFormatter(Javax.Swing.JFormattedTextField arg0)
            {
                return IExecuteWithSignature<Javax.Swing.JFormattedTextField.AbstractFormatter>("getFormatter", "(Ljavax/swing/JFormattedTextField;)Ljavax/swing/JFormattedTextField$AbstractFormatter;", arg0);
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