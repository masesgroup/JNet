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

namespace Java.Util.Regex
{
    #region Matcher
    public partial class Matcher
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Util.Regex.MatchResult(Java.Util.Regex.Matcher t) => t.Cast<Java.Util.Regex.MatchResult>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#quoteReplacement(java.lang.String)
        /// </summary>
        public static string QuoteReplacement(string arg0)
        {
            return SExecute<string>("quoteReplacement", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#find()
        /// </summary>
        public bool Find()
        {
            return IExecute<bool>("find");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#find(int)
        /// </summary>
        public bool Find(int arg0)
        {
            return IExecute<bool>("find", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#hasAnchoringBounds()
        /// </summary>
        public bool HasAnchoringBounds()
        {
            return IExecute<bool>("hasAnchoringBounds");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#hasTransparentBounds()
        /// </summary>
        public bool HasTransparentBounds()
        {
            return IExecute<bool>("hasTransparentBounds");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#hitEnd()
        /// </summary>
        public bool HitEnd()
        {
            return IExecute<bool>("hitEnd");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#lookingAt()
        /// </summary>
        public bool LookingAt()
        {
            return IExecute<bool>("lookingAt");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#matches()
        /// </summary>
        public bool Matches()
        {
            return IExecute<bool>("matches");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#requireEnd()
        /// </summary>
        public bool RequireEnd()
        {
            return IExecute<bool>("requireEnd");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#end()
        /// </summary>
        public int End()
        {
            return IExecute<int>("end");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#end(int)
        /// </summary>
        public int End(int arg0)
        {
            return IExecute<int>("end", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#end(java.lang.String)
        /// </summary>
        public int End(string arg0)
        {
            return IExecute<int>("end", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#groupCount()
        /// </summary>
        public int GroupCount()
        {
            return IExecute<int>("groupCount");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#regionEnd()
        /// </summary>
        public int RegionEnd()
        {
            return IExecute<int>("regionEnd");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#regionStart()
        /// </summary>
        public int RegionStart()
        {
            return IExecute<int>("regionStart");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#start()
        /// </summary>
        public int Start()
        {
            return IExecute<int>("start");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#start(int)
        /// </summary>
        public int Start(int arg0)
        {
            return IExecute<int>("start", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#start(java.lang.String)
        /// </summary>
        public int Start(string arg0)
        {
            return IExecute<int>("start", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#group()
        /// </summary>
        public string Group()
        {
            return IExecute<string>("group");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#group(int)
        /// </summary>
        public string Group(int arg0)
        {
            return IExecute<string>("group", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#group(java.lang.String)
        /// </summary>
        public string Group(string arg0)
        {
            return IExecute<string>("group", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#replaceAll(java.lang.String)
        /// </summary>
        public string ReplaceAll(string arg0)
        {
            return IExecute<string>("replaceAll", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#replaceFirst(java.lang.String)
        /// </summary>
        public string ReplaceFirst(string arg0)
        {
            return IExecute<string>("replaceFirst", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#appendTail(java.lang.StringBuffer)
        /// </summary>
        public Java.Lang.StringBuffer AppendTail(Java.Lang.StringBuffer arg0)
        {
            return IExecute<Java.Lang.StringBuffer>("appendTail", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#appendTail(java.lang.StringBuilder)
        /// </summary>
        public Java.Lang.StringBuilder AppendTail(Java.Lang.StringBuilder arg0)
        {
            return IExecute<Java.Lang.StringBuilder>("appendTail", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#appendReplacement(java.lang.StringBuffer,java.lang.String)
        /// </summary>
        public Java.Util.Regex.Matcher AppendReplacement(Java.Lang.StringBuffer arg0, string arg1)
        {
            return IExecute<Java.Util.Regex.Matcher>("appendReplacement", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#appendReplacement(java.lang.StringBuilder,java.lang.String)
        /// </summary>
        public Java.Util.Regex.Matcher AppendReplacement(Java.Lang.StringBuilder arg0, string arg1)
        {
            return IExecute<Java.Util.Regex.Matcher>("appendReplacement", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#region(int,int)
        /// </summary>
        public Java.Util.Regex.Matcher Region(int arg0, int arg1)
        {
            return IExecute<Java.Util.Regex.Matcher>("region", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#reset()
        /// </summary>
        public Java.Util.Regex.Matcher Reset()
        {
            return IExecute<Java.Util.Regex.Matcher>("reset");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#reset(java.lang.CharSequence)
        /// </summary>
        public Java.Util.Regex.Matcher Reset(Java.Lang.CharSequence arg0)
        {
            return IExecute<Java.Util.Regex.Matcher>("reset", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#useAnchoringBounds(boolean)
        /// </summary>
        public Java.Util.Regex.Matcher UseAnchoringBounds(bool arg0)
        {
            return IExecute<Java.Util.Regex.Matcher>("useAnchoringBounds", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#usePattern(java.util.regex.Pattern)
        /// </summary>
        public Java.Util.Regex.Matcher UsePattern(Java.Util.Regex.Pattern arg0)
        {
            return IExecute<Java.Util.Regex.Matcher>("usePattern", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#useTransparentBounds(boolean)
        /// </summary>
        public Java.Util.Regex.Matcher UseTransparentBounds(bool arg0)
        {
            return IExecute<Java.Util.Regex.Matcher>("useTransparentBounds", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#toMatchResult()
        /// </summary>
        public Java.Util.Regex.MatchResult ToMatchResult()
        {
            return IExecute<Java.Util.Regex.MatchResult>("toMatchResult");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/Matcher.html#pattern()
        /// </summary>
        public Java.Util.Regex.Pattern Pattern()
        {
            return IExecute<Java.Util.Regex.Pattern>("pattern");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}