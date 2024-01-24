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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text.Html.Parser
{
    #region AttributeList
    public partial class AttributeList
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#%3Cinit%3E(java.lang.String,int,int,java.lang.String,java.util.Vector,javax.swing.text.html.parser.AttributeList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="Java.Util.Vector"/></param>
        /// <param name="arg5"><see cref="Javax.Swing.Text.Html.Parser.AttributeList"/></param>
        public AttributeList(string arg0, int arg1, int arg2, string arg3, Java.Util.Vector<object> arg4, Javax.Swing.Text.Html.Parser.AttributeList arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public AttributeList(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.Html.Parser.AttributeList"/> to <see cref="Javax.Swing.Text.Html.Parser.DTDConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.Text.Html.Parser.DTDConstants(Javax.Swing.Text.Html.Parser.AttributeList t) => t.Cast<Javax.Swing.Text.Html.Parser.DTDConstants>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.Html.Parser.AttributeList"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Text.Html.Parser.AttributeList t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#modifier"/>
        /// </summary>
        public int modifier { get { return IGetField<int>("modifier"); } set { ISetField("modifier", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#type"/>
        /// </summary>
        public int type { get { return IGetField<int>("type"); } set { ISetField("type", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#name"/>
        /// </summary>
        public string name { get { return IGetField<string>("name"); } set { ISetField("name", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#value"/>
        /// </summary>
        public string value { get { return IGetField<string>("value"); } set { ISetField("value", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#values"/>
        /// </summary>
        public Java.Util.Vector values { get { return IGetField<Java.Util.Vector>("values"); } set { ISetField("values", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#next"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.AttributeList next { get { return IGetField<Javax.Swing.Text.Html.Parser.AttributeList>("next"); } set { ISetField("next", value); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#name2type(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Name2type(string arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "name2type", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#type2name(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string Type2name(int arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "type2name", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#getModifier()"/> 
        /// </summary>
        public int Modifier
        {
            get { return IExecute<int>("getModifier"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#getNext()"/> 
        /// </summary>
        public Javax.Swing.Text.Html.Parser.AttributeList Next
        {
            get { return IExecute<Javax.Swing.Text.Html.Parser.AttributeList>("getNext"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecute<int>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#getValue()"/> 
        /// </summary>
        public string Value
        {
            get { return IExecute<string>("getValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/AttributeList.html#getValues()"/> 
        /// </summary>
        public Java.Util.Enumeration<object> Values
        {
            get { return IExecute<Java.Util.Enumeration<object>>("getValues"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}