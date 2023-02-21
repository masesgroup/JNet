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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Geom
{
    #region Arc2D
    public partial class Arc2D
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#OPEN
        /// </summary>
        public static int OPEN => Clazz.GetField<int>("OPEN");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#CHORD
        /// </summary>
        public static int CHORD => Clazz.GetField<int>("CHORD");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#PIE
        /// </summary>
        public static int PIE => Clazz.GetField<int>("PIE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#getAngleExtent() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setAngleExtent(double)
        /// </summary>
        public double AngleExtent
        {
            get { return IExecute<double>("getAngleExtent"); } set { IExecute("setAngleExtent", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#getAngleStart() 
        /// </summary>
        public double AngleStart
        {
            get { return IExecute<double>("getAngleStart"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#getArcType() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setArcType(int)
        /// </summary>
        public int ArcType
        {
            get { return IExecute<int>("getArcType"); } set { IExecute("setArcType", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#getEndPoint() 
        /// </summary>
        public Java.Awt.Geom.Point2D EndPoint
        {
            get { return IExecute<Java.Awt.Geom.Point2D>("getEndPoint"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#getStartPoint() 
        /// </summary>
        public Java.Awt.Geom.Point2D StartPoint
        {
            get { return IExecute<Java.Awt.Geom.Point2D>("getStartPoint"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setAngleStart(double)
        /// </summary>
        public void SetAngleStart(double arg0)
        {
            IExecute("setAngleStart", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setArc(double,double,double,double,double,double,int)
        /// </summary>
        public void SetArc(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, int arg6)
        {
            IExecute("setArc", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#containsAngle(double)
        /// </summary>
        public bool ContainsAngle(double arg0)
        {
            return IExecute<bool>("containsAngle", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setAngles(double,double,double,double)
        /// </summary>
        public void SetAngles(double arg0, double arg1, double arg2, double arg3)
        {
            IExecute("setAngles", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setAngles(java.awt.geom.Point2D,java.awt.geom.Point2D)
        /// </summary>
        public void SetAngles(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1)
        {
            IExecute("setAngles", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setAngleStart(java.awt.geom.Point2D)
        /// </summary>
        public void SetAngleStart(Java.Awt.Geom.Point2D arg0)
        {
            IExecute("setAngleStart", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setArc(java.awt.geom.Arc2D)
        /// </summary>
        public void SetArc(Java.Awt.Geom.Arc2D arg0)
        {
            IExecute("setArc", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setArc(java.awt.geom.Point2D,java.awt.geom.Dimension2D,double,double,int)
        /// </summary>
        public void SetArc(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Dimension2D arg1, double arg2, double arg3, int arg4)
        {
            IExecute("setArc", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setArc(java.awt.geom.Rectangle2D,double,double,int)
        /// </summary>
        public void SetArc(Java.Awt.Geom.Rectangle2D arg0, double arg1, double arg2, int arg3)
        {
            IExecute("setArc", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setArcByCenter(double,double,double,double,double,int)
        /// </summary>
        public void SetArcByCenter(double arg0, double arg1, double arg2, double arg3, double arg4, int arg5)
        {
            IExecute("setArcByCenter", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setArcByTangent(java.awt.geom.Point2D,java.awt.geom.Point2D,java.awt.geom.Point2D,double)
        /// </summary>
        public void SetArcByTangent(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1, Java.Awt.Geom.Point2D arg2, double arg3)
        {
            IExecute("setArcByTangent", arg0, arg1, arg2, arg3);
        }
        
        #endregion

        #region Nested classes
        #region Double
        public partial class Double
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#<init>(java.awt.geom.Rectangle2D,double,double,int)
            /// </summary>
            public Double(Java.Awt.Geom.Rectangle2D arg0, double arg1, double arg2, int arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#<init>(double,double,double,double,double,double,int)
            /// </summary>
            public Double(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, int arg6)
                : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
            {
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#<init>(int)
            /// </summary>
            public Double(int arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Java.Io.Serializable(Java.Awt.Geom.Arc2D.Double t) => t.Cast<Java.Io.Serializable>();
            
            #endregion

            #region Fields
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#x
            /// </summary>
            public double x => Instance.GetField<double>("x");
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#y
            /// </summary>
            public double y => Instance.GetField<double>("y");
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#width
            /// </summary>
            public double width => Instance.GetField<double>("width");
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#height
            /// </summary>
            public double height => Instance.GetField<double>("height");
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#start
            /// </summary>
            public double start => Instance.GetField<double>("start");
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#extent
            /// </summary>
            public double extent => Instance.GetField<double>("extent");
            
            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Float
        public partial class Float
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#<init>(java.awt.geom.Rectangle2D,float,float,int)
            /// </summary>
            public Float(Java.Awt.Geom.Rectangle2D arg0, float arg1, float arg2, int arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#<init>(float,float,float,float,float,float,int)
            /// </summary>
            public Float(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, int arg6)
                : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
            {
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#<init>(int)
            /// </summary>
            public Float(int arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Java.Io.Serializable(Java.Awt.Geom.Arc2D.Float t) => t.Cast<Java.Io.Serializable>();
            
            #endregion

            #region Fields
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#x
            /// </summary>
            public float x => Instance.GetField<float>("x");
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#y
            /// </summary>
            public float y => Instance.GetField<float>("y");
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#width
            /// </summary>
            public float width => Instance.GetField<float>("width");
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#height
            /// </summary>
            public float height => Instance.GetField<float>("height");
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#start
            /// </summary>
            public float start => Instance.GetField<float>("start");
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#extent
            /// </summary>
            public float extent => Instance.GetField<float>("extent");
            
            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}