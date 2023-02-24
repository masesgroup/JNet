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

namespace Java.Awt
{
    #region BasicStroke
    public partial class BasicStroke
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#%3Cinit%3E(float,int,int,float,float[],float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        public BasicStroke(float arg0, int arg1, int arg2, float arg3, float[] arg4, float arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#%3Cinit%3E(float,int,int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public BasicStroke(float arg0, int arg1, int arg2, float arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#%3Cinit%3E(float,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public BasicStroke(float arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#%3Cinit%3E(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public BasicStroke(float arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.BasicStroke"/> to <see cref="Java.Awt.Stroke"/>
        /// </summary>
        public static implicit operator Java.Awt.Stroke(Java.Awt.BasicStroke t) => t.Cast<Java.Awt.Stroke>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#CAP_BUTT"/>
        /// </summary>
        public static int CAP_BUTT => Clazz.GetField<int>("CAP_BUTT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#CAP_ROUND"/>
        /// </summary>
        public static int CAP_ROUND => Clazz.GetField<int>("CAP_ROUND");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#CAP_SQUARE"/>
        /// </summary>
        public static int CAP_SQUARE => Clazz.GetField<int>("CAP_SQUARE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#JOIN_BEVEL"/>
        /// </summary>
        public static int JOIN_BEVEL => Clazz.GetField<int>("JOIN_BEVEL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#JOIN_MITER"/>
        /// </summary>
        public static int JOIN_MITER => Clazz.GetField<int>("JOIN_MITER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#JOIN_ROUND"/>
        /// </summary>
        public static int JOIN_ROUND => Clazz.GetField<int>("JOIN_ROUND");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#getDashArray()"/> 
        /// </summary>
        public float[] DashArray
        {
            get { return IExecuteArray<float>("getDashArray"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#getDashPhase()"/> 
        /// </summary>
        public float DashPhase
        {
            get { return IExecute<float>("getDashPhase"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#getEndCap()"/> 
        /// </summary>
        public int EndCap
        {
            get { return IExecute<int>("getEndCap"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#getLineJoin()"/> 
        /// </summary>
        public int LineJoin
        {
            get { return IExecute<int>("getLineJoin"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#getLineWidth()"/> 
        /// </summary>
        public float LineWidth
        {
            get { return IExecute<float>("getLineWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#getMiterLimit()"/> 
        /// </summary>
        public float MiterLimit
        {
            get { return IExecute<float>("getMiterLimit"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BasicStroke.html#createStrokedShape(java.awt.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Shape"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape CreateStrokedShape(Java.Awt.Shape arg0)
        {
            return IExecute<Java.Awt.Shape>("createStrokedShape", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}