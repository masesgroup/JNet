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

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Throwable.html"/>
    /// </summary>
    public class Throwable : JVMBridgeException<Throwable>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "java.lang.Throwable";
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
        public Throwable Cause => IExecute<Throwable>("getCause");
        /// <summary>
        ///  Creates a localized description of this throwable.
        /// </summary>
        public string LocalizedMessage => IExecute<string>("getLocalizedMessage");
        /// <summary>
        /// Returns the detail message string of this throwable.
        /// </summary>
        public new string Message => IExecute<string>("getMessage");
    }
}
