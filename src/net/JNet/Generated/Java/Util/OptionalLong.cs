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
    #region OptionalLong
    public partial class OptionalLong
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalLong.html#empty()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public static Java.Util.OptionalLong Empty()
        {
            return SExecute<Java.Util.OptionalLong>("empty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalLong.html#of(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public static Java.Util.OptionalLong Of(long arg0)
        {
            return SExecute<Java.Util.OptionalLong>("of", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalLong.html#getAsLong()"/> 
        /// </summary>
        public long AsLong
        {
            get { return IExecute<long>("getAsLong"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalLong.html#orElseThrow(java.util.function.Supplier%3C? extends X%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public long OrElseThrow(Java.Util.Function.Supplier arg0)
        {
            return IExecute<long>("orElseThrow", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalLong.html#isEmpty()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalLong.html#isPresent()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsPresent()
        {
            return IExecute<bool>("isPresent");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalLong.html#stream.LongStream java.util.OptionalLong.stream()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Stream()
        {
            return IExecute<Java.Util.Stream.LongStream>("stream");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalLong.html#orElse(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long OrElse(long arg0)
        {
            return IExecute<long>("orElse", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalLong.html#orElseGet(java.util.function.LongSupplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongSupplier"/></param>
        /// <returns><see cref="long"/></returns>
        public long OrElseGet(Java.Util.Function.LongSupplier arg0)
        {
            return IExecute<long>("orElseGet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalLong.html#orElseThrow()"/>
        /// </summary>
        
        /// <returns><see cref="long"/></returns>
        public long OrElseThrow()
        {
            return IExecute<long>("orElseThrow");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalLong.html#ifPresent(java.util.function.LongConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
        public void IfPresent(Java.Util.Function.LongConsumer arg0)
        {
            IExecute("ifPresent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/OptionalLong.html#ifPresentOrElse(java.util.function.LongConsumer,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        public void IfPresentOrElse(Java.Util.Function.LongConsumer arg0, Java.Lang.Runnable arg1)
        {
            IExecute("ifPresentOrElse", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}