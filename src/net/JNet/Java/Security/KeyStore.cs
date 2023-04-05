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

namespace Java.Security
{
    #region KeyStore
    public partial class KeyStore
    {
        #region Nested classes

        #region Entry
        public partial class Entry
        {
            #region Nested classes
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStore.Entry.Attribute.html"/>
            /// </summary>
            public partial class Attribute : JVMBridgeBase<Attribute>
            {
                /// <summary>
                /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
                /// </summary>
                public override string ClassName => "java.security.KeyStore$Entry$Attribute";
            }

            #endregion
        }
        #endregion

        #endregion

        // TODO: complete the class
    }
    #endregion
}