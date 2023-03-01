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

namespace Java.Lang.Management
{
    #region RuntimeMXBean
    public partial class RuntimeMXBean
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Management.RuntimeMXBean"/> to <see cref="Java.Lang.Management.PlatformManagedObject"/>
        /// </summary>
        public static implicit operator Java.Lang.Management.PlatformManagedObject(Java.Lang.Management.RuntimeMXBean t) => t.Cast<Java.Lang.Management.PlatformManagedObject>();
        
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
        public Java.Util.List InputArguments
        {
            get { return IExecute<Java.Util.List>("getInputArguments"); }
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
        public Java.Util.Map SystemProperties
        {
            get { return IExecute<Java.Util.Map>("getSystemProperties"); }
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
        
        /// <returns><see langword="bool"/></returns>
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