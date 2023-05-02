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

namespace Java.Lang.Ref
{
    #region Cleaner
    public partial class Cleaner
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/Cleaner.html#create()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Ref.Cleaner"/></returns>
        public static Java.Lang.Ref.Cleaner Create()
        {
            return SExecute<Java.Lang.Ref.Cleaner>(LocalBridgeClazz, "create");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/Cleaner.html#create(java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Lang.Ref.Cleaner"/></returns>
        public static Java.Lang.Ref.Cleaner Create(Java.Util.Concurrent.ThreadFactory arg0)
        {
            return SExecute<Java.Lang.Ref.Cleaner>(LocalBridgeClazz, "create", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/Cleaner.html#register(java.lang.Object,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Lang.Ref.Cleaner.Cleanable"/></returns>
        public Java.Lang.Ref.Cleaner.Cleanable Register(object arg0, Java.Lang.Runnable arg1)
        {
            return IExecute<Java.Lang.Ref.Cleaner.Cleanable>("register", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Cleanable
        public partial class Cleanable
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ref/Cleaner.Cleanable.html#clean()"/>
            /// </summary>
            public void Clean()
            {
                IExecute("clean");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}