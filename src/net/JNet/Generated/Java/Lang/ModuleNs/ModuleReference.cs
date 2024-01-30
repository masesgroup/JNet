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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.ModuleNs
{
    #region ModuleReference
    public partial class ModuleReference
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleReference.html#open()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.ModuleNs.ModuleReader"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.ModuleNs.ModuleReader Open()
        {
            return IExecute<Java.Lang.ModuleNs.ModuleReader>("open");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleReference.html#descriptor()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor"/></returns>
        public Java.Lang.ModuleNs.ModuleDescriptor Descriptor()
        {
            return IExecute<Java.Lang.ModuleNs.ModuleDescriptor>("descriptor");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleReference.html#location()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Net.URI> Location()
        {
            return IExecute<Java.Util.Optional<Java.Net.URI>>("location");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}