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
    #region ArrayDeque
    public partial class ArrayDeque
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public ArrayDeque(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#%3Cinit%3E(java.util.Collection%3C? extends E%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public ArrayDeque(Java.Util.Collection arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.ArrayDeque"/> to <see cref="Java.Util.Deque"/>
        /// </summary>
        public static implicit operator Java.Util.Deque(Java.Util.ArrayDeque t) => t.Cast<Java.Util.Deque>();
        /// <summary>
        /// Converter from <see cref="Java.Util.ArrayDeque"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.ArrayDeque t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.ArrayDeque"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.ArrayDeque t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#getFirst()"/> 
        /// </summary>
        public object First
        {
            get { return IExecute("getFirst"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#getLast()"/> 
        /// </summary>
        public object Last
        {
            get { return IExecute("getLast"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#offer(E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Offer(object arg0)
        {
            return IExecute<bool>("offer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#offerFirst(E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OfferFirst(object arg0)
        {
            return IExecute<bool>("offerFirst", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#offerLast(E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OfferLast(object arg0)
        {
            return IExecute<bool>("offerLast", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#removeFirstOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveFirstOccurrence(object arg0)
        {
            return IExecute<bool>("removeFirstOccurrence", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#removeLastOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveLastOccurrence(object arg0)
        {
            return IExecute<bool>("removeLastOccurrence", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#element()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object Element()
        {
            return IExecute("element");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#peek()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object Peek()
        {
            return IExecute("peek");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#peekFirst()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object PeekFirst()
        {
            return IExecute("peekFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#peekLast()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object PeekLast()
        {
            return IExecute("peekLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#poll()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object Poll()
        {
            return IExecute("poll");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#pollFirst()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object PollFirst()
        {
            return IExecute("pollFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#pollLast()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object PollLast()
        {
            return IExecute("pollLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#pop()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object Pop()
        {
            return IExecute("pop");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#remove()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object Remove()
        {
            return IExecute("remove");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#removeFirst()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object RemoveFirst()
        {
            return IExecute("removeFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#removeLast()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object RemoveLast()
        {
            return IExecute("removeLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#clone()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.ArrayDeque"/></returns>
        public Java.Util.ArrayDeque Clone()
        {
            return IExecute<Java.Util.ArrayDeque>("clone");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#descendingIterator()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator DescendingIteratorMethod()
        {
            return IExecute<Java.Util.Iterator>("descendingIterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#addFirst(E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddFirst(object arg0)
        {
            IExecute("addFirst", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#addLast(E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddLast(object arg0)
        {
            IExecute("addLast", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayDeque.html#push(E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Push(object arg0)
        {
            IExecute("push", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}