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

namespace Java.Awt.ImageNs.Renderable
{
    #region IRenderableImage
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRenderableImage
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getHeight()"/> 
        /// </summary>
        float Height { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getMinX()"/> 
        /// </summary>
        float MinX { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getMinY()"/> 
        /// </summary>
        float MinY { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getPropertyNames()"/> 
        /// </summary>
        string[] PropertyNames { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getSources()"/> 
        /// </summary>
        Java.Util.Vector<Java.Awt.ImageNs.Renderable.RenderableImage> Sources { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getWidth()"/> 
        /// </summary>
        float Width { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#isDynamic()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsDynamic();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#createDefaultRendering()"/>
        /// </summary>

        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        Java.Awt.ImageNs.RenderedImage CreateDefaultRendering();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#createRendering(java.awt.image.renderable.RenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        Java.Awt.ImageNs.RenderedImage CreateRendering(Java.Awt.ImageNs.Renderable.RenderContext arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#createScaledRendering(int,int,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.RenderingHints"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        Java.Awt.ImageNs.RenderedImage CreateScaledRendering(int arg0, int arg1, Java.Awt.RenderingHints arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        object GetProperty(string arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RenderableImage
    public partial class RenderableImage : Java.Awt.ImageNs.Renderable.IRenderableImage
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#HINTS_OBSERVED"/>
        /// </summary>
        public static string HINTS_OBSERVED { get { if (!_HINTS_OBSERVEDReady) { _HINTS_OBSERVEDContent = SGetField<string>(LocalBridgeClazz, "HINTS_OBSERVED"); _HINTS_OBSERVEDReady = true; } return _HINTS_OBSERVEDContent; } }
        private static string _HINTS_OBSERVEDContent = default;
        private static bool _HINTS_OBSERVEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getHeight()"/> 
        /// </summary>
        public float Height
        {
            get { return IExecute<float>("getHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getMinX()"/> 
        /// </summary>
        public float MinX
        {
            get { return IExecute<float>("getMinX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getMinY()"/> 
        /// </summary>
        public float MinY
        {
            get { return IExecute<float>("getMinY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getPropertyNames()"/> 
        /// </summary>
        public string[] PropertyNames
        {
            get { return IExecuteArray<string>("getPropertyNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getSources()"/> 
        /// </summary>
        public Java.Util.Vector<Java.Awt.ImageNs.Renderable.RenderableImage> Sources
        {
            get { return IExecute<Java.Util.Vector<Java.Awt.ImageNs.Renderable.RenderableImage>>("getSources"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getWidth()"/> 
        /// </summary>
        public float Width
        {
            get { return IExecute<float>("getWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#isDynamic()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDynamic()
        {
            return IExecute<bool>("isDynamic");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#createDefaultRendering()"/>
        /// </summary>

        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        public Java.Awt.ImageNs.RenderedImage CreateDefaultRendering()
        {
            return IExecute<Java.Awt.ImageNs.RenderedImage>("createDefaultRendering");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#createRendering(java.awt.image.renderable.RenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        public Java.Awt.ImageNs.RenderedImage CreateRendering(Java.Awt.ImageNs.Renderable.RenderContext arg0)
        {
            return IExecute<Java.Awt.ImageNs.RenderedImage>("createRendering", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#createScaledRendering(int,int,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.RenderingHints"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        public Java.Awt.ImageNs.RenderedImage CreateScaledRendering(int arg0, int arg1, Java.Awt.RenderingHints arg2)
        {
            return IExecute<Java.Awt.ImageNs.RenderedImage>("createScaledRendering", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}