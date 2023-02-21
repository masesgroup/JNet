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

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

namespace Javax.Lang.Model
{
    #region UnknownEntityException
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/UnknownEntityException.html
    /// </summary>
    public partial class UnknownEntityException : Java.Lang.RuntimeException
    {
        public UnknownEntityException() { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.lang.model.UnknownEntityException";

        // TODO: complete the class

    }
    #endregion

    #region SourceVersion
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/SourceVersion.html
    /// </summary>
    public partial class SourceVersion : Java.Lang.Enum
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SourceVersion() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SourceVersion(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.lang.model.SourceVersion";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => false;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region AnnotatedConstruct
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/AnnotatedConstruct.html
    /// </summary>
    public partial class AnnotatedConstruct : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AnnotatedConstruct>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AnnotatedConstruct() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AnnotatedConstruct(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.lang.model.AnnotatedConstruct";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => true;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => true;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion


}