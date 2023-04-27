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

namespace Javax.Print
{
    #region URIException
    public partial class URIException
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/URIException.html#URIInaccessible"/>
        /// </summary>
        public static int URIInaccessible { get { return LocalClazz.GetField<int>("URIInaccessible"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/URIException.html#URIOtherProblem"/>
        /// </summary>
        public static int URIOtherProblem { get { return LocalClazz.GetField<int>("URIOtherProblem"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/URIException.html#URISchemeNotSupported"/>
        /// </summary>
        public static int URISchemeNotSupported { get { return LocalClazz.GetField<int>("URISchemeNotSupported"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/URIException.html#getReason()"/> 
        /// </summary>
        public int Reason
        {
            get { return IExecute<int>("getReason"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/URIException.html#getUnsupportedURI()"/> 
        /// </summary>
        public Java.Net.URI UnsupportedURI
        {
            get { return IExecute<Java.Net.URI>("getUnsupportedURI"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}