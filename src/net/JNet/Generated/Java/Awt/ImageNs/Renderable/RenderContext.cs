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

namespace Java.Awt.ImageNs.Renderable
{
    #region RenderContext
    public partial class RenderContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderContext.html#%3Cinit%3E(java.awt.geom.AffineTransform,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg1"><see cref="Java.Awt.RenderingHints"/></param>
        public RenderContext(Java.Awt.Geom.AffineTransform arg0, Java.Awt.RenderingHints arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderContext.html#%3Cinit%3E(java.awt.geom.AffineTransform,java.awt.Shape,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Shape"/></param>
        /// <param name="arg2"><see cref="Java.Awt.RenderingHints"/></param>
        public RenderContext(Java.Awt.Geom.AffineTransform arg0, Java.Awt.Shape arg1, Java.Awt.RenderingHints arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderContext.html#%3Cinit%3E(java.awt.geom.AffineTransform,java.awt.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Shape"/></param>
        public RenderContext(Java.Awt.Geom.AffineTransform arg0, Java.Awt.Shape arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderContext.html#%3Cinit%3E(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public RenderContext(Java.Awt.Geom.AffineTransform arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderContext.html#getAreaOfInterest()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderContext.html#setAreaOfInterest(java.awt.Shape)"/>
        /// </summary>
        public Java.Awt.Shape AreaOfInterest
        {
            get { return IExecuteWithSignature<Java.Awt.Shape>("getAreaOfInterest", "()Ljava/awt/Shape;"); } set { IExecuteWithSignature("setAreaOfInterest", "(Ljava/awt/Shape;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderContext.html#getRenderingHints()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderContext.html#setRenderingHints(java.awt.RenderingHints)"/>
        /// </summary>
        public Java.Awt.RenderingHints RenderingHints
        {
            get { return IExecuteWithSignature<Java.Awt.RenderingHints>("getRenderingHints", "()Ljava/awt/RenderingHints;"); } set { IExecuteWithSignature("setRenderingHints", "(Ljava/awt/RenderingHints;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderContext.html#getTransform()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderContext.html#setTransform(java.awt.geom.AffineTransform)"/>
        /// </summary>
        public Java.Awt.Geom.AffineTransform Transform
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.AffineTransform>("getTransform", "()Ljava/awt/geom/AffineTransform;"); } set { IExecuteWithSignature("setTransform", "(Ljava/awt/geom/AffineTransform;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderContext.html#concatenateTransform(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public void ConcatenateTransform(Java.Awt.Geom.AffineTransform arg0)
        {
            IExecuteWithSignature("concatenateTransform", "(Ljava/awt/geom/AffineTransform;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderContext.html#preConcatenateTransform(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public void PreConcatenateTransform(Java.Awt.Geom.AffineTransform arg0)
        {
            IExecuteWithSignature("preConcatenateTransform", "(Ljava/awt/geom/AffineTransform;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}