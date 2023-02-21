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

namespace Java.Lang
{
    #region Boolean
    public partial class Boolean
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Io.Serializable(bool t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#TRUE
        /// </summary>
        public static bool TRUE => Clazz.GetField<bool>("TRUE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#FALSE
        /// </summary>
        public static bool FALSE => Clazz.GetField<bool>("FALSE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#TYPE
        /// </summary>
        public static Java.Lang.Class TYPE => Clazz.GetField<Java.Lang.Class>("TYPE");
        
        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#getBoolean(java.lang.String)
        /// </summary>
        public static bool GetBoolean(string arg0)
        {
            return SExecute<bool>("getBoolean", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#logicalAnd(boolean,boolean)
        /// </summary>
        public static bool LogicalAnd(bool arg0, bool arg1)
        {
            return SExecute<bool>("logicalAnd", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#logicalOr(boolean,boolean)
        /// </summary>
        public static bool LogicalOr(bool arg0, bool arg1)
        {
            return SExecute<bool>("logicalOr", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#logicalXor(boolean,boolean)
        /// </summary>
        public static bool LogicalXor(bool arg0, bool arg1)
        {
            return SExecute<bool>("logicalXor", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#parseBoolean(java.lang.String)
        /// </summary>
        public static bool ParseBoolean(string arg0)
        {
            return SExecute<bool>("parseBoolean", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#compare(boolean,boolean)
        /// </summary>
        public static int Compare(bool arg0, bool arg1)
        {
            return SExecute<int>("compare", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#hashCode(boolean)
        /// </summary>
        public static int HashCode(bool arg0)
        {
            return SExecute<int>("hashCode", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#valueOf(boolean)
        /// </summary>
        public static bool ValueOf(bool arg0)
        {
            return SExecute<bool>("valueOf", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#valueOf(java.lang.String)
        /// </summary>
        public static bool ValueOf(string arg0)
        {
            return SExecute<bool>("valueOf", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#toString(boolean)
        /// </summary>
        public static string ToString(bool arg0)
        {
            return SExecute<string>("toString", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#booleanValue()
        /// </summary>
        public bool BooleanValue()
        {
            return IExecute<bool>("booleanValue");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#compareTo(java.lang.Boolean)
        /// </summary>
        public int CompareTo(bool arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Boolean.html#compareTo(java.lang.Object)
        /// </summary>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}