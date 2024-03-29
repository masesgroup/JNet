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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Management
{
    #region IOperatingSystemMXBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IOperatingSystemMXBean : Java.Lang.Management.IPlatformManagedObject
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getArch()"/> 
        /// </summary>
        Java.Lang.String Arch { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getAvailableProcessors()"/> 
        /// </summary>
        int AvailableProcessors { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getName()"/> 
        /// </summary>
        Java.Lang.String Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getSystemLoadAverage()"/> 
        /// </summary>
        double SystemLoadAverage { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getVersion()"/> 
        /// </summary>
        Java.Lang.String Version { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OperatingSystemMXBean
    public partial class OperatingSystemMXBean : Java.Lang.Management.IOperatingSystemMXBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getArch()"/> 
        /// </summary>
        public Java.Lang.String Arch
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getArch", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getAvailableProcessors()"/> 
        /// </summary>
        public int AvailableProcessors
        {
            get { return IExecuteWithSignature<int>("getAvailableProcessors", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getSystemLoadAverage()"/> 
        /// </summary>
        public double SystemLoadAverage
        {
            get { return IExecuteWithSignature<double>("getSystemLoadAverage", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/OperatingSystemMXBean.html#getVersion()"/> 
        /// </summary>
        public Java.Lang.String Version
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVersion", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}