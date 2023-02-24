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
    #region Scanner
    public partial class Scanner
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.io.File,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see langword="string"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Scanner(Java.Io.File arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.io.File,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Scanner(Java.Io.File arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Scanner(Java.Io.File arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.io.InputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see langword="string"/></param>
        public Scanner(Java.Io.InputStream arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.io.InputStream,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        public Scanner(Java.Io.InputStream arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        public Scanner(Java.Io.InputStream arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.lang.Readable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Readable"/></param>
        public Scanner(Java.Lang.Readable arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        public Scanner(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.nio.channels.ReadableByteChannel,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.ReadableByteChannel"/></param>
        /// <param name="arg1"><see langword="string"/></param>
        public Scanner(Java.Nio.Channels.ReadableByteChannel arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.nio.channels.ReadableByteChannel,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.ReadableByteChannel"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        public Scanner(Java.Nio.Channels.ReadableByteChannel arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.nio.channels.ReadableByteChannel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.ReadableByteChannel"/></param>
        public Scanner(Java.Nio.Channels.ReadableByteChannel arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.nio.file.Path,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see langword="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Scanner(Java.Nio.File.Path arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.nio.file.Path,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Scanner(Java.Nio.File.Path arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#%3Cinit%3E(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Scanner(Java.Nio.File.Path arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Scanner"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Util.Scanner t) => t.Cast<Java.Io.Closeable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNext()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasNext()
        {
            return IExecute<bool>("hasNext");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNext(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool HasNext(string arg0)
        {
            return IExecute<bool>("hasNext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNext(java.util.regex.Pattern)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool HasNext(Java.Util.Regex.Pattern arg0)
        {
            return IExecute<bool>("hasNext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextBigDecimal()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasNextBigDecimal()
        {
            return IExecute<bool>("hasNextBigDecimal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextBigInteger()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasNextBigInteger()
        {
            return IExecute<bool>("hasNextBigInteger");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextBigInteger(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool HasNextBigInteger(int arg0)
        {
            return IExecute<bool>("hasNextBigInteger", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextBoolean()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasNextBoolean()
        {
            return IExecute<bool>("hasNextBoolean");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextByte()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasNextByte()
        {
            return IExecute<bool>("hasNextByte");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextByte(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool HasNextByte(int arg0)
        {
            return IExecute<bool>("hasNextByte", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextDouble()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasNextDouble()
        {
            return IExecute<bool>("hasNextDouble");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextFloat()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasNextFloat()
        {
            return IExecute<bool>("hasNextFloat");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextInt()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasNextInt()
        {
            return IExecute<bool>("hasNextInt");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool HasNextInt(int arg0)
        {
            return IExecute<bool>("hasNextInt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextLine()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasNextLine()
        {
            return IExecute<bool>("hasNextLine");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextLong()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasNextLong()
        {
            return IExecute<bool>("hasNextLong");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextLong(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool HasNextLong(int arg0)
        {
            return IExecute<bool>("hasNextLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextShort()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasNextShort()
        {
            return IExecute<bool>("hasNextShort");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#hasNextShort(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool HasNextShort(int arg0)
        {
            return IExecute<bool>("hasNextShort", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextBoolean()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool NextBoolean()
        {
            return IExecute<bool>("nextBoolean");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextByte()"/>
        /// </summary>
        
        /// <returns><see langword="byte"/></returns>
        public byte NextByte()
        {
            return IExecute<byte>("nextByte");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextByte(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="byte"/></returns>
        public byte NextByte(int arg0)
        {
            return IExecute<byte>("nextByte", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextDouble()"/>
        /// </summary>
        
        /// <returns><see langword="double"/></returns>
        public double NextDouble()
        {
            return IExecute<double>("nextDouble");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextFloat()"/>
        /// </summary>
        
        /// <returns><see langword="float"/></returns>
        public float NextFloat()
        {
            return IExecute<float>("nextFloat");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextInt()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int NextInt()
        {
            return IExecute<int>("nextInt");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="int"/></returns>
        public int NextInt(int arg0)
        {
            return IExecute<int>("nextInt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#radix()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int Radix()
        {
            return IExecute<int>("radix");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#ioException()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Io.IOException"/></returns>
        public Java.Io.IOException IoException()
        {
            var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("ioException"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Io.IOException>(obj);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#next()"/>
        /// </summary>
        
        /// <returns><see langword="object"/></returns>
        public object Next()
        {
            return IExecute("next");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#findInLine(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see langword="string"/></returns>
        public string FindInLine(string arg0)
        {
            return IExecute<string>("findInLine", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#findInLine(java.util.regex.Pattern)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <returns><see langword="string"/></returns>
        public string FindInLine(Java.Util.Regex.Pattern arg0)
        {
            return IExecute<string>("findInLine", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#findWithinHorizon(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <returns><see langword="string"/></returns>
        public string FindWithinHorizon(string arg0, int arg1)
        {
            return IExecute<string>("findWithinHorizon", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#findWithinHorizon(java.util.regex.Pattern,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <returns><see langword="string"/></returns>
        public string FindWithinHorizon(Java.Util.Regex.Pattern arg0, int arg1)
        {
            return IExecute<string>("findWithinHorizon", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#next(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see langword="string"/></returns>
        public string Next(string arg0)
        {
            return IExecute<string>("next", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#next(java.util.regex.Pattern)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <returns><see langword="string"/></returns>
        public string Next(Java.Util.Regex.Pattern arg0)
        {
            return IExecute<string>("next", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextLine()"/>
        /// </summary>
        
        /// <returns><see langword="string"/></returns>
        public string NextLine()
        {
            return IExecute<string>("nextLine");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextBigDecimal()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal NextBigDecimal()
        {
            return IExecute<Java.Math.BigDecimal>("nextBigDecimal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextBigInteger()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger NextBigInteger()
        {
            return IExecute<Java.Math.BigInteger>("nextBigInteger");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextBigInteger(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger NextBigInteger(int arg0)
        {
            return IExecute<Java.Math.BigInteger>("nextBigInteger", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#locale()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public Java.Util.Locale Locale()
        {
            return IExecute<Java.Util.Locale>("locale");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#match()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Regex.MatchResult"/></returns>
        public Java.Util.Regex.MatchResult Match()
        {
            return IExecute<Java.Util.Regex.MatchResult>("match");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#delimiter()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Regex.Pattern"/></returns>
        public Java.Util.Regex.Pattern Delimiter()
        {
            return IExecute<Java.Util.Regex.Pattern>("delimiter");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#reset()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Scanner"/></returns>
        public Java.Util.Scanner Reset()
        {
            return IExecute<Java.Util.Scanner>("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#skip(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see cref="Java.Util.Scanner"/></returns>
        public Java.Util.Scanner Skip(string arg0)
        {
            return IExecute<Java.Util.Scanner>("skip", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#skip(java.util.regex.Pattern)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <returns><see cref="Java.Util.Scanner"/></returns>
        public Java.Util.Scanner Skip(Java.Util.Regex.Pattern arg0)
        {
            return IExecute<Java.Util.Scanner>("skip", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#useDelimiter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see cref="Java.Util.Scanner"/></returns>
        public Java.Util.Scanner UseDelimiter(string arg0)
        {
            return IExecute<Java.Util.Scanner>("useDelimiter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#useDelimiter(java.util.regex.Pattern)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <returns><see cref="Java.Util.Scanner"/></returns>
        public Java.Util.Scanner UseDelimiter(Java.Util.Regex.Pattern arg0)
        {
            return IExecute<Java.Util.Scanner>("useDelimiter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#useLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Util.Scanner"/></returns>
        public Java.Util.Scanner UseLocale(Java.Util.Locale arg0)
        {
            return IExecute<Java.Util.Scanner>("useLocale", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#useRadix(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Util.Scanner"/></returns>
        public Java.Util.Scanner UseRadix(int arg0)
        {
            return IExecute<Java.Util.Scanner>("useRadix", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextLong()"/>
        /// </summary>
        
        /// <returns><see langword="long"/></returns>
        public long NextLong()
        {
            return IExecute<long>("nextLong");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextLong(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="long"/></returns>
        public long NextLong(int arg0)
        {
            return IExecute<long>("nextLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextShort()"/>
        /// </summary>
        
        /// <returns><see langword="short"/></returns>
        public short NextShort()
        {
            return IExecute<short>("nextShort");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#nextShort(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="short"/></returns>
        public short NextShort(int arg0)
        {
            return IExecute<short>("nextShort", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Scanner.html#remove()"/>
        /// </summary>
        public void Remove()
        {
            IExecute("remove");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}