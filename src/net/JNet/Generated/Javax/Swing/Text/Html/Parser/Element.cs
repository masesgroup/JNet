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

namespace Javax.Swing.Text.Html.Parser
{
    #region Element
    public partial class Element
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Swing.Text.Html.Parser.DTDConstants(Javax.Swing.Text.Html.Parser.Element t) => t.Cast<Javax.Swing.Text.Html.Parser.DTDConstants>();
        public static implicit operator Java.Io.Serializable(Javax.Swing.Text.Html.Parser.Element t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#index
        /// </summary>
        public int index => Instance.GetField<int>("index");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#name
        /// </summary>
        public string name => Instance.GetField<string>("name");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#oStart
        /// </summary>
        public bool oStart => Instance.GetField<bool>("oStart");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#oEnd
        /// </summary>
        public bool oEnd => Instance.GetField<bool>("oEnd");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#inclusions
        /// </summary>
        public Java.Util.BitSet inclusions => Instance.GetField<Java.Util.BitSet>("inclusions");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#exclusions
        /// </summary>
        public Java.Util.BitSet exclusions => Instance.GetField<Java.Util.BitSet>("exclusions");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#type
        /// </summary>
        public int type => Instance.GetField<int>("type");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#content
        /// </summary>
        public Javax.Swing.Text.Html.Parser.ContentModel content => Instance.GetField<Javax.Swing.Text.Html.Parser.ContentModel>("content");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#atts
        /// </summary>
        public Javax.Swing.Text.Html.Parser.AttributeList atts => Instance.GetField<Javax.Swing.Text.Html.Parser.AttributeList>("atts");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#data
        /// </summary>
        public object data => Instance.GetField("data");
        
        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#name2type(java.lang.String)
        /// </summary>
        public static int Name2type(string arg0)
        {
            return SExecute<int>("name2type", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#getAttributes() 
        /// </summary>
        public Javax.Swing.Text.Html.Parser.AttributeList Attributes
        {
            get { return IExecute<Javax.Swing.Text.Html.Parser.AttributeList>("getAttributes"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#getContent() 
        /// </summary>
        public Javax.Swing.Text.Html.Parser.ContentModel Content
        {
            get { return IExecute<Javax.Swing.Text.Html.Parser.ContentModel>("getContent"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#getIndex() 
        /// </summary>
        public int Index
        {
            get { return IExecute<int>("getIndex"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#getName() 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#getType() 
        /// </summary>
        public int Type
        {
            get { return IExecute<int>("getType"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#isEmpty()
        /// </summary>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#omitEnd()
        /// </summary>
        public bool OmitEnd()
        {
            return IExecute<bool>("omitEnd");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#omitStart()
        /// </summary>
        public bool OmitStart()
        {
            return IExecute<bool>("omitStart");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#getAttribute(java.lang.String)
        /// </summary>
        public Javax.Swing.Text.Html.Parser.AttributeList GetAttribute(string arg0)
        {
            return IExecute<Javax.Swing.Text.Html.Parser.AttributeList>("getAttribute", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#getAttributeByValue(java.lang.String)
        /// </summary>
        public Javax.Swing.Text.Html.Parser.AttributeList GetAttributeByValue(string arg0)
        {
            return IExecute<Javax.Swing.Text.Html.Parser.AttributeList>("getAttributeByValue", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}