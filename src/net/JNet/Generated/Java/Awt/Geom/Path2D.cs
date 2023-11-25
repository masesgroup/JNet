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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Geom
{
    #region Path2D
    public partial class Path2D
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Geom.Path2D"/> to <see cref="Java.Awt.Shape"/>
        /// </summary>
        public static implicit operator Java.Awt.Shape(Java.Awt.Geom.Path2D t) => t.Cast<Java.Awt.Shape>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Geom.Path2D"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.Geom.Path2D t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#WIND_EVEN_ODD"/>
        /// </summary>
        public static int WIND_EVEN_ODD { get { return SGetField<int>(LocalBridgeClazz, "WIND_EVEN_ODD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#WIND_NON_ZERO"/>
        /// </summary>
        public static int WIND_NON_ZERO { get { return SGetField<int>(LocalBridgeClazz, "WIND_NON_ZERO"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#contains(java.awt.geom.PathIterator,double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.PathIterator"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Contains(Java.Awt.Geom.PathIterator arg0, double arg1, double arg2, double arg3, double arg4)
        {
            return SExecute<bool>(LocalBridgeClazz, "contains", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#contains(java.awt.geom.PathIterator,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.PathIterator"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Contains(Java.Awt.Geom.PathIterator arg0, double arg1, double arg2)
        {
            return SExecute<bool>(LocalBridgeClazz, "contains", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#contains(java.awt.geom.PathIterator,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.PathIterator"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Contains(Java.Awt.Geom.PathIterator arg0, Java.Awt.Geom.Point2D arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "contains", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#contains(java.awt.geom.PathIterator,java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.PathIterator"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Contains(Java.Awt.Geom.PathIterator arg0, Java.Awt.Geom.Rectangle2D arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "contains", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#intersects(java.awt.geom.PathIterator,double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.PathIterator"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Intersects(Java.Awt.Geom.PathIterator arg0, double arg1, double arg2, double arg3, double arg4)
        {
            return SExecute<bool>(LocalBridgeClazz, "intersects", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#intersects(java.awt.geom.PathIterator,java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.PathIterator"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Intersects(Java.Awt.Geom.PathIterator arg0, Java.Awt.Geom.Rectangle2D arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "intersects", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#getBounds()"/> 
        /// </summary>
        public Java.Awt.Rectangle Bounds
        {
            get { return IExecute<Java.Awt.Rectangle>("getBounds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#getCurrentPoint()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D CurrentPoint
        {
            get { return IExecute<Java.Awt.Geom.Point2D>("getCurrentPoint"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#getWindingRule()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#setWindingRule(int)"/>
        /// </summary>
        public int WindingRule
        {
            get { return IExecute<int>("getWindingRule"); } set { IExecute("setWindingRule", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#append(java.awt.geom.PathIterator,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.PathIterator"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Append(Java.Awt.Geom.PathIterator arg0, bool arg1)
        {
            IExecute("append", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#curveTo(double,double,double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        public void CurveTo(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
        {
            IExecute("curveTo", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#lineTo(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void LineTo(double arg0, double arg1)
        {
            IExecute("lineTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#moveTo(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void MoveTo(double arg0, double arg1)
        {
            IExecute("moveTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#quadTo(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        public void QuadTo(double arg0, double arg1, double arg2, double arg3)
        {
            IExecute("quadTo", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#transform(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public void Transform(Java.Awt.Geom.AffineTransform arg0)
        {
            IExecute("transform", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#trimToSize()"/>
        /// </summary>
        public void TrimToSize()
        {
            IExecute("trimToSize");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#contains(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(double arg0, double arg1, double arg2, double arg3)
        {
            return IExecute<bool>("contains", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#contains(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(double arg0, double arg1)
        {
            return IExecute<bool>("contains", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#contains(java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Java.Awt.Geom.Point2D arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#contains(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Java.Awt.Geom.Rectangle2D arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#intersects(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersects(double arg0, double arg1, double arg2, double arg3)
        {
            return IExecute<bool>("intersects", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#intersects(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersects(Java.Awt.Geom.Rectangle2D arg0)
        {
            return IExecute<bool>("intersects", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#getPathIterator(java.awt.geom.AffineTransform,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Awt.Geom.PathIterator"/></returns>
        public Java.Awt.Geom.PathIterator GetPathIterator(Java.Awt.Geom.AffineTransform arg0, double arg1)
        {
            return IExecute<Java.Awt.Geom.PathIterator>("getPathIterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#createTransformedShape(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape CreateTransformedShape(Java.Awt.Geom.AffineTransform arg0)
        {
            return IExecute<Java.Awt.Shape>("createTransformedShape", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#closePath()"/>
        /// </summary>
        public void ClosePath()
        {
            IExecute("closePath");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.html#append(java.awt.Shape,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Shape"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Append(Java.Awt.Shape arg0, bool arg1)
        {
            IExecute("append", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Double
        public partial class Double
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.Double.html#%3Cinit%3E(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public Double(int arg0, int arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.Double.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Double(int arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.Double.html#%3Cinit%3E(java.awt.Shape,java.awt.geom.AffineTransform)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Shape"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Geom.AffineTransform"/></param>
            public Double(Java.Awt.Shape arg0, Java.Awt.Geom.AffineTransform arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.Double.html#%3Cinit%3E(java.awt.Shape)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Shape"/></param>
            public Double(Java.Awt.Shape arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Awt.Geom.Path2D.Double"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Awt.Geom.Path2D.Double t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Float
        public partial class Float
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.Float.html#%3Cinit%3E(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public Float(int arg0, int arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.Float.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Float(int arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.Float.html#%3Cinit%3E(java.awt.Shape,java.awt.geom.AffineTransform)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Shape"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Geom.AffineTransform"/></param>
            public Float(Java.Awt.Shape arg0, Java.Awt.Geom.AffineTransform arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.Float.html#%3Cinit%3E(java.awt.Shape)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Shape"/></param>
            public Float(Java.Awt.Shape arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Awt.Geom.Path2D.Float"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Awt.Geom.Path2D.Float t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.Float.html#curveTo(float,float,float,float,float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            /// <param name="arg4"><see cref="float"/></param>
            /// <param name="arg5"><see cref="float"/></param>
            public void CurveTo(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
            {
                IExecute("curveTo", arg0, arg1, arg2, arg3, arg4, arg5);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.Float.html#lineTo(float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            public void LineTo(float arg0, float arg1)
            {
                IExecute("lineTo", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.Float.html#moveTo(float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            public void MoveTo(float arg0, float arg1)
            {
                IExecute("moveTo", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Path2D.Float.html#quadTo(float,float,float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            public void QuadTo(float arg0, float arg1, float arg2, float arg3)
            {
                IExecute("quadTo", arg0, arg1, arg2, arg3);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}