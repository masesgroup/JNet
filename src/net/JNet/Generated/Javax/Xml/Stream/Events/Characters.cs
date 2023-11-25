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

namespace Javax.Xml.Stream.Events
{
    #region ICharacters
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICharacters : Javax.Xml.Stream.Events.IXMLEvent
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Characters.html#getData()"/> 
        /// </summary>
        string Data { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Characters.html#isCData()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsCData();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Characters.html#isIgnorableWhiteSpace()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsIgnorableWhiteSpace();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Characters.html#isWhiteSpace()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsWhiteSpace();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Characters
    public partial class Characters : Javax.Xml.Stream.Events.ICharacters
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Characters.html#getData()"/> 
        /// </summary>
        public string Data
        {
            get { return IExecute<string>("getData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Characters.html#isCData()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCData()
        {
            return IExecute<bool>("isCData");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Characters.html#isIgnorableWhiteSpace()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsIgnorableWhiteSpace()
        {
            return IExecute<bool>("isIgnorableWhiteSpace");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/stream/events/Characters.html#isWhiteSpace()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsWhiteSpace()
        {
            return IExecute<bool>("isWhiteSpace");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}