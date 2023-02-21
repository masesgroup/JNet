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

namespace Java.Util.Logging
{
    #region ErrorManager
    public partial class ErrorManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/ErrorManager.html#GENERIC_FAILURE
        /// </summary>
        public static int GENERIC_FAILURE => Clazz.GetField<int>("GENERIC_FAILURE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/ErrorManager.html#WRITE_FAILURE
        /// </summary>
        public static int WRITE_FAILURE => Clazz.GetField<int>("WRITE_FAILURE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/ErrorManager.html#FLUSH_FAILURE
        /// </summary>
        public static int FLUSH_FAILURE => Clazz.GetField<int>("FLUSH_FAILURE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/ErrorManager.html#CLOSE_FAILURE
        /// </summary>
        public static int CLOSE_FAILURE => Clazz.GetField<int>("CLOSE_FAILURE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/ErrorManager.html#OPEN_FAILURE
        /// </summary>
        public static int OPEN_FAILURE => Clazz.GetField<int>("OPEN_FAILURE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/ErrorManager.html#FORMAT_FAILURE
        /// </summary>
        public static int FORMAT_FAILURE => Clazz.GetField<int>("FORMAT_FAILURE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/ErrorManager.html#error(java.lang.String,java.lang.Exception,int)
        /// </summary>
        public void Error(string arg0, Java.Lang.Exception arg1, int arg2)
        {
            IExecute("error", arg0, arg1, arg2);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}