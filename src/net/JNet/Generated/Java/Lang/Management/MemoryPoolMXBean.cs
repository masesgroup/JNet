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
    #region IMemoryPoolMXBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMemoryPoolMXBean : Java.Lang.Management.IPlatformManagedObject
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getCollectionUsage()"/> 
        /// </summary>
        Java.Lang.Management.MemoryUsage CollectionUsage { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getCollectionUsageThreshold()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#setCollectionUsageThreshold(long)"/>
        /// </summary>
        long CollectionUsageThreshold { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getCollectionUsageThresholdCount()"/> 
        /// </summary>
        long CollectionUsageThresholdCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getMemoryManagerNames()"/> 
        /// </summary>
        string[] MemoryManagerNames { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getName()"/> 
        /// </summary>
        string Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getPeakUsage()"/> 
        /// </summary>
        Java.Lang.Management.MemoryUsage PeakUsage { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getType()"/> 
        /// </summary>
        Java.Lang.Management.MemoryType Type { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getUsage()"/> 
        /// </summary>
        Java.Lang.Management.MemoryUsage Usage { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getUsageThreshold()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#setUsageThreshold(long)"/>
        /// </summary>
        long UsageThreshold { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getUsageThresholdCount()"/> 
        /// </summary>
        long UsageThresholdCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#isCollectionUsageThresholdExceeded()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsCollectionUsageThresholdExceeded();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#isCollectionUsageThresholdSupported()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsCollectionUsageThresholdSupported();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#isUsageThresholdExceeded()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsUsageThresholdExceeded();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#isUsageThresholdSupported()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsUsageThresholdSupported();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#isValid()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsValid();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#resetPeakUsage()"/>
        /// </summary>
        void ResetPeakUsage();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MemoryPoolMXBean
    public partial class MemoryPoolMXBean : Java.Lang.Management.IMemoryPoolMXBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getCollectionUsage()"/> 
        /// </summary>
        public Java.Lang.Management.MemoryUsage CollectionUsage
        {
            get { return IExecute<Java.Lang.Management.MemoryUsage>("getCollectionUsage"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getCollectionUsageThreshold()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#setCollectionUsageThreshold(long)"/>
        /// </summary>
        public long CollectionUsageThreshold
        {
            get { return IExecute<long>("getCollectionUsageThreshold"); } set { IExecute("setCollectionUsageThreshold", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getCollectionUsageThresholdCount()"/> 
        /// </summary>
        public long CollectionUsageThresholdCount
        {
            get { return IExecute<long>("getCollectionUsageThresholdCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getMemoryManagerNames()"/> 
        /// </summary>
        public string[] MemoryManagerNames
        {
            get { return IExecuteArray<string>("getMemoryManagerNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getPeakUsage()"/> 
        /// </summary>
        public Java.Lang.Management.MemoryUsage PeakUsage
        {
            get { return IExecute<Java.Lang.Management.MemoryUsage>("getPeakUsage"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getType()"/> 
        /// </summary>
        public Java.Lang.Management.MemoryType Type
        {
            get { return IExecute<Java.Lang.Management.MemoryType>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getUsage()"/> 
        /// </summary>
        public Java.Lang.Management.MemoryUsage Usage
        {
            get { return IExecute<Java.Lang.Management.MemoryUsage>("getUsage"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getUsageThreshold()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#setUsageThreshold(long)"/>
        /// </summary>
        public long UsageThreshold
        {
            get { return IExecute<long>("getUsageThreshold"); } set { IExecute("setUsageThreshold", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#getUsageThresholdCount()"/> 
        /// </summary>
        public long UsageThresholdCount
        {
            get { return IExecute<long>("getUsageThresholdCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#isCollectionUsageThresholdExceeded()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCollectionUsageThresholdExceeded()
        {
            return IExecute<bool>("isCollectionUsageThresholdExceeded");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#isCollectionUsageThresholdSupported()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCollectionUsageThresholdSupported()
        {
            return IExecute<bool>("isCollectionUsageThresholdSupported");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#isUsageThresholdExceeded()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsUsageThresholdExceeded()
        {
            return IExecute<bool>("isUsageThresholdExceeded");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#isUsageThresholdSupported()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsUsageThresholdSupported()
        {
            return IExecute<bool>("isUsageThresholdSupported");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#isValid()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsValid()
        {
            return IExecute<bool>("isValid");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryPoolMXBean.html#resetPeakUsage()"/>
        /// </summary>
        public void ResetPeakUsage()
        {
            IExecute("resetPeakUsage");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}