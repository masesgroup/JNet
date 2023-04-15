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

namespace Javax.Xml.Crypto
{
    #region KeySelector
    public partial class KeySelector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/KeySelector.html#singletonKeySelector(java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.KeySelector"/></returns>
        public static Javax.Xml.Crypto.KeySelector SingletonKeySelectorMethod(Java.Security.Key arg0)
        {
            return SExecute<Javax.Xml.Crypto.KeySelector>(LocalClazz, "singletonKeySelector", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/KeySelector.html#select(javax.xml.crypto.dsig.keyinfo.KeyInfo,javax.xml.crypto.KeySelector.Purpose,javax.xml.crypto.AlgorithmMethod,javax.xml.crypto.XMLCryptoContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.KeySelector.Purpose"/></param>
        /// <param name="arg2"><see cref="Javax.Xml.Crypto.AlgorithmMethod"/></param>
        /// <param name="arg3"><see cref="Javax.Xml.Crypto.XMLCryptoContext"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.KeySelectorResult"/></returns>
        /// <exception cref="Javax.Xml.Crypto.KeySelectorException"/>
        public Javax.Xml.Crypto.KeySelectorResult Select(Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo arg0, Javax.Xml.Crypto.KeySelector.Purpose arg1, Javax.Xml.Crypto.AlgorithmMethod arg2, Javax.Xml.Crypto.XMLCryptoContext arg3)
        {
            return IExecute<Javax.Xml.Crypto.KeySelectorResult>("select", arg0, arg1, arg2, arg3);
        }
        
        #endregion

        #region Nested classes
        #region Purpose
        public partial class Purpose
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/KeySelector.Purpose.html#DECRYPT"/>
            /// </summary>
            public static Javax.Xml.Crypto.KeySelector.Purpose DECRYPT => Clazz.GetField<Javax.Xml.Crypto.KeySelector.Purpose>("DECRYPT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/KeySelector.Purpose.html#ENCRYPT"/>
            /// </summary>
            public static Javax.Xml.Crypto.KeySelector.Purpose ENCRYPT => Clazz.GetField<Javax.Xml.Crypto.KeySelector.Purpose>("ENCRYPT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/KeySelector.Purpose.html#SIGN"/>
            /// </summary>
            public static Javax.Xml.Crypto.KeySelector.Purpose SIGN => Clazz.GetField<Javax.Xml.Crypto.KeySelector.Purpose>("SIGN");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/KeySelector.Purpose.html#VERIFY"/>
            /// </summary>
            public static Javax.Xml.Crypto.KeySelector.Purpose VERIFY => Clazz.GetField<Javax.Xml.Crypto.KeySelector.Purpose>("VERIFY");
            
            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}