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

namespace Javax.Xml.Transform.Sax
{
    #region SAXSource
    public partial class SAXSource
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#%3Cinit%3E(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        public SAXSource(Org.Xml.Sax.InputSource arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#%3Cinit%3E(org.xml.sax.XMLReader,org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.XMLReader"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        public SAXSource(Org.Xml.Sax.XMLReader arg0, Org.Xml.Sax.InputSource arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Transform.Sax.SAXSource"/> to <see cref="Javax.Xml.Transform.Source"/>
        /// </summary>
        public static implicit operator Javax.Xml.Transform.Source(Javax.Xml.Transform.Sax.SAXSource t) => t.Cast<Javax.Xml.Transform.Source>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#FEATURE"/>
        /// </summary>
        public static string FEATURE { get { return LocalClazz.GetField<string>("FEATURE"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#sourceToInputSource(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Org.Xml.Sax.InputSource"/></returns>
        public static Org.Xml.Sax.InputSource SourceToInputSource(Javax.Xml.Transform.Source arg0)
        {
            return SExecute<Org.Xml.Sax.InputSource>(LocalClazz, "sourceToInputSource", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#getInputSource()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#setInputSource(org.xml.sax.InputSource)"/>
        /// </summary>
        public Org.Xml.Sax.InputSource InputSource
        {
            get { return IExecute<Org.Xml.Sax.InputSource>("getInputSource"); } set { IExecute("setInputSource", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#setSystemId(java.lang.String)"/>
        /// </summary>
        public string SystemId
        {
            get { return IExecute<string>("getSystemId"); } set { IExecute("setSystemId", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#getXMLReader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/sax/SAXSource.html#setXMLReader(org.xml.sax.XMLReader)"/>
        /// </summary>
        public Org.Xml.Sax.XMLReader XMLReader
        {
            get { return IExecute<Org.Xml.Sax.XMLReader>("getXMLReader"); } set { IExecute("setXMLReader", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}