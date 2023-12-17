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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs.Renderable
{
    #region IContextualRenderedImageFactory
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IContextualRenderedImageFactory : Java.Awt.ImageNs.Renderable.IRenderedImageFactory
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#getPropertyNames()"/> 
        /// </summary>
        string[] PropertyNames { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#isDynamic()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsDynamic();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#getBounds2D(java.awt.image.renderable.ParameterBlock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.Renderable.ParameterBlock arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#mapRenderContext(int,java.awt.image.renderable.RenderContext,java.awt.image.renderable.ParameterBlock,java.awt.image.renderable.RenderableImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.Renderable.RenderableImage"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></returns>
        Java.Awt.ImageNs.Renderable.RenderContext MapRenderContext(int arg0, Java.Awt.ImageNs.Renderable.RenderContext arg1, Java.Awt.ImageNs.Renderable.ParameterBlock arg2, Java.Awt.ImageNs.Renderable.RenderableImage arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#create(java.awt.image.renderable.RenderContext,java.awt.image.renderable.ParameterBlock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        Java.Awt.ImageNs.RenderedImage Create(Java.Awt.ImageNs.Renderable.RenderContext arg0, Java.Awt.ImageNs.Renderable.ParameterBlock arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#getProperty(java.awt.image.renderable.ParameterBlock,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        object GetProperty(Java.Awt.ImageNs.Renderable.ParameterBlock arg0, string arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ContextualRenderedImageFactory
    public partial class ContextualRenderedImageFactory : Java.Awt.ImageNs.Renderable.IContextualRenderedImageFactory
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#getPropertyNames()"/> 
        /// </summary>
        public string[] PropertyNames
        {
            get { return IExecuteArray<string>("getPropertyNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#isDynamic()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDynamic()
        {
            return IExecute<bool>("isDynamic");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#getBounds2D(java.awt.image.renderable.ParameterBlock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.Renderable.ParameterBlock arg0)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getBounds2D", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#mapRenderContext(int,java.awt.image.renderable.RenderContext,java.awt.image.renderable.ParameterBlock,java.awt.image.renderable.RenderableImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.Renderable.RenderableImage"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></returns>
        public Java.Awt.ImageNs.Renderable.RenderContext MapRenderContext(int arg0, Java.Awt.ImageNs.Renderable.RenderContext arg1, Java.Awt.ImageNs.Renderable.ParameterBlock arg2, Java.Awt.ImageNs.Renderable.RenderableImage arg3)
        {
            return IExecute<Java.Awt.ImageNs.Renderable.RenderContext>("mapRenderContext", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#create(java.awt.image.renderable.RenderContext,java.awt.image.renderable.ParameterBlock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        public Java.Awt.ImageNs.RenderedImage Create(Java.Awt.ImageNs.Renderable.RenderContext arg0, Java.Awt.ImageNs.Renderable.ParameterBlock arg1)
        {
            return IExecute<Java.Awt.ImageNs.RenderedImage>("create", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#getProperty(java.awt.image.renderable.ParameterBlock,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(Java.Awt.ImageNs.Renderable.ParameterBlock arg0, string arg1)
        {
            return IExecute("getProperty", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}