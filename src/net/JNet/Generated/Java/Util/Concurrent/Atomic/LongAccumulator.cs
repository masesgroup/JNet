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

namespace Java.Util.Concurrent.Atomic
{
    #region LongAccumulator
    public partial class LongAccumulator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/LongAccumulator.html#%3Cinit%3E(java.util.function.LongBinaryOperator,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongBinaryOperator"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public LongAccumulator(Java.Util.Function.LongBinaryOperator arg0, long arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.Atomic.LongAccumulator"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.Atomic.LongAccumulator t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/LongAccumulator.html#get()"/> 
        /// </summary>
        public long Get
        {
            get { return IExecute<long>("get"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/LongAccumulator.html#getThenReset()"/> 
        /// </summary>
        public long ThenReset
        {
            get { return IExecute<long>("getThenReset"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/LongAccumulator.html#accumulate(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Accumulate(long arg0)
        {
            IExecute("accumulate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/LongAccumulator.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecute("reset");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}