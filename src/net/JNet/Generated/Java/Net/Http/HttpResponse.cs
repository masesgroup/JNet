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

namespace Java.Net.Http
{
    #region HttpResponse
    public partial class HttpResponse
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpResponse.html#statusCode()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int StatusCode()
        {
            return IExecute<int>("statusCode");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpResponse.html#headers()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Net.Http.HttpHeaders"/></returns>
        public Java.Net.Http.HttpHeaders Headers()
        {
            return IExecute<Java.Net.Http.HttpHeaders>("headers");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpResponse.html#request()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Net.Http.HttpRequest"/></returns>
        public Java.Net.Http.HttpRequest Request()
        {
            return IExecute<Java.Net.Http.HttpRequest>("request");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpResponse.html#uri()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI Uri()
        {
            return IExecute<Java.Net.URI>("uri");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpResponse.html#body()"/>
        /// </summary>
        
        /// <returns><see langword="object"/></returns>
        public object Body()
        {
            return IExecute("body");
        }
        
        #endregion

        #region Nested classes
        #region BodyHandler
        public partial class BodyHandler
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

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region BodyHandlers
        public partial class BodyHandlers
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

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region BodySubscriber
        public partial class BodySubscriber
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

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region BodySubscribers
        public partial class BodySubscribers
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

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region PushPromiseHandler
        public partial class PushPromiseHandler
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

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ResponseInfo
        public partial class ResponseInfo
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpResponse.ResponseInfo.html#statusCode()"/>
            /// </summary>
            
            /// <returns><see langword="int"/></returns>
            public int StatusCode()
            {
                return IExecute<int>("statusCode");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpResponse.ResponseInfo.html#headers()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Net.Http.HttpHeaders"/></returns>
            public Java.Net.Http.HttpHeaders Headers()
            {
                return IExecute<Java.Net.Http.HttpHeaders>("headers");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}