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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region ConcurrentSkipListSet
    public partial class ConcurrentSkipListSet
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public ConcurrentSkipListSet(Java.Util.Collection arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#%3Cinit%3E(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        public ConcurrentSkipListSet(Java.Util.Comparator arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#%3Cinit%3E(java.util.SortedSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.SortedSet"/></param>
        public ConcurrentSkipListSet(Java.Util.SortedSet arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentSkipListSet"/> to <see cref="Java.Util.NavigableSet"/>
        /// </summary>
        public static implicit operator Java.Util.NavigableSet(Java.Util.Concurrent.ConcurrentSkipListSet t) => t.Cast<Java.Util.NavigableSet>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentSkipListSet"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Concurrent.ConcurrentSkipListSet t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentSkipListSet"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.ConcurrentSkipListSet t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#ceiling(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Ceiling(object arg0)
        {
            return IExecute("ceiling", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#first()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object First()
        {
            return IExecute("first");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#floor(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Floor(object arg0)
        {
            return IExecute("floor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#higher(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Higher(object arg0)
        {
            return IExecute("higher", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#last()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Last()
        {
            return IExecute("last");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#lower(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Lower(object arg0)
        {
            return IExecute("lower", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#pollFirst()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object PollFirst()
        {
            return IExecute("pollFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#pollLast()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object PollLast()
        {
            return IExecute("pollLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#comparator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Comparator"/></returns>
        public Java.Util.Comparator Comparator()
        {
            return IExecute<Java.Util.Comparator>("comparator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#clone()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.ConcurrentSkipListSet"/></returns>
        public Java.Util.Concurrent.ConcurrentSkipListSet Clone()
        {
            return IExecute<Java.Util.Concurrent.ConcurrentSkipListSet>("clone");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#descendingIterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator DescendingIterator()
        {
            return IExecute<Java.Util.Iterator>("descendingIterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#descendingSet()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet DescendingSet()
        {
            return IExecute<Java.Util.NavigableSet>("descendingSet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#headSet(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet HeadSet(object arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableSet>("headSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#subSet(java.lang.Object,boolean,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet SubSet(object arg0, bool arg1, object arg2, bool arg3)
        {
            return IExecute<Java.Util.NavigableSet>("subSet", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#tailSet(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet TailSet(object arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableSet>("tailSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#headSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet HeadSet(object arg0)
        {
            return IExecute<Java.Util.SortedSet>("headSet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#subSet(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet SubSet(object arg0, object arg1)
        {
            return IExecute<Java.Util.SortedSet>("subSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#tailSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet TailSet(object arg0)
        {
            return IExecute<Java.Util.SortedSet>("tailSet", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConcurrentSkipListSet<E>
    public partial class ConcurrentSkipListSet<E>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public ConcurrentSkipListSet(Java.Util.Collection<E> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#%3Cinit%3E(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        public ConcurrentSkipListSet(Java.Util.Comparator<E> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#%3Cinit%3E(java.util.SortedSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.SortedSet"/></param>
        public ConcurrentSkipListSet(Java.Util.SortedSet<E> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentSkipListSet{E}"/> to <see cref="Java.Util.NavigableSet{E}"/>
        /// </summary>
        public static implicit operator Java.Util.NavigableSet<E>(Java.Util.Concurrent.ConcurrentSkipListSet<E> t) => t.Cast<Java.Util.NavigableSet<E>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentSkipListSet{E}"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Concurrent.ConcurrentSkipListSet<E> t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentSkipListSet{E}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.ConcurrentSkipListSet<E> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentSkipListSet{E}"/> to <see cref="Java.Util.Concurrent.ConcurrentSkipListSet"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ConcurrentSkipListSet(Java.Util.Concurrent.ConcurrentSkipListSet<E> t) => t.Cast<Java.Util.Concurrent.ConcurrentSkipListSet>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#ceiling(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Ceiling(E arg0)
        {
            return IExecute<E>("ceiling", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#first()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E First()
        {
            return IExecute<E>("first");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#floor(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Floor(E arg0)
        {
            return IExecute<E>("floor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#higher(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Higher(E arg0)
        {
            return IExecute<E>("higher", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#last()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Last()
        {
            return IExecute<E>("last");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#lower(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Lower(E arg0)
        {
            return IExecute<E>("lower", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#pollFirst()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E PollFirst()
        {
            return IExecute<E>("pollFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#pollLast()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E PollLast()
        {
            return IExecute<E>("pollLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#comparator()"/>
        /// </summary>

        /// <typeparam name="ReturnobjectSuperE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="Java.Util.Comparator"/></returns>
        public Java.Util.Comparator<ReturnobjectSuperE> Comparator<ReturnobjectSuperE>() where ReturnobjectSuperE: E
        {
            return IExecute<Java.Util.Comparator<ReturnobjectSuperE>>("comparator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#clone()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.ConcurrentSkipListSet"/></returns>
        public Java.Util.Concurrent.ConcurrentSkipListSet<E> Clone()
        {
            return IExecute<Java.Util.Concurrent.ConcurrentSkipListSet<E>>("clone");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#descendingIterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<E> DescendingIterator()
        {
            return IExecute<Java.Util.Iterator<E>>("descendingIterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#descendingSet()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<E> DescendingSet()
        {
            return IExecute<Java.Util.NavigableSet<E>>("descendingSet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#headSet(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<E> HeadSet(E arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableSet<E>>("headSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#subSet(java.lang.Object,boolean,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<E> SubSet(E arg0, bool arg1, E arg2, bool arg3)
        {
            return IExecute<Java.Util.NavigableSet<E>>("subSet", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#tailSet(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<E> TailSet(E arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableSet<E>>("tailSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#headSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet HeadSet(object arg0)
        {
            return IExecute<Java.Util.SortedSet>("headSet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#subSet(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet SubSet(object arg0, object arg1)
        {
            return IExecute<Java.Util.SortedSet>("subSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListSet.html#tailSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet TailSet(object arg0)
        {
            return IExecute<Java.Util.SortedSet>("tailSet", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}