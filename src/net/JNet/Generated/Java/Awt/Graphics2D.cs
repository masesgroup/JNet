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
    #region Graphics2D
    public partial class Graphics2D
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#getBackground()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#setBackground(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color Background
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getBackground", "()Ljava/awt/Color;"); } set { IExecuteWithSignature("setBackground", "(Ljava/awt/Color;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#getComposite()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#setComposite(java.awt.Composite)"/>
        /// </summary>
        public Java.Awt.Composite Composite
        {
            get { return IExecuteWithSignature<Java.Awt.Composite>("getComposite", "()Ljava/awt/Composite;"); } set { IExecuteWithSignature("setComposite", "(Ljava/awt/Composite;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#getDeviceConfiguration()"/> 
        /// </summary>
        public Java.Awt.GraphicsConfiguration DeviceConfiguration
        {
            get { return IExecuteWithSignature<Java.Awt.GraphicsConfiguration>("getDeviceConfiguration", "()Ljava/awt/GraphicsConfiguration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#getFontRenderContext()"/> 
        /// </summary>
        public Java.Awt.FontNs.FontRenderContext FontRenderContext
        {
            get { return IExecuteWithSignature<Java.Awt.FontNs.FontRenderContext>("getFontRenderContext", "()Ljava/awt/font/FontRenderContext;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#getPaint()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#setPaint(java.awt.Paint)"/>
        /// </summary>
        public Java.Awt.Paint Paint
        {
            get { return IExecuteWithSignature<Java.Awt.Paint>("getPaint", "()Ljava/awt/Paint;"); } set { IExecuteWithSignature("setPaint", "(Ljava/awt/Paint;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#getRenderingHints()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#setRenderingHints(java.util.Map)"/>
        /// </summary>
        public Java.Awt.RenderingHints RenderingHints
        {
            get { return IExecuteWithSignature<Java.Awt.RenderingHints>("getRenderingHints", "()Ljava/awt/RenderingHints;"); } set { IExecuteWithSignature("setRenderingHints", "(Ljava/util/Map;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#getStroke()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#setStroke(java.awt.Stroke)"/>
        /// </summary>
        public Java.Awt.Stroke Stroke
        {
            get { return IExecuteWithSignature<Java.Awt.Stroke>("getStroke", "()Ljava/awt/Stroke;"); } set { IExecuteWithSignature("setStroke", "(Ljava/awt/Stroke;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#drawImage(java.awt.Image,java.awt.geom.AffineTransform,java.awt.image.ImageObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageNs.ImageObserver"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DrawImage(Java.Awt.Image arg0, Java.Awt.Geom.AffineTransform arg1, Java.Awt.ImageNs.ImageObserver arg2)
        {
            return IExecute<bool>("drawImage", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#hit(java.awt.Rectangle,java.awt.Shape,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Shape"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Hit(Java.Awt.Rectangle arg0, Java.Awt.Shape arg1, bool arg2)
        {
            return IExecute<bool>("hit", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#getTransform()"/>
        /// </summary>

        /// <returns><see cref="Java.Awt.Geom.AffineTransform"/></returns>
        public Java.Awt.Geom.AffineTransform GetTransform()
        {
            return IExecuteWithSignature<Java.Awt.Geom.AffineTransform>("getTransform", "()Ljava/awt/geom/AffineTransform;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#getRenderingHint(java.awt.RenderingHints.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.RenderingHints.Key"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetRenderingHint(Java.Awt.RenderingHints.Key arg0)
        {
            return IExecuteWithSignature("getRenderingHint", "(Ljava/awt/RenderingHints$Key;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#addRenderingHints(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void AddRenderingHints(Java.Util.Map<object, object> arg0)
        {
            IExecuteWithSignature("addRenderingHints", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#clip(java.awt.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Shape"/></param>
        public void Clip(Java.Awt.Shape arg0)
        {
            IExecuteWithSignature("clip", "(Ljava/awt/Shape;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#draw(java.awt.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Shape"/></param>
        public void Draw(Java.Awt.Shape arg0)
        {
            IExecuteWithSignature("draw", "(Ljava/awt/Shape;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#drawGlyphVector(java.awt.font.GlyphVector,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.GlyphVector"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void DrawGlyphVector(Java.Awt.FontNs.GlyphVector arg0, float arg1, float arg2)
        {
            IExecute("drawGlyphVector", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#drawImage(java.awt.image.BufferedImage,java.awt.image.BufferedImageOp,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImageOp"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void DrawImage(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.BufferedImageOp arg1, int arg2, int arg3)
        {
            IExecute("drawImage", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#drawRenderableImage(java.awt.image.renderable.RenderableImage,java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.RenderableImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public void DrawRenderableImage(Java.Awt.ImageNs.Renderable.RenderableImage arg0, Java.Awt.Geom.AffineTransform arg1)
        {
            IExecute("drawRenderableImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#drawRenderedImage(java.awt.image.RenderedImage,java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public void DrawRenderedImage(Java.Awt.ImageNs.RenderedImage arg0, Java.Awt.Geom.AffineTransform arg1)
        {
            IExecute("drawRenderedImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#drawString(java.lang.String,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void DrawString(Java.Lang.String arg0, float arg1, float arg2)
        {
            IExecute("drawString", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#drawString(java.text.AttributedCharacterIterator,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void DrawString(Java.Text.AttributedCharacterIterator arg0, float arg1, float arg2)
        {
            IExecute("drawString", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#fill(java.awt.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Shape"/></param>
        public void Fill(Java.Awt.Shape arg0)
        {
            IExecuteWithSignature("fill", "(Ljava/awt/Shape;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#rotate(double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        public void Rotate(double arg0, double arg1, double arg2)
        {
            IExecute("rotate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#rotate(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void Rotate(double arg0)
        {
            IExecuteWithSignature("rotate", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#scale(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void Scale(double arg0, double arg1)
        {
            IExecute("scale", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#setRenderingHint(java.awt.RenderingHints.Key,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.RenderingHints.Key"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void SetRenderingHint(Java.Awt.RenderingHints.Key arg0, object arg1)
        {
            IExecute("setRenderingHint", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#setTransform(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public void SetTransform(Java.Awt.Geom.AffineTransform arg0)
        {
            IExecuteWithSignature("setTransform", "(Ljava/awt/geom/AffineTransform;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#shear(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void Shear(double arg0, double arg1)
        {
            IExecute("shear", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#transform(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public void Transform(Java.Awt.Geom.AffineTransform arg0)
        {
            IExecuteWithSignature("transform", "(Ljava/awt/geom/AffineTransform;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Graphics2D.html#translate(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void Translate(double arg0, double arg1)
        {
            IExecute("translate", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}