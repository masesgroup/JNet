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

namespace Org.Xml.Sax.Helpers
{
    #region AttributesImpl
    public partial class AttributesImpl
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#<init>(org.xml.sax.Attributes)
        /// </summary>
        public AttributesImpl(Org.Xml.Sax.Attributes arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Org.Xml.Sax.Attributes(Org.Xml.Sax.Helpers.AttributesImpl t) => t.Cast<Org.Xml.Sax.Attributes>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#getLength() 
        /// </summary>
        public int Length
        {
            get { return IExecute<int>("getLength"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#getIndex(java.lang.String,java.lang.String)
        /// </summary>
        public int GetIndex(string arg0, string arg1)
        {
            return IExecute<int>("getIndex", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#getIndex(java.lang.String)
        /// </summary>
        public int GetIndex(string arg0)
        {
            return IExecute<int>("getIndex", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#getLocalName(int)
        /// </summary>
        public string GetLocalName(int arg0)
        {
            return IExecute<string>("getLocalName", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#getQName(int)
        /// </summary>
        public string GetQName(int arg0)
        {
            return IExecute<string>("getQName", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#getType(int)
        /// </summary>
        public string GetType(int arg0)
        {
            return IExecute<string>("getType", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#getType(java.lang.String,java.lang.String)
        /// </summary>
        public string GetType(string arg0, string arg1)
        {
            return IExecute<string>("getType", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#getType(java.lang.String)
        /// </summary>
        public string GetType(string arg0)
        {
            return IExecute<string>("getType", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#getURI(int)
        /// </summary>
        public string GetURI(int arg0)
        {
            return IExecute<string>("getURI", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#getValue(int)
        /// </summary>
        public string GetValue(int arg0)
        {
            return IExecute<string>("getValue", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#getValue(java.lang.String,java.lang.String)
        /// </summary>
        public string GetValue(string arg0, string arg1)
        {
            return IExecute<string>("getValue", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#getValue(java.lang.String)
        /// </summary>
        public string GetValue(string arg0)
        {
            return IExecute<string>("getValue", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#addAttribute(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String)
        /// </summary>
        public void AddAttribute(string arg0, string arg1, string arg2, string arg3, string arg4)
        {
            IExecute("addAttribute", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#clear()
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#removeAttribute(int)
        /// </summary>
        public void RemoveAttribute(int arg0)
        {
            IExecute("removeAttribute", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#setAttribute(int,java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String)
        /// </summary>
        public void SetAttribute(int arg0, string arg1, string arg2, string arg3, string arg4, string arg5)
        {
            IExecute("setAttribute", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#setAttributes(org.xml.sax.Attributes)
        /// </summary>
        public void SetAttributes(Org.Xml.Sax.Attributes arg0)
        {
            IExecute("setAttributes", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#setLocalName(int,java.lang.String)
        /// </summary>
        public void SetLocalName(int arg0, string arg1)
        {
            IExecute("setLocalName", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#setQName(int,java.lang.String)
        /// </summary>
        public void SetQName(int arg0, string arg1)
        {
            IExecute("setQName", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#setType(int,java.lang.String)
        /// </summary>
        public void SetType(int arg0, string arg1)
        {
            IExecute("setType", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#setURI(int,java.lang.String)
        /// </summary>
        public void SetURI(int arg0, string arg1)
        {
            IExecute("setURI", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/AttributesImpl.html#setValue(int,java.lang.String)
        /// </summary>
        public void SetValue(int arg0, string arg1)
        {
            IExecute("setValue", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}