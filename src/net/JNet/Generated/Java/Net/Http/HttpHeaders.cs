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

namespace Java.Net.Http
{
    #region HttpHeaders
    public partial class HttpHeaders
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpHeaders.html#of(java.util.Map,java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Net.Http.HttpHeaders"/></returns>
        public static Java.Net.Http.HttpHeaders Of(Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>> arg0, Java.Util.Function.BiPredicate<Java.Lang.String, Java.Lang.String> arg1)
        {
            return SExecute<Java.Net.Http.HttpHeaders>(LocalBridgeClazz, "of", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpHeaders.html#allValues(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> AllValues(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("allValues", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpHeaders.html#map()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>> Map()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>>>("map", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpHeaders.html#firstValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Lang.String> FirstValue(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Lang.String>>("firstValue", "(Ljava/lang/String;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpHeaders.html#firstValueAsLong(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public Java.Util.OptionalLong FirstValueAsLong(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.OptionalLong>("firstValueAsLong", "(Ljava/lang/String;)Ljava/util/OptionalLong;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}