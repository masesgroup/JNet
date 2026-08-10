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
using MASES.JCOBridge.C2JBridge.JVMInterop;
using System;
using System.Reflection;

namespace MASES.JNet.Specific
{
    /// <summary>
    /// Helper class of JNet for some specific operations done with callbacks
    /// </summary>
    public sealed class JNetEventResult : MASES.JCOBridge.C2JBridge.JVMBridgeBase<JNetEventResult>
    {
        /// <inheritdoc/>
        public JNetEventResult() { }
        /// <inheritdoc/>
        public JNetEventResult(IJVMBridgeBaseInitializer initializer) : base(initializer) { }

        const string _bridgeClassName = "org.mases.jnet.developed.JNetEventResult";

        private static readonly global::System.Exception _LocalBridgeClazzException = null;
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName, out _LocalBridgeClazzException, false);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw _LocalBridgeClazzException ?? new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <inheritdoc/>
        public override string BridgeClassName => _bridgeClassName;
        /// <inheritdoc/>
        public override bool IsBridgeAbstract => false;
        /// <inheritdoc/>
        public override bool IsBridgeCloseable => false;
        /// <inheritdoc/>
        public override bool IsBridgeInterface => false;
        /// <inheritdoc/>
        public override bool IsBridgeStatic => false;
        /// <summary>
        /// Set to <see langword="true"/> if the method applied an override
        /// </summary>
        public bool HasOverride { get => IExecute<bool>("getHasOverride"); set => IExecute("setHasOverride", value); }
        /// <summary>
        /// The <see cref="object"/> to be returned to the JVM side.
        /// This property is intentionally read-only: setting it directly is not supported because
        /// JVM-side handling raises an exception. Use <see cref="SetReturnData(bool, object)"/>
        /// to set both override state and return data in a supported way.
        /// </summary>
        public object ReturnData { get => IExecute("getReturnData"); }
        /// <summary>
        /// Helper function to set both <see cref="HasOverride"/> and <see cref="ReturnData"/>
        /// </summary>
        /// <param name="hasOverride"><see langword="true"/> if the method applied an override</param>
        /// <param name="retData">The <see cref="object"/> to be returned to the JVM side</param>
        public void SetReturnData(bool hasOverride, object retData)
        {
            IExecute("setReturnData", hasOverride, retData);
        }
        /// <summary>
        /// Tests if <paramref name="methodName"/> has an override in <paramref name="thisType"/>
        /// </summary>
        /// <param name="thisType">The <see cref="System.Type"/> with possible override</param>
        /// <param name="methodName">The method name</param>
        /// <param name="types">The set of <see cref="System.Type"/> of <paramref name="methodName"/> declaration</param>
        /// <returns><see langword="true"/> if <paramref name="methodName"/> has an override from the user</returns>
        public static bool GetMethodIsOverridden(global::System.Type thisType, string methodName, params global::System.Type[] types)
        {
            var method = thisType.GetMethod(
                methodName,
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy,
                null,
                types,
                null
            );

            if (method == null)
            {
                var signature = (types == null || types.Length == 0) ? string.Empty : global::System.String.Join(", ", global::System.Array.ConvertAll(types, t => t?.ToString() ?? "<null>"));
                throw new MissingMethodException($"Method '{methodName}({signature})' not found on type '{thisType}'");
            }
            return method.GetBaseDefinition().DeclaringType != method.DeclaringType;
        }
    }
    /// <summary>
    /// Helper class able to simpify definition of data associated to events
    /// </summary>
    public sealed class JNetEventData : CLREventData<MASES.JNet.Specific.JNetEventResult>
    {
        /// <inheritdoc cref="CLREventData{TObject}.CLREventData(IJavaObject, long)"/>
        public JNetEventData(IJavaObject javaObject, long callId) : base(javaObject, callId) { }

        /// <inheritdoc cref="JNetEventResult.HasOverride"/>
        public bool HasOverride { get => TypedEventData.HasOverride; set => TypedEventData.HasOverride = value; }
        /// <inheritdoc cref="JNetEventResult.ReturnData"/>
        public object ReturnData => TypedEventData.ReturnData;
        /// <inheritdoc cref="JNetEventResult.SetReturnData(bool, object)"/>
        public void SetReturnData(bool hasOverride, object retData)
        {
            TypedEventData.SetReturnData(hasOverride, retData);
        }
    }
}
