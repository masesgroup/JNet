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

namespace Java.Awt.Geom
{
    #region Rectangle2D
    public partial class Rectangle2D
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#OUT_BOTTOM"/>
        /// </summary>
        public static int OUT_BOTTOM { get { if (!_OUT_BOTTOMReady) { _OUT_BOTTOMContent = SGetField<int>(LocalBridgeClazz, "OUT_BOTTOM"); _OUT_BOTTOMReady = true; } return _OUT_BOTTOMContent; } }
        private static int _OUT_BOTTOMContent = default;
        private static bool _OUT_BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#OUT_LEFT"/>
        /// </summary>
        public static int OUT_LEFT { get { if (!_OUT_LEFTReady) { _OUT_LEFTContent = SGetField<int>(LocalBridgeClazz, "OUT_LEFT"); _OUT_LEFTReady = true; } return _OUT_LEFTContent; } }
        private static int _OUT_LEFTContent = default;
        private static bool _OUT_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#OUT_RIGHT"/>
        /// </summary>
        public static int OUT_RIGHT { get { if (!_OUT_RIGHTReady) { _OUT_RIGHTContent = SGetField<int>(LocalBridgeClazz, "OUT_RIGHT"); _OUT_RIGHTReady = true; } return _OUT_RIGHTContent; } }
        private static int _OUT_RIGHTContent = default;
        private static bool _OUT_RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#OUT_TOP"/>
        /// </summary>
        public static int OUT_TOP { get { if (!_OUT_TOPReady) { _OUT_TOPContent = SGetField<int>(LocalBridgeClazz, "OUT_TOP"); _OUT_TOPReady = true; } return _OUT_TOPContent; } }
        private static int _OUT_TOPContent = default;
        private static bool _OUT_TOPReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#intersect(java.awt.geom.Rectangle2D,java.awt.geom.Rectangle2D,java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        public static void Intersect(Java.Awt.Geom.Rectangle2D arg0, Java.Awt.Geom.Rectangle2D arg1, Java.Awt.Geom.Rectangle2D arg2)
        {
            SExecute(LocalBridgeClazz, "intersect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#union(java.awt.geom.Rectangle2D,java.awt.geom.Rectangle2D,java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        public static void Union(Java.Awt.Geom.Rectangle2D arg0, Java.Awt.Geom.Rectangle2D arg1, Java.Awt.Geom.Rectangle2D arg2)
        {
            SExecute(LocalBridgeClazz, "union", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#outcode(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        public int Outcode(double arg0, double arg1)
        {
            return IExecute<int>("outcode", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#createIntersection(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D CreateIntersection(Java.Awt.Geom.Rectangle2D arg0)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("createIntersection", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#createUnion(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D CreateUnion(Java.Awt.Geom.Rectangle2D arg0)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("createUnion", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#setRect(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        public void SetRect(double arg0, double arg1, double arg2, double arg3)
        {
            IExecute("setRect", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#intersectsLine(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IntersectsLine(double arg0, double arg1, double arg2, double arg3)
        {
            return IExecute<bool>("intersectsLine", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#intersectsLine(java.awt.geom.Line2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Line2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IntersectsLine(Java.Awt.Geom.Line2D arg0)
        {
            return IExecute<bool>("intersectsLine", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#outcode(java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="int"/></returns>
        public int Outcode(Java.Awt.Geom.Point2D arg0)
        {
            return IExecute<int>("outcode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#add(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void Add(double arg0, double arg1)
        {
            IExecute("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#add(java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        public void Add(Java.Awt.Geom.Point2D arg0)
        {
            IExecute("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#add(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        public void Add(Java.Awt.Geom.Rectangle2D arg0)
        {
            IExecute("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.html#setRect(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        public void SetRect(Java.Awt.Geom.Rectangle2D arg0)
        {
            IExecute("setRect", arg0);
        }

        #endregion

        #region Nested classes
        #region Double
        public partial class Double
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.Double.html#%3Cinit%3E(double,double,double,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            /// <param name="arg2"><see cref="double"/></param>
            /// <param name="arg3"><see cref="double"/></param>
            public Double(double arg0, double arg1, double arg2, double arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Awt.Geom.Rectangle2D.Double"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Awt.Geom.Rectangle2D.Double t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.Double.html#height"/>
            /// </summary>
            public double height { get { return IGetField<double>("height"); } set { ISetField("height", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.Double.html#width"/>
            /// </summary>
            public double width { get { return IGetField<double>("width"); } set { ISetField("width", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.Double.html#x"/>
            /// </summary>
            public double x { get { return IGetField<double>("x"); } set { ISetField("x", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.Double.html#y"/>
            /// </summary>
            public double y { get { return IGetField<double>("y"); } set { ISetField("y", value); } }

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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.Float.html#%3Cinit%3E(float,float,float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            public Float(float arg0, float arg1, float arg2, float arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Awt.Geom.Rectangle2D.Float"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Awt.Geom.Rectangle2D.Float t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.Float.html#height"/>
            /// </summary>
            public float height { get { return IGetField<float>("height"); } set { ISetField("height", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.Float.html#width"/>
            /// </summary>
            public float width { get { return IGetField<float>("width"); } set { ISetField("width", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.Float.html#x"/>
            /// </summary>
            public float x { get { return IGetField<float>("x"); } set { ISetField("x", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.Float.html#y"/>
            /// </summary>
            public float y { get { return IGetField<float>("y"); } set { ISetField("y", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Rectangle2D.Float.html#setRect(float,float,float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            public void SetRect(float arg0, float arg1, float arg2, float arg3)
            {
                IExecute("setRect", arg0, arg1, arg2, arg3);
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