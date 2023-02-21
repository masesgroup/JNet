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
    #region Formatter
    public partial class Formatter
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.io.File) throws java.io.FileNotFoundException
        /// </summary>
        public Formatter(Java.Io.File arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.io.File,java.lang.String) throws java.io.FileNotFoundException,java.io.UnsupportedEncodingException
        /// </summary>
        public Formatter(Java.Io.File arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.io.File,java.lang.String,java.util.Locale) throws java.io.FileNotFoundException,java.io.UnsupportedEncodingException
        /// </summary>
        public Formatter(Java.Io.File arg0, string arg1, Java.Util.Locale arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.lang.String,java.nio.charset.Charset,java.util.Locale) throws java.io.IOException
        /// </summary>
        public Formatter(string arg0, Java.Nio.Charset.Charset arg1, Java.Util.Locale arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.lang.String,java.lang.String,java.util.Locale) throws java.io.FileNotFoundException,java.io.UnsupportedEncodingException
        /// </summary>
        public Formatter(string arg0, string arg1, Java.Util.Locale arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.io.OutputStream,java.lang.String,java.util.Locale) throws java.io.UnsupportedEncodingException
        /// </summary>
        public Formatter(Java.Io.OutputStream arg0, string arg1, Java.Util.Locale arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.io.OutputStream,java.lang.String) throws java.io.UnsupportedEncodingException
        /// </summary>
        public Formatter(Java.Io.OutputStream arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.io.OutputStream,java.nio.charset.Charset,java.util.Locale)
        /// </summary>
        public Formatter(Java.Io.OutputStream arg0, Java.Nio.Charset.Charset arg1, Java.Util.Locale arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.io.PrintStream)
        /// </summary>
        public Formatter(Java.Io.PrintStream arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.io.File,java.nio.charset.Charset,java.util.Locale) throws java.io.IOException
        /// </summary>
        public Formatter(Java.Io.File arg0, Java.Nio.Charset.Charset arg1, Java.Util.Locale arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.lang.Appendable)
        /// </summary>
        public Formatter(Java.Lang.Appendable arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.io.OutputStream)
        /// </summary>
        public Formatter(Java.Io.OutputStream arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.lang.String,java.lang.String) throws java.io.FileNotFoundException,java.io.UnsupportedEncodingException
        /// </summary>
        public Formatter(string arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.lang.String) throws java.io.FileNotFoundException
        /// </summary>
        public Formatter(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.lang.Appendable,java.util.Locale)
        /// </summary>
        public Formatter(Java.Lang.Appendable arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#<init>(java.util.Locale)
        /// </summary>
        public Formatter(Java.Util.Locale arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Io.Closeable(Java.Util.Formatter t) => t.Cast<Java.Io.Closeable>();
        public static implicit operator Java.Io.Flushable(Java.Util.Formatter t) => t.Cast<Java.Io.Flushable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#ioException()
        /// </summary>
        public Java.Io.IOException IoException()
        {
            var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("ioException"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Io.IOException>(obj);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#out()
        /// </summary>
        public Java.Lang.Appendable Out()
        {
            return IExecute<Java.Lang.Appendable>("out");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#format(java.lang.String,java.lang.Object...)
        /// </summary>
        public Java.Util.Formatter Format(string arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Util.Formatter>("format", arg0); else return IExecute<Java.Util.Formatter>("format", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#format(java.util.Locale,java.lang.String,java.lang.Object...)
        /// </summary>
        public Java.Util.Formatter Format(Java.Util.Locale arg0, string arg1, params object[] arg2)
        {
            if (arg2.Length == 0) return IExecute<Java.Util.Formatter>("format", arg0, arg1); else return IExecute<Java.Util.Formatter>("format", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#locale()
        /// </summary>
        public Java.Util.Locale Locale()
        {
            return IExecute<Java.Util.Locale>("locale");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#close()
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.html#flush()
        /// </summary>
        public void Flush()
        {
            IExecute("flush");
        }
        
        #endregion

        #region Nested classes
        #region BigDecimalLayoutForm
        public partial class BigDecimalLayoutForm
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.BigDecimalLayoutForm.html#SCIENTIFIC
            /// </summary>
            public static Java.Util.Formatter.BigDecimalLayoutForm SCIENTIFIC => Clazz.GetField<Java.Util.Formatter.BigDecimalLayoutForm>("SCIENTIFIC");
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.BigDecimalLayoutForm.html#DECIMAL_FLOAT
            /// </summary>
            public static Java.Util.Formatter.BigDecimalLayoutForm DECIMAL_FLOAT => Clazz.GetField<Java.Util.Formatter.BigDecimalLayoutForm>("DECIMAL_FLOAT");
            
            #endregion

            #region Static methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Formatter.BigDecimalLayoutForm.html#values()
            /// </summary>
            public static Java.Util.Formatter.BigDecimalLayoutForm[] Values()
            {
                return SExecuteArray<Java.Util.Formatter.BigDecimalLayoutForm>("values");
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