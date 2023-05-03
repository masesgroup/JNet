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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text.Html.Parser
{
    #region DTD
    public partial class DTD
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.Html.Parser.DTD"/> to <see cref="Javax.Swing.Text.Html.Parser.DTDConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.Text.Html.Parser.DTDConstants(Javax.Swing.Text.Html.Parser.DTD t) => t.Cast<Javax.Swing.Text.Html.Parser.DTDConstants>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#applet"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element applet { get { return IGetField<Javax.Swing.Text.Html.Parser.Element>("applet"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#base"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element baseField { get { return IGetField<Javax.Swing.Text.Html.Parser.Element>("base"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#body"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element body { get { return IGetField<Javax.Swing.Text.Html.Parser.Element>("body"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#head"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element head { get { return IGetField<Javax.Swing.Text.Html.Parser.Element>("head"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#html"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element html { get { return IGetField<Javax.Swing.Text.Html.Parser.Element>("html"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#isindex"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element isindex { get { return IGetField<Javax.Swing.Text.Html.Parser.Element>("isindex"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#meta"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element meta { get { return IGetField<Javax.Swing.Text.Html.Parser.Element>("meta"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#p"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element p { get { return IGetField<Javax.Swing.Text.Html.Parser.Element>("p"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#param"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element param { get { return IGetField<Javax.Swing.Text.Html.Parser.Element>("param"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#pcdata"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element pcdata { get { return IGetField<Javax.Swing.Text.Html.Parser.Element>("pcdata"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#title"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.Element title { get { return IGetField<Javax.Swing.Text.Html.Parser.Element>("title"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#name"/>
        /// </summary>
        public string name { get { return IGetField<string>("name"); } set { ISetField("name", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#entityHash"/>
        /// </summary>
        public Java.Util.Hashtable entityHash { get { return IGetField<Java.Util.Hashtable>("entityHash"); } set { ISetField("entityHash", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#elementHash"/>
        /// </summary>
        public Java.Util.Hashtable elementHash { get { return IGetField<Java.Util.Hashtable>("elementHash"); } set { ISetField("elementHash", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#elements"/>
        /// </summary>
        public Java.Util.Vector elements { get { return IGetField<Java.Util.Vector>("elements"); } set { ISetField("elements", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#FILE_VERSION"/>
        /// </summary>
        public static int FILE_VERSION { get { return SGetField<int>(LocalBridgeClazz, "FILE_VERSION"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#getDTD(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.DTD"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Swing.Text.Html.Parser.DTD GetDTD(string arg0)
        {
            return SExecute<Javax.Swing.Text.Html.Parser.DTD>(LocalBridgeClazz, "getDTD", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#putDTDHash(java.lang.String,javax.swing.text.html.parser.DTD)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Html.Parser.DTD"/></param>
        public static void PutDTDHash(string arg0, Javax.Swing.Text.Html.Parser.DTD arg1)
        {
            SExecute(LocalBridgeClazz, "putDTDHash", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#defineElement(java.lang.String,int,boolean,boolean,javax.swing.text.html.parser.ContentModel,java.util.BitSet,java.util.BitSet,javax.swing.text.html.parser.AttributeList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Text.Html.Parser.ContentModel"/></param>
        /// <param name="arg5"><see cref="Java.Util.BitSet"/></param>
        /// <param name="arg6"><see cref="Java.Util.BitSet"/></param>
        /// <param name="arg7"><see cref="Javax.Swing.Text.Html.Parser.AttributeList"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.Element"/></returns>
        public Javax.Swing.Text.Html.Parser.Element DefineElement(string arg0, int arg1, bool arg2, bool arg3, Javax.Swing.Text.Html.Parser.ContentModel arg4, Java.Util.BitSet arg5, Java.Util.BitSet arg6, Javax.Swing.Text.Html.Parser.AttributeList arg7)
        {
            return IExecute<Javax.Swing.Text.Html.Parser.Element>("defineElement", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#getElement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.Element"/></returns>
        public Javax.Swing.Text.Html.Parser.Element GetElement(int arg0)
        {
            return IExecute<Javax.Swing.Text.Html.Parser.Element>("getElement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#getElement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.Element"/></returns>
        public Javax.Swing.Text.Html.Parser.Element GetElement(string arg0)
        {
            return IExecute<Javax.Swing.Text.Html.Parser.Element>("getElement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#defEntity(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.Entity"/></returns>
        public Javax.Swing.Text.Html.Parser.Entity DefEntity(string arg0, int arg1, int arg2)
        {
            return IExecute<Javax.Swing.Text.Html.Parser.Entity>("defEntity", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#defineEntity(java.lang.String,int,char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="char"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.Entity"/></returns>
        public Javax.Swing.Text.Html.Parser.Entity DefineEntity(string arg0, int arg1, char[] arg2)
        {
            return IExecute<Javax.Swing.Text.Html.Parser.Entity>("defineEntity", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#getEntity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.Entity"/></returns>
        public Javax.Swing.Text.Html.Parser.Entity GetEntity(int arg0)
        {
            return IExecute<Javax.Swing.Text.Html.Parser.Entity>("getEntity", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#getEntity(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.Entity"/></returns>
        public Javax.Swing.Text.Html.Parser.Entity GetEntity(string arg0)
        {
            return IExecute<Javax.Swing.Text.Html.Parser.Entity>("getEntity", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#defineAttributes(java.lang.String,javax.swing.text.html.parser.AttributeList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Html.Parser.AttributeList"/></param>
        public void DefineAttributes(string arg0, Javax.Swing.Text.Html.Parser.AttributeList arg1)
        {
            IExecute("defineAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/DTD.html#read(java.io.DataInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.DataInputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Read(Java.Io.DataInputStream arg0)
        {
            IExecute("read", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}