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
using System.Reflection;

namespace MASES.JNetPSCore.Cmdlet
{
    public abstract class StartJNetPSCmdletCommandBase<T> : PSCmdlet
        where T : JNetCore<T>
    {
        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationLicensePath" />
        [Parameter(
            // Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The path where is located the license file")]
        public string LicensePath { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationJDKHome" />
        [Parameter(
            // Mandatory = true,
            Position = 1,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The path where is located the JRE of the installed JDK")]
        public string JDKHome { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationJVMPath" />
        [Parameter(
            // Mandatory = true,
            Position = 2,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The path to the JRE ennvironment or full path to (jvm.dll/libjvm.so). If not set the library try to find a suitable version on the system")]
        public string JVMPath { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationJNIVerbosity" />
        [Parameter(
            // Mandatory = true,
            Position = 3,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Sets the verbosity of the JNI interface. See oracle documentation")]
        public string JNIVerbosity { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationJNIOutputFile" />
        [Parameter(
            // Mandatory = true,
            Position = 4,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The path where the JNI verbose info will be written. The file will be opened in append mode")]
        public string JNIOutputFile { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationJmxPort" />
        [Parameter(
            // Mandatory = true,
            Position = 5,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The JMX port to be set when JVM will be created")]
        public short? JmxPort { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationEnableDebug" />
        [Parameter(
            // Mandatory = true,
            Position = 6,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Put in command line to enable JVM debug")]
        public bool? EnableDebug { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationJavaDebugPort" />
        [Parameter(
            // Mandatory = true,
            Position = 7,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The port to be used for debug when JVM will be created")]
        public short? JavaDebugPort { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationDebugSuspendFlag" />
        [Parameter(
            // Mandatory = true,
            Position = 8,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The suspend flag to be used in the debug option when JVM will be created. Default is \"n\"")]
        public string DebugSuspendFlag { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationJavaDebugOpts" />
        [Parameter(
            // Mandatory = true,
            Position = 9,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The string to be used in the debug option when JVM will be created. Default is \"-agentlib:jdwp=transport=dt_socket,server=y,suspend={JVMDebugSuspendFlag},address={JVMDebugPort}\"")]
        public string JavaDebugOpts { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationHeapSize" />
        [Parameter(
            // Mandatory = true,
            Position = 10,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The Heap size (-Xmx) to be set when JVM will be created")]
        public string HeapSize { get; set; }

        /// <inheritdoc cref="JNetCoreBase{T}.ApplicationInitialHeapSize" />
        [Parameter(
            // Mandatory = true,
            Position = 11,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The initial Heap size (-Xms) to be set when JVM will be created")]
        public string InitialHeapSize { get; set; }

        private static readonly PropertyInfo ApplicationLicensePathProperty = typeof(T).TraverseUntil(typeof(JNetCoreBase<>)).GetProperty(nameof(JNetCore.ApplicationLicensePath));
        private static readonly PropertyInfo ApplicationJDKHomeProperty = typeof(T).TraverseUntil(typeof(JNetCoreBase<>)).GetProperty(nameof(JNetCore.ApplicationJDKHome));
        private static readonly PropertyInfo ApplicationJVMPathProperty = typeof(T).TraverseUntil(typeof(JNetCoreBase<>)).GetProperty(nameof(JNetCore.ApplicationJVMPath));
        private static readonly PropertyInfo ApplicationJNIVerbosityProperty = typeof(T).TraverseUntil(typeof(JNetCoreBase<>)).GetProperty(nameof(JNetCore.ApplicationJNIVerbosity));
        private static readonly PropertyInfo ApplicationJNIOutputFileProperty = typeof(T).TraverseUntil(typeof(JNetCoreBase<>)).GetProperty(nameof(JNetCore.ApplicationJNIOutputFile));
        private static readonly PropertyInfo ApplicationJmxPortProperty = typeof(T).TraverseUntil(typeof(JNetCoreBase<>)).GetProperty(nameof(JNetCore.ApplicationJmxPort));
        private static readonly PropertyInfo ApplicationEnableDebugProperty = typeof(T).TraverseUntil(typeof(JNetCoreBase<>)).GetProperty(nameof(JNetCore.ApplicationEnableDebug));
        private static readonly PropertyInfo ApplicationJavaDebugPortProperty = typeof(T).TraverseUntil(typeof(JNetCoreBase<>)).GetProperty(nameof(JNetCore.ApplicationJavaDebugPort));
        private static readonly PropertyInfo ApplicationDebugSuspendFlagProperty = typeof(T).TraverseUntil(typeof(JNetCoreBase<>)).GetProperty(nameof(JNetCore.ApplicationDebugSuspendFlag));
        private static readonly PropertyInfo ApplicationJavaDebugOptsProperty = typeof(T).TraverseUntil(typeof(JNetCoreBase<>)).GetProperty(nameof(JNetCore.ApplicationJavaDebugOpts));
        private static readonly PropertyInfo ApplicationHeapSizeProperty = typeof(T).TraverseUntil(typeof(JNetCoreBase<>)).GetProperty(nameof(JNetCore.ApplicationHeapSize));
        private static readonly PropertyInfo ApplicationInitialHeapSizeProperty = typeof(T).TraverseUntil(typeof(JNetCoreBase<>)).GetProperty(nameof(JNetCore.ApplicationInitialHeapSize));

        private static readonly MethodInfo CreateGlobalInstanceMethod = typeof(T).TraverseUntil(typeof(SetupJVMWrapper<>)).GetMethod(nameof(JNetCore.CreateGlobalInstance));

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin!");
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            ApplicationLicensePathProperty.SetValue(null, LicensePath);
            ApplicationJDKHomeProperty.SetValue(null, JDKHome);
            ApplicationJVMPathProperty.SetValue(null, JVMPath);
            ApplicationJNIVerbosityProperty.SetValue(null, JNIVerbosity);
            ApplicationJNIOutputFileProperty.SetValue(null, JNIOutputFile);
            ApplicationJmxPortProperty.SetValue(null, JmxPort);
            ApplicationEnableDebugProperty.SetValue(null, EnableDebug);
            ApplicationJavaDebugPortProperty.SetValue(null, JavaDebugPort);
            ApplicationDebugSuspendFlagProperty.SetValue(null, DebugSuspendFlag);
            ApplicationJavaDebugOptsProperty.SetValue(null, JavaDebugOpts);
            ApplicationHeapSizeProperty.SetValue(null, HeapSize);
            ApplicationInitialHeapSizeProperty.SetValue(null, InitialHeapSize);

            OnBeforeCreateGlobalInstance();
            CreateGlobalInstance();
        }
        /// <summary>
        /// Executes the code before invoke <see cref="CreateGlobalInstance"/>
        /// </summary>
        public virtual void OnBeforeCreateGlobalInstance() { }
        /// <summary>
        /// Invokes 
        /// </summary>
        public virtual void CreateGlobalInstance() { CreateGlobalInstanceMethod.Invoke(null, null); }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}
