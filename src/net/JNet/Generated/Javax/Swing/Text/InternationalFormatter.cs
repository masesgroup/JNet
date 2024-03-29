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

namespace Javax.Swing.Text
{
    #region InternationalFormatter
    public partial class InternationalFormatter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/InternationalFormatter.html#%3Cinit%3E(java.text.Format)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.Format"/></param>
        public InternationalFormatter(Java.Text.Format arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/InternationalFormatter.html#getFormat()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/InternationalFormatter.html#setFormat(java.text.Format)"/>
        /// </summary>
        public Java.Text.Format Format
        {
            get { return IExecuteWithSignature<Java.Text.Format>("getFormat", "()Ljava/text/Format;"); } set { IExecuteWithSignature("setFormat", "(Ljava/text/Format;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/InternationalFormatter.html#getMaximum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/InternationalFormatter.html#setMaximum(java.lang.Comparable)"/>
        /// </summary>
        public Java.Lang.Comparable<object> Maximum
        {
            get { return IExecuteWithSignature<Java.Lang.Comparable<object>>("getMaximum", "()Ljava/lang/Comparable;"); } set { IExecuteWithSignature("setMaximum", "(Ljava/lang/Comparable;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/InternationalFormatter.html#getMinimum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/InternationalFormatter.html#setMinimum(java.lang.Comparable)"/>
        /// </summary>
        public Java.Lang.Comparable<object> Minimum
        {
            get { return IExecuteWithSignature<Java.Lang.Comparable<object>>("getMinimum", "()Ljava/lang/Comparable;"); } set { IExecuteWithSignature("setMinimum", "(Ljava/lang/Comparable;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/InternationalFormatter.html#getFields(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Text.Format.Field"/></returns>
        public Java.Text.Format.Field[] GetFields(int arg0)
        {
            return IExecuteWithSignatureArray<Java.Text.Format.Field>("getFields", "(I)[Ljava/text/Format$Field;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}