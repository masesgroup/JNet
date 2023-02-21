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
    #region Watchable
    public partial class Watchable
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Watchable.html#register(java.nio.file.WatchService,java.nio.file.WatchEvent$Kind<?>...) throws java.io.IOException
        /// </summary>
        public Java.Nio.File.WatchKey Register(Java.Nio.File.WatchService arg0, params Java.Nio.File.WatchEvent.Kind[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Nio.File.WatchKey>("register", arg0); else return IExecute<Java.Nio.File.WatchKey>("register", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Watchable.html#register(java.nio.file.WatchService,java.nio.file.WatchEvent$Kind<?>[],java.nio.file.WatchEvent$Modifier...) throws java.io.IOException
        /// </summary>
        public Java.Nio.File.WatchKey Register(Java.Nio.File.WatchService arg0, Java.Nio.File.WatchEvent.Kind[] arg1, params Java.Nio.File.WatchEvent.Modifier[] arg2)
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