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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.ModuleNs
{
    #region ResolvedModule
    public partial class ResolvedModule
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ResolvedModule.html#configuration()"/> 
        /// </summary>
        public Java.Lang.ModuleNs.Configuration Configuration
        {
            get { return IExecute<Java.Lang.ModuleNs.Configuration>("configuration"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ResolvedModule.html#name()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("name"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ResolvedModule.html#reads()"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.ModuleNs.ResolvedModule> Reads
        {
            get { return IExecute<Java.Util.Set<Java.Lang.ModuleNs.ResolvedModule>>("reads"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ResolvedModule.html#reference()"/> 
        /// </summary>
        public Java.Lang.ModuleNs.ModuleReference Reference
        {
            get { return IExecute<Java.Lang.ModuleNs.ModuleReference>("reference"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}