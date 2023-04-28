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

namespace Javax.Xml.Transform.Stax
{
    #region StAXResult
    public partial class StAXResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXResult.html#%3Cinit%3E(javax.xml.stream.XMLEventWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLEventWriter"/></param>
        public StAXResult(Javax.Xml.Stream.XMLEventWriter arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXResult.html#%3Cinit%3E(javax.xml.stream.XMLStreamWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Stream.XMLStreamWriter"/></param>
        public StAXResult(Javax.Xml.Stream.XMLStreamWriter arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Transform.Stax.StAXResult"/> to <see cref="Javax.Xml.Transform.Result"/>
        /// </summary>
        public static implicit operator Javax.Xml.Transform.Result(Javax.Xml.Transform.Stax.StAXResult t) => t.Cast<Javax.Xml.Transform.Result>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXResult.html#FEATURE"/>
        /// </summary>
        public static string FEATURE { get { return SGetField<string>(LocalClazz, "FEATURE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXResult.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXResult.html#setSystemId(java.lang.String)"/>
        /// </summary>
        public string SystemId
        {
            get { return IExecute<string>("getSystemId"); } set { IExecute("setSystemId", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXResult.html#getXMLEventWriter()"/> 
        /// </summary>
        public Javax.Xml.Stream.XMLEventWriter XMLEventWriter
        {
            get { return IExecute<Javax.Xml.Stream.XMLEventWriter>("getXMLEventWriter"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/stax/StAXResult.html#getXMLStreamWriter()"/> 
        /// </summary>
        public Javax.Xml.Stream.XMLStreamWriter XMLStreamWriter
        {
            get { return IExecute<Javax.Xml.Stream.XMLStreamWriter>("getXMLStreamWriter"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}