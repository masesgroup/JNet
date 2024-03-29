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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Ls
{
    #region ILSParser
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILSParser
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getAsync()"/> 
        /// </summary>
        bool Async { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getBusy()"/> 
        /// </summary>
        bool Busy { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getDomConfig()"/> 
        /// </summary>
        Org.W3c.Dom.DOMConfiguration DomConfig { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#setFilter(org.w3c.dom.ls.LSParserFilter)"/>
        /// </summary>
        Org.W3c.Dom.Ls.LSParserFilter Filter { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#parse(org.w3c.dom.ls.LSInput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Ls.LSInput"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        Org.W3c.Dom.Document Parse(Org.W3c.Dom.Ls.LSInput arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#parseURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        Org.W3c.Dom.Document ParseURI(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#parseWithContext(org.w3c.dom.ls.LSInput,org.w3c.dom.Node,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Ls.LSInput"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        Org.W3c.Dom.Node ParseWithContext(Org.W3c.Dom.Ls.LSInput arg0, Org.W3c.Dom.Node arg1, short arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#abort()"/>
        /// </summary>
        void Abort();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LSParser
    public partial class LSParser : Org.W3c.Dom.Ls.ILSParser
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#ACTION_APPEND_AS_CHILDREN"/>
        /// </summary>
        public static short ACTION_APPEND_AS_CHILDREN { get { if (!_ACTION_APPEND_AS_CHILDRENReady) { _ACTION_APPEND_AS_CHILDRENContent = SGetField<short>(LocalBridgeClazz, "ACTION_APPEND_AS_CHILDREN"); _ACTION_APPEND_AS_CHILDRENReady = true; } return _ACTION_APPEND_AS_CHILDRENContent; } }
        private static short _ACTION_APPEND_AS_CHILDRENContent = default;
        private static bool _ACTION_APPEND_AS_CHILDRENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#ACTION_INSERT_AFTER"/>
        /// </summary>
        public static short ACTION_INSERT_AFTER { get { if (!_ACTION_INSERT_AFTERReady) { _ACTION_INSERT_AFTERContent = SGetField<short>(LocalBridgeClazz, "ACTION_INSERT_AFTER"); _ACTION_INSERT_AFTERReady = true; } return _ACTION_INSERT_AFTERContent; } }
        private static short _ACTION_INSERT_AFTERContent = default;
        private static bool _ACTION_INSERT_AFTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#ACTION_INSERT_BEFORE"/>
        /// </summary>
        public static short ACTION_INSERT_BEFORE { get { if (!_ACTION_INSERT_BEFOREReady) { _ACTION_INSERT_BEFOREContent = SGetField<short>(LocalBridgeClazz, "ACTION_INSERT_BEFORE"); _ACTION_INSERT_BEFOREReady = true; } return _ACTION_INSERT_BEFOREContent; } }
        private static short _ACTION_INSERT_BEFOREContent = default;
        private static bool _ACTION_INSERT_BEFOREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#ACTION_REPLACE"/>
        /// </summary>
        public static short ACTION_REPLACE { get { if (!_ACTION_REPLACEReady) { _ACTION_REPLACEContent = SGetField<short>(LocalBridgeClazz, "ACTION_REPLACE"); _ACTION_REPLACEReady = true; } return _ACTION_REPLACEContent; } }
        private static short _ACTION_REPLACEContent = default;
        private static bool _ACTION_REPLACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#ACTION_REPLACE_CHILDREN"/>
        /// </summary>
        public static short ACTION_REPLACE_CHILDREN { get { if (!_ACTION_REPLACE_CHILDRENReady) { _ACTION_REPLACE_CHILDRENContent = SGetField<short>(LocalBridgeClazz, "ACTION_REPLACE_CHILDREN"); _ACTION_REPLACE_CHILDRENReady = true; } return _ACTION_REPLACE_CHILDRENContent; } }
        private static short _ACTION_REPLACE_CHILDRENContent = default;
        private static bool _ACTION_REPLACE_CHILDRENReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getAsync()"/> 
        /// </summary>
        public bool Async
        {
            get { return IExecuteWithSignature<bool>("getAsync", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getBusy()"/> 
        /// </summary>
        public bool Busy
        {
            get { return IExecuteWithSignature<bool>("getBusy", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getDomConfig()"/> 
        /// </summary>
        public Org.W3c.Dom.DOMConfiguration DomConfig
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.DOMConfiguration>("getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#getFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#setFilter(org.w3c.dom.ls.LSParserFilter)"/>
        /// </summary>
        public Org.W3c.Dom.Ls.LSParserFilter Filter
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Ls.LSParserFilter>("getFilter", "()Lorg/w3c/dom/ls/LSParserFilter;"); } set { IExecuteWithSignature("setFilter", "(Lorg/w3c/dom/ls/LSParserFilter;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#parse(org.w3c.dom.ls.LSInput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Ls.LSInput"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        public Org.W3c.Dom.Document Parse(Org.W3c.Dom.Ls.LSInput arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Document>("parse", "(Lorg/w3c/dom/ls/LSInput;)Lorg/w3c/dom/Document;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#parseURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        public Org.W3c.Dom.Document ParseURI(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Document>("parseURI", "(Ljava/lang/String;)Lorg/w3c/dom/Document;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#parseWithContext(org.w3c.dom.ls.LSInput,org.w3c.dom.Node,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Ls.LSInput"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        public Org.W3c.Dom.Node ParseWithContext(Org.W3c.Dom.Ls.LSInput arg0, Org.W3c.Dom.Node arg1, short arg2)
        {
            return IExecute<Org.W3c.Dom.Node>("parseWithContext", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSParser.html#abort()"/>
        /// </summary>
        public void Abort()
        {
            IExecuteWithSignature("abort", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}