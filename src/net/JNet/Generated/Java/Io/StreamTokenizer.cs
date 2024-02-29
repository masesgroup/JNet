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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Io
{
    #region StreamTokenizer
    public partial class StreamTokenizer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#%3Cinit%3E(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        public StreamTokenizer(Java.Io.Reader arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#nval"/>
        /// </summary>
        public double nval { get { return IGetField<double>("nval"); } set { ISetField("nval", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#ttype"/>
        /// </summary>
        public int ttype { get { return IGetField<int>("ttype"); } set { ISetField("ttype", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#sval"/>
        /// </summary>
        public Java.Lang.String sval { get { return IGetField<Java.Lang.String>("sval"); } set { ISetField("sval", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#TT_EOF"/>
        /// </summary>
        public static int TT_EOF { get { if (!_TT_EOFReady) { _TT_EOFContent = SGetField<int>(LocalBridgeClazz, "TT_EOF"); _TT_EOFReady = true; } return _TT_EOFContent; } }
        private static int _TT_EOFContent = default;
        private static bool _TT_EOFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#TT_EOL"/>
        /// </summary>
        public static int TT_EOL { get { if (!_TT_EOLReady) { _TT_EOLContent = SGetField<int>(LocalBridgeClazz, "TT_EOL"); _TT_EOLReady = true; } return _TT_EOLContent; } }
        private static int _TT_EOLContent = default;
        private static bool _TT_EOLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#TT_NUMBER"/>
        /// </summary>
        public static int TT_NUMBER { get { if (!_TT_NUMBERReady) { _TT_NUMBERContent = SGetField<int>(LocalBridgeClazz, "TT_NUMBER"); _TT_NUMBERReady = true; } return _TT_NUMBERContent; } }
        private static int _TT_NUMBERContent = default;
        private static bool _TT_NUMBERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#TT_WORD"/>
        /// </summary>
        public static int TT_WORD { get { if (!_TT_WORDReady) { _TT_WORDContent = SGetField<int>(LocalBridgeClazz, "TT_WORD"); _TT_WORDReady = true; } return _TT_WORDContent; } }
        private static int _TT_WORDContent = default;
        private static bool _TT_WORDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#lineno()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Lineno()
        {
            return IExecuteWithSignature<int>("lineno", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#nextToken()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int NextToken()
        {
            return IExecuteWithSignature<int>("nextToken", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#commentChar(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void CommentChar(int arg0)
        {
            IExecuteWithSignature("commentChar", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#eolIsSignificant(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void EolIsSignificant(bool arg0)
        {
            IExecuteWithSignature("eolIsSignificant", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#lowerCaseMode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void LowerCaseMode(bool arg0)
        {
            IExecuteWithSignature("lowerCaseMode", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#ordinaryChar(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OrdinaryChar(int arg0)
        {
            IExecuteWithSignature("ordinaryChar", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#ordinaryChars(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OrdinaryChars(int arg0, int arg1)
        {
            IExecute("ordinaryChars", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#parseNumbers()"/>
        /// </summary>
        public void ParseNumbers()
        {
            IExecuteWithSignature("parseNumbers", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#pushBack()"/>
        /// </summary>
        public void PushBack()
        {
            IExecuteWithSignature("pushBack", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#quoteChar(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void QuoteChar(int arg0)
        {
            IExecuteWithSignature("quoteChar", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#resetSyntax()"/>
        /// </summary>
        public void ResetSyntax()
        {
            IExecuteWithSignature("resetSyntax", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#slashSlashComments(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SlashSlashComments(bool arg0)
        {
            IExecuteWithSignature("slashSlashComments", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#slashStarComments(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SlashStarComments(bool arg0)
        {
            IExecuteWithSignature("slashStarComments", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#whitespaceChars(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WhitespaceChars(int arg0, int arg1)
        {
            IExecute("whitespaceChars", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/StreamTokenizer.html#wordChars(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WordChars(int arg0, int arg1)
        {
            IExecute("wordChars", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}