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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region IProcessHandle
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IProcessHandle : Java.Lang.IComparable<Java.Lang.ProcessHandle>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#destroy()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool Destroy();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#destroyForcibly()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool DestroyForcibly();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#isAlive()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsAlive();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#supportsNormalTermination()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool SupportsNormalTermination();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#compareTo(java.lang.ProcessHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ProcessHandle"/></param>
        /// <returns><see cref="int"/></returns>
        int CompareTo(Java.Lang.ProcessHandle arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#info()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.ProcessHandle.Info"/></returns>
        Java.Lang.ProcessHandle.Info InfoMethod();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#onExit()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        Java.Util.Concurrent.CompletableFuture<Java.Lang.ProcessHandle> OnExit();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#parent()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        Java.Util.Optional<Java.Lang.ProcessHandle> Parent();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#children()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        Java.Util.Stream.Stream<Java.Lang.ProcessHandle> Children();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#descendants()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        Java.Util.Stream.Stream<Java.Lang.ProcessHandle> Descendants();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#pid()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        long Pid();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        int CompareTo(object arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ProcessHandle
    public partial class ProcessHandle : Java.Lang.IProcessHandle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#current()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.ProcessHandle"/></returns>
        public static Java.Lang.ProcessHandle Current()
        {
            return SExecute<Java.Lang.ProcessHandle>(LocalBridgeClazz, "current");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#of(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional<Java.Lang.ProcessHandle> Of(long arg0)
        {
            return SExecute<Java.Util.Optional<Java.Lang.ProcessHandle>>(LocalBridgeClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#allProcesses()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public static Java.Util.Stream.Stream<Java.Lang.ProcessHandle> AllProcesses()
        {
            return SExecute<Java.Util.Stream.Stream<Java.Lang.ProcessHandle>>(LocalBridgeClazz, "allProcesses");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#destroy()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Destroy()
        {
            return IExecute<bool>("destroy");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#destroyForcibly()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool DestroyForcibly()
        {
            return IExecute<bool>("destroyForcibly");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#isAlive()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAlive()
        {
            return IExecute<bool>("isAlive");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#supportsNormalTermination()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool SupportsNormalTermination()
        {
            return IExecute<bool>("supportsNormalTermination");
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#onExit()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Lang.ProcessHandle> OnExit()
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture<Java.Lang.ProcessHandle>>("onExit");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#parent()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Lang.ProcessHandle> Parent()
        {
            return IExecute<Java.Util.Optional<Java.Lang.ProcessHandle>>("parent");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#children()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Lang.ProcessHandle> Children()
        {
            return IExecute<Java.Util.Stream.Stream<Java.Lang.ProcessHandle>>("children");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#descendants()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Lang.ProcessHandle> Descendants()
        {
            return IExecute<Java.Util.Stream.Stream<Java.Lang.ProcessHandle>>("descendants");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.html#pid()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Pid()
        {
            return IExecute<long>("pid");
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

            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<string[]> Arguments()
            {
                return IExecute<Java.Util.Optional<string[]>>("arguments");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.Info.html#command()"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<string> Command()
            {
                return IExecute<Java.Util.Optional<string>>("command");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.Info.html#commandLine()"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<string> CommandLine()
            {
                return IExecute<Java.Util.Optional<string>>("commandLine");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.Info.html#user()"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<string> User()
            {
                return IExecute<Java.Util.Optional<string>>("user");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.Info.html#totalCpuDuration()"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Time.Duration> TotalCpuDuration()
            {
                return IExecute<Java.Util.Optional<Java.Time.Duration>>("totalCpuDuration");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ProcessHandle.Info.html#startInstant()"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Time.Instant> StartInstant()
            {
                return IExecute<Java.Util.Optional<Java.Time.Instant>>("startInstant");
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