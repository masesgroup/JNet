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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region ProcessHandle
    public partial class ProcessHandle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#allProcesses()"/> 
        /// </summary>
        public static Java.Util.Stream.Stream<Java.Lang.ProcessHandle> AllProcesses
        {
            get { return SExecute<Java.Util.Stream.Stream<Java.Lang.ProcessHandle>>("allProcesses"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#current()"/> 
        /// </summary>
        public static Java.Lang.ProcessHandle Current
        {
            get { return SExecute<Java.Lang.ProcessHandle>("current"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#of(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional<Java.Lang.ProcessHandle> Of(long arg0)
        {
            return SExecute<Java.Util.Optional<Java.Lang.ProcessHandle>>("of", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#children()"/> 
        /// </summary>
        public Java.Util.Stream.Stream<Java.Lang.ProcessHandle> Children
        {
            get { return IExecute<Java.Util.Stream.Stream<Java.Lang.ProcessHandle>>("children"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#descendants()"/> 
        /// </summary>
        public Java.Util.Stream.Stream<Java.Lang.ProcessHandle> Descendants
        {
            get { return IExecute<Java.Util.Stream.Stream<Java.Lang.ProcessHandle>>("descendants"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#destroy()"/> 
        /// </summary>
        public bool Destroy
        {
            get { return IExecute<bool>("destroy"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#destroyForcibly()"/> 
        /// </summary>
        public bool DestroyForcibly
        {
            get { return IExecute<bool>("destroyForcibly"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#isAlive()"/> 
        /// </summary>
        public bool IsAlive
        {
            get { return IExecute<bool>("isAlive"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#onExit()"/> 
        /// </summary>
        public Java.Util.Concurrent.CompletableFuture<Java.Lang.ProcessHandle> OnExit
        {
            get { return IExecute<Java.Util.Concurrent.CompletableFuture<Java.Lang.ProcessHandle>>("onExit"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#parent()"/> 
        /// </summary>
        public Java.Util.Optional<Java.Lang.ProcessHandle> Parent
        {
            get { return IExecute<Java.Util.Optional<Java.Lang.ProcessHandle>>("parent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#pid()"/> 
        /// </summary>
        public long Pid
        {
            get { return IExecute<long>("pid"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#supportsNormalTermination()"/> 
        /// </summary>
        public bool SupportsNormalTermination
        {
            get { return IExecute<bool>("supportsNormalTermination"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#compareTo(java.lang.ProcessHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ProcessHandle"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Lang.ProcessHandle arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#info()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Lang.ProcessHandle.Info"/></returns>
        public Java.Lang.ProcessHandle.Info InfoMethod()
        {
            return IExecute<Java.Lang.ProcessHandle.Info>("info");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        
        #endregion

        #region Nested classes
        #region Info
        public partial class Info
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.Info.html#arguments()"/> 
            /// </summary>
            public Java.Util.Optional<string[]> Arguments
            {
                get { return IExecute<Java.Util.Optional<string[]>>("arguments"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.Info.html#command()"/> 
            /// </summary>
            public Java.Util.Optional<string> Command
            {
                get { return IExecute<Java.Util.Optional<string>>("command"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.Info.html#commandLine()"/> 
            /// </summary>
            public Java.Util.Optional<string> CommandLine
            {
                get { return IExecute<Java.Util.Optional<string>>("commandLine"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.Info.html#startInstant()"/> 
            /// </summary>
            public Java.Util.Optional<Java.Time.Instant> StartInstant
            {
                get { return IExecute<Java.Util.Optional<Java.Time.Instant>>("startInstant"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.Info.html#totalCpuDuration()"/> 
            /// </summary>
            public Java.Util.Optional<Java.Time.Duration> TotalCpuDuration
            {
                get { return IExecute<Java.Util.Optional<Java.Time.Duration>>("totalCpuDuration"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.Info.html#user()"/> 
            /// </summary>
            public Java.Util.Optional<string> User
            {
                get { return IExecute<Java.Util.Optional<string>>("user"); }
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