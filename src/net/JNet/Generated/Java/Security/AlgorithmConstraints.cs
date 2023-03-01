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

namespace Java.Security
{
    #region AlgorithmConstraints
    public partial class AlgorithmConstraints
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmConstraints.html#permits(java.util.Set%3Cjava.security.CryptoPrimitive%3E,java.lang.String,java.security.AlgorithmParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Security.AlgorithmParameters"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Permits(Java.Util.Set arg0, string arg1, Java.Security.AlgorithmParameters arg2)
        {
            return IExecute<bool>("permits", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmConstraints.html#permits(java.util.Set%3Cjava.security.CryptoPrimitive%3E,java.lang.String,java.security.Key,java.security.AlgorithmParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Security.Key"/></param>
        /// <param name="arg3"><see cref="Java.Security.AlgorithmParameters"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Permits(Java.Util.Set arg0, string arg1, Java.Security.Key arg2, Java.Security.AlgorithmParameters arg3)
        {
            return IExecute<bool>("permits", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/AlgorithmConstraints.html#permits(java.util.Set%3Cjava.security.CryptoPrimitive%3E,java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Permits(Java.Util.Set arg0, Java.Security.Key arg1)
        {
            return IExecute<bool>("permits", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}