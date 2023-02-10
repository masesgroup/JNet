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

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio
{
    public class Buffer : JVMBridgeBase<Buffer>
    {
        public override bool IsAbstract => true;

        public override string ClassName => "java.nio.Buffer";
        /// <summary>
        /// Returns the array that backs this buffer  (optional operation).
        /// </summary>
        /// <typeparam name="T">The return type</typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T Array<T>() => IExecute<T>("array");
        /// <summary>
        /// Returns the offset within this buffer's backing array of the first element of the buffer  (optional operation).
        /// </summary>
        /// <returns></returns>
        public int ArrayOffset => IExecute<int>("arrayOffset");
        /// <summary>
        /// Returns this buffer's capacity.
        /// </summary>
        public int Capacity => IExecute<int>("capacity");
        /// <summary>
        /// Clears this buffer.
        /// </summary>
        /// <returns>This <see cref="Buffer"/></returns>
        public Buffer Clear() => IExecute<Buffer>("clear");
        /// <summary>
        /// Flips this buffer.
        /// </summary>
        public Buffer Flip() => IExecute<Buffer>("flip");
        /// <summary>
        /// Tells whether or not this buffer is backed by an accessible array.
        /// </summary>
        public bool HasArray => IExecute<bool>("hasArray");
        /// <summary>
        /// Tells whether there are any elements between the current position and the limit.
        /// </summary>
        public bool HasRemaining => IExecute<bool>("hasRemaining");
        /// <summary>
        /// Tells whether or not this buffer is direct.
        /// </summary>
        public bool IsDirect => IExecute<bool>("isDirect");
        /// <summary>
        /// Tells whether or not this buffer is read-only.
        /// </summary>
        public bool IsReadOnly => IExecute<bool>("isReadOnly");
        /// <summary>
        /// Returns this buffer's limit.
        /// </summary>
        public int Limit() => IExecute<int>("limit");
        /// <summary>
        /// Sets this buffer's limit.
        /// </summary>
        public Buffer Limit(int newLimit) => IExecute<Buffer>("limit", newLimit);
        /// <summary>
        /// Sets this buffer's mark at its position.
        /// </summary>
        public Buffer Mark() => IExecute<Buffer>("mark");
        /// <summary>
        /// Returns this buffer's position.
        /// </summary>
        public int Position() => IExecute<int>("position");
        /// <summary>
        /// Sets this buffer's position.
        /// </summary>
        public Buffer Position(int newPosition) => IExecute<Buffer>("position", newPosition);
        /// <summary>
        /// Returns the number of elements between the current position and the limit.
        /// </summary>
        public int Remaining => IExecute<int>("remaining");
        /// <summary>
        /// Resets this buffer's position to the previously-marked position.
        /// </summary>
        public Buffer Reset() => IExecute<Buffer>("reset");
        /// <summary>
        /// Rewinds this buffer.
        /// </summary>
        public Buffer Rewind() => IExecute<Buffer>("rewind");
    }
}
