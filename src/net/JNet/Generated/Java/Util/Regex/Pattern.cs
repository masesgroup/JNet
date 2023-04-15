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

namespace Java.Util.Regex
{
    #region Pattern
    public partial class Pattern
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Regex.Pattern"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Regex.Pattern t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#CANON_EQ"/>
        /// </summary>
        public static int CANON_EQ => Clazz.GetField<int>("CANON_EQ");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#CASE_INSENSITIVE"/>
        /// </summary>
        public static int CASE_INSENSITIVE => Clazz.GetField<int>("CASE_INSENSITIVE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#COMMENTS"/>
        /// </summary>
        public static int COMMENTS => Clazz.GetField<int>("COMMENTS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#DOTALL"/>
        /// </summary>
        public static int DOTALL => Clazz.GetField<int>("DOTALL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#LITERAL"/>
        /// </summary>
        public static int LITERAL => Clazz.GetField<int>("LITERAL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#MULTILINE"/>
        /// </summary>
        public static int MULTILINE => Clazz.GetField<int>("MULTILINE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#UNICODE_CASE"/>
        /// </summary>
        public static int UNICODE_CASE => Clazz.GetField<int>("UNICODE_CASE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#UNICODE_CHARACTER_CLASS"/>
        /// </summary>
        public static int UNICODE_CHARACTER_CLASS => Clazz.GetField<int>("UNICODE_CHARACTER_CLASS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#UNIX_LINES"/>
        /// </summary>
        public static int UNIX_LINES => Clazz.GetField<int>("UNIX_LINES");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#matches(java.lang.String,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Matches(string arg0, Java.Lang.CharSequence arg1)
        {
            return SExecute<bool>(LocalClazz, "matches", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#quote(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public static string Quote(string arg0)
        {
            return SExecute<string>(LocalClazz, "quote", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#compile(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Regex.Pattern"/></returns>
        public static Java.Util.Regex.Pattern Compile(string arg0, int arg1)
        {
            return SExecute<Java.Util.Regex.Pattern>(LocalClazz, "compile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#compile(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Regex.Pattern"/></returns>
        public static Java.Util.Regex.Pattern Compile(string arg0)
        {
            return SExecute<Java.Util.Regex.Pattern>(LocalClazz, "compile", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#asMatchPredicate()"/> 
        /// </summary>
        public Java.Util.Function.Predicate<string> AsMatchPredicate
        {
            get { return IExecute<Java.Util.Function.Predicate<string>>("asMatchPredicate"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#asPredicate()"/> 
        /// </summary>
        public Java.Util.Function.Predicate<string> AsPredicate
        {
            get { return IExecute<Java.Util.Function.Predicate<string>>("asPredicate"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#flags()"/> 
        /// </summary>
        public int Flags
        {
            get { return IExecute<int>("flags"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#pattern()"/> 
        /// </summary>
        public string PatternMethod
        {
            get { return IExecute<string>("pattern"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#split(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] Split(Java.Lang.CharSequence arg0, int arg1)
        {
            return IExecuteArray<string>("split", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#split(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] Split(Java.Lang.CharSequence arg0)
        {
            return IExecuteArray<string>("split", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#matcher(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher Matcher(Java.Lang.CharSequence arg0)
        {
            return IExecute<Java.Util.Regex.Matcher>("matcher", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Pattern.html#splitAsStream(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<string> SplitAsStream(Java.Lang.CharSequence arg0)
        {
            return IExecute<Java.Util.Stream.Stream<string>>("splitAsStream", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}