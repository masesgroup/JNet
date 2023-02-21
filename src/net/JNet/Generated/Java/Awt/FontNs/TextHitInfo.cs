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
    #region TextHitInfo
    public partial class TextHitInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#afterOffset(int)
        /// </summary>
        public static Java.Awt.FontNs.TextHitInfo AfterOffset(int arg0)
        {
            return SExecute<Java.Awt.FontNs.TextHitInfo>("afterOffset", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#beforeOffset(int)
        /// </summary>
        public static Java.Awt.FontNs.TextHitInfo BeforeOffset(int arg0)
        {
            return SExecute<Java.Awt.FontNs.TextHitInfo>("beforeOffset", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#leading(int)
        /// </summary>
        public static Java.Awt.FontNs.TextHitInfo Leading(int arg0)
        {
            return SExecute<Java.Awt.FontNs.TextHitInfo>("leading", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#trailing(int)
        /// </summary>
        public static Java.Awt.FontNs.TextHitInfo Trailing(int arg0)
        {
            return SExecute<Java.Awt.FontNs.TextHitInfo>("trailing", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#getCharIndex() 
        /// </summary>
        public int CharIndex
        {
            get { return IExecute<int>("getCharIndex"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#getInsertionIndex() 
        /// </summary>
        public int InsertionIndex
        {
            get { return IExecute<int>("getInsertionIndex"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#getOtherHit() 
        /// </summary>
        public Java.Awt.FontNs.TextHitInfo OtherHit
        {
            get { return IExecute<Java.Awt.FontNs.TextHitInfo>("getOtherHit"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#isLeadingEdge()
        /// </summary>
        public bool IsLeadingEdge()
        {
            return IExecute<bool>("isLeadingEdge");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TextHitInfo.html#getOffsetHit(int)
        /// </summary>
        public Java.Awt.FontNs.TextHitInfo GetOffsetHit(int arg0)
        {
            return IExecute<Java.Awt.FontNs.TextHitInfo>("getOffsetHit", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}