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

namespace Java.Security.Interfaces
{
    #region ECPublicKey
    public partial class ECPublicKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Security.PublicKey(Java.Security.Interfaces.ECPublicKey t) => t.Cast<Java.Security.PublicKey>();
        public static implicit operator Java.Security.Interfaces.ECKey(Java.Security.Interfaces.ECPublicKey t) => t.Cast<Java.Security.Interfaces.ECKey>();
        
        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/ECPublicKey.html#serialVersionUID
        /// </summary>
        public static long serialVersionUID => Clazz.GetField<long>("serialVersionUID");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/ECPublicKey.html#getW() 
        /// </summary>
        public Java.Security.Spec.ECPoint W
        {
            get { return IExecute<Java.Security.Spec.ECPoint>("getW"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}