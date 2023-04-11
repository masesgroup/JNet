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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region Color
    public partial class Color
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#%3Cinit%3E(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public Color(float arg0, float arg1, float arg2, float arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#%3Cinit%3E(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public Color(float arg0, float arg1, float arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#%3Cinit%3E(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public Color(int arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#%3Cinit%3E(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public Color(int arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public Color(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Color(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#%3Cinit%3E(java.awt.color.ColorSpace,float[],float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ColorNs.ColorSpace"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public Color(Java.Awt.ColorNs.ColorSpace arg0, float[] arg1, float arg2)
            : base(arg0, arg1, arg2)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Color"/> to <see cref="Java.Awt.Paint"/>
        /// </summary>
        public static implicit operator Java.Awt.Paint(Java.Awt.Color t) => t.Cast<Java.Awt.Paint>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Color"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.Color t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#black"/>
        /// </summary>
        public static Java.Awt.Color black => Clazz.GetField<Java.Awt.Color>("black");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#BLACK"/>
        /// </summary>
        public static Java.Awt.Color BLACK => Clazz.GetField<Java.Awt.Color>("BLACK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#blue"/>
        /// </summary>
        public static Java.Awt.Color blue => Clazz.GetField<Java.Awt.Color>("blue");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#BLUE"/>
        /// </summary>
        public static Java.Awt.Color BLUE => Clazz.GetField<Java.Awt.Color>("BLUE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#cyan"/>
        /// </summary>
        public static Java.Awt.Color cyan => Clazz.GetField<Java.Awt.Color>("cyan");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#CYAN"/>
        /// </summary>
        public static Java.Awt.Color CYAN => Clazz.GetField<Java.Awt.Color>("CYAN");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#DARK_GRAY"/>
        /// </summary>
        public static Java.Awt.Color DARK_GRAY => Clazz.GetField<Java.Awt.Color>("DARK_GRAY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#darkGray"/>
        /// </summary>
        public static Java.Awt.Color darkGray => Clazz.GetField<Java.Awt.Color>("darkGray");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#gray"/>
        /// </summary>
        public static Java.Awt.Color gray => Clazz.GetField<Java.Awt.Color>("gray");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#GRAY"/>
        /// </summary>
        public static Java.Awt.Color GRAY => Clazz.GetField<Java.Awt.Color>("GRAY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#green"/>
        /// </summary>
        public static Java.Awt.Color green => Clazz.GetField<Java.Awt.Color>("green");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#GREEN"/>
        /// </summary>
        public static Java.Awt.Color GREEN => Clazz.GetField<Java.Awt.Color>("GREEN");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#LIGHT_GRAY"/>
        /// </summary>
        public static Java.Awt.Color LIGHT_GRAY => Clazz.GetField<Java.Awt.Color>("LIGHT_GRAY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#lightGray"/>
        /// </summary>
        public static Java.Awt.Color lightGray => Clazz.GetField<Java.Awt.Color>("lightGray");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#magenta"/>
        /// </summary>
        public static Java.Awt.Color magenta => Clazz.GetField<Java.Awt.Color>("magenta");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#MAGENTA"/>
        /// </summary>
        public static Java.Awt.Color MAGENTA => Clazz.GetField<Java.Awt.Color>("MAGENTA");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#orange"/>
        /// </summary>
        public static Java.Awt.Color orange => Clazz.GetField<Java.Awt.Color>("orange");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#ORANGE"/>
        /// </summary>
        public static Java.Awt.Color ORANGE => Clazz.GetField<Java.Awt.Color>("ORANGE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#pink"/>
        /// </summary>
        public static Java.Awt.Color pink => Clazz.GetField<Java.Awt.Color>("pink");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#PINK"/>
        /// </summary>
        public static Java.Awt.Color PINK => Clazz.GetField<Java.Awt.Color>("PINK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#red"/>
        /// </summary>
        public static Java.Awt.Color red => Clazz.GetField<Java.Awt.Color>("red");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#RED"/>
        /// </summary>
        public static Java.Awt.Color RED => Clazz.GetField<Java.Awt.Color>("RED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#white"/>
        /// </summary>
        public static Java.Awt.Color white => Clazz.GetField<Java.Awt.Color>("white");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#WHITE"/>
        /// </summary>
        public static Java.Awt.Color WHITE => Clazz.GetField<Java.Awt.Color>("WHITE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#yellow"/>
        /// </summary>
        public static Java.Awt.Color yellow => Clazz.GetField<Java.Awt.Color>("yellow");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#YELLOW"/>
        /// </summary>
        public static Java.Awt.Color YELLOW => Clazz.GetField<Java.Awt.Color>("YELLOW");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#RGBtoHSB(int,int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float[] RGBtoHSB(int arg0, int arg1, int arg2, float[] arg3)
        {
            return SExecuteArray<float>("RGBtoHSB", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#HSBtoRGB(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HSBtoRGB(float arg0, float arg1, float arg2)
        {
            return SExecute<int>("HSBtoRGB", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#decode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Awt.Color Decode(string arg0)
        {
            return SExecute<Java.Awt.Color>("decode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getColor(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public static Java.Awt.Color GetColor(string arg0, int arg1)
        {
            return SExecute<Java.Awt.Color>("getColor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getColor(java.lang.String,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public static Java.Awt.Color GetColor(string arg0, Java.Awt.Color arg1)
        {
            return SExecute<Java.Awt.Color>("getColor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getColor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public static Java.Awt.Color GetColor(string arg0)
        {
            return SExecute<Java.Awt.Color>("getColor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getHSBColor(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public static Java.Awt.Color GetHSBColor(float arg0, float arg1, float arg2)
        {
            return SExecute<Java.Awt.Color>("getHSBColor", arg0, arg1, arg2);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getAlpha()"/> 
        /// </summary>
        public int Alpha
        {
            get { return IExecute<int>("getAlpha"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getBlue()"/> 
        /// </summary>
        public int Blue
        {
            get { return IExecute<int>("getBlue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#brighter()"/> 
        /// </summary>
        public Java.Awt.Color Brighter
        {
            get { return IExecute<Java.Awt.Color>("brighter"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getColorSpace()"/> 
        /// </summary>
        public Java.Awt.ColorNs.ColorSpace ColorSpace
        {
            get { return IExecute<Java.Awt.ColorNs.ColorSpace>("getColorSpace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#darker()"/> 
        /// </summary>
        public Java.Awt.Color Darker
        {
            get { return IExecute<Java.Awt.Color>("darker"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getGreen()"/> 
        /// </summary>
        public int Green
        {
            get { return IExecute<int>("getGreen"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getRed()"/> 
        /// </summary>
        public int Red
        {
            get { return IExecute<int>("getRed"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getRGB()"/> 
        /// </summary>
        public int RGB
        {
            get { return IExecute<int>("getRGB"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getTransparency()"/> 
        /// </summary>
        public int Transparency
        {
            get { return IExecute<int>("getTransparency"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getColorComponents(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetColorComponents(float[] arg0)
        {
            return IExecuteArray<float>("getColorComponents", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getColorComponents(java.awt.color.ColorSpace,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ColorNs.ColorSpace"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetColorComponents(Java.Awt.ColorNs.ColorSpace arg0, float[] arg1)
        {
            return IExecuteArray<float>("getColorComponents", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getComponents(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetComponents(float[] arg0)
        {
            return IExecuteArray<float>("getComponents", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getComponents(java.awt.color.ColorSpace,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ColorNs.ColorSpace"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetComponents(Java.Awt.ColorNs.ColorSpace arg0, float[] arg1)
        {
            return IExecuteArray<float>("getComponents", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getRGBColorComponents(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetRGBColorComponents(float[] arg0)
        {
            return IExecuteArray<float>("getRGBColorComponents", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#getRGBComponents(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetRGBComponents(float[] arg0)
        {
            return IExecuteArray<float>("getRGBComponents", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Color.html#createContext(java.awt.image.ColorModel,java.awt.Rectangle,java.awt.geom.Rectangle2D,java.awt.geom.AffineTransform,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg4"><see cref="Java.Awt.RenderingHints"/></param>
        /// <returns><see cref="Java.Awt.PaintContext"/></returns>
        public Java.Awt.PaintContext CreateContext(Java.Awt.ImageNs.ColorModel arg0, Java.Awt.Rectangle arg1, Java.Awt.Geom.Rectangle2D arg2, Java.Awt.Geom.AffineTransform arg3, Java.Awt.RenderingHints arg4)
        {
            return IExecute<Java.Awt.PaintContext>("createContext", arg0, arg1, arg2, arg3, arg4);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}