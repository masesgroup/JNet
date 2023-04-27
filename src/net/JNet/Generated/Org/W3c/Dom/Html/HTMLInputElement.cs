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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Html
{
    #region HTMLInputElement
    public partial class HTMLInputElement
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getAccept()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setAccept(java.lang.String)"/>
        /// </summary>
        public string Accept
        {
            get { return IExecute<string>("getAccept"); } set { IExecute("setAccept", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getAccessKey()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setAccessKey(java.lang.String)"/>
        /// </summary>
        public string AccessKey
        {
            get { return IExecute<string>("getAccessKey"); } set { IExecute("setAccessKey", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getAlign()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setAlign(java.lang.String)"/>
        /// </summary>
        public string Align
        {
            get { return IExecute<string>("getAlign"); } set { IExecute("setAlign", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getAlt()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setAlt(java.lang.String)"/>
        /// </summary>
        public string Alt
        {
            get { return IExecute<string>("getAlt"); } set { IExecute("setAlt", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getChecked()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setChecked(boolean)"/>
        /// </summary>
        public bool Checked
        {
            get { return IExecute<bool>("getChecked"); } set { IExecute("setChecked", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getDefaultChecked()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setDefaultChecked(boolean)"/>
        /// </summary>
        public bool DefaultChecked
        {
            get { return IExecute<bool>("getDefaultChecked"); } set { IExecute("setDefaultChecked", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getDefaultValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setDefaultValue(java.lang.String)"/>
        /// </summary>
        public string DefaultValue
        {
            get { return IExecute<string>("getDefaultValue"); } set { IExecute("setDefaultValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getDisabled()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setDisabled(boolean)"/>
        /// </summary>
        public bool Disabled
        {
            get { return IExecute<bool>("getDisabled"); } set { IExecute("setDisabled", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getForm()"/> 
        /// </summary>
        public Org.W3c.Dom.Html.HTMLFormElement Form
        {
            get { return IExecute<Org.W3c.Dom.Html.HTMLFormElement>("getForm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getMaxLength()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setMaxLength(int)"/>
        /// </summary>
        public int MaxLength
        {
            get { return IExecute<int>("getMaxLength"); } set { IExecute("setMaxLength", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setName(java.lang.String)"/>
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); } set { IExecute("setName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getReadOnly()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setReadOnly(boolean)"/>
        /// </summary>
        public bool ReadOnly
        {
            get { return IExecute<bool>("getReadOnly"); } set { IExecute("setReadOnly", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setSize(java.lang.String)"/>
        /// </summary>
        public string Size
        {
            get { return IExecute<string>("getSize"); } set { IExecute("setSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getSrc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setSrc(java.lang.String)"/>
        /// </summary>
        public string Src
        {
            get { return IExecute<string>("getSrc"); } set { IExecute("setSrc", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getTabIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setTabIndex(int)"/>
        /// </summary>
        public int TabIndex
        {
            get { return IExecute<int>("getTabIndex"); } set { IExecute("setTabIndex", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getType()"/> 
        /// </summary>
        public string Type
        {
            get { return IExecute<string>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getUseMap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setUseMap(java.lang.String)"/>
        /// </summary>
        public string UseMap
        {
            get { return IExecute<string>("getUseMap"); } set { IExecute("setUseMap", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#setValue(java.lang.String)"/>
        /// </summary>
        public string Value
        {
            get { return IExecute<string>("getValue"); } set { IExecute("setValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#blur()"/>
        /// </summary>
        public void Blur()
        {
            IExecute("blur");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#click()"/>
        /// </summary>
        public void Click()
        {
            IExecute("click");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#focus()"/>
        /// </summary>
        public void Focus()
        {
            IExecute("focus");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/html/HTMLInputElement.html#select()"/>
        /// </summary>
        public void Select()
        {
            IExecute("select");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}