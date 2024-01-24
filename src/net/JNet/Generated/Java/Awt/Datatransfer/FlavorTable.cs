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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Datatransfer
{
    #region IFlavorTable
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IFlavorTable : Java.Awt.Datatransfer.IFlavorMap
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/FlavorTable.html#getFlavorsForNative(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        Java.Util.List<Java.Awt.Datatransfer.DataFlavor> GetFlavorsForNative(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/FlavorTable.html#getNativesForFlavor(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        Java.Util.List<string> GetNativesForFlavor(Java.Awt.Datatransfer.DataFlavor arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region FlavorTable
    public partial class FlavorTable : Java.Awt.Datatransfer.IFlavorTable
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/FlavorTable.html#getFlavorsForNative(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Awt.Datatransfer.DataFlavor> GetFlavorsForNative(string arg0)
        {
            return IExecute<Java.Util.List<Java.Awt.Datatransfer.DataFlavor>>("getFlavorsForNative", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/FlavorTable.html#getNativesForFlavor(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<string> GetNativesForFlavor(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return IExecute<Java.Util.List<string>>("getNativesForFlavor", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}