/*
*  Copyright (c) 2022-2026 MASES s.r.l.
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
    /// .NET implementations of <see href="https://docs.oracle.com/en/java/javase/17/docs/api/java.base/java/lang/Record.html"/>
    /// </summary>
    public class Record : JVMBridgeBase<Record>
    {
        /// <inheritdoc/>
        public Record() { }
        /// <inheritdoc/>
        public Record(IJVMBridgeBaseInitializer initializer) : base(initializer) { }
        /// <inheritdoc/>
        public Record(params object[] args) : base(args) { }
        /// <inheritdoc />
        public override string BridgeClassName => "java.lang.Record";
    }
}
