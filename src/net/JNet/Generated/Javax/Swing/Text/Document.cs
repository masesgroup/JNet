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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region IDocument
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDocument
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getDefaultRootElement()"/> 
        /// </summary>
        Javax.Swing.Text.Element DefaultRootElement { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getEndPosition()"/> 
        /// </summary>
        Javax.Swing.Text.Position EndPosition { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getLength()"/> 
        /// </summary>
        int Length { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getRootElements()"/> 
        /// </summary>
        Javax.Swing.Text.Element[] RootElements { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getStartPosition()"/> 
        /// </summary>
        Javax.Swing.Text.Position StartPosition { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getProperty(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        object GetProperty(object arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getText(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        string GetText(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#createPosition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Position"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        Javax.Swing.Text.Position CreatePosition(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#addDocumentListener(javax.swing.event.DocumentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentListener"/></param>
        void AddDocumentListener(Javax.Swing.Event.DocumentListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#addUndoableEditListener(javax.swing.event.UndoableEditListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.UndoableEditListener"/></param>
        void AddUndoableEditListener(Javax.Swing.Event.UndoableEditListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getText(int,int,javax.swing.text.Segment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.Segment"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        void GetText(int arg0, int arg1, Javax.Swing.Text.Segment arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#insertString(int,java.lang.String,javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        void InsertString(int arg0, string arg1, Javax.Swing.Text.AttributeSet arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#putProperty(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        void PutProperty(object arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#remove(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        void Remove(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#removeDocumentListener(javax.swing.event.DocumentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentListener"/></param>
        void RemoveDocumentListener(Javax.Swing.Event.DocumentListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#removeUndoableEditListener(javax.swing.event.UndoableEditListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.UndoableEditListener"/></param>
        void RemoveUndoableEditListener(Javax.Swing.Event.UndoableEditListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#render(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        void Render(Java.Lang.Runnable arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Document
    public partial class Document : Javax.Swing.Text.IDocument
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#StreamDescriptionProperty"/>
        /// </summary>
        public static string StreamDescriptionProperty { get { if (!_StreamDescriptionPropertyReady) { _StreamDescriptionPropertyContent = SGetField<string>(LocalBridgeClazz, "StreamDescriptionProperty"); _StreamDescriptionPropertyReady = true; } return _StreamDescriptionPropertyContent; } }
        private static string _StreamDescriptionPropertyContent = default;
        private static bool _StreamDescriptionPropertyReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#TitleProperty"/>
        /// </summary>
        public static string TitleProperty { get { if (!_TitlePropertyReady) { _TitlePropertyContent = SGetField<string>(LocalBridgeClazz, "TitleProperty"); _TitlePropertyReady = true; } return _TitlePropertyContent; } }
        private static string _TitlePropertyContent = default;
        private static bool _TitlePropertyReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getDefaultRootElement()"/> 
        /// </summary>
        public Javax.Swing.Text.Element DefaultRootElement
        {
            get { return IExecute<Javax.Swing.Text.Element>("getDefaultRootElement"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getEndPosition()"/> 
        /// </summary>
        public Javax.Swing.Text.Position EndPosition
        {
            get { return IExecute<Javax.Swing.Text.Position>("getEndPosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getLength()"/> 
        /// </summary>
        public int Length
        {
            get { return IExecute<int>("getLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getRootElements()"/> 
        /// </summary>
        public Javax.Swing.Text.Element[] RootElements
        {
            get { return IExecuteArray<Javax.Swing.Text.Element>("getRootElements"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getStartPosition()"/> 
        /// </summary>
        public Javax.Swing.Text.Position StartPosition
        {
            get { return IExecute<Javax.Swing.Text.Position>("getStartPosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getProperty(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(object arg0)
        {
            return IExecute("getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getText(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public string GetText(int arg0, int arg1)
        {
            return IExecute<string>("getText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#createPosition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Position"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public Javax.Swing.Text.Position CreatePosition(int arg0)
        {
            return IExecute<Javax.Swing.Text.Position>("createPosition", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#addDocumentListener(javax.swing.event.DocumentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentListener"/></param>
        public void AddDocumentListener(Javax.Swing.Event.DocumentListener arg0)
        {
            IExecute("addDocumentListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#addUndoableEditListener(javax.swing.event.UndoableEditListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.UndoableEditListener"/></param>
        public void AddUndoableEditListener(Javax.Swing.Event.UndoableEditListener arg0)
        {
            IExecute("addUndoableEditListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getText(int,int,javax.swing.text.Segment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.Segment"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void GetText(int arg0, int arg1, Javax.Swing.Text.Segment arg2)
        {
            IExecute("getText", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#insertString(int,java.lang.String,javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void InsertString(int arg0, string arg1, Javax.Swing.Text.AttributeSet arg2)
        {
            IExecute("insertString", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#putProperty(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void PutProperty(object arg0, object arg1)
        {
            IExecute("putProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#remove(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Remove(int arg0, int arg1)
        {
            IExecute("remove", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#removeDocumentListener(javax.swing.event.DocumentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentListener"/></param>
        public void RemoveDocumentListener(Javax.Swing.Event.DocumentListener arg0)
        {
            IExecute("removeDocumentListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#removeUndoableEditListener(javax.swing.event.UndoableEditListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.UndoableEditListener"/></param>
        public void RemoveUndoableEditListener(Javax.Swing.Event.UndoableEditListener arg0)
        {
            IExecute("removeUndoableEditListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#render(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        public void Render(Java.Lang.Runnable arg0)
        {
            IExecute("render", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}