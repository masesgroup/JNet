﻿/*
*  Copyright 2022 MASES s.r.l.
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

using Java.Lang;
using MASES.JCOBridge.C2JBridge;

namespace Java.Nio
{
    public class CharBuffer : Buffer
    {
        public override string ClassName => "java.nio.CharBuffer";

        public static implicit operator Comparable<CharBuffer>(CharBuffer buffer) => buffer.Cast<Comparable<CharBuffer>>();

        public static CharBuffer Allocate(int capacity) => SExecute<CharBuffer>("allocate", capacity);

        public char[] Array => IExecute<char[]>("array");
    }
}
