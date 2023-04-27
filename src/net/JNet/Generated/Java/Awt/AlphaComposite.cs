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

namespace Java.Awt
{
    #region AlphaComposite
    public partial class AlphaComposite
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.AlphaComposite"/> to <see cref="Java.Awt.Composite"/>
        /// </summary>
        public static implicit operator Java.Awt.Composite(Java.Awt.AlphaComposite t) => t.Cast<Java.Awt.Composite>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#CLEAR"/>
        /// </summary>
        public static int CLEAR { get { return LocalClazz.GetField<int>("CLEAR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DST"/>
        /// </summary>
        public static int DST { get { return LocalClazz.GetField<int>("DST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DST_ATOP"/>
        /// </summary>
        public static int DST_ATOP { get { return LocalClazz.GetField<int>("DST_ATOP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DST_IN"/>
        /// </summary>
        public static int DST_IN { get { return LocalClazz.GetField<int>("DST_IN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DST_OUT"/>
        /// </summary>
        public static int DST_OUT { get { return LocalClazz.GetField<int>("DST_OUT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DST_OVER"/>
        /// </summary>
        public static int DST_OVER { get { return LocalClazz.GetField<int>("DST_OVER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SRC"/>
        /// </summary>
        public static int SRC { get { return LocalClazz.GetField<int>("SRC"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SRC_ATOP"/>
        /// </summary>
        public static int SRC_ATOP { get { return LocalClazz.GetField<int>("SRC_ATOP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SRC_IN"/>
        /// </summary>
        public static int SRC_IN { get { return LocalClazz.GetField<int>("SRC_IN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SRC_OUT"/>
        /// </summary>
        public static int SRC_OUT { get { return LocalClazz.GetField<int>("SRC_OUT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SRC_OVER"/>
        /// </summary>
        public static int SRC_OVER { get { return LocalClazz.GetField<int>("SRC_OVER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#XOR"/>
        /// </summary>
        public static int XOR { get { return LocalClazz.GetField<int>("XOR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#Clear"/>
        /// </summary>
        public static Java.Awt.AlphaComposite Clear { get { return LocalClazz.GetField<Java.Awt.AlphaComposite>("Clear"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#Dst"/>
        /// </summary>
        public static Java.Awt.AlphaComposite Dst { get { return LocalClazz.GetField<Java.Awt.AlphaComposite>("Dst"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DstAtop"/>
        /// </summary>
        public static Java.Awt.AlphaComposite DstAtop { get { return LocalClazz.GetField<Java.Awt.AlphaComposite>("DstAtop"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DstIn"/>
        /// </summary>
        public static Java.Awt.AlphaComposite DstIn { get { return LocalClazz.GetField<Java.Awt.AlphaComposite>("DstIn"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DstOut"/>
        /// </summary>
        public static Java.Awt.AlphaComposite DstOut { get { return LocalClazz.GetField<Java.Awt.AlphaComposite>("DstOut"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#DstOver"/>
        /// </summary>
        public static Java.Awt.AlphaComposite DstOver { get { return LocalClazz.GetField<Java.Awt.AlphaComposite>("DstOver"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#Src"/>
        /// </summary>
        public static Java.Awt.AlphaComposite Src { get { return LocalClazz.GetField<Java.Awt.AlphaComposite>("Src"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SrcAtop"/>
        /// </summary>
        public static Java.Awt.AlphaComposite SrcAtop { get { return LocalClazz.GetField<Java.Awt.AlphaComposite>("SrcAtop"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SrcIn"/>
        /// </summary>
        public static Java.Awt.AlphaComposite SrcIn { get { return LocalClazz.GetField<Java.Awt.AlphaComposite>("SrcIn"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SrcOut"/>
        /// </summary>
        public static Java.Awt.AlphaComposite SrcOut { get { return LocalClazz.GetField<Java.Awt.AlphaComposite>("SrcOut"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#SrcOver"/>
        /// </summary>
        public static Java.Awt.AlphaComposite SrcOver { get { return LocalClazz.GetField<Java.Awt.AlphaComposite>("SrcOver"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#Xor"/>
        /// </summary>
        public static Java.Awt.AlphaComposite Xor { get { return LocalClazz.GetField<Java.Awt.AlphaComposite>("Xor"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#getInstance(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.AlphaComposite"/></returns>
        public static Java.Awt.AlphaComposite GetInstance(int arg0, float arg1)
        {
            return SExecute<Java.Awt.AlphaComposite>(LocalClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#getInstance(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.AlphaComposite"/></returns>
        public static Java.Awt.AlphaComposite GetInstance(int arg0)
        {
            return SExecute<Java.Awt.AlphaComposite>(LocalClazz, "getInstance", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#getAlpha()"/> 
        /// </summary>
        public float Alpha
        {
            get { return IExecute<float>("getAlpha"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#getRule()"/> 
        /// </summary>
        public int Rule
        {
            get { return IExecute<int>("getRule"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#derive(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.AlphaComposite"/></returns>
        public Java.Awt.AlphaComposite Derive(float arg0)
        {
            return IExecute<Java.Awt.AlphaComposite>("derive", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#derive(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.AlphaComposite"/></returns>
        public Java.Awt.AlphaComposite Derive(int arg0)
        {
            return IExecute<Java.Awt.AlphaComposite>("derive", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AlphaComposite.html#createContext(java.awt.image.ColorModel,java.awt.image.ColorModel,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg2"><see cref="Java.Awt.RenderingHints"/></param>
        /// <returns><see cref="Java.Awt.CompositeContext"/></returns>
        public Java.Awt.CompositeContext CreateContext(Java.Awt.ImageNs.ColorModel arg0, Java.Awt.ImageNs.ColorModel arg1, Java.Awt.RenderingHints arg2)
        {
            return IExecute<Java.Awt.CompositeContext>("createContext", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}