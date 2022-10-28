/*
*  Copyright 2022 MASES s.r.l.
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

namespace MASES.JNetPSCore.Cmdlet
{
    /// <summary>
    /// Base class to be extended in derived projects to add other parameters
    /// </summary>
    /// <typeparam name="T">A class based on <see cref="JNetCore{T}"/></typeparam>
    public abstract class StartJNetPSCmdletCommandBase<T> : PSCmdlet
        where T : JNetCore<T>
    {
        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationLicensePath" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The path where is located the license file")]
        public string LicensePath { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationJDKHome" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The path where is located the JRE of the installed JDK")]
        public string JDKHome { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationJVMPath" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The path to the JRE ennvironment or full path to (jvm.dll/libjvm.so). If not set the library try to find a suitable version on the system")]
        public string JVMPath { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationJNIVerbosity" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Sets the verbosity of the JNI interface. See oracle documentation")]
        public string JNIVerbosity { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationJNIOutputFile" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The path where the JNI verbose info will be written. The file will be opened in append mode")]
        public string JNIOutputFile { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationJmxPort" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The JMX port to be set when JVM will be created")]
        public short? JmxPort { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationEnableDebug" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Put in command line to enable JVM debug")]
        public bool? EnableDebug { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationJavaDebugPort" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The port to be used for debug when JVM will be created")]
        public short? JavaDebugPort { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationDebugSuspendFlag" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The suspend flag to be used in the debug option when JVM will be created. Default is \"n\"")]
        public string DebugSuspendFlag { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationJavaDebugOpts" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The string to be used in the debug option when JVM will be created. Default is \"-agentlib:jdwp=transport=dt_socket,server=y,suspend={JVMDebugSuspendFlag},address={JVMDebugPort}\"")]
        public string JavaDebugOpts { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationHeapSize" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The Heap size (-Xmx) to be set when JVM will be created")]
        public string HeapSize { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationInitialHeapSize" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The initial Heap size (-Xms) to be set when JVM will be created")]
        public string InitialHeapSize { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationLogClassPath" />
        [Parameter(
            // Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Set to true to print ClassPath")]
        public bool? LogClassPath { get; set; }

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin!");
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            JNetPSHelper<T>.SetLicensePath(LicensePath);
            JNetPSHelper<T>.SetJDKHome(JDKHome);
            JNetPSHelper<T>.SetJVMPath(JVMPath);
            JNetPSHelper<T>.SetJNIVerbosity(JNIVerbosity);
            JNetPSHelper<T>.SetJNIOutputFile(JNIOutputFile);
            JNetPSHelper<T>.SetJmxPort(JmxPort);
            JNetPSHelper<T>.SetEnableDebug(EnableDebug);
            JNetPSHelper<T>.SetJavaDebugPort(JavaDebugPort);
            JNetPSHelper<T>.SetDebugSuspendFlag(DebugSuspendFlag);
            JNetPSHelper<T>.SetJavaDebugOpts(JavaDebugOpts);
            JNetPSHelper<T>.SetHeapSize(HeapSize);
            JNetPSHelper<T>.SetInitialHeapSize(InitialHeapSize);

            OnBeforeCreateGlobalInstance();
            CreateGlobalInstance();
            OnAfterCreateGlobalInstance();
        }
        /// <summary>
        /// Executes the code before invoke <see cref="CreateGlobalInstance"/>
        /// </summary>
        public virtual void OnBeforeCreateGlobalInstance() { }
        /// <summary>
        /// Invokes the <see cref="SetupJVMWrapper{T}.CreateGlobalInstance"/>
        /// </summary>
        public virtual void CreateGlobalInstance() { JNetPSHelper<T>.CreateGlobalInstance(); }
        /// <summary>
        /// Executes the code after invoke <see cref="CreateGlobalInstance"/>
        /// </summary>
        public virtual void OnAfterCreateGlobalInstance() { }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}
