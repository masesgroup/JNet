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

/*
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Management
{
    #region IRuntimeMXBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRuntimeMXBean : Java.Lang.Management.IPlatformManagedObject
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getBootClassPath()"/> 
        /// </summary>
        string BootClassPath { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getClassPath()"/> 
        /// </summary>
        string ClassPath { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getInputArguments()"/> 
        /// </summary>
        Java.Util.List<string> InputArguments { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getLibraryPath()"/> 
        /// </summary>
        string LibraryPath { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getManagementSpecVersion()"/> 
        /// </summary>
        string ManagementSpecVersion { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getName()"/> 
        /// </summary>
        string Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getPid()"/> 
        /// </summary>
        long Pid { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSpecName()"/> 
        /// </summary>
        string SpecName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSpecVendor()"/> 
        /// </summary>
        string SpecVendor { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSpecVersion()"/> 
        /// </summary>
        string SpecVersion { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getStartTime()"/> 
        /// </summary>
        long StartTime { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSystemProperties()"/> 
        /// </summary>
        Java.Util.Map<string, string> SystemProperties { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getUptime()"/> 
        /// </summary>
        long Uptime { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getVmName()"/> 
        /// </summary>
        string VmName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getVmVendor()"/> 
        /// </summary>
        string VmVendor { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getVmVersion()"/> 
        /// </summary>
        string VmVersion { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#isBootClassPathSupported()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsBootClassPathSupported();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RuntimeMXBean
    public partial class RuntimeMXBean : Java.Lang.Management.IRuntimeMXBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getBootClassPath()"/> 
        /// </summary>
        public string BootClassPath
        {
            get { return IExecute<string>("getBootClassPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getClassPath()"/> 
        /// </summary>
        public string ClassPath
        {
            get { return IExecute<string>("getClassPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getInputArguments()"/> 
        /// </summary>
        public Java.Util.List<string> InputArguments
        {
            get { return IExecute<Java.Util.List<string>>("getInputArguments"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getLibraryPath()"/> 
        /// </summary>
        public string LibraryPath
        {
            get { return IExecute<string>("getLibraryPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getManagementSpecVersion()"/> 
        /// </summary>
        public string ManagementSpecVersion
        {
            get { return IExecute<string>("getManagementSpecVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getPid()"/> 
        /// </summary>
        public long Pid
        {
            get { return IExecute<long>("getPid"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSpecName()"/> 
        /// </summary>
        public string SpecName
        {
            get { return IExecute<string>("getSpecName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSpecVendor()"/> 
        /// </summary>
        public string SpecVendor
        {
            get { return IExecute<string>("getSpecVendor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSpecVersion()"/> 
        /// </summary>
        public string SpecVersion
        {
            get { return IExecute<string>("getSpecVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getStartTime()"/> 
        /// </summary>
        public long StartTime
        {
            get { return IExecute<long>("getStartTime"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSystemProperties()"/> 
        /// </summary>
        public Java.Util.Map<string, string> SystemProperties
        {
            get { return IExecute<Java.Util.Map<string, string>>("getSystemProperties"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getUptime()"/> 
        /// </summary>
        public long Uptime
        {
            get { return IExecute<long>("getUptime"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getVmName()"/> 
        /// </summary>
        public string VmName
        {
            get { return IExecute<string>("getVmName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getVmVendor()"/> 
        /// </summary>
        public string VmVendor
        {
            get { return IExecute<string>("getVmVendor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getVmVersion()"/> 
        /// </summary>
        public string VmVersion
        {
            get { return IExecute<string>("getVmVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#isBootClassPathSupported()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsBootClassPathSupported()
        {
            return IExecute<bool>("isBootClassPathSupported");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}