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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Management
{
    #region MemoryMXBean
    public partial class MemoryMXBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryMXBean.html#getHeapMemoryUsage()"/> 
        /// </summary>
        public Java.Lang.Management.MemoryUsage HeapMemoryUsage
        {
            get { return IExecute<Java.Lang.Management.MemoryUsage>("getHeapMemoryUsage"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryMXBean.html#getNonHeapMemoryUsage()"/> 
        /// </summary>
        public Java.Lang.Management.MemoryUsage NonHeapMemoryUsage
        {
            get { return IExecute<Java.Lang.Management.MemoryUsage>("getNonHeapMemoryUsage"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryMXBean.html#getObjectPendingFinalizationCount()"/> 
        /// </summary>
        public int ObjectPendingFinalizationCount
        {
            get { return IExecute<int>("getObjectPendingFinalizationCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryMXBean.html#isVerbose()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsVerbose()
        {
            return IExecute<bool>("isVerbose");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryMXBean.html#gc()"/>
        /// </summary>
        public void Gc()
        {
            IExecute("gc");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryMXBean.html#setVerbose(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetVerbose(bool arg0)
        {
            IExecute("setVerbose", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}