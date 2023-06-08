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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Regex
{
    #region IMatchResult
    public partial interface IMatchResult
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/MatchResult.html#groupCount()"/> 
        /// </summary>
        int GroupCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/MatchResult.html#end()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        int End();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/MatchResult.html#end(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        int End(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/MatchResult.html#start()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        int Start();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/MatchResult.html#start(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        int Start(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/MatchResult.html#group()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        string Group();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/MatchResult.html#group(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        string Group(int arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MatchResult
    public partial class MatchResult : Java.Util.Regex.IMatchResult
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/MatchResult.html#groupCount()"/> 
        /// </summary>
        public int GroupCount
        {
            get { return IExecute<int>("groupCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/MatchResult.html#end()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int End()
        {
            return IExecute<int>("end");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/MatchResult.html#end(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int End(int arg0)
        {
            return IExecute<int>("end", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/MatchResult.html#start()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Start()
        {
            return IExecute<int>("start");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/MatchResult.html#start(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Start(int arg0)
        {
            return IExecute<int>("start", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/MatchResult.html#group()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Group()
        {
            return IExecute<string>("group");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/regex/MatchResult.html#group(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string Group(int arg0)
        {
            return IExecute<string>("group", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}