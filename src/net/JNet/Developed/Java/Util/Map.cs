/*
*  Copyright 2025 MASES s.r.l.
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
    public partial class Map
    {

    }

    public partial class Map<K, V>
    {
        /// <summary>
        /// Useful converter from <see cref="Java.Util.Map{K, V}"/> to <see cref="Java.Util.Properties"/>
        /// </summary>
        public static implicit operator Java.Util.Properties(Map<K, V> t)
        {
            Properties p = new Properties();
            p.PutAll(t);
            return p;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#get(java.lang.Object)"/>
        /// </summary>
        public virtual V Get​(K key) { return IExecute<V>("get", key); }
    }
}