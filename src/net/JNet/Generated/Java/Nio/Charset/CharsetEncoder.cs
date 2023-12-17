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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.Charset
{
    #region CharsetEncoder
    public partial class CharsetEncoder
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#canEncode(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanEncode(char arg0)
        {
            return IExecute<bool>("canEncode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#canEncode(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanEncode(Java.Lang.CharSequence arg0)
        {
            return IExecute<bool>("canEncode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#isLegalReplacement(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsLegalReplacement(byte[] arg0)
        {
            return IExecute<bool>("isLegalReplacement", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#replacement()"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        public byte[] Replacement()
        {
            return IExecuteArray<byte>("replacement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#averageBytesPerChar()"/>
        /// </summary>

        /// <returns><see cref="float"/></returns>
        public float AverageBytesPerChar()
        {
            return IExecute<float>("averageBytesPerChar");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#maxBytesPerChar()"/>
        /// </summary>

        /// <returns><see cref="float"/></returns>
        public float MaxBytesPerChar()
        {
            return IExecute<float>("maxBytesPerChar");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#encode(java.nio.CharBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.CharBuffer"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        /// <exception cref="Java.Nio.Charset.CharacterCodingException"/>
        public Java.Nio.ByteBuffer Encode(Java.Nio.CharBuffer arg0)
        {
            return IExecute<Java.Nio.ByteBuffer>("encode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#charset()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Charset.Charset"/></returns>
        public Java.Nio.Charset.Charset Charset()
        {
            return IExecute<Java.Nio.Charset.Charset>("charset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#onMalformedInput(java.nio.charset.CodingErrorAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Charset.CodingErrorAction"/></param>
        /// <returns><see cref="Java.Nio.Charset.CharsetEncoder"/></returns>
        public Java.Nio.Charset.CharsetEncoder OnMalformedInput(Java.Nio.Charset.CodingErrorAction arg0)
        {
            return IExecute<Java.Nio.Charset.CharsetEncoder>("onMalformedInput", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#onUnmappableCharacter(java.nio.charset.CodingErrorAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Charset.CodingErrorAction"/></param>
        /// <returns><see cref="Java.Nio.Charset.CharsetEncoder"/></returns>
        public Java.Nio.Charset.CharsetEncoder OnUnmappableCharacter(Java.Nio.Charset.CodingErrorAction arg0)
        {
            return IExecute<Java.Nio.Charset.CharsetEncoder>("onUnmappableCharacter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#replaceWith(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Nio.Charset.CharsetEncoder"/></returns>
        public Java.Nio.Charset.CharsetEncoder ReplaceWith(byte[] arg0)
        {
            return IExecute<Java.Nio.Charset.CharsetEncoder>("replaceWith", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#reset()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Charset.CharsetEncoder"/></returns>
        public Java.Nio.Charset.CharsetEncoder Reset()
        {
            return IExecute<Java.Nio.Charset.CharsetEncoder>("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#encode(java.nio.CharBuffer,java.nio.ByteBuffer,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.CharBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Nio.Charset.CoderResult"/></returns>
        public Java.Nio.Charset.CoderResult Encode(Java.Nio.CharBuffer arg0, Java.Nio.ByteBuffer arg1, bool arg2)
        {
            return IExecute<Java.Nio.Charset.CoderResult>("encode", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#flush(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Nio.Charset.CoderResult"/></returns>
        public Java.Nio.Charset.CoderResult Flush(Java.Nio.ByteBuffer arg0)
        {
            return IExecute<Java.Nio.Charset.CoderResult>("flush", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#malformedInputAction()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Charset.CodingErrorAction"/></returns>
        public Java.Nio.Charset.CodingErrorAction MalformedInputAction()
        {
            return IExecute<Java.Nio.Charset.CodingErrorAction>("malformedInputAction");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/charset/CharsetEncoder.html#unmappableCharacterAction()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Charset.CodingErrorAction"/></returns>
        public Java.Nio.Charset.CodingErrorAction UnmappableCharacterAction()
        {
            return IExecute<Java.Nio.Charset.CodingErrorAction>("unmappableCharacterAction");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}