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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Management
{
    #region MemoryUsage
    public partial class MemoryUsage
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryUsage.html#%3Cinit%3E(long,long,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public MemoryUsage(long arg0, long arg1, long arg2, long arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryUsage.html#from(javax.management.openmbean.CompositeData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        /// <returns><see cref="Java.Lang.Management.MemoryUsage"/></returns>
        public static Java.Lang.Management.MemoryUsage From(Javax.Management.Openmbean.CompositeData arg0)
        {
            return SExecute<Java.Lang.Management.MemoryUsage>(LocalBridgeClazz, "from", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryUsage.html#getCommitted()"/> 
        /// </summary>
        public long Committed
        {
            get { return IExecute<long>("getCommitted"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryUsage.html#getInit()"/> 
        /// </summary>
        public long Init
        {
            get { return IExecute<long>("getInit"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryUsage.html#getMax()"/> 
        /// </summary>
        public long Max
        {
            get { return IExecute<long>("getMax"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryUsage.html#getUsed()"/> 
        /// </summary>
        public long Used
        {
            get { return IExecute<long>("getUsed"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}