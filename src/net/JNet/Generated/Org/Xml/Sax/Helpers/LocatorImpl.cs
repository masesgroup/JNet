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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Xml.Sax.Helpers
{
    #region LocatorImpl
    public partial class LocatorImpl
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/LocatorImpl.html#%3Cinit%3E(org.xml.sax.Locator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.Locator"/></param>
        public LocatorImpl(Org.Xml.Sax.Locator arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/LocatorImpl.html#getColumnNumber()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/LocatorImpl.html#setColumnNumber(int)"/>
        /// </summary>
        public int ColumnNumber
        {
            get { return IExecute<int>("getColumnNumber"); } set { IExecute("setColumnNumber", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/LocatorImpl.html#getLineNumber()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/LocatorImpl.html#setLineNumber(int)"/>
        /// </summary>
        public int LineNumber
        {
            get { return IExecute<int>("getLineNumber"); } set { IExecute("setLineNumber", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/LocatorImpl.html#getPublicId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/LocatorImpl.html#setPublicId(java.lang.String)"/>
        /// </summary>
        public string PublicId
        {
            get { return IExecute<string>("getPublicId"); } set { IExecute("setPublicId", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/LocatorImpl.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/LocatorImpl.html#setSystemId(java.lang.String)"/>
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