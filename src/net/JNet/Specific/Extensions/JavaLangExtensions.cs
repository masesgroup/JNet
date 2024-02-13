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

using Java.Util;
using System;
using System.Collections.Generic;

namespace MASES.JNet.Specific.Extensions
{
    /// <summary>
    /// Extension for Java.Util classes
    /// </summary>
    public static class JavaLangExtension
    {
        #region Enumerable/Array Extensions

        /// <summary>
        /// Converts an <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="Java.Lang.String"/> to an <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/>
        /// </summary>
        /// <param name="set">The <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="Java.Lang.String"/> to be converted</param>
        /// <returns>The converted <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/></returns>
        public static System.Collections.Generic.IEnumerable<string> ToEnumerable(this System.Collections.Generic.IEnumerable<Java.Lang.String> set)
        {
            System.Collections.Generic.List<string> list = new();
            foreach (var item in set)
            {
                list.Add(item);
            }
            return list;
        }

        /// <summary>
        /// Converts an <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="Java.Lang.String"/> to an array of <see cref="string"/>
        /// </summary>
        /// <param name="set">The <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="Java.Lang.String"/> to be converted</param>
        /// <returns>The converted array of <see cref="string"/></returns>
        public static string[] ToArray(this System.Collections.Generic.IEnumerable<Java.Lang.String> set)
        {
            System.Collections.Generic.List<string> list = new();
            foreach (var item in set)
            {
                list.Add(item);
            }
            return list.ToArray();
        }

        /// <summary>
        /// Converts an <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/> to an <see cref="Java.Util.Collection{T}"/> of <see cref="Java.Lang.String"/>
        /// </summary>
        /// <param name="set">The <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/> to be converted</param>
        /// <returns>The converted <see cref="Java.Util.Collection{T}"/> of <see cref="Java.Lang.String"/></returns>
        public static Java.Util.Collection<Java.Lang.String> ToJCollection(this System.Collections.Generic.IEnumerable<string> set)
        {
            ArrayList<Java.Lang.String> list = new();
            foreach (var item in set)
            {
                list.Add(item);
            }
            return list;
        }

        /// <summary>
        /// Converts an <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/> to an <see cref="Java.Lang.Iterable{T}"/> of <see cref="Java.Lang.String"/>
        /// </summary>
        /// <param name="set">The <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/> to be converted</param>
        /// <returns>The converted <see cref="Java.Lang.Iterable{T}"/> of <see cref="Java.Lang.String"/></returns>
        public static Java.Lang.Iterable<Java.Lang.String> ToIterable(this System.Collections.Generic.IEnumerable<string> set)
        {
            return ToJCollection(set);
        }

        /// <summary>
        /// Converts an <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/> to an array of <see cref="Java.Lang.String"/>
        /// </summary>
        /// <param name="collection">The <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/> to be converted</param>
        /// <returns>The array of <see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String[] ToArray(this System.Collections.Generic.IEnumerable<string> collection)
        {
            System.Collections.Generic.List<Java.Lang.String> list = new();
            foreach (var item in collection)
            {
                list.Add(item);
            }
            return list.ToArray();
        }

        #endregion
    }
}
