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

namespace Java.Math
{
    #region MathContext
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/MathContext.html
    /// </summary>
    public partial class MathContext : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MathContext>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MathContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MathContext(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.math.MathContext";

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

    #region BigDecimal
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html
    /// </summary>
    public partial class BigDecimal : Java.Lang.Number
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BigDecimal() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BigDecimal(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.math.BigDecimal";

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

    #region RoundingMode
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/RoundingMode.html
    /// </summary>
    public partial class RoundingMode : Java.Lang.Enum
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RoundingMode() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RoundingMode(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.math.RoundingMode";

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

    #region BigInteger
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigInteger.html
    /// </summary>
    public partial class BigInteger : Java.Lang.Number
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BigInteger() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BigInteger(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.math.BigInteger";

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


}