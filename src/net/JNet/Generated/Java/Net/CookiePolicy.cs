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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region ICookiePolicy
    public partial interface ICookiePolicy
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookiePolicy.html#shouldAccept(java.net.URI,java.net.HttpCookie)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Net.HttpCookie"/></param>
        /// <returns><see cref="bool"/></returns>
        bool ShouldAccept(Java.Net.URI arg0, Java.Net.HttpCookie arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CookiePolicy
    public partial class CookiePolicy : Java.Net.ICookiePolicy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookiePolicy.html#ACCEPT_ALL"/>
        /// </summary>
        public static Java.Net.CookiePolicy ACCEPT_ALL { get { return SGetField<Java.Net.CookiePolicy>(LocalBridgeClazz, "ACCEPT_ALL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookiePolicy.html#ACCEPT_NONE"/>
        /// </summary>
        public static Java.Net.CookiePolicy ACCEPT_NONE { get { return SGetField<Java.Net.CookiePolicy>(LocalBridgeClazz, "ACCEPT_NONE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookiePolicy.html#ACCEPT_ORIGINAL_SERVER"/>
        /// </summary>
        public static Java.Net.CookiePolicy ACCEPT_ORIGINAL_SERVER { get { return SGetField<Java.Net.CookiePolicy>(LocalBridgeClazz, "ACCEPT_ORIGINAL_SERVER"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/CookiePolicy.html#shouldAccept(java.net.URI,java.net.HttpCookie)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Net.HttpCookie"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldAccept(Java.Net.URI arg0, Java.Net.HttpCookie arg1)
        {
            return IExecute<bool>("shouldAccept", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}