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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Text
{
    #region Normalizer
    public partial class Normalizer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.html#isNormalized(java.lang.CharSequence,java.text.Normalizer.Form)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Text.Normalizer.Form"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNormalized(Java.Lang.CharSequence arg0, Java.Text.Normalizer.Form arg1)
        {
            return SExecute<bool>("isNormalized", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.html#normalize(java.lang.CharSequence,java.text.Normalizer.Form)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Text.Normalizer.Form"/></param>
        /// <returns><see cref="string"/></returns>
        public static string Normalize(Java.Lang.CharSequence arg0, Java.Text.Normalizer.Form arg1)
        {
            return SExecute<string>("normalize", arg0, arg1);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Form
        public partial class Form
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.Form.html#NFC"/>
            /// </summary>
            public static Java.Text.Normalizer.Form NFC => Clazz.GetField<Java.Text.Normalizer.Form>("NFC");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.Form.html#NFD"/>
            /// </summary>
            public static Java.Text.Normalizer.Form NFD => Clazz.GetField<Java.Text.Normalizer.Form>("NFD");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.Form.html#NFKC"/>
            /// </summary>
            public static Java.Text.Normalizer.Form NFKC => Clazz.GetField<Java.Text.Normalizer.Form>("NFKC");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.Form.html#NFKD"/>
            /// </summary>
            public static Java.Text.Normalizer.Form NFKD => Clazz.GetField<Java.Text.Normalizer.Form>("NFKD");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.Form.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Text.Normalizer.Form"/></returns>
            public static Java.Text.Normalizer.Form ValueOf(string arg0)
            {
                return SExecute<Java.Text.Normalizer.Form>("valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/Normalizer.Form.html#values()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Text.Normalizer.Form"/></returns>
            public static Java.Text.Normalizer.Form[] Values()
            {
                return SExecuteArray<Java.Text.Normalizer.Form>("values");
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