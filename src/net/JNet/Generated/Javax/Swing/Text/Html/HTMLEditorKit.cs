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

namespace Javax.Swing.Text.Html
{
    #region HTMLEditorKit
    public partial class HTMLEditorKit
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.Html.HTMLEditorKit"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.Text.Html.HTMLEditorKit t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#BOLD_ACTION"/>
        /// </summary>
        public static string BOLD_ACTION => Clazz.GetField<string>("BOLD_ACTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#COLOR_ACTION"/>
        /// </summary>
        public static string COLOR_ACTION => Clazz.GetField<string>("COLOR_ACTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#DEFAULT_CSS"/>
        /// </summary>
        public static string DEFAULT_CSS => Clazz.GetField<string>("DEFAULT_CSS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#FONT_CHANGE_BIGGER"/>
        /// </summary>
        public static string FONT_CHANGE_BIGGER => Clazz.GetField<string>("FONT_CHANGE_BIGGER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#FONT_CHANGE_SMALLER"/>
        /// </summary>
        public static string FONT_CHANGE_SMALLER => Clazz.GetField<string>("FONT_CHANGE_SMALLER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#IMG_ALIGN_BOTTOM"/>
        /// </summary>
        public static string IMG_ALIGN_BOTTOM => Clazz.GetField<string>("IMG_ALIGN_BOTTOM");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#IMG_ALIGN_MIDDLE"/>
        /// </summary>
        public static string IMG_ALIGN_MIDDLE => Clazz.GetField<string>("IMG_ALIGN_MIDDLE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#IMG_ALIGN_TOP"/>
        /// </summary>
        public static string IMG_ALIGN_TOP => Clazz.GetField<string>("IMG_ALIGN_TOP");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#IMG_BORDER"/>
        /// </summary>
        public static string IMG_BORDER => Clazz.GetField<string>("IMG_BORDER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#ITALIC_ACTION"/>
        /// </summary>
        public static string ITALIC_ACTION => Clazz.GetField<string>("ITALIC_ACTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#LOGICAL_STYLE_ACTION"/>
        /// </summary>
        public static string LOGICAL_STYLE_ACTION => Clazz.GetField<string>("LOGICAL_STYLE_ACTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#PARA_INDENT_LEFT"/>
        /// </summary>
        public static string PARA_INDENT_LEFT => Clazz.GetField<string>("PARA_INDENT_LEFT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#PARA_INDENT_RIGHT"/>
        /// </summary>
        public static string PARA_INDENT_RIGHT => Clazz.GetField<string>("PARA_INDENT_RIGHT");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#getAccessibleContext()"/> 
        /// </summary>
        public Javax.Accessibility.AccessibleContext AccessibleContext
        {
            get { return IExecute<Javax.Accessibility.AccessibleContext>("getAccessibleContext"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#getDefaultCursor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#setDefaultCursor(java.awt.Cursor)"/>
        /// </summary>
        public Java.Awt.Cursor DefaultCursor
        {
            get { return IExecute<Java.Awt.Cursor>("getDefaultCursor"); } set { IExecute("setDefaultCursor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#getLinkCursor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#setLinkCursor(java.awt.Cursor)"/>
        /// </summary>
        public Java.Awt.Cursor LinkCursor
        {
            get { return IExecute<Java.Awt.Cursor>("getLinkCursor"); } set { IExecute("setLinkCursor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#getStyleSheet()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#setStyleSheet(javax.swing.text.html.StyleSheet)"/>
        /// </summary>
        public Javax.Swing.Text.Html.StyleSheet StyleSheet
        {
            get { return IExecute<Javax.Swing.Text.Html.StyleSheet>("getStyleSheet"); } set { IExecute("setStyleSheet", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#isAutoFormSubmission()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsAutoFormSubmission()
        {
            return IExecute<bool>("isAutoFormSubmission");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#insertHTML(javax.swing.text.html.HTMLDocument,int,java.lang.String,int,int,javax.swing.text.html.HTML$Tag)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see langword="string"/></param>
        /// <param name="arg3"><see langword="int"/></param>
        /// <param name="arg4"><see langword="int"/></param>
        /// <param name="arg5"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void InsertHTML(Javax.Swing.Text.Html.HTMLDocument arg0, int arg1, string arg2, int arg3, int arg4, Javax.Swing.Text.Html.HTML.Tag arg5)
        {
            IExecute("insertHTML", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#setAutoFormSubmission(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see langword="bool"/></param>
        public void SetAutoFormSubmission(bool arg0)
        {
            IExecute("setAutoFormSubmission", arg0);
        }
        
        #endregion

        #region Nested classes
        #region HTMLFactory
        public partial class HTMLFactory
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Text.Html.HTMLEditorKit.HTMLFactory"/> to <see cref="Javax.Swing.Text.ViewFactory"/>
            /// </summary>
            public static implicit operator Javax.Swing.Text.ViewFactory(Javax.Swing.Text.Html.HTMLEditorKit.HTMLFactory t) => t.Cast<Javax.Swing.Text.ViewFactory>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.HTMLFactory.html#create(javax.swing.text.Element)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
            /// <returns><see cref="Javax.Swing.Text.View"/></returns>
            public Javax.Swing.Text.View Create(Javax.Swing.Text.Element arg0)
            {
                return IExecute<Javax.Swing.Text.View>("create", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region HTMLTextAction
        public partial class HTMLTextAction
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.HTMLTextAction.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see langword="string"/></param>
            public HTMLTextAction(string arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region InsertHTMLTextAction
        public partial class InsertHTMLTextAction
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.InsertHTMLTextAction.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.swing.text.html.HTML$Tag,javax.swing.text.html.HTML$Tag,javax.swing.text.html.HTML$Tag,javax.swing.text.html.HTML$Tag)"/>
            /// </summary>
            /// <param name="arg0"><see langword="string"/></param>
            /// <param name="arg1"><see langword="string"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            /// <param name="arg3"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            /// <param name="arg4"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            /// <param name="arg5"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            public InsertHTMLTextAction(string arg0, string arg1, Javax.Swing.Text.Html.HTML.Tag arg2, Javax.Swing.Text.Html.HTML.Tag arg3, Javax.Swing.Text.Html.HTML.Tag arg4, Javax.Swing.Text.Html.HTML.Tag arg5)
                : base(arg0, arg1, arg2, arg3, arg4, arg5)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.InsertHTMLTextAction.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.swing.text.html.HTML$Tag,javax.swing.text.html.HTML$Tag)"/>
            /// </summary>
            /// <param name="arg0"><see langword="string"/></param>
            /// <param name="arg1"><see langword="string"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            /// <param name="arg3"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            public InsertHTMLTextAction(string arg0, string arg1, Javax.Swing.Text.Html.HTML.Tag arg2, Javax.Swing.Text.Html.HTML.Tag arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Parser
        public partial class Parser
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.Parser.html#parse(java.io.Reader,javax.swing.text.html.HTMLEditorKit$ParserCallback,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.Html.HTMLEditorKit.ParserCallback"/></param>
            /// <param name="arg2"><see langword="bool"/></param>
            /// <exception cref="Java.Io.IOException"/>
            public void Parse(Java.Io.Reader arg0, Javax.Swing.Text.Html.HTMLEditorKit.ParserCallback arg1, bool arg2)
            {
                IExecute("parse", arg0, arg1, arg2);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ParserCallback
        public partial class ParserCallback
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#IMPLIED"/>
            /// </summary>
            public static object IMPLIED => Clazz.GetField("IMPLIED");
            
            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#flush()"/>
            /// </summary>
            
            /// <exception cref="Javax.Swing.Text.BadLocationException"/>
            public void Flush()
            {
                IExecute("flush");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#handleComment(char[],int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="char"/></param>
            /// <param name="arg1"><see langword="int"/></param>
            public void HandleComment(char[] arg0, int arg1)
            {
                IExecute("handleComment", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#handleEndOfLineString(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see langword="string"/></param>
            public void HandleEndOfLineString(string arg0)
            {
                IExecute("handleEndOfLineString", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#handleEndTag(javax.swing.text.html.HTML$Tag,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            /// <param name="arg1"><see langword="int"/></param>
            public void HandleEndTag(Javax.Swing.Text.Html.HTML.Tag arg0, int arg1)
            {
                IExecute("handleEndTag", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#handleError(java.lang.String,int)"/>
            /// </summary>
            /// <param name="arg0"><see langword="string"/></param>
            /// <param name="arg1"><see langword="int"/></param>
            public void HandleError(string arg0, int arg1)
            {
                IExecute("handleError", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#handleSimpleTag(javax.swing.text.html.HTML$Tag,javax.swing.text.MutableAttributeSet,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.MutableAttributeSet"/></param>
            /// <param name="arg2"><see langword="int"/></param>
            public void HandleSimpleTag(Javax.Swing.Text.Html.HTML.Tag arg0, Javax.Swing.Text.MutableAttributeSet arg1, int arg2)
            {
                IExecute("handleSimpleTag", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#handleStartTag(javax.swing.text.html.HTML$Tag,javax.swing.text.MutableAttributeSet,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.MutableAttributeSet"/></param>
            /// <param name="arg2"><see langword="int"/></param>
            public void HandleStartTag(Javax.Swing.Text.Html.HTML.Tag arg0, Javax.Swing.Text.MutableAttributeSet arg1, int arg2)
            {
                IExecute("handleStartTag", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#handleText(char[],int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="char"/></param>
            /// <param name="arg1"><see langword="int"/></param>
            public void HandleText(char[] arg0, int arg1)
            {
                IExecute("handleText", arg0, arg1);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}