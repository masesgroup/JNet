/*
*  Copyright 2025 MASES s.r.l.
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
using MASES.JNet.Specific.Extensions;
using System.Runtime.CompilerServices;
using SystemNet = System;

namespace Java.Lang
{
    public partial class String : JVMBridgeBase<String>, INativeConvertible<String, string>, SystemNet.IComparable<String>, SystemNet.IEquatable<String>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/String.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public String(string arg0)
            : base(arg0)
        {
        }
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="String"/> to <see cref="string"/>
        /// </summary>
        public static implicit operator string(String b) => b != null ? b.ToString() : null;
        /// <summary>
        /// Converter from <see cref="string"/> to <see cref="String"/>
        /// </summary>
        public static implicit operator String(string b) => b != null ? new Java.Lang.String(b) : null;
        #endregion
        /// <summary>
        /// Binary operator managing concatanation within JVM
        /// </summary>
        /// <param name="a">The left <see cref="String"/></param>
        /// <param name="b">The right <see cref="String"/></param>
        /// <returns>A new <see cref="String"/> which is the concatanation of <paramref name="a"/> and <paramref name="b"/></returns>
        /// <remarks>This overload can be very helpful because it avoids to move string contant from JVM to .NET and viceversa</remarks>
        public static String operator +(String a, String b) => b != null ? a?.Concat(b) : a;
        /// <summary>
        /// Returns the character at <paramref name="index"/>
        /// </summary>
        /// <param name="index">The index of the character to return</param>
        /// <returns><see cref="char"/> at <paramref name="index"/></returns>
        public char this[int index] => this.CharAt(index);

        #region SystemNet.IComparable<String>

        int SystemNet.IComparable<String>.CompareTo(Java.Lang.String other)
        {
            return this.CompareTo(other);
        }

        #endregion

        #region SystemNet.IEquatable<String>

        bool SystemNet.IEquatable<String>.Equals(Java.Lang.String other)
        {
            return base.Equals(other);
        }
        #endregion

        #region INativeConvertible<String, string>
        string INativeConvertible<String, string>.ToCLR()
        {
            return ToString();
        }
        /// <summary>
        /// Returns the <see cref="String"/> from the <paramref name="clrValue"/> instance
        /// </summary>
        /// <param name="clrValue">The <see cref="string"/> of CLR</param>
        /// <returns>The converted <see cref="String"/></returns>
        public static String ToJVM(string clrValue)
        {
            return clrValue != null ? new Java.Lang.String(clrValue) : null;
        }

        #endregion

        //#region Enumerable/Array Extensions

        ///// <summary>
        ///// Converts an <see cref="SystemNet.Collections.Generic.IEnumerable{T}"/> of <see cref="Java.Lang.String"/> to an array of <see cref="string"/>
        ///// </summary>
        ///// <param name="set">The <see cref="SystemNet.Collections.Generic.IEnumerable{T}"/> of <see cref="Java.Lang.String"/> to be converted</param>
        ///// <returns>The converted array of <see cref="string"/></returns>
        //public static implicit operator string[](Java.Lang.String[] set)
        //{
        //    SystemNet.Collections.Generic.List<string> list = new();
        //    foreach (var item in set)
        //    {
        //        list.Add(item);
        //    }
        //    return list.ToArray();
        //}

        ///// <summary>
        ///// Converts an <see cref="SystemNet.Collections.Generic.IEnumerable{T}"/> of <see cref="Java.Lang.String"/> to an array of <see cref="string"/>
        ///// </summary>
        ///// <param name="set">The <see cref="SystemNet.Collections.Generic.IEnumerable{T}"/> of <see cref="Java.Lang.String"/> to be converted</param>
        ///// <returns>The converted array of <see cref="string"/></returns>
        //public static implicit operator string[](Java.Util.Collection<Java.Lang.String> set)
        //{
        //    SystemNet.Collections.Generic.List<string> list = new();
        //    foreach (var item in set)
        //    {
        //        list.Add(item);
        //    }
        //    return list.ToArray();
        //}

        ///// <summary>
        ///// Converts an <see cref="SystemNet.Collections.Generic.IEnumerable{T}"/> of <see cref="Java.Lang.String"/> to an array of <see cref="string"/>
        ///// </summary>
        ///// <param name="set">The <see cref="SystemNet.Collections.Generic.IEnumerable{T}"/> of <see cref="Java.Lang.String"/> to be converted</param>
        ///// <returns>The converted array of <see cref="string"/></returns>
        //public static implicit operator string[](Java.Lang.Iterable<Java.Lang.String> set)
        //{
        //    SystemNet.Collections.Generic.List<string> list = new();
        //    foreach (var item in set)
        //    {
        //        list.Add(item);
        //    }
        //    return list.ToArray();
        //}

        ///// <summary>
        ///// Converts an <see cref="SystemNet.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/> to an <see cref="Java.Util.Collection{T}"/> of <see cref="Java.Lang.String"/>
        ///// </summary>
        ///// <param name="set">The <see cref="SystemNet.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/> to be converted</param>
        ///// <returns>The converted <see cref="Java.Util.Collection{T}"/> of <see cref="Java.Lang.String"/></returns>
        //public static implicit operator Java.Util.Collection<Java.Lang.String>(string[] set)
        //{
        //    Java.Util.ArrayList<Java.Lang.String> list = new();
        //    foreach (var item in set)
        //    {
        //        list.Add(item);
        //    }
        //    return list;
        //}

        ///// <summary>
        ///// Converts an <see cref="SystemNet.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/> to an <see cref="Java.Lang.Iterable{T}"/> of <see cref="Java.Lang.String"/>
        ///// </summary>
        ///// <param name="set">The array of <see cref="string"/> to be converted</param>
        ///// <returns>The converted <see cref="Java.Lang.Iterable{T}"/> of <see cref="Java.Lang.String"/></returns>
        //public static implicit operator Java.Lang.Iterable<Java.Lang.String>(string[] set)
        //{
        //    Java.Util.ArrayList<Java.Lang.String> list = new();
        //    foreach (var item in set)
        //    {
        //        list.Add(item);
        //    }
        //    return list;
        //}

        ///// <summary>
        ///// Converts an <see cref="SystemNet.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/> to an array of <see cref="Java.Lang.String"/>
        ///// </summary>
        ///// <param name="collection">The <see cref="SystemNet.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/> to be converted</param>
        ///// <returns>The array of <see cref="Java.Lang.String"/></returns>
        //public static implicit operator Java.Lang.String[](string[] collection)
        //{
        //    SystemNet.Collections.Generic.List<Java.Lang.String> list = new();
        //    foreach (var item in collection)
        //    {
        //        list.Add(item);
        //    }
        //    return list.ToArray();
        //}

        //#endregion
    }
}
