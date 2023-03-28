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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Transform.Dom
{
    #region DOMResult
    public partial class DOMResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/dom/DOMResult.html#%3Cinit%3E(org.w3c.dom.Node,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public DOMResult(Org.W3c.Dom.Node arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/dom/DOMResult.html#%3Cinit%3E(org.w3c.dom.Node,org.w3c.dom.Node,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        public DOMResult(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1, string arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/dom/DOMResult.html#%3Cinit%3E(org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        public DOMResult(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/dom/DOMResult.html#%3Cinit%3E(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        public DOMResult(Org.W3c.Dom.Node arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Transform.Dom.DOMResult"/> to <see cref="Javax.Xml.Transform.Result"/>
        /// </summary>
        public static implicit operator Javax.Xml.Transform.Result(Javax.Xml.Transform.Dom.DOMResult t) => t.Cast<Javax.Xml.Transform.Result>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/dom/DOMResult.html#FEATURE"/>
        /// </summary>
        public static string FEATURE => Clazz.GetField<string>("FEATURE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/dom/DOMResult.html#getNextSibling()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/dom/DOMResult.html#setNextSibling(org.w3c.dom.Node)"/>
        /// </summary>
        public Org.W3c.Dom.Node NextSibling
        {
            get { return IExecute<Org.W3c.Dom.Node>("getNextSibling"); } set { IExecute("setNextSibling", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/dom/DOMResult.html#getNode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/dom/DOMResult.html#setNode(org.w3c.dom.Node)"/>
        /// </summary>
        public Org.W3c.Dom.Node Node
        {
            get { return IExecute<Org.W3c.Dom.Node>("getNode"); } set { IExecute("setNode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/dom/DOMResult.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/dom/DOMResult.html#setSystemId(java.lang.String)"/>
        /// </summary>
        public string SystemId
        {
            get { return IExecute<string>("getSystemId"); } set { IExecute("setSystemId", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}