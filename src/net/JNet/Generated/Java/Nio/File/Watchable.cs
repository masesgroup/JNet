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

namespace Java.Nio.File
{
    #region IWatchable
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IWatchable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Watchable.html#register(java.nio.file.WatchService,java.nio.file.WatchEvent.Kind[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.WatchService"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.WatchEvent.Kind"/></param>
        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.File.WatchKey Register(Java.Nio.File.WatchService arg0, params Java.Nio.File.WatchEvent.Kind<object>[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Watchable.html#register(java.nio.file.WatchService,java.nio.file.WatchEvent.Kind[],java.nio.file.WatchEvent.Modifier[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.WatchService"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.WatchEvent.Kind"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.WatchEvent.Modifier"/></param>
        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.File.WatchKey Register(Java.Nio.File.WatchService arg0, Java.Nio.File.WatchEvent.Kind<object>[] arg1, params Java.Nio.File.WatchEvent.Modifier[] arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Watchable
    public partial class Watchable : Java.Nio.File.IWatchable
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Watchable.html#register(java.nio.file.WatchService,java.nio.file.WatchEvent.Kind[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.WatchService"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.WatchEvent.Kind"/></param>
        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.WatchKey Register(Java.Nio.File.WatchService arg0, params Java.Nio.File.WatchEvent.Kind<object>[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Nio.File.WatchKey>("register", arg0); else return IExecute<Java.Nio.File.WatchKey>("register", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Watchable.html#register(java.nio.file.WatchService,java.nio.file.WatchEvent.Kind[],java.nio.file.WatchEvent.Modifier[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.WatchService"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.WatchEvent.Kind"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.WatchEvent.Modifier"/></param>
        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.WatchKey Register(Java.Nio.File.WatchService arg0, Java.Nio.File.WatchEvent.Kind<object>[] arg1, params Java.Nio.File.WatchEvent.Modifier[] arg2)
        {
            if (arg2.Length == 0) return IExecute<Java.Nio.File.WatchKey>("register", arg0, arg1); else return IExecute<Java.Nio.File.WatchKey>("register", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}