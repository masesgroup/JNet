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

namespace Javax.Xml.Crypto.Dsig.Spec
{
    #region ExcC14NParameterSpec
    public partial class ExcC14NParameterSpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/spec/ExcC14NParameterSpec.html#%3Cinit%3E(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public ExcC14NParameterSpec(Java.Util.List arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.Spec.ExcC14NParameterSpec"/> to <see cref="Javax.Xml.Crypto.Dsig.Spec.C14NMethodParameterSpec"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.Dsig.Spec.C14NMethodParameterSpec(Javax.Xml.Crypto.Dsig.Spec.ExcC14NParameterSpec t) => t.Cast<Javax.Xml.Crypto.Dsig.Spec.C14NMethodParameterSpec>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/spec/ExcC14NParameterSpec.html#DEFAULT"/>
        /// </summary>
        public static string DEFAULT => Clazz.GetField<string>("DEFAULT");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/spec/ExcC14NParameterSpec.html#getPrefixList()"/> 
        /// </summary>
        public Java.Util.List<string> PrefixList
        {
            get { return IExecute<Java.Util.List<string>>("getPrefixList"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}