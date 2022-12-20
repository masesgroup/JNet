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

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Byte.html"/>
    /// </summary>
    public sealed class Byte : Number
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.Byte";
        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => false;
        /// <summary>
        /// Compares two <see cref="byte"/> values numerically.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Compare​(byte x, byte y) => SExecute<int>("compare​​​​​", x, y);
        /// <summary>
        /// Compares two <see cref="Byte"/> objects numerically.
        /// </summary>
        /// <param name="anotherByte"></param>
        /// <returns></returns>
        public int CompareTo​(Byte anotherByte) => IExecute<int>("compareTo​​​​​​", anotherByte);
        /// <summary>
        /// Compares two byte values numerically treating the values as unsigned.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int CompareUnsigned​(byte x, byte y) => SExecute<int>("compareUnsigned​​​​​​", x, y);
        /// <summary>
        /// Decodes a <see cref="string"/> into a <see cref="Byte"/>.
        /// </summary>
        /// <param name="nm"></param>
        /// <returns></returns>
        public static Byte Decode​(string nm) => SExecute<Byte>("decode​​​​​​​", nm);
        /// <summary>
        /// Returns a hash code for a <see cref="byte"/> value; compatible with Byte.hashCode().
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int HashCode​(byte value) => SExecute<int>("hashCode​​​​​​​​", value);
        /// <summary>
        /// Parses the <see cref="string"/> argument as a signed decimal <see cref="byte"/>.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte ParseByte​(string s) => SExecute<byte>("parseByte​​​​​​​​​", s);
        /// <summary>
        /// Parses the <see cref="string"/> argument as a signed <see cref="byte"/> in the radix specified by the second argument.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="radix"></param>
        /// <returns></returns>
        public static byte ParseByte​(string s, int radix) => SExecute<byte>("parseByte​​​​​​​​​", s, radix);
        /// <summary>
        /// Returns a new <see cref="string"/> object representing the specified byte.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string ToString​(byte b) => SExecute<string>("toString​​​​", b);
        /// <summary>
        /// Converts the argument to an <see cref="int"/> by an unsigned conversion.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int ToUnsignedInt​(byte x) => SExecute<int>("toUnsignedInt​​​", x);
        /// <summary>
        /// Converts the argument to a <see cref="long"/> by an unsigned conversion.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static long ToUnsignedLong​(byte x) => SExecute<long>("toUnsignedLong​​​​", x);
        /// <summary>
        /// Returns a <see cref="Byte"/> instance representing the specified <see cref="byte"/> value.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Byte ValueOf​(byte b) => SExecute<Byte>("valueOf​", b);
        /// <summary>
        /// Returns a <see cref="Byte"/> object holding the value given by the specified <see cref="string"/>.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Byte ValueOf​(string s) => SExecute<Byte>("valueOf​", s);
        /// <summary>
        /// Returns a <see cref="Byte"/> object holding the value extracted from the specified <see cref="string"/> when parsed with the radix given by the second argument.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="radix"></param>
        /// <returns></returns>
        public static Byte ValueOf​(string s, int radix) => SExecute<Byte>("valueOf​", s, radix);
    }
}
