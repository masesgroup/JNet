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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Openmbean
{
    #region SimpleType
    public partial class SimpleType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#BOOLEAN"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType BOOLEAN { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType>("BOOLEAN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#BYTE"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType BYTE { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType>("BYTE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#CHARACTER"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType CHARACTER { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType>("CHARACTER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#DOUBLE"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType DOUBLE { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType>("DOUBLE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#FLOAT"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType FLOAT { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType>("FLOAT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#INTEGER"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType INTEGER { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType>("INTEGER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#LONG"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType LONG { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType>("LONG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#SHORT"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType SHORT { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType>("SHORT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#STRING"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType STRING { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType>("STRING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#VOID"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType VOID { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType>("VOID"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#BIGDECIMAL"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType BIGDECIMAL { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType>("BIGDECIMAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#BIGINTEGER"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType BIGINTEGER { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType>("BIGINTEGER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#DATE"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType DATE { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType>("DATE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#OBJECTNAME"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType OBJECTNAME { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType>("OBJECTNAME"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#readResolve()"/> 
        /// </summary>
        public object ReadResolve
        {
            get { return IExecute("readResolve"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SimpleType<T>
    public partial class SimpleType<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Openmbean.SimpleType{T}"/> to <see cref="Javax.Management.Openmbean.SimpleType"/>
        /// </summary>
        public static implicit operator Javax.Management.Openmbean.SimpleType(Javax.Management.Openmbean.SimpleType<T> t) => t.Cast<Javax.Management.Openmbean.SimpleType>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#BOOLEAN"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType<bool?> BOOLEAN { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType<bool?>>("BOOLEAN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#BYTE"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType<byte?> BYTE { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType<byte?>>("BYTE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#CHARACTER"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType<char?> CHARACTER { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType<char?>>("CHARACTER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#DOUBLE"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType<double?> DOUBLE { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType<double?>>("DOUBLE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#FLOAT"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType<float?> FLOAT { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType<float?>>("FLOAT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#INTEGER"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType<int?> INTEGER { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType<int?>>("INTEGER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#LONG"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType<long?> LONG { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType<long?>>("LONG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#SHORT"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType<short?> SHORT { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType<short?>>("SHORT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#STRING"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType<string> STRING { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType<string>>("STRING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#VOID"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType<Java.Lang.Void> VOID { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType<Java.Lang.Void>>("VOID"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#BIGDECIMAL"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType<Java.Math.BigDecimal> BIGDECIMAL { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType<Java.Math.BigDecimal>>("BIGDECIMAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#BIGINTEGER"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType<Java.Math.BigInteger> BIGINTEGER { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType<Java.Math.BigInteger>>("BIGINTEGER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#DATE"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType<Java.Util.Date> DATE { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType<Java.Util.Date>>("DATE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#OBJECTNAME"/>
        /// </summary>
        public static Javax.Management.Openmbean.SimpleType<Javax.Management.ObjectName> OBJECTNAME { get { return LocalClazz.GetField<Javax.Management.Openmbean.SimpleType<Javax.Management.ObjectName>>("OBJECTNAME"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/SimpleType.html#readResolve()"/> 
        /// </summary>
        public object ReadResolve
        {
            get { return IExecute("readResolve"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}