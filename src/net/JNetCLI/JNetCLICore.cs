/*
*  Copyright 2025 MASES s.r.l.
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

using MASES.CLIParser;
using MASES.JNet;
using MASES.JNet.Specific.CLI;
using System;
using System.Collections.Generic;
using System.IO;

namespace MASES.JNet.CLI
{
    /// <summary>
    /// Public entry point of <see cref="JNetCLICore{T}"/>
    /// </summary>
    public abstract class JNetCLICore<T> : JNetCore<T> where T : JNetCLICore<T>
    {
        #region Initialization
        /// <inheritdoc cref="JNetCoreBase{T}.CommandLineArguments"/>
        public override IEnumerable<IArgumentMetadata> CommandLineArguments => base.CommandLineArguments.SetCLICommandLineArguments();

        /// <summary>
        /// Public ctor
        /// </summary>
        public JNetCLICore()
        {
            this.InitCLI();
        }

        /// <inheritdoc cref="JNetCoreBase{T}.ProcessCommandLine"/>
        protected override string[] ProcessCommandLine()
        {
            var result = base.ProcessCommandLine(); 
            return this.ProcessCLIParsedArgs(result, settingsCallback: (className) =>
            {
                switch(className)
                {
                    default:
                        ApplicationInitialHeapSize = ApplicationHeapSize = Environment.Is64BitOperatingSystem ? "1G" : "512M";
                        break;
                }
            });
        }

        /// <inheritdoc cref="JNetCoreBase{T}.PathToParse"/>
        protected override IList<string> PathToParse => base.PathToParse.SetCLIPathToParse();
        #endregion

#if DEBUG
        public override bool EnableDebug => true;
#endif
    }
    /// <summary>
    /// Concrete implementation of <see cref="JNetCLICore{T}"/>
    /// </summary>
    public class JNetCLICore : JNetCLICore<JNetCLICore>
    {
    }
}