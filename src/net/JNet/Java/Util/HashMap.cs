﻿/*
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
    public class HashMap<K, V> : AbstractMap<K, V>
    {
        public override string ClassName => "java.util.HashMap";

        public HashMap()
        {
        }

        public HashMap(int initialCapacity)
            : base(initialCapacity)
        {
        }

        public HashMap(int initialCapacity, float loadFactor)
            : base(initialCapacity, loadFactor)
        {
        }

        public HashMap(Map<K, V> m)
            : base(m)
        {
        }
    }
}