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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Io
{
    #region FileDescriptor
    public partial class FileDescriptor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/FileDescriptor.html#err"/>
        /// </summary>
        public static Java.Io.FileDescriptor err { get { if (!_errReady) { _errContent = SGetField<Java.Io.FileDescriptor>(LocalBridgeClazz, "err"); _errReady = true; } return _errContent; } }
        private static Java.Io.FileDescriptor _errContent = default;
        private static bool _errReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/FileDescriptor.html#in"/>
        /// </summary>
        public static Java.Io.FileDescriptor inField { get { if (!_inFieldReady) { _inFieldContent = SGetField<Java.Io.FileDescriptor>(LocalBridgeClazz, "in"); _inFieldReady = true; } return _inFieldContent; } }
        private static Java.Io.FileDescriptor _inFieldContent = default;
        private static bool _inFieldReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/FileDescriptor.html#out"/>
        /// </summary>
        public static Java.Io.FileDescriptor outField { get { if (!_outFieldReady) { _outFieldContent = SGetField<Java.Io.FileDescriptor>(LocalBridgeClazz, "out"); _outFieldReady = true; } return _outFieldContent; } }
        private static Java.Io.FileDescriptor _outFieldContent = default;
        private static bool _outFieldReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/FileDescriptor.html#valid()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Valid()
        {
            return IExecuteWithSignature<bool>("valid", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/FileDescriptor.html#sync()"/>
        /// </summary>

        /// <exception cref="Java.Io.SyncFailedException"/>
        public void Sync()
        {
            IExecuteWithSignature("sync", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}