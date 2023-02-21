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
    #region Stack
    public partial class Stack
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Stack.html#empty()
        /// </summary>
        public bool Empty()
        {
            return IExecute<bool>("empty");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Stack.html#push(E)
        /// </summary>
        public object Push(object arg0)
        {
            return IExecute("push", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Stack.html#peek()
        /// </summary>
        public object Peek()
        {
            return IExecute("peek");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Stack.html#pop()
        /// </summary>
        public object Pop()
        {
            return IExecute("pop");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Stack.html#search(java.lang.Object)
        /// </summary>
        public int Search(object arg0)
        {
            return IExecute<int>("search", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}