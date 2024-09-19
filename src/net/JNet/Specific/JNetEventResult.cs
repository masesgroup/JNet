/*
*  Copyright 2024 MASES s.r.l.
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

using MASES.JCOBridge.C2JBridge.JVMInterop;
using System;

namespace MASES.JNet.Specific
{
    /// <summary>
    /// Helper class of JNet for some specific operations done with callbacks
    /// </summary>
    public sealed class JNetEventResult : MASES.JCOBridge.C2JBridge.JVMBridgeBase<JNetEventResult>
    {
        const string _bridgeClassName = "org.mases.jnet.developed.JNetEventResult";

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
        /// <summary>
        /// Set to <see langword="true"/> if the method applied an override
        /// </summary>
        public bool HasOverride { get => IExecute<bool>("getHasOverride"); set => IExecute("setHasOverride", value); }
        /// <summary>
        /// The <see cref="object"/> to be returned to the JVM side
        /// </summary>
        public object ReturnData { get => IExecute("getReturnData"); set => IExecute("setReturnData", value); }
        /// <summary>
        /// Helper function to set both <see cref="HasOverride"/> and <see cref="ReturnData"/>
        /// </summary>
        /// <param name="hasOverride"><see langword="true"/> if the method applied an override</param>
        /// <param name="retData">The <see cref="object"/> to be returned to the JVM side</param>
        public void SetReturnData(bool hasOverride, object retData)
        {
            IExecute("setReturnData", hasOverride, retData);
        }
    }
}
