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

namespace Java.Security.Cert
{
    #region PolicyNode
    public partial class PolicyNode
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getChildren()"/> 
        /// </summary>
        public Java.Util.Iterator Children
        {
            get { return IExecute<Java.Util.Iterator>("getChildren"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getDepth()"/> 
        /// </summary>
        public int Depth
        {
            get { return IExecute<int>("getDepth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getExpectedPolicies()"/> 
        /// </summary>
        public Java.Util.Set ExpectedPolicies
        {
            get { return IExecute<Java.Util.Set>("getExpectedPolicies"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getParent()"/> 
        /// </summary>
        public Java.Security.Cert.PolicyNode Parent
        {
            get { return IExecute<Java.Security.Cert.PolicyNode>("getParent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getPolicyQualifiers()"/> 
        /// </summary>
        public Java.Util.Set PolicyQualifiers
        {
            get { return IExecute<Java.Util.Set>("getPolicyQualifiers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#getValidPolicy()"/> 
        /// </summary>
        public string ValidPolicy
        {
            get { return IExecute<string>("getValidPolicy"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PolicyNode.html#isCritical()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsCritical()
        {
            return IExecute<bool>("isCritical");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}