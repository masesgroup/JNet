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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Regex
{
    #region Matcher
    public partial class Matcher
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#quoteReplacement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public static string QuoteReplacement(string arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "quoteReplacement", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#find()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Find()
        {
            return IExecute<bool>("find");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#find(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Find(int arg0)
        {
            return IExecute<bool>("find", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#hasAnchoringBounds()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasAnchoringBounds()
        {
            return IExecute<bool>("hasAnchoringBounds");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#hasTransparentBounds()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasTransparentBounds()
        {
            return IExecute<bool>("hasTransparentBounds");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#hitEnd()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HitEnd()
        {
            return IExecute<bool>("hitEnd");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#lookingAt()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool LookingAt()
        {
            return IExecute<bool>("lookingAt");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#matches()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Matches()
        {
            return IExecute<bool>("matches");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#requireEnd()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool RequireEnd()
        {
            return IExecute<bool>("requireEnd");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#end()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int End()
        {
            return IExecute<int>("end");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#end(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int End(int arg0)
        {
            return IExecute<int>("end", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#end(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int End(string arg0)
        {
            return IExecute<int>("end", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#groupCount()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int GroupCount()
        {
            return IExecute<int>("groupCount");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#regionEnd()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int RegionEnd()
        {
            return IExecute<int>("regionEnd");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#regionStart()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int RegionStart()
        {
            return IExecute<int>("regionStart");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#start()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Start()
        {
            return IExecute<int>("start");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#start(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Start(int arg0)
        {
            return IExecute<int>("start", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#start(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int Start(string arg0)
        {
            return IExecute<int>("start", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#group()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Group()
        {
            return IExecute<string>("group");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#group(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string Group(int arg0)
        {
            return IExecute<string>("group", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#group(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string Group(string arg0)
        {
            return IExecute<string>("group", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#replaceAll(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string ReplaceAll(string arg0)
        {
            return IExecute<string>("replaceAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#replaceAll(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="string"/></returns>
        public string ReplaceAll(Java.Util.Function.Function<Java.Util.Regex.MatchResult, string> arg0)
        {
            return IExecute<string>("replaceAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#replaceFirst(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string ReplaceFirst(string arg0)
        {
            return IExecute<string>("replaceFirst", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#replaceFirst(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="string"/></returns>
        public string ReplaceFirst(Java.Util.Function.Function<Java.Util.Regex.MatchResult, string> arg0)
        {
            return IExecute<string>("replaceFirst", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#appendTail(java.lang.StringBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.StringBuffer"/></param>
        /// <returns><see cref="Java.Lang.StringBuffer"/></returns>
        public Java.Lang.StringBuffer AppendTail(Java.Lang.StringBuffer arg0)
        {
            return IExecute<Java.Lang.StringBuffer>("appendTail", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#appendTail(java.lang.StringBuilder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.StringBuilder"/></param>
        /// <returns><see cref="Java.Lang.StringBuilder"/></returns>
        public Java.Lang.StringBuilder AppendTail(Java.Lang.StringBuilder arg0)
        {
            return IExecute<Java.Lang.StringBuilder>("appendTail", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#appendReplacement(java.lang.StringBuffer,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.StringBuffer"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher AppendReplacement(Java.Lang.StringBuffer arg0, string arg1)
        {
            return IExecute<Java.Util.Regex.Matcher>("appendReplacement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#appendReplacement(java.lang.StringBuilder,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.StringBuilder"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher AppendReplacement(Java.Lang.StringBuilder arg0, string arg1)
        {
            return IExecute<Java.Util.Regex.Matcher>("appendReplacement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#region(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher Region(int arg0, int arg1)
        {
            return IExecute<Java.Util.Regex.Matcher>("region", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#reset()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher Reset()
        {
            return IExecute<Java.Util.Regex.Matcher>("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#reset(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher Reset(Java.Lang.CharSequence arg0)
        {
            return IExecute<Java.Util.Regex.Matcher>("reset", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#useAnchoringBounds(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher UseAnchoringBounds(bool arg0)
        {
            return IExecute<Java.Util.Regex.Matcher>("useAnchoringBounds", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#usePattern(java.util.regex.Pattern)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher UsePattern(Java.Util.Regex.Pattern arg0)
        {
            return IExecute<Java.Util.Regex.Matcher>("usePattern", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#useTransparentBounds(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher UseTransparentBounds(bool arg0)
        {
            return IExecute<Java.Util.Regex.Matcher>("useTransparentBounds", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#toMatchResult()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Regex.MatchResult"/></returns>
        public Java.Util.Regex.MatchResult ToMatchResult()
        {
            return IExecute<Java.Util.Regex.MatchResult>("toMatchResult");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#pattern()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Regex.Pattern"/></returns>
        public Java.Util.Regex.Pattern Pattern()
        {
            return IExecute<Java.Util.Regex.Pattern>("pattern");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#results()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Util.Regex.MatchResult> Results()
        {
            return IExecute<Java.Util.Stream.Stream<Java.Util.Regex.MatchResult>>("results");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}