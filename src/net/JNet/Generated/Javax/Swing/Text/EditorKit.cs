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

namespace Javax.Swing.Text
{
    #region EditorKit
    public partial class EditorKit
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.EditorKit"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Swing.Text.EditorKit t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.EditorKit"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Text.EditorKit t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#getActions()"/> 
        /// </summary>
        public Javax.Swing.Action[] Actions
        {
            get { return IExecuteArray<Javax.Swing.Action>("getActions"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#getContentType()"/> 
        /// </summary>
        public string ContentType
        {
            get { return IExecute<string>("getContentType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#getViewFactory()"/> 
        /// </summary>
        public Javax.Swing.Text.ViewFactory ViewFactory
        {
            get { return IExecute<Javax.Swing.Text.ViewFactory>("getViewFactory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#createCaret()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Swing.Text.Caret"/></returns>
        public Javax.Swing.Text.Caret CreateCaret()
        {
            return IExecute<Javax.Swing.Text.Caret>("createCaret");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#createDefaultDocument()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Swing.Text.Document"/></returns>
        public Javax.Swing.Text.Document CreateDefaultDocument()
        {
            return IExecute<Javax.Swing.Text.Document>("createDefaultDocument");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#read(java.io.InputStream,javax.swing.text.Document,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Document"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Read(Java.Io.InputStream arg0, Javax.Swing.Text.Document arg1, int arg2)
        {
            IExecute("read", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#read(java.io.Reader,javax.swing.text.Document,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Document"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Read(Java.Io.Reader arg0, Javax.Swing.Text.Document arg1, int arg2)
        {
            IExecute("read", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#write(java.io.OutputStream,javax.swing.text.Document,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Document"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <param name="arg3"><see langword="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Write(Java.Io.OutputStream arg0, Javax.Swing.Text.Document arg1, int arg2, int arg3)
        {
            IExecute("write", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#write(java.io.Writer,javax.swing.text.Document,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Document"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <param name="arg3"><see langword="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Write(Java.Io.Writer arg0, Javax.Swing.Text.Document arg1, int arg2, int arg3)
        {
            IExecute("write", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#deinstall(javax.swing.JEditorPane)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JEditorPane"/></param>
        public void Deinstall(Javax.Swing.JEditorPane arg0)
        {
            IExecute("deinstall", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#install(javax.swing.JEditorPane)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JEditorPane"/></param>
        public void Install(Javax.Swing.JEditorPane arg0)
        {
            IExecute("install", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}