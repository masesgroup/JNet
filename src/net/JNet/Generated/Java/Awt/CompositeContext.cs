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

namespace Java.Awt
{
    #region ICompositeContext
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICompositeContext
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CompositeContext.html#compose(java.awt.image.Raster,java.awt.image.Raster,java.awt.image.WritableRaster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        void Compose(Java.Awt.ImageNs.Raster arg0, Java.Awt.ImageNs.Raster arg1, Java.Awt.ImageNs.WritableRaster arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CompositeContext.html#dispose()"/>
        /// </summary>
        void Dispose();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CompositeContext
    public partial class CompositeContext : Java.Awt.ICompositeContext
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CompositeContext.html#compose(java.awt.image.Raster,java.awt.image.Raster,java.awt.image.WritableRaster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        public void Compose(Java.Awt.ImageNs.Raster arg0, Java.Awt.ImageNs.Raster arg1, Java.Awt.ImageNs.WritableRaster arg2)
        {
            IExecute("compose", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CompositeContext.html#dispose()"/>
        /// </summary>
        public new void Dispose()
        {
            IExecuteWithSignature("dispose", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}