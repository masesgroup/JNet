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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Im.Spi
{
    #region IInputMethodContext
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IInputMethodContext : Java.Awt.Im.IInputMethodRequests
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodContext.html#createInputMethodWindow(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Awt.Window"/></returns>
        Java.Awt.Window CreateInputMethodWindow(string arg0, bool arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodContext.html#createInputMethodJFrame(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Swing.JFrame"/></returns>
        Javax.Swing.JFrame CreateInputMethodJFrame(string arg0, bool arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodContext.html#dispatchInputMethodEvent(int,java.text.AttributedCharacterIterator,int,java.awt.font.TextHitInfo,java.awt.font.TextHitInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Text.AttributedCharacterIterator"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <param name="arg4"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        void DispatchInputMethodEvent(int arg0, Java.Text.AttributedCharacterIterator arg1, int arg2, Java.Awt.FontNs.TextHitInfo arg3, Java.Awt.FontNs.TextHitInfo arg4);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodContext.html#enableClientWindowNotification(java.awt.im.spi.InputMethod,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Im.Spi.InputMethod"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        void EnableClientWindowNotification(Java.Awt.Im.Spi.InputMethod arg0, bool arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region InputMethodContext
    public partial class InputMethodContext : Java.Awt.Im.Spi.IInputMethodContext
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodContext.html#createInputMethodWindow(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Awt.Window"/></returns>
        public Java.Awt.Window CreateInputMethodWindow(string arg0, bool arg1)
        {
            return IExecute<Java.Awt.Window>("createInputMethodWindow", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodContext.html#createInputMethodJFrame(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Swing.JFrame"/></returns>
        public Javax.Swing.JFrame CreateInputMethodJFrame(string arg0, bool arg1)
        {
            return IExecute<Javax.Swing.JFrame>("createInputMethodJFrame", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodContext.html#dispatchInputMethodEvent(int,java.text.AttributedCharacterIterator,int,java.awt.font.TextHitInfo,java.awt.font.TextHitInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Text.AttributedCharacterIterator"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <param name="arg4"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        public void DispatchInputMethodEvent(int arg0, Java.Text.AttributedCharacterIterator arg1, int arg2, Java.Awt.FontNs.TextHitInfo arg3, Java.Awt.FontNs.TextHitInfo arg4)
        {
            IExecute("dispatchInputMethodEvent", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/spi/InputMethodContext.html#enableClientWindowNotification(java.awt.im.spi.InputMethod,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Im.Spi.InputMethod"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void EnableClientWindowNotification(Java.Awt.Im.Spi.InputMethod arg0, bool arg1)
        {
            IExecute("enableClientWindowNotification", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}