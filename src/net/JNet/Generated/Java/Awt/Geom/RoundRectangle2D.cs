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
    #region RoundRectangle2D
    public partial class RoundRectangle2D
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.html#getArcHeight()"/> 
        /// </summary>
        public double ArcHeight
        {
            get { return IExecute<double>("getArcHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.html#getArcWidth()"/> 
        /// </summary>
        public double ArcWidth
        {
            get { return IExecute<double>("getArcWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.html#setRoundRect(double,double,double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        public void SetRoundRect(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
        {
            IExecute("setRoundRect", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.html#setRoundRect(java.awt.geom.RoundRectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.RoundRectangle2D"/></param>
        public void SetRoundRect(Java.Awt.Geom.RoundRectangle2D arg0)
        {
            IExecute("setRoundRect", arg0);
        }

        #endregion

        #region Nested classes
        #region Double
        public partial class Double
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Double.html#%3Cinit%3E(double,double,double,double,double,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            /// <param name="arg2"><see cref="double"/></param>
            /// <param name="arg3"><see cref="double"/></param>
            /// <param name="arg4"><see cref="double"/></param>
            /// <param name="arg5"><see cref="double"/></param>
            public Double(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
                : base(arg0, arg1, arg2, arg3, arg4, arg5)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Awt.Geom.RoundRectangle2D.Double"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Awt.Geom.RoundRectangle2D.Double t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Double.html#archeight"/>
            /// </summary>
            public double archeight { get { return IGetField<double>("archeight"); } set { ISetField("archeight", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Double.html#arcwidth"/>
            /// </summary>
            public double arcwidth { get { return IGetField<double>("arcwidth"); } set { ISetField("arcwidth", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Double.html#height"/>
            /// </summary>
            public double height { get { return IGetField<double>("height"); } set { ISetField("height", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Double.html#width"/>
            /// </summary>
            public double width { get { return IGetField<double>("width"); } set { ISetField("width", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Double.html#x"/>
            /// </summary>
            public double x { get { return IGetField<double>("x"); } set { ISetField("x", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Double.html#y"/>
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Float.html#%3Cinit%3E(float,float,float,float,float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            /// <param name="arg4"><see cref="float"/></param>
            /// <param name="arg5"><see cref="float"/></param>
            public Float(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
                : base(arg0, arg1, arg2, arg3, arg4, arg5)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Awt.Geom.RoundRectangle2D.Float"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Awt.Geom.RoundRectangle2D.Float t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Float.html#archeight"/>
            /// </summary>
            public float archeight { get { return IGetField<float>("archeight"); } set { ISetField("archeight", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Float.html#arcwidth"/>
            /// </summary>
            public float arcwidth { get { return IGetField<float>("arcwidth"); } set { ISetField("arcwidth", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Float.html#height"/>
            /// </summary>
            public float height { get { return IGetField<float>("height"); } set { ISetField("height", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Float.html#width"/>
            /// </summary>
            public float width { get { return IGetField<float>("width"); } set { ISetField("width", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Float.html#x"/>
            /// </summary>
            public float x { get { return IGetField<float>("x"); } set { ISetField("x", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Float.html#y"/>
            /// </summary>
            public float y { get { return IGetField<float>("y"); } set { ISetField("y", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RoundRectangle2D.Float.html#setRoundRect(float,float,float,float,float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            /// <param name="arg4"><see cref="float"/></param>
            /// <param name="arg5"><see cref="float"/></param>
            public void SetRoundRect(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
            {
                IExecute("setRoundRect", arg0, arg1, arg2, arg3, arg4, arg5);
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