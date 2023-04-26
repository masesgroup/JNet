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
    #region RenderingHints
    public partial class RenderingHints
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#%3Cinit%3E(java.awt.RenderingHints.Key,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.RenderingHints.Key"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public RenderingHints(Java.Awt.RenderingHints.Key arg0, object arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public RenderingHints(Java.Util.Map arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.RenderingHints"/> to <see cref="Java.Util.Map"/>
        /// </summary>
        public static implicit operator Java.Util.Map(Java.Awt.RenderingHints t) => t.Cast<Java.Util.Map>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.RenderingHints"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.RenderingHints t) => t.Cast<Java.Lang.Cloneable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#KEY_ALPHA_INTERPOLATION"/>
        /// </summary>
        public static Java.Awt.RenderingHints.Key KEY_ALPHA_INTERPOLATION => LocalClazz.GetField<Java.Awt.RenderingHints.Key>("KEY_ALPHA_INTERPOLATION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#KEY_ANTIALIASING"/>
        /// </summary>
        public static Java.Awt.RenderingHints.Key KEY_ANTIALIASING => LocalClazz.GetField<Java.Awt.RenderingHints.Key>("KEY_ANTIALIASING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#KEY_COLOR_RENDERING"/>
        /// </summary>
        public static Java.Awt.RenderingHints.Key KEY_COLOR_RENDERING => LocalClazz.GetField<Java.Awt.RenderingHints.Key>("KEY_COLOR_RENDERING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#KEY_DITHERING"/>
        /// </summary>
        public static Java.Awt.RenderingHints.Key KEY_DITHERING => LocalClazz.GetField<Java.Awt.RenderingHints.Key>("KEY_DITHERING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#KEY_FRACTIONALMETRICS"/>
        /// </summary>
        public static Java.Awt.RenderingHints.Key KEY_FRACTIONALMETRICS => LocalClazz.GetField<Java.Awt.RenderingHints.Key>("KEY_FRACTIONALMETRICS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#KEY_INTERPOLATION"/>
        /// </summary>
        public static Java.Awt.RenderingHints.Key KEY_INTERPOLATION => LocalClazz.GetField<Java.Awt.RenderingHints.Key>("KEY_INTERPOLATION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#KEY_RENDERING"/>
        /// </summary>
        public static Java.Awt.RenderingHints.Key KEY_RENDERING => LocalClazz.GetField<Java.Awt.RenderingHints.Key>("KEY_RENDERING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#KEY_RESOLUTION_VARIANT"/>
        /// </summary>
        public static Java.Awt.RenderingHints.Key KEY_RESOLUTION_VARIANT => LocalClazz.GetField<Java.Awt.RenderingHints.Key>("KEY_RESOLUTION_VARIANT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#KEY_STROKE_CONTROL"/>
        /// </summary>
        public static Java.Awt.RenderingHints.Key KEY_STROKE_CONTROL => LocalClazz.GetField<Java.Awt.RenderingHints.Key>("KEY_STROKE_CONTROL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#KEY_TEXT_ANTIALIASING"/>
        /// </summary>
        public static Java.Awt.RenderingHints.Key KEY_TEXT_ANTIALIASING => LocalClazz.GetField<Java.Awt.RenderingHints.Key>("KEY_TEXT_ANTIALIASING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#KEY_TEXT_LCD_CONTRAST"/>
        /// </summary>
        public static Java.Awt.RenderingHints.Key KEY_TEXT_LCD_CONTRAST => LocalClazz.GetField<Java.Awt.RenderingHints.Key>("KEY_TEXT_LCD_CONTRAST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_ALPHA_INTERPOLATION_DEFAULT"/>
        /// </summary>
        public static object VALUE_ALPHA_INTERPOLATION_DEFAULT => LocalClazz.GetField("VALUE_ALPHA_INTERPOLATION_DEFAULT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_ALPHA_INTERPOLATION_QUALITY"/>
        /// </summary>
        public static object VALUE_ALPHA_INTERPOLATION_QUALITY => LocalClazz.GetField("VALUE_ALPHA_INTERPOLATION_QUALITY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_ALPHA_INTERPOLATION_SPEED"/>
        /// </summary>
        public static object VALUE_ALPHA_INTERPOLATION_SPEED => LocalClazz.GetField("VALUE_ALPHA_INTERPOLATION_SPEED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_ANTIALIAS_DEFAULT"/>
        /// </summary>
        public static object VALUE_ANTIALIAS_DEFAULT => LocalClazz.GetField("VALUE_ANTIALIAS_DEFAULT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_ANTIALIAS_OFF"/>
        /// </summary>
        public static object VALUE_ANTIALIAS_OFF => LocalClazz.GetField("VALUE_ANTIALIAS_OFF");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_ANTIALIAS_ON"/>
        /// </summary>
        public static object VALUE_ANTIALIAS_ON => LocalClazz.GetField("VALUE_ANTIALIAS_ON");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_COLOR_RENDER_DEFAULT"/>
        /// </summary>
        public static object VALUE_COLOR_RENDER_DEFAULT => LocalClazz.GetField("VALUE_COLOR_RENDER_DEFAULT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_COLOR_RENDER_QUALITY"/>
        /// </summary>
        public static object VALUE_COLOR_RENDER_QUALITY => LocalClazz.GetField("VALUE_COLOR_RENDER_QUALITY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_COLOR_RENDER_SPEED"/>
        /// </summary>
        public static object VALUE_COLOR_RENDER_SPEED => LocalClazz.GetField("VALUE_COLOR_RENDER_SPEED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_DITHER_DEFAULT"/>
        /// </summary>
        public static object VALUE_DITHER_DEFAULT => LocalClazz.GetField("VALUE_DITHER_DEFAULT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_DITHER_DISABLE"/>
        /// </summary>
        public static object VALUE_DITHER_DISABLE => LocalClazz.GetField("VALUE_DITHER_DISABLE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_DITHER_ENABLE"/>
        /// </summary>
        public static object VALUE_DITHER_ENABLE => LocalClazz.GetField("VALUE_DITHER_ENABLE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_FRACTIONALMETRICS_DEFAULT"/>
        /// </summary>
        public static object VALUE_FRACTIONALMETRICS_DEFAULT => LocalClazz.GetField("VALUE_FRACTIONALMETRICS_DEFAULT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_FRACTIONALMETRICS_OFF"/>
        /// </summary>
        public static object VALUE_FRACTIONALMETRICS_OFF => LocalClazz.GetField("VALUE_FRACTIONALMETRICS_OFF");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_FRACTIONALMETRICS_ON"/>
        /// </summary>
        public static object VALUE_FRACTIONALMETRICS_ON => LocalClazz.GetField("VALUE_FRACTIONALMETRICS_ON");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_INTERPOLATION_BICUBIC"/>
        /// </summary>
        public static object VALUE_INTERPOLATION_BICUBIC => LocalClazz.GetField("VALUE_INTERPOLATION_BICUBIC");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_INTERPOLATION_BILINEAR"/>
        /// </summary>
        public static object VALUE_INTERPOLATION_BILINEAR => LocalClazz.GetField("VALUE_INTERPOLATION_BILINEAR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_INTERPOLATION_NEAREST_NEIGHBOR"/>
        /// </summary>
        public static object VALUE_INTERPOLATION_NEAREST_NEIGHBOR => LocalClazz.GetField("VALUE_INTERPOLATION_NEAREST_NEIGHBOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_RENDER_DEFAULT"/>
        /// </summary>
        public static object VALUE_RENDER_DEFAULT => LocalClazz.GetField("VALUE_RENDER_DEFAULT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_RENDER_QUALITY"/>
        /// </summary>
        public static object VALUE_RENDER_QUALITY => LocalClazz.GetField("VALUE_RENDER_QUALITY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_RENDER_SPEED"/>
        /// </summary>
        public static object VALUE_RENDER_SPEED => LocalClazz.GetField("VALUE_RENDER_SPEED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_RESOLUTION_VARIANT_BASE"/>
        /// </summary>
        public static object VALUE_RESOLUTION_VARIANT_BASE => LocalClazz.GetField("VALUE_RESOLUTION_VARIANT_BASE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_RESOLUTION_VARIANT_DEFAULT"/>
        /// </summary>
        public static object VALUE_RESOLUTION_VARIANT_DEFAULT => LocalClazz.GetField("VALUE_RESOLUTION_VARIANT_DEFAULT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_RESOLUTION_VARIANT_DPI_FIT"/>
        /// </summary>
        public static object VALUE_RESOLUTION_VARIANT_DPI_FIT => LocalClazz.GetField("VALUE_RESOLUTION_VARIANT_DPI_FIT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_RESOLUTION_VARIANT_SIZE_FIT"/>
        /// </summary>
        public static object VALUE_RESOLUTION_VARIANT_SIZE_FIT => LocalClazz.GetField("VALUE_RESOLUTION_VARIANT_SIZE_FIT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_STROKE_DEFAULT"/>
        /// </summary>
        public static object VALUE_STROKE_DEFAULT => LocalClazz.GetField("VALUE_STROKE_DEFAULT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_STROKE_NORMALIZE"/>
        /// </summary>
        public static object VALUE_STROKE_NORMALIZE => LocalClazz.GetField("VALUE_STROKE_NORMALIZE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_STROKE_PURE"/>
        /// </summary>
        public static object VALUE_STROKE_PURE => LocalClazz.GetField("VALUE_STROKE_PURE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_TEXT_ANTIALIAS_DEFAULT"/>
        /// </summary>
        public static object VALUE_TEXT_ANTIALIAS_DEFAULT => LocalClazz.GetField("VALUE_TEXT_ANTIALIAS_DEFAULT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_TEXT_ANTIALIAS_GASP"/>
        /// </summary>
        public static object VALUE_TEXT_ANTIALIAS_GASP => LocalClazz.GetField("VALUE_TEXT_ANTIALIAS_GASP");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_TEXT_ANTIALIAS_LCD_HBGR"/>
        /// </summary>
        public static object VALUE_TEXT_ANTIALIAS_LCD_HBGR => LocalClazz.GetField("VALUE_TEXT_ANTIALIAS_LCD_HBGR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_TEXT_ANTIALIAS_LCD_HRGB"/>
        /// </summary>
        public static object VALUE_TEXT_ANTIALIAS_LCD_HRGB => LocalClazz.GetField("VALUE_TEXT_ANTIALIAS_LCD_HRGB");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_TEXT_ANTIALIAS_LCD_VBGR"/>
        /// </summary>
        public static object VALUE_TEXT_ANTIALIAS_LCD_VBGR => LocalClazz.GetField("VALUE_TEXT_ANTIALIAS_LCD_VBGR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_TEXT_ANTIALIAS_LCD_VRGB"/>
        /// </summary>
        public static object VALUE_TEXT_ANTIALIAS_LCD_VRGB => LocalClazz.GetField("VALUE_TEXT_ANTIALIAS_LCD_VRGB");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_TEXT_ANTIALIAS_OFF"/>
        /// </summary>
        public static object VALUE_TEXT_ANTIALIAS_OFF => LocalClazz.GetField("VALUE_TEXT_ANTIALIAS_OFF");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#VALUE_TEXT_ANTIALIAS_ON"/>
        /// </summary>
        public static object VALUE_TEXT_ANTIALIAS_ON => LocalClazz.GetField("VALUE_TEXT_ANTIALIAS_ON");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#entrySet()"/> 
        /// </summary>
        public Java.Util.Set<Java.Util.Map.Entry<object, object>> EntrySet
        {
            get { return IExecute<Java.Util.Set<Java.Util.Map.Entry<object, object>>>("entrySet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#keySet()"/> 
        /// </summary>
        public Java.Util.Set<object> KeySet
        {
            get { return IExecute<Java.Util.Set<object>>("keySet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#size()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecute<int>("size"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#values()"/> 
        /// </summary>
        public Java.Util.Collection<object> Values
        {
            get { return IExecute<Java.Util.Collection<object>>("values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#containsKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(object arg0)
        {
            return IExecute<bool>("containsKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#containsValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsValue(object arg0)
        {
            return IExecute<bool>("containsValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(object arg0)
        {
            return IExecute("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#put(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Put(object arg0, object arg1)
        {
            return IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Remove(object arg0)
        {
            return IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#add(java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.RenderingHints"/></param>
        public void Add(Java.Awt.RenderingHints arg0)
        {
            IExecute("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.html#putAll(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void PutAll<Arg0Extendsobject>(Java.Util.Map<Arg0Extendsobject, Arg0Extendsobject> arg0)
        {
            IExecute("putAll", arg0);
        }
        
        #endregion

        #region Nested classes
        #region Key
        public partial class Key
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RenderingHints.Key.html#isCompatibleValue(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsCompatibleValue(object arg0)
            {
                return IExecute<bool>("isCompatibleValue", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}