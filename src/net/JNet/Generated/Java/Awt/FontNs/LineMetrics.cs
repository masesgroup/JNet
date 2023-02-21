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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getAscent() 
        /// </summary>
        public float Ascent
        {
            get { return IExecute<float>("getAscent"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getBaselineIndex() 
        /// </summary>
        public int BaselineIndex
        {
            get { return IExecute<int>("getBaselineIndex"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getBaselineOffsets() 
        /// </summary>
        public float[] BaselineOffsets
        {
            get { return IExecuteArray<float>("getBaselineOffsets"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getDescent() 
        /// </summary>
        public float Descent
        {
            get { return IExecute<float>("getDescent"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getHeight() 
        /// </summary>
        public float Height
        {
            get { return IExecute<float>("getHeight"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getLeading() 
        /// </summary>
        public float Leading
        {
            get { return IExecute<float>("getLeading"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getNumChars() 
        /// </summary>
        public int NumChars
        {
            get { return IExecute<int>("getNumChars"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getStrikethroughOffset() 
        /// </summary>
        public float StrikethroughOffset
        {
            get { return IExecute<float>("getStrikethroughOffset"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getStrikethroughThickness() 
        /// </summary>
        public float StrikethroughThickness
        {
            get { return IExecute<float>("getStrikethroughThickness"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getUnderlineOffset() 
        /// </summary>
        public float UnderlineOffset
        {
            get { return IExecute<float>("getUnderlineOffset"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/LineMetrics.html#getUnderlineThickness() 
        /// </summary>
        public float UnderlineThickness
        {
            get { return IExecute<float>("getUnderlineThickness"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}