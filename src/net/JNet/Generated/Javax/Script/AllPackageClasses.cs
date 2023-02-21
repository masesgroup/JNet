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

namespace Javax.Script
{
    #region Bindings
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/Bindings.html
    /// </summary>
    public partial class Bindings : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Bindings>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Bindings() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Bindings(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.script.Bindings";

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

    #region SimpleScriptContext
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html
    /// </summary>
    public partial class SimpleScriptContext : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SimpleScriptContext>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SimpleScriptContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SimpleScriptContext(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.script.SimpleScriptContext";

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

    #region ScriptEngine
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngine.html
    /// </summary>
    public partial class ScriptEngine : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ScriptEngine>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ScriptEngine() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ScriptEngine(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.script.ScriptEngine";

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

    #region CompiledScript
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/CompiledScript.html
    /// </summary>
    public partial class CompiledScript : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CompiledScript>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CompiledScript() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CompiledScript(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.script.CompiledScript";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => true;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ScriptException
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptException.html
    /// </summary>
    public partial class ScriptException : Java.Lang.Exception
    {
        public ScriptException() { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.script.ScriptException";

        // TODO: complete the class

    }
    #endregion

    #region AbstractScriptEngine
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/AbstractScriptEngine.html
    /// </summary>
    public partial class AbstractScriptEngine : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AbstractScriptEngine>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AbstractScriptEngine() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AbstractScriptEngine(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.script.AbstractScriptEngine";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => true;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ScriptEngineManager
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineManager.html
    /// </summary>
    public partial class ScriptEngineManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ScriptEngineManager>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ScriptEngineManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ScriptEngineManager(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.script.ScriptEngineManager";

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

    #region ScriptEngineFactory
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineFactory.html
    /// </summary>
    public partial class ScriptEngineFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ScriptEngineFactory>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ScriptEngineFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ScriptEngineFactory(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.script.ScriptEngineFactory";

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

    #region Compilable
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/Compilable.html
    /// </summary>
    public partial class Compilable : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Compilable>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Compilable() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Compilable(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.script.Compilable";

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

    #region SimpleBindings
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleBindings.html
    /// </summary>
    public partial class SimpleBindings : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SimpleBindings>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SimpleBindings() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SimpleBindings(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.script.SimpleBindings";

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

    #region ScriptContext
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptContext.html
    /// </summary>
    public partial class ScriptContext : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ScriptContext>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ScriptContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ScriptContext(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.script.ScriptContext";

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

    #region Invocable
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/Invocable.html
    /// </summary>
    public partial class Invocable : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Invocable>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Invocable() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Invocable(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "javax.script.Invocable";

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