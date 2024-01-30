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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Script
{
    #region ScriptEngineManager
    public partial class ScriptEngineManager
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineManager.html#%3Cinit%3E(java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ClassLoader"/></param>
        public ScriptEngineManager(Java.Lang.ClassLoader arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineManager.html#getBindings()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineManager.html#setBindings(javax.script.Bindings)"/>
        /// </summary>
        public Javax.Script.Bindings Bindings
        {
            get { return IExecute<Javax.Script.Bindings>("getBindings"); } set { IExecute("setBindings", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineManager.html#getEngineFactories()"/> 
        /// </summary>
        public Java.Util.List<Javax.Script.ScriptEngineFactory> EngineFactories
        {
            get { return IExecute<Java.Util.List<Javax.Script.ScriptEngineFactory>>("getEngineFactories"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineManager.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(string arg0)
        {
            return IExecute("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineManager.html#getEngineByExtension(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Script.ScriptEngine"/></returns>
        public Javax.Script.ScriptEngine GetEngineByExtension(string arg0)
        {
            return IExecute<Javax.Script.ScriptEngine>("getEngineByExtension", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineManager.html#getEngineByMimeType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Script.ScriptEngine"/></returns>
        public Javax.Script.ScriptEngine GetEngineByMimeType(string arg0)
        {
            return IExecute<Javax.Script.ScriptEngine>("getEngineByMimeType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineManager.html#getEngineByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Script.ScriptEngine"/></returns>
        public Javax.Script.ScriptEngine GetEngineByName(string arg0)
        {
            return IExecute<Javax.Script.ScriptEngine>("getEngineByName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineManager.html#put(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Put(string arg0, object arg1)
        {
            IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineManager.html#registerEngineExtension(java.lang.String,javax.script.ScriptEngineFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Script.ScriptEngineFactory"/></param>
        public void RegisterEngineExtension(string arg0, Javax.Script.ScriptEngineFactory arg1)
        {
            IExecute("registerEngineExtension", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineManager.html#registerEngineMimeType(java.lang.String,javax.script.ScriptEngineFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Script.ScriptEngineFactory"/></param>
        public void RegisterEngineMimeType(string arg0, Javax.Script.ScriptEngineFactory arg1)
        {
            IExecute("registerEngineMimeType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/ScriptEngineManager.html#registerEngineName(java.lang.String,javax.script.ScriptEngineFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Script.ScriptEngineFactory"/></param>
        public void RegisterEngineName(string arg0, Javax.Script.ScriptEngineFactory arg1)
        {
            IExecute("registerEngineName", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}