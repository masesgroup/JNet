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

/*
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Script
{
    #region CompiledScript
    public partial class CompiledScript
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/CompiledScript.html#getEngine()"/> 
        /// </summary>
        public Javax.Script.ScriptEngine Engine
        {
            get { return IExecuteWithSignature<Javax.Script.ScriptEngine>("getEngine", "()Ljavax/script/ScriptEngine;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/CompiledScript.html#eval(javax.script.ScriptContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Script.ScriptContext"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        public object Eval(Javax.Script.ScriptContext arg0)
        {
            return IExecuteWithSignature("eval", "(Ljavax/script/ScriptContext;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/CompiledScript.html#eval()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        public object Eval()
        {
            return IExecuteWithSignature("eval", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/CompiledScript.html#eval(javax.script.Bindings)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Script.Bindings"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Script.ScriptException"/>
        public object Eval(Javax.Script.Bindings arg0)
        {
            return IExecuteWithSignature("eval", "(Ljavax/script/Bindings;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}