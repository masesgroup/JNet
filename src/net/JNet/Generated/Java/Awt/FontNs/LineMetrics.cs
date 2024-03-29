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

namespace Java.Awt.FontNs
{
    #region LineMetrics
    public partial class LineMetrics
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getAscent()"/> 
        /// </summary>
        public float Ascent
        {
            get { return IExecuteWithSignature<float>("getAscent", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getBaselineIndex()"/> 
        /// </summary>
        public int BaselineIndex
        {
            get { return IExecuteWithSignature<int>("getBaselineIndex", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getBaselineOffsets()"/> 
        /// </summary>
        public float[] BaselineOffsets
        {
            get { return IExecuteWithSignatureArray<float>("getBaselineOffsets", "()[F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getDescent()"/> 
        /// </summary>
        public float Descent
        {
            get { return IExecuteWithSignature<float>("getDescent", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getHeight()"/> 
        /// </summary>
        public float Height
        {
            get { return IExecuteWithSignature<float>("getHeight", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getLeading()"/> 
        /// </summary>
        public float Leading
        {
            get { return IExecuteWithSignature<float>("getLeading", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getNumChars()"/> 
        /// </summary>
        public int NumChars
        {
            get { return IExecuteWithSignature<int>("getNumChars", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getStrikethroughOffset()"/> 
        /// </summary>
        public float StrikethroughOffset
        {
            get { return IExecuteWithSignature<float>("getStrikethroughOffset", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getStrikethroughThickness()"/> 
        /// </summary>
        public float StrikethroughThickness
        {
            get { return IExecuteWithSignature<float>("getStrikethroughThickness", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getUnderlineOffset()"/> 
        /// </summary>
        public float UnderlineOffset
        {
            get { return IExecuteWithSignature<float>("getUnderlineOffset", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getUnderlineThickness()"/> 
        /// </summary>
        public float UnderlineThickness
        {
            get { return IExecuteWithSignature<float>("getUnderlineThickness", "()F"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}