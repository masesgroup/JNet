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

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Character.html"/>
    /// </summary>
    public sealed class Character : JVMBridgeBase<Character>
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.Character";
        /// <summary>
        /// Do not use: it is intended for internal use.
        /// </summary>
        public Character()
        {
        }
        /// <summary>
        /// Constructs a newly allocated <see cref="Character"/> object that represents the specified char value.
        /// </summary>
        /// <param name="value">The value to be represented by the <see cref="Character"/> object.</param>
        public Character(char value)
            : base(value)
        {
        }

        /// <summary>
        /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Character.Subset.html"/>
        /// </summary>
        public sealed class Subset : JVMBridgeBase<Subset>
        {
            /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
            public override string ClassName => "java.lang.Character.Subset";
        }
        /// <summary>
        /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Character.UnicodeBlock.html"/>
        /// </summary>
        public sealed class UnicodeBlock : JVMBridgeBase<UnicodeBlock>
        {
            /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
            public override string ClassName => "java.lang.Character.UnicodeBlock";
            /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
            public override bool IsStatic => true;
        }
    }
}
