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
    #region FlatteningPathIterator
    public partial class FlatteningPathIterator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/FlatteningPathIterator.html#%3Cinit%3E(java.awt.geom.PathIterator,double,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.PathIterator"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public FlatteningPathIterator(Java.Awt.Geom.PathIterator arg0, double arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/FlatteningPathIterator.html#%3Cinit%3E(java.awt.geom.PathIterator,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.PathIterator"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public FlatteningPathIterator(Java.Awt.Geom.PathIterator arg0, double arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Geom.FlatteningPathIterator"/> to <see cref="Java.Awt.Geom.PathIterator"/>
        /// </summary>
        public static implicit operator Java.Awt.Geom.PathIterator(Java.Awt.Geom.FlatteningPathIterator t) => t.Cast<Java.Awt.Geom.PathIterator>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/FlatteningPathIterator.html#getFlatness()"/> 
        /// </summary>
        public double Flatness
        {
            get { return IExecute<double>("getFlatness"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/FlatteningPathIterator.html#getRecursionLimit()"/> 
        /// </summary>
        public int RecursionLimit
        {
            get { return IExecute<int>("getRecursionLimit"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/FlatteningPathIterator.html#getWindingRule()"/> 
        /// </summary>
        public int WindingRule
        {
            get { return IExecute<int>("getWindingRule"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/FlatteningPathIterator.html#isDone()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsDone()
        {
            return IExecute<bool>("isDone");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/FlatteningPathIterator.html#currentSegment(double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see langword="int"/></returns>
        public int CurrentSegment(double[] arg0)
        {
            return IExecute<int>("currentSegment", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/FlatteningPathIterator.html#currentSegment(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see langword="int"/></returns>
        public int CurrentSegment(float[] arg0)
        {
            return IExecute<int>("currentSegment", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/FlatteningPathIterator.html#next()"/>
        /// </summary>
        public void Next()
        {
            IExecute("next");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}