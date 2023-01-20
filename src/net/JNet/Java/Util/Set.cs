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

namespace Java.Util
{
    public class Set<E> : Collection<E>
    {
        public override string ClassName => "java.util.Set";

        public static Set<E> CopyOf​<ExtendsE>(Collection<ExtendsE> coll) where ExtendsE : E => SExecute<Set<E>>("copyOf​", coll);

        public static Set<E> Of() => SExecute<Set<E>>("of");

        public static Set<E> Of(E e1) => SExecute<Set<E>>("of", e1);

        public static Set<E> Of(params E[] elements) => elements.Length == 0 ? SExecute<Set<E>>("of") : SExecute<Set<E>>("of", elements);

        public static Set<E> Of(E e1, E e2) => SExecute<Set<E>>("of", e1, e2);

        public static Set<E> Of(E e1, E e2, E e3) => SExecute<Set<E>>("of", e1, e2, e3);

        public static Set<E> Of(E e1, E e2, E e3, E e4) => SExecute<Set<E>>("of", e1, e2, e3, e4);

        public static Set<E> Of(E e1, E e2, E e3, E e4, E e5) => SExecute<Set<E>>("of", e1, e2, e3, e4, e5);

        public static Set<E> Of(E e1, E e2, E e3, E e4, E e5, E e6) => SExecute<Set<E>>("of", e1, e2, e3, e4, e5, e6);

        public static Set<E> Of(E e1, E e2, E e3, E e4, E e5, E e6, E e7) => SExecute<Set<E>>("of", e1, e2, e3, e4, e5, e6, e7);

        public static Set<E> Of(E e1, E e2, E e3, E e4, E e5, E e6, E e7, E e8) => SExecute<Set<E>>("of", e1, e2, e3, e4, e5, e6, e7, e8);

        public static Set<E> Of(E e1, E e2, E e3, E e4, E e5, E e6, E e7, E e8, E e9) => SExecute<Set<E>>("of", e1, e2, e3, e4, e5, e6, e7, e8, e9);

        public static Set<E> Of(E e1, E e2, E e3, E e4, E e5, E e6, E e7, E e8, E e9, E e10) => SExecute<Set<E>>("of", e1, e2, e3, e4, e5, e6, e7, e8, e9, e10);
    }
}
