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

namespace Java.Nio.File
{
    #region IWatchService
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchService.html"/>
    /// </summary>
    public partial interface IWatchService : Java.Io.ICloseable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchService.html#poll()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        Java.Nio.File.WatchKey Poll();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchService.html#poll(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        Java.Nio.File.WatchKey Poll(long arg0, Java.Util.Concurrent.TimeUnit arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchService.html#take()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        Java.Nio.File.WatchKey Take();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchService.html#close()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        void Close();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WatchService
    public partial class WatchService : Java.Nio.File.IWatchService
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchService.html#poll()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        public Java.Nio.File.WatchKey Poll()
        {
            return IExecute<Java.Nio.File.WatchKey>("poll");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchService.html#poll(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Nio.File.WatchKey Poll(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<Java.Nio.File.WatchKey>("poll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchService.html#take()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Nio.File.WatchKey Take()
        {
            return IExecute<Java.Nio.File.WatchKey>("take");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/WatchService.html#close()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecute("close");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}