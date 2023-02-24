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
    #region NumericShaper
    public partial class NumericShaper
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.FontNs.NumericShaper"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.FontNs.NumericShaper t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#ALL_RANGES"/>
        /// </summary>
        public static int ALL_RANGES => Clazz.GetField<int>("ALL_RANGES");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#ARABIC"/>
        /// </summary>
        public static int ARABIC => Clazz.GetField<int>("ARABIC");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#BENGALI"/>
        /// </summary>
        public static int BENGALI => Clazz.GetField<int>("BENGALI");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#DEVANAGARI"/>
        /// </summary>
        public static int DEVANAGARI => Clazz.GetField<int>("DEVANAGARI");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#EASTERN_ARABIC"/>
        /// </summary>
        public static int EASTERN_ARABIC => Clazz.GetField<int>("EASTERN_ARABIC");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#ETHIOPIC"/>
        /// </summary>
        public static int ETHIOPIC => Clazz.GetField<int>("ETHIOPIC");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#EUROPEAN"/>
        /// </summary>
        public static int EUROPEAN => Clazz.GetField<int>("EUROPEAN");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#GUJARATI"/>
        /// </summary>
        public static int GUJARATI => Clazz.GetField<int>("GUJARATI");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#GURMUKHI"/>
        /// </summary>
        public static int GURMUKHI => Clazz.GetField<int>("GURMUKHI");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#KANNADA"/>
        /// </summary>
        public static int KANNADA => Clazz.GetField<int>("KANNADA");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#KHMER"/>
        /// </summary>
        public static int KHMER => Clazz.GetField<int>("KHMER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#LAO"/>
        /// </summary>
        public static int LAO => Clazz.GetField<int>("LAO");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#MALAYALAM"/>
        /// </summary>
        public static int MALAYALAM => Clazz.GetField<int>("MALAYALAM");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#MONGOLIAN"/>
        /// </summary>
        public static int MONGOLIAN => Clazz.GetField<int>("MONGOLIAN");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#MYANMAR"/>
        /// </summary>
        public static int MYANMAR => Clazz.GetField<int>("MYANMAR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#ORIYA"/>
        /// </summary>
        public static int ORIYA => Clazz.GetField<int>("ORIYA");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#TAMIL"/>
        /// </summary>
        public static int TAMIL => Clazz.GetField<int>("TAMIL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#TELUGU"/>
        /// </summary>
        public static int TELUGU => Clazz.GetField<int>("TELUGU");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#THAI"/>
        /// </summary>
        public static int THAI => Clazz.GetField<int>("THAI");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#TIBETAN"/>
        /// </summary>
        public static int TIBETAN => Clazz.GetField<int>("TIBETAN");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#getContextualShaper(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.NumericShaper"/></returns>
        public static Java.Awt.FontNs.NumericShaper GetContextualShaper(int arg0, int arg1)
        {
            return SExecute<Java.Awt.FontNs.NumericShaper>("getContextualShaper", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#getContextualShaper(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.NumericShaper"/></returns>
        public static Java.Awt.FontNs.NumericShaper GetContextualShaper(int arg0)
        {
            return SExecute<Java.Awt.FontNs.NumericShaper>("getContextualShaper", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#getShaper(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.NumericShaper"/></returns>
        public static Java.Awt.FontNs.NumericShaper GetShaper(int arg0)
        {
            return SExecute<Java.Awt.FontNs.NumericShaper>("getShaper", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#getRanges()"/> 
        /// </summary>
        public int Ranges
        {
            get { return IExecute<int>("getRanges"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#isContextual()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsContextual()
        {
            return IExecute<bool>("isContextual");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#shape(char[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void Shape(char[] arg0, int arg1, int arg2, int arg3)
        {
            IExecute("shape", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.html#shape(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void Shape(char[] arg0, int arg1, int arg2)
        {
            IExecute("shape", arg0, arg1, arg2);
        }
        
        #endregion

        #region Nested classes
        #region Range
        public partial class Range
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#ARABIC"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range ARABIC => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("ARABIC");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#BALINESE"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range BALINESE => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("BALINESE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#BENGALI"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range BENGALI => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("BENGALI");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#CHAM"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range CHAM => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("CHAM");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#DEVANAGARI"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range DEVANAGARI => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("DEVANAGARI");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#EASTERN_ARABIC"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range EASTERN_ARABIC => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("EASTERN_ARABIC");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#ETHIOPIC"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range ETHIOPIC => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("ETHIOPIC");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#EUROPEAN"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range EUROPEAN => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("EUROPEAN");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#GUJARATI"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range GUJARATI => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("GUJARATI");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#GURMUKHI"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range GURMUKHI => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("GURMUKHI");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#JAVANESE"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range JAVANESE => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("JAVANESE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#KANNADA"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range KANNADA => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("KANNADA");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#KAYAH_LI"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range KAYAH_LI => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("KAYAH_LI");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#KHMER"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range KHMER => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("KHMER");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#LAO"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range LAO => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("LAO");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#LEPCHA"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range LEPCHA => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("LEPCHA");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#LIMBU"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range LIMBU => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("LIMBU");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#MALAYALAM"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range MALAYALAM => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("MALAYALAM");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#MEETEI_MAYEK"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range MEETEI_MAYEK => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("MEETEI_MAYEK");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#MONGOLIAN"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range MONGOLIAN => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("MONGOLIAN");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#MYANMAR"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range MYANMAR => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("MYANMAR");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#MYANMAR_SHAN"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range MYANMAR_SHAN => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("MYANMAR_SHAN");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#MYANMAR_TAI_LAING"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range MYANMAR_TAI_LAING => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("MYANMAR_TAI_LAING");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#NEW_TAI_LUE"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range NEW_TAI_LUE => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("NEW_TAI_LUE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#NKO"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range NKO => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("NKO");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#OL_CHIKI"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range OL_CHIKI => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("OL_CHIKI");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#ORIYA"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range ORIYA => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("ORIYA");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#SAURASHTRA"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range SAURASHTRA => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("SAURASHTRA");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#SINHALA"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range SINHALA => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("SINHALA");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#SUNDANESE"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range SUNDANESE => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("SUNDANESE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#TAI_THAM_HORA"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range TAI_THAM_HORA => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("TAI_THAM_HORA");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#TAI_THAM_THAM"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range TAI_THAM_THAM => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("TAI_THAM_THAM");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#TAMIL"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range TAMIL => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("TAMIL");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#TELUGU"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range TELUGU => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("TELUGU");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#THAI"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range THAI => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("THAI");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#TIBETAN"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range TIBETAN => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("TIBETAN");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#VAI"/>
            /// </summary>
            public static Java.Awt.FontNs.NumericShaper.Range VAI => Clazz.GetField<Java.Awt.FontNs.NumericShaper.Range>("VAI");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/NumericShaper.Range.html#values()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Awt.FontNs.NumericShaper.Range"/></returns>
            public static Java.Awt.FontNs.NumericShaper.Range[] Values()
            {
                return SExecuteArray<Java.Awt.FontNs.NumericShaper.Range>("values");
            }
            
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