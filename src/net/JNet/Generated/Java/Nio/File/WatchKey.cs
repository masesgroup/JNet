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

namespace Java.Nio.File
{
    #region WatchKey
    public partial class WatchKey
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchKey.html#isValid()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsValid()
        {
            return IExecute<bool>("isValid");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchKey.html#reset()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool Reset()
        {
            return IExecute<bool>("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchKey.html#watchable()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.File.Watchable"/></returns>
        public Java.Nio.File.Watchable Watchable()
        {
            return IExecute<Java.Nio.File.Watchable>("watchable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchKey.html#pollEvents()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List PollEvents()
        {
            return IExecute<Java.Util.List>("pollEvents");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchKey.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecute("cancel");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}