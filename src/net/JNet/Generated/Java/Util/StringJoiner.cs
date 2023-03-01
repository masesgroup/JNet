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

namespace Java.Util
{
    #region StringJoiner
    public partial class StringJoiner
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/StringJoiner.html#%3Cinit%3E(java.lang.CharSequence,java.lang.CharSequence,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        public StringJoiner(Java.Lang.CharSequence arg0, Java.Lang.CharSequence arg1, Java.Lang.CharSequence arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/StringJoiner.html#%3Cinit%3E(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public StringJoiner(Java.Lang.CharSequence arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/StringJoiner.html#length()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int Length()
        {
            return IExecute<int>("length");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/StringJoiner.html#add(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Util.StringJoiner"/></returns>
        public Java.Util.StringJoiner Add(Java.Lang.CharSequence arg0)
        {
            return IExecute<Java.Util.StringJoiner>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/StringJoiner.html#merge(java.util.StringJoiner)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.StringJoiner"/></param>
        /// <returns><see cref="Java.Util.StringJoiner"/></returns>
        public Java.Util.StringJoiner Merge(Java.Util.StringJoiner arg0)
        {
            return IExecute<Java.Util.StringJoiner>("merge", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/StringJoiner.html#setEmptyValue(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Util.StringJoiner"/></returns>
        public Java.Util.StringJoiner SetEmptyValue(Java.Lang.CharSequence arg0)
        {
            return IExecute<Java.Util.StringJoiner>("setEmptyValue", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}