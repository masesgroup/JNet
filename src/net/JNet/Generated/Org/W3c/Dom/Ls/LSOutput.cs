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

namespace Org.W3c.Dom.Ls
{
    #region ILSOutput
    public partial interface ILSOutput
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#getByteStream()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#setByteStream(java.io.OutputStream)"/>
        /// </summary>
        Java.Io.OutputStream ByteStream { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#getCharacterStream()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#setCharacterStream(java.io.Writer)"/>
        /// </summary>
        Java.Io.Writer CharacterStream { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#getEncoding()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#setEncoding(java.lang.String)"/>
        /// </summary>
        string Encoding { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#setSystemId(java.lang.String)"/>
        /// </summary>
        string SystemId { get; set; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LSOutput
    public partial class LSOutput : Org.W3c.Dom.Ls.ILSOutput
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#getByteStream()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#setByteStream(java.io.OutputStream)"/>
        /// </summary>
        public Java.Io.OutputStream ByteStream
        {
            get { return IExecute<Java.Io.OutputStream>("getByteStream"); } set { IExecute("setByteStream", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#getCharacterStream()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#setCharacterStream(java.io.Writer)"/>
        /// </summary>
        public Java.Io.Writer CharacterStream
        {
            get { return IExecute<Java.Io.Writer>("getCharacterStream"); } set { IExecute("setCharacterStream", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#getEncoding()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#setEncoding(java.lang.String)"/>
        /// </summary>
        public string Encoding
        {
            get { return IExecute<string>("getEncoding"); } set { IExecute("setEncoding", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSOutput.html#setSystemId(java.lang.String)"/>
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