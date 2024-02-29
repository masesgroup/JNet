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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print
{
    #region IURIException
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IURIException
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/URIException.html#getReason()"/> 
        /// </summary>
        int Reason { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/URIException.html#getUnsupportedURI()"/> 
        /// </summary>
        Java.Net.URI UnsupportedURI { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region URIException
    public partial class URIException : Javax.Print.IURIException
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/URIException.html#URIInaccessible"/>
        /// </summary>
        public static int URIInaccessible { get { if (!_URIInaccessibleReady) { _URIInaccessibleContent = SGetField<int>(LocalBridgeClazz, "URIInaccessible"); _URIInaccessibleReady = true; } return _URIInaccessibleContent; } }
        private static int _URIInaccessibleContent = default;
        private static bool _URIInaccessibleReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/URIException.html#URIOtherProblem"/>
        /// </summary>
        public static int URIOtherProblem { get { if (!_URIOtherProblemReady) { _URIOtherProblemContent = SGetField<int>(LocalBridgeClazz, "URIOtherProblem"); _URIOtherProblemReady = true; } return _URIOtherProblemContent; } }
        private static int _URIOtherProblemContent = default;
        private static bool _URIOtherProblemReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/URIException.html#URISchemeNotSupported"/>
        /// </summary>
        public static int URISchemeNotSupported { get { if (!_URISchemeNotSupportedReady) { _URISchemeNotSupportedContent = SGetField<int>(LocalBridgeClazz, "URISchemeNotSupported"); _URISchemeNotSupportedReady = true; } return _URISchemeNotSupportedContent; } }
        private static int _URISchemeNotSupportedContent = default;
        private static bool _URISchemeNotSupportedReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/URIException.html#getReason()"/> 
        /// </summary>
        public int Reason
        {
            get { return IExecuteWithSignature<int>("getReason", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/URIException.html#getUnsupportedURI()"/> 
        /// </summary>
        public Java.Net.URI UnsupportedURI
        {
            get { return IExecuteWithSignature<Java.Net.URI>("getUnsupportedURI", "()Ljava/net/URI;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}