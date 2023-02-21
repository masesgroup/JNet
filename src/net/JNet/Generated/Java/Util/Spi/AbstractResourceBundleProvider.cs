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

namespace Java.Util.Spi
{
    #region AbstractResourceBundleProvider
    public partial class AbstractResourceBundleProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Util.Spi.ResourceBundleProvider(Java.Util.Spi.AbstractResourceBundleProvider t) => t.Cast<Java.Util.Spi.ResourceBundleProvider>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/AbstractResourceBundleProvider.html#getBundle(java.lang.String,java.util.Locale)
        /// </summary>
        public Java.Util.ResourceBundle GetBundle(string arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Util.ResourceBundle>("getBundle", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}