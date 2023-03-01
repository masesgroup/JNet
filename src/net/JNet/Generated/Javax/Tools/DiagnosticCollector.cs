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

namespace Javax.Tools
{
    #region DiagnosticCollector
    public partial class DiagnosticCollector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Tools.DiagnosticCollector"/> to <see cref="Javax.Tools.DiagnosticListener"/>
        /// </summary>
        public static implicit operator Javax.Tools.DiagnosticListener(Javax.Tools.DiagnosticCollector t) => t.Cast<Javax.Tools.DiagnosticListener>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DiagnosticCollector.html#getDiagnostics()"/> 
        /// </summary>
        public Java.Util.List Diagnostics
        {
            get { return IExecute<Java.Util.List>("getDiagnostics"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DiagnosticCollector.html#report(javax.tools.Diagnostic%3C? extends S%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.Diagnostic"/></param>
        public void Report(Javax.Tools.Diagnostic arg0)
        {
            IExecute("report", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}