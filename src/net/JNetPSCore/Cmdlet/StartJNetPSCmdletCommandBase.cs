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

using MASES.JCOBridge.C2JBridge;
using MASES.JNet;
using System.Management.Automation;

namespace MASES.JNet.PowerShell.Cmdlet
{
    /// <summary>
    /// Base class to be extended in derived projects to add other parameters
    /// </summary>
    /// <typeparam name="T">A class based on <see cref="JNetCore{TCore}"/></typeparam>
    public abstract class StartJNetPSCmdletCommandBase<TCmdlet, TCore> : JNetPSExternalizableCmdlet<TCmdlet>
        where TCmdlet : StartJNetPSCmdletCommandBase<TCmdlet, TCore>
        where TCore : JNetCore<TCore>
    {
        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationLicensePath" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The path where is located the license file")]
        public string LicensePath { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationJDKHome" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The path where is located the JRE of the installed JDK")]
        public string JDKHome { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationJVMPath" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The path to the JRE ennvironment or full path to (jvm.dll/libjvm.so). If not set the library try to find a suitable version on the system")]
        public string JVMPath { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationJNIVerbosity" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Sets the verbosity of the JNI interface. See oracle documentation")]
        public string JNIVerbosity { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationJNIOutputFile" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The path where the JNI verbose info will be written. The file will be opened in append mode")]
        public string JNIOutputFile { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationJmxPort" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The JMX port to be set when JVM will be created")]
        public short? JmxPort { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationEnableDebug" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Put in command line to enable JVM debug")]
        public SwitchParameter EnableDebug { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationJavaDebugPort" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The port to be used for debug when JVM will be created")]
        public short? JavaDebugPort { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationDebugSuspendFlag" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The suspend flag to be used in the debug option when JVM will be created. Default is \"n\"")]
        public string DebugSuspendFlag { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationJavaDebugOpts" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The string to be used in the debug option when JVM will be created. Default is \"-agentlib:jdwp=transport=dt_socket,server=y,suspend={JVMDebugSuspendFlag},address={JVMDebugPort}\"")]
        public string JavaDebugOpts { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationHeapSize" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The Heap size (-Xmx) to be set when JVM will be created")]
        public string HeapSize { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationInitialHeapSize" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The initial Heap size (-Xms) to be set when JVM will be created")]
        public string InitialHeapSize { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationLogClassPath" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Set on command-line to print ClassPath")]
        public SwitchParameter LogClassPath { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationWriteEventsOnCmdLine" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Set on command-line to show events from the underlying JCOBridge engine")]
        public SwitchParameter WriteEventOrExceptionOnCmdLine { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationJVMExtraOptions" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Defines extra options to be passed to the starting JVM")]
        public string[] ExtraJVMOptions { get; set; }

        /// <inheritdoc cref="JNetCoreBase{TCore}.ApplicationJVMExtraOptions" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Defines extra options inkey=value format to be passed to the starting JVM")]
        public string[] ExtraJVMKVOptions { get; set; }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessCommand()
        {
            JNetPSHelper<TCore>.SetLicensePath(LicensePath);
            JNetPSHelper<TCore>.SetJDKHome(JDKHome);
            JNetPSHelper<TCore>.SetJVMPath(JVMPath);
            JNetPSHelper<TCore>.SetJNIVerbosity(JNIVerbosity);
            JNetPSHelper<TCore>.SetJNIOutputFile(JNIOutputFile);
            JNetPSHelper<TCore>.SetJmxPort(JmxPort);
            JNetPSHelper<TCore>.SetEnableDebug(EnableDebug.IsPresent);
            JNetPSHelper<TCore>.SetJavaDebugPort(JavaDebugPort);
            JNetPSHelper<TCore>.SetDebugSuspendFlag(DebugSuspendFlag);
            JNetPSHelper<TCore>.SetJavaDebugOpts(JavaDebugOpts);
            JNetPSHelper<TCore>.SetHeapSize(HeapSize);
            JNetPSHelper<TCore>.SetInitialHeapSize(InitialHeapSize);
            JNetPSHelper<TCore>.SetLogClassPath(LogClassPath.IsPresent);
            JNetPSHelper<TCore>.SetWriteEventOrExceptionOnCmdLine(WriteEventOrExceptionOnCmdLine.IsPresent);
            if (ExtraJVMOptions != null)
            {
                foreach (var item in ExtraJVMOptions)
                {
                    if (string.IsNullOrWhiteSpace(item)) continue;
                    AddJVMOption(item);
                }
            }
            if (ExtraJVMKVOptions != null)
            {
                foreach (var item in ExtraJVMKVOptions)
                {
                    if (string.IsNullOrWhiteSpace(item)) continue;
                    var index = item.IndexOf("=");

                    if (index != -1)
                    {
                        var key = item.Substring(index);
                        var value = item.Substring(index + 1, item.Length);
                        AddJVMOption(key, value);
                    }
                }
            }

            OnBeforeCreateGlobalInstance();
            CreateGlobalInstance();
            OnAfterCreateGlobalInstance();
        }
        /// <summary>
        /// Adds <paramref name="jvmOptionName"/>, with optional <paramref name="jvmOptionValue"/>, to <see cref="ApplicationJVMExtraOptions"/>
        /// </summary>
        /// <param name="jvmOptionName">The JVM option name</param>
        /// <param name="jvmOptionValue">The value of <paramref name="jvmOptionName"/> if it is an option like name=value</param>
        protected void AddJVMOption(string jvmOptionName, string jvmOptionValue = null)
        {
            if (string.IsNullOrWhiteSpace(jvmOptionName)) return;
            JNetPSHelper<TCore>.AddJVMOption(jvmOptionName, jvmOptionValue);
        }
        /// <summary>
        /// Executes the code before invoke <see cref="CreateGlobalInstance"/>
        /// </summary>
        protected virtual void OnBeforeCreateGlobalInstance() { }
        /// <summary>
        /// Invokes the <see cref="SetupJVMWrapper{TCore}.CreateGlobalInstance"/>
        /// </summary>
        protected virtual void CreateGlobalInstance() { JNetPSHelper<TCore>.CreateGlobalInstance(this); }
        /// <summary>
        /// Executes the code after invoke <see cref="CreateGlobalInstance"/>
        /// </summary>
        protected virtual void OnAfterCreateGlobalInstance() { }
    }
}
