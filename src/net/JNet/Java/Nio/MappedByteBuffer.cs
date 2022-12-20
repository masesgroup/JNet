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

namespace Java.Nio
{
    public class MappedByteBuffer : ByteBuffer
    {
        public override string ClassName => "java.nio.MappedByteBuffer";

        /// <summary>
        /// Forces any changes made to this buffer's content to be written to the storage device containing the mapped file.
        /// </summary>
        public MappedByteBuffer Force() => IExecute<MappedByteBuffer>("force");

        /// <summary>
        /// Tells whether or not this buffer's content is resident in physical memory.
        /// </summary>
        public bool IsLoaded => IExecute<bool>("isLoaded");

        /// <summary>
        /// Loads this buffer's content into physical memory.
        /// </summary>
        public MappedByteBuffer Load() => IExecute<MappedByteBuffer>("load");
    }
}
