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

namespace Java.Util
{
    #region UUID
    public partial class UUID
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/UUID.html#%3Cinit%3E(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public UUID(long arg0, long arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.UUID"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.UUID t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.UUID"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Util.UUID t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/UUID.html#fromString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.UUID"/></returns>
        public static Java.Util.UUID FromString(Java.Lang.String arg0)
        {
            return SExecute<Java.Util.UUID>(LocalBridgeClazz, "fromString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/UUID.html#nameUUIDFromBytes(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Util.UUID"/></returns>
        public static Java.Util.UUID NameUUIDFromBytes(byte[] arg0)
        {
            return SExecute<Java.Util.UUID>(LocalBridgeClazz, "nameUUIDFromBytes", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/UUID.html#randomUUID()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.UUID"/></returns>
        public static Java.Util.UUID RandomUUID()
        {
            return SExecute<Java.Util.UUID>(LocalBridgeClazz, "randomUUID");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/UUID.html#getLeastSignificantBits()"/> 
        /// </summary>
        public long LeastSignificantBits
        {
            get { return IExecute<long>("getLeastSignificantBits"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/UUID.html#getMostSignificantBits()"/> 
        /// </summary>
        public long MostSignificantBits
        {
            get { return IExecute<long>("getMostSignificantBits"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/UUID.html#clockSequence()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int ClockSequence()
        {
            return IExecute<int>("clockSequence");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/UUID.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/UUID.html#compareTo(java.util.UUID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Util.UUID arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/UUID.html#variant()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Variant()
        {
            return IExecute<int>("variant");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/UUID.html#version()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Version()
        {
            return IExecute<int>("version");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/UUID.html#node()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Node()
        {
            return IExecute<long>("node");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/UUID.html#timestamp()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Timestamp()
        {
            return IExecute<long>("timestamp");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}