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
    #region DefaultFormatterFactory
    public partial class DefaultFormatterFactory
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#%3Cinit%3E(javax.swing.JFormattedTextField.AbstractFormatter,javax.swing.JFormattedTextField.AbstractFormatter,javax.swing.JFormattedTextField.AbstractFormatter,javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        public DefaultFormatterFactory(Javax.Swing.JFormattedTextField.AbstractFormatter arg0, Javax.Swing.JFormattedTextField.AbstractFormatter arg1, Javax.Swing.JFormattedTextField.AbstractFormatter arg2, Javax.Swing.JFormattedTextField.AbstractFormatter arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#%3Cinit%3E(javax.swing.JFormattedTextField.AbstractFormatter,javax.swing.JFormattedTextField.AbstractFormatter,javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        public DefaultFormatterFactory(Javax.Swing.JFormattedTextField.AbstractFormatter arg0, Javax.Swing.JFormattedTextField.AbstractFormatter arg1, Javax.Swing.JFormattedTextField.AbstractFormatter arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#%3Cinit%3E(javax.swing.JFormattedTextField.AbstractFormatter,javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        public DefaultFormatterFactory(Javax.Swing.JFormattedTextField.AbstractFormatter arg0, Javax.Swing.JFormattedTextField.AbstractFormatter arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#%3Cinit%3E(javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFormattedTextField.AbstractFormatter"/></param>
        public DefaultFormatterFactory(Javax.Swing.JFormattedTextField.AbstractFormatter arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.DefaultFormatterFactory"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Text.DefaultFormatterFactory t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#getDefaultFormatter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#setDefaultFormatter(javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        public Javax.Swing.JFormattedTextField.AbstractFormatter DefaultFormatter
        {
            get { return IExecute<Javax.Swing.JFormattedTextField.AbstractFormatter>("getDefaultFormatter"); } set { IExecute("setDefaultFormatter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#getDisplayFormatter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#setDisplayFormatter(javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        public Javax.Swing.JFormattedTextField.AbstractFormatter DisplayFormatter
        {
            get { return IExecute<Javax.Swing.JFormattedTextField.AbstractFormatter>("getDisplayFormatter"); } set { IExecute("setDisplayFormatter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#getEditFormatter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#setEditFormatter(javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        public Javax.Swing.JFormattedTextField.AbstractFormatter EditFormatter
        {
            get { return IExecute<Javax.Swing.JFormattedTextField.AbstractFormatter>("getEditFormatter"); } set { IExecute("setEditFormatter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#getNullFormatter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatterFactory.html#setNullFormatter(javax.swing.JFormattedTextField.AbstractFormatter)"/>
        /// </summary>
        public Javax.Swing.JFormattedTextField.AbstractFormatter NullFormatter
        {
            get { return IExecute<Javax.Swing.JFormattedTextField.AbstractFormatter>("getNullFormatter"); } set { IExecute("setNullFormatter", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}