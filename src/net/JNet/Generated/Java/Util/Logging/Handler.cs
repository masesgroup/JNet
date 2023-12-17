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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Logging
{
    #region Handler
    public partial class Handler
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Handler.html#getEncoding()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Handler.html#setEncoding(java.lang.String)"/>
        /// </summary>
        public string Encoding
        {
            get { return IExecute<string>("getEncoding"); } set { IExecute("setEncoding", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Handler.html#getErrorManager()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Handler.html#setErrorManager(java.util.logging.ErrorManager)"/>
        /// </summary>
        public Java.Util.Logging.ErrorManager ErrorManager
        {
            get { return IExecute<Java.Util.Logging.ErrorManager>("getErrorManager"); } set { IExecute("setErrorManager", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Handler.html#getFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Handler.html#setFilter(java.util.logging.Filter)"/>
        /// </summary>
        public Java.Util.Logging.Filter Filter
        {
            get { return IExecute<Java.Util.Logging.Filter>("getFilter"); } set { IExecute("setFilter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Handler.html#getFormatter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Handler.html#setFormatter(java.util.logging.Formatter)"/>
        /// </summary>
        public Java.Util.Logging.Formatter Formatter
        {
            get { return IExecute<Java.Util.Logging.Formatter>("getFormatter"); } set { IExecute("setFormatter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Handler.html#getLevel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Handler.html#setLevel(java.util.logging.Level)"/>
        /// </summary>
        public Java.Util.Logging.Level Level
        {
            get { return IExecute<Java.Util.Logging.Level>("getLevel"); } set { IExecute("setLevel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Handler.html#close()"/>
        /// </summary>

        /// <exception cref="Java.Lang.SecurityException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Handler.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecute("flush");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Handler.html#publish(java.util.logging.LogRecord)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.LogRecord"/></param>
        public void Publish(Java.Util.Logging.LogRecord arg0)
        {
            IExecute("publish", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Handler.html#isLoggable(java.util.logging.LogRecord)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.LogRecord"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsLoggable(Java.Util.Logging.LogRecord arg0)
        {
            return IExecute<bool>("isLoggable", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}