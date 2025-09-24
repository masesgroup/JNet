/*
*  Copyright (c) 2022-2025 MASES s.r.l.
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

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Throwable.html"/>
    /// </summary>
    public class Throwable : JVMBridgeException<Throwable>
    {
        /// <inheritdoc cref="global::System.Exception()"/>
        public Throwable() { }
        /// <inheritdoc cref="global::System.Exception(string)"/>
        public Throwable(string message) : base(message) { }
        /// <inheritdoc cref="global::System.Exception(string, global::System.Exception)"/>
        public Throwable(string message, global::System.Exception innerException) : base(message, innerException) { }
        /// <inheritdoc />
        public override string BridgeClassName => "java.lang.Throwable";
#if !JNETREFLECTOR
        /// <summary>
        /// Appends the specified exception to the exceptions that were suppressed in order to deliver this exception.
        /// </summary>
        /// <param name="exception">The exception to be added to the list of suppressed exceptions</param>
        public void AddSuppressed(Throwable exception) => IExecute("addSuppressed", exception);
        /// <summary>
        /// Fills in the execution stack trace.
        /// </summary>
        /// <returns>A reference to this <see cref="Throwable"/> instance.</returns>
        public Throwable FillInStackTrace() => IExecute<Throwable>("fillInStackTrace");
        /// <summary>
        /// Returns the cause of this throwable or null if the cause is nonexistent or unknown.
        /// </summary>
        public Throwable Cause
        {
            get
            {
                try
                {
                    return IExecute<Throwable>("getCause");
                }
                catch
                {
                    return InnerException as Throwable;
                }
            }
        }
        /// <summary>
        ///  Creates a localized description of this throwable.
        /// </summary>
        public string LocalizedMessage => IExecute<string>("getLocalizedMessage");
        /// <summary>
        /// Provides programmatic access to the stack trace information printed by printStackTrace().
        /// </summary>
        public StackTraceElement[] StackTraceElements => IExecuteArray<StackTraceElement>("getStackTrace");
        /// <summary>
        /// Returns an array containing all of the exceptions that were suppressed, typically by the try-with-resources statement, in order to deliver this exception.
        /// </summary>
        public Throwable[] Suppressed => IExecuteArray<Throwable>("getSuppressed");
        /// <summary>
        /// Initializes the cause of this <see cref="Throwable"/> to the specified value.
        /// </summary>
        /// <param name="cause">The cause (which is saved for later retrieval by the <see cref="Cause"/> property). (A null value is permitted, and indicates that the cause is nonexistent or unknown.)</param>
        /// <returns>A reference to this <see cref="Throwable"/> instance.</returns>
        public Throwable InitCause(Throwable cause) => IExecute<Throwable>("initCause", cause);
        /// <summary>
        /// Prints this <see cref="Throwable"/> and its backtrace to the standard error stream.
        /// </summary>
        public void PrintStackTrace() => IExecute("printStackTrace");
        /// <summary>
        /// Prints this <see cref="Throwable"/> and its backtrace to the specified print stream.
        /// </summary>
        public void PrintStackTrace(Java.Io.PrintStream s) => IExecute("printStackTrace", s);
        /// <summary>
        /// Prints this <see cref="Throwable"/> and its backtrace to the specified print writer.
        /// </summary>
        public void PrintStackTrace(Java.Io.PrintWriter s) => IExecute("printStackTrace", s);
        /// <summary>
        /// Sets the stack trace elements that will be returned by <see cref="StackTraceElements"/> and printed by <see cref="PrintStackTrace()"/> and related methods.
        /// </summary>
        /// <param name="stackTrace"></param>
        public void SetStackTrace(StackTraceElement[] stackTrace) => IExecute("setStackTrace", stackTrace);
#endif
    }
}
