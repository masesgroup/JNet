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
using Java.Nio;
using Java.Util;
using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/System.html"/>
    /// </summary>
    public sealed class System : JVMBridgeBase<System>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.lang.System";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => true;
        /// <summary>
        /// Copies an array from the specified source array, beginning at the specified position, to the specified position of the destination array.
        /// </summary>
        public static void Arraycopy​(Object src, int srcPos, Object dest, int destPos, int length) => SExecute("arraycopy​", src, srcPos, dest, destPos, length);
        /// <summary>
        /// Removes the system property indicated by the specified key.
        /// </summary>
        public static string ClearProperty​(string key) => SExecute<string>("clearProperty​​", key);
        /// <summary>
        /// Returns the unique Console object associated with the current Java virtual machine, if any.
        /// </summary>
        public static Console Console => SExecute<Console>("console​​");
        /// <summary>
        /// Returns the current time in milliseconds.
        /// </summary>
        public static long CurrentTimeMillis => SExecute<long>("currentTimeMillis​​");
        /// <summary>
        /// Terminates the currently running Java Virtual Machine.
        /// </summary>
        public static void Exit​(int status) => SExecute("exit​​​", status);
        /// <summary>
        /// Runs the garbage collector.
        /// </summary>
        public static void Gc() => SExecute("gc​​​");
        /// <summary>
        /// Returns an unmodifiable string map view of the current system environment.
        /// </summary>
        public static Map<string, string> Env => SExecute<Map<string, string>>("getenv​​​​");
        /// <summary>
        /// Gets the value of the specified environment variable.
        /// </summary>
        public static string Getenv​(string name) => SExecute<string>("getenv​​​​", name);
        /// <summary>
        /// Returns an instance of Logger for the caller's use.
        /// </summary>
        public static Logger GetLogger​(string name) => SExecute<Logger>("getLogger​​​​​", name);
        /// <summary>
        /// Returns a localizable instance of Logger for the caller's use.
        /// </summary>
        public static Logger GetLogger​(string name, ResourceBundle bundle) => SExecute<Logger>("getLogger​​​​​", name, bundle);
        /// <summary>
        /// Determines the current system properties.
        /// </summary>
        public static Properties Properties => SExecute<Properties>("getProperties​​​​");
        /// <summary>
        /// Gets the system property indicated by the specified key.
        /// </summary>
        public static string GetProperty​(string key) => SExecute<string>("getProperty​​​​​", key);
        /// <summary>
        ///  Gets the system property indicated by the specified key.
        /// </summary>
        public static string GetProperty​(string key, string def) => SExecute<string>("getProperty​​​​​", key, def);
        /// <summary>
        /// Gets the system-wide security manager.
        /// </summary>
        public static SecurityManager SecurityManager => SExecute<SecurityManager>("getSecurityManager​​​​​");
        /// <summary>
        /// Returns the same hash code for the given object as would be returned by the default method hashCode(), whether or not the given object's class overrides hashCode().
        /// </summary>
        public static int IdentityHashCode​(object x) => SExecute<int>("identityHashCode​​​​​​", x);
        /// <summary>
        /// Returns the channel inherited from the entity that created this Java virtual machine.
        /// </summary>
        public static Channel inheritedChannel => SExecute<Channel>("inheritedChannel​​​​​​");
        /// <summary>
        /// Returns the system-dependent line separator string.
        /// </summary>
        public static string LineSeparator => SExecute<string>("lineSeparator​​​​​​");
        /// <summary>
        /// Loads the native library specified by the filename argument.
        /// </summary>
        public static void Load​(string filename) => SExecute("load​​​​​​​", filename);
        /// <summary>
        ///  Loads the native library specified by the libname argument.
        /// </summary>
        public static void LoadLibrary​(string libname) => SExecute("loadLibrary​​​​​​​​", libname);
        /// <summary>
        /// Maps a library name into a platform-specific string representing a native library.
        /// </summary>
        public static string MapLibraryName​(string libname) => SExecute<string>("mapLibraryName​​​​​​​​​", libname);
        /// <summary>
        /// Returns the current value of the running Java Virtual Machine's high-resolution time source, in nanoseconds.
        /// </summary>
        public static long NanoTime => SExecute<long>("nanoTime​​​​​​​​​");
        /// <summary>
        /// Runs the finalization methods of any objects pending finalization.
        /// </summary>
        public static void RunFinalization() => SExecute("runFinalization​​​​​​​​​");
        /// <summary>
        /// Reassigns the "standard" error output stream.
        /// </summary>
        public static void SetErr​(PrintStream err) => SExecute("setErr​​​​​​​​​​", err);
        /// <summary>
        /// Reassigns the "standard" input stream.
        /// </summary>
        public static void SetIn​(InputStream _in) => SExecute("setIn​​​​​​​​​​​", _in);
        /// <summary>
        /// Reassigns the "standard" output stream.
        /// </summary>
        public static void SetOut​(PrintStream _out) => SExecute("setOut​​​​​​​​​​​​", _out);
        /// <summary>
        /// Sets the system properties to the Properties argument.
        /// </summary>
        public static void SetProperties​(Properties props) => SExecute("setProperties​​​​​​​​​​", props);
        /// <summary>
        /// Sets the system property indicated by the specified key.
        /// </summary>
        public static string SetProperty​(string key, string value) => SExecute<string>("setProperty​​​​​​​​​​​", key, value);
        /// <summary>
        ///  Sets the system-wide security manager.
        /// </summary>
        public static void SetSecurityManager​(SecurityManager sm) => SExecute("setSecurityManager​​​​​​​​​​​​", sm);

        /// <summary>
        /// .NET implementations of https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/System.Logger.html
        /// </summary>
        public sealed class Logger : JVMBridgeBase<Logger>
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
            /// </summary>
            public override bool IsInterface => true;
            /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
            public override string ClassName => "java.lang.System$Logger";
        }
    }
}
