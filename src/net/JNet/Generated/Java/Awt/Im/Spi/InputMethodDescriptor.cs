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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Im.Spi
{
    #region IInputMethodDescriptor
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IInputMethodDescriptor
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#getAvailableLocales()"/> 
        /// </summary>
        Java.Util.Locale[] AvailableLocales { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#hasDynamicLocaleList()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool HasDynamicLocaleList();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#createInputMethod()"/>
        /// </summary>

        /// <returns><see cref="Java.Awt.Im.Spi.InputMethod"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        Java.Awt.Im.Spi.InputMethod CreateInputMethod();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#getInputMethodIcon(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        Java.Awt.Image GetInputMethodIcon(Java.Util.Locale arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#getInputMethodDisplayName(java.util.Locale,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        string GetInputMethodDisplayName(Java.Util.Locale arg0, Java.Util.Locale arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region InputMethodDescriptor
    public partial class InputMethodDescriptor : Java.Awt.Im.Spi.IInputMethodDescriptor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#getAvailableLocales()"/> 
        /// </summary>
        public Java.Util.Locale[] AvailableLocales
        {
            get { return IExecuteArray<Java.Util.Locale>("getAvailableLocales"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#hasDynamicLocaleList()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasDynamicLocaleList()
        {
            return IExecute<bool>("hasDynamicLocaleList");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#createInputMethod()"/>
        /// </summary>

        /// <returns><see cref="Java.Awt.Im.Spi.InputMethod"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        public Java.Awt.Im.Spi.InputMethod CreateInputMethod()
        {
            return IExecute<Java.Awt.Im.Spi.InputMethod>("createInputMethod");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#getInputMethodIcon(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image GetInputMethodIcon(Java.Util.Locale arg0)
        {
            return IExecute<Java.Awt.Image>("getInputMethodIcon", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodDescriptor.html#getInputMethodDisplayName(java.util.Locale,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetInputMethodDisplayName(Java.Util.Locale arg0, Java.Util.Locale arg1)
        {
            return IExecute<string>("getInputMethodDisplayName", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}