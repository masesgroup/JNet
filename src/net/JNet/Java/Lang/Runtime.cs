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

using Java.Io;
using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Runtime.html"/>
    /// </summary>
    public sealed class Runtime : JVMBridgeBase<Runtime>
    {
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public override string ClassName => "java.lang.Runtime";
        /// <summary>
        /// Registers a new virtual-machine shutdown hook.
        /// </summary>
        public void AddShutdownHook​(Thread hook) => IExecute("addShutdownHook​", hook);
        /// <summary>
        /// Returns the number of processors available to the Java virtual machine.
        /// </summary>
        public int AvailableProcessors => IExecute<int>("availableProcessors​");
        /// <summary>
        /// Executes the specified string command in a separate process.
        /// </summary>
        public Process Exec​(String command) => IExecute<Process>("exec​​", command);
        /// <summary>
        /// Executes the specified command and arguments in a separate process.
        /// </summary>
        public Process Exec​(String[] cmdarray) => IExecute<Process>("exec​​", cmdarray);
        /// <summary>
        /// Executes the specified command and arguments in a separate process with the specified environment.
        /// </summary>
        public Process Exec​(String[] cmdarray, String[] envp) => IExecute<Process>("exec​​", cmdarray, envp);
        /// <summary>
        /// Executes the specified command and arguments in a separate process with the specified environment and working directory.
        /// </summary>
        public Process Exec​(String[] cmdarray, String[] envp, File dir) => IExecute<Process>("exec​​", cmdarray, envp, dir);
        /// <summary>
        /// Executes the specified string command in a separate process with the specified environment.
        /// </summary>
        public Process Exec​(String command, String[] envp) => IExecute<Process>("exec​​", command, envp);
        /// <summary>
        /// Executes the specified string command in a separate process with the specified environment and working directory.
        /// </summary>
        public Process Exec​(String command, String[] envp, File dir) => IExecute<Process>("exec​​", command, envp, dir);
        /// <summary>
        /// Terminates the currently running Java virtual machine by initiating its shutdown sequence.
        /// </summary>
        public void Exit​(int status) => IExecute("exit​​", status);
        /// <summary>
        /// Returns the amount of free memory in the Java Virtual Machine.
        /// </summary>
        public long FreeMemory => IExecute<long>("freeMemory​");
        /// <summary>
        /// Runs the garbage collector.
        /// </summary>
        public void Gc() => IExecute("gc​");
        /// <summary>
        /// Returns the runtime object associated with the current Java application.
        /// </summary>
        public static Runtime Current => SExecute<Runtime>("getRuntime​");
        /// <summary>
        /// Forcibly terminates the currently running Java virtual machine.
        /// </summary>
        public void Halt​(int status) => IExecute("halt​​​", status);
        /// <summary>
        /// Loads the native library specified by the filename argument.
        /// </summary>
        public void Load​(String filename) => IExecute("load​​​​", filename);
        /// <summary>
        /// Loads the native library specified by the libname argument.
        /// </summary>
        public void LoadLibrary​(String libname) => IExecute("loadLibrary​​​​​", libname);
        /// <summary>
        /// Returns the maximum amount of memory that the Java virtual machine will attempt to use.
        /// </summary>
        public long MaxMemory => IExecute<long>("freeMemory​");
        /// <summary>
        /// De-registers a previously-registered virtual-machine shutdown hook.
        /// </summary>
        public bool RemoveShutdownHook​(Thread hook) => IExecute<bool>("removeShutdownHook​", hook);
        /// <summary>
        /// Runs the finalization methods of any objects pending finalization.
        /// </summary>
        public void RunFinalization() => IExecute("runFinalization​");
        /// <summary>
        /// Returns the total amount of memory in the Java virtual machine.
        /// </summary>
        public long TotalMemory => IExecute<long>("totalMemory​");
        /// <summary>
        /// Returns the version of the Java Runtime Environment as a Runtime.Version.
        /// </summary>
        public static Runtime.Version CurrentVersion => SExecute<Runtime.Version>("version");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html"/>
        /// </summary>
        public sealed class Version : JVMBridgeBase<Version>
        {
            /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
            public override string ClassName => "java.lang.Runtime$Version";
        }
    }
}
