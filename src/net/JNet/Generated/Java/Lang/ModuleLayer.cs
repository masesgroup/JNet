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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region ModuleLayer
    public partial class ModuleLayer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.html#boot()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.ModuleLayer"/></returns>
        public static Java.Lang.ModuleLayer Boot()
        {
            return SExecute<Java.Lang.ModuleLayer>(LocalBridgeClazz, "boot");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.html#empty()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.ModuleLayer"/></returns>
        public static Java.Lang.ModuleLayer Empty()
        {
            return SExecute<Java.Lang.ModuleLayer>(LocalBridgeClazz, "empty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.html#defineModules(java.lang.module.Configuration,java.util.List,java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ModuleNs.Configuration"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Lang.ModuleLayer.Controller"/></returns>
        public static Java.Lang.ModuleLayer.Controller DefineModules(Java.Lang.ModuleNs.Configuration arg0, Java.Util.List<Java.Lang.ModuleLayer> arg1, Java.Util.Function.Function<string, Java.Lang.ClassLoader> arg2)
        {
            return SExecute<Java.Lang.ModuleLayer.Controller>(LocalBridgeClazz, "defineModules", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.html#defineModulesWithManyLoaders(java.lang.module.Configuration,java.util.List,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ModuleNs.Configuration"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Lang.ModuleLayer.Controller"/></returns>
        public static Java.Lang.ModuleLayer.Controller DefineModulesWithManyLoaders(Java.Lang.ModuleNs.Configuration arg0, Java.Util.List<Java.Lang.ModuleLayer> arg1, Java.Lang.ClassLoader arg2)
        {
            return SExecute<Java.Lang.ModuleLayer.Controller>(LocalBridgeClazz, "defineModulesWithManyLoaders", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.html#defineModulesWithOneLoader(java.lang.module.Configuration,java.util.List,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ModuleNs.Configuration"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Lang.ModuleLayer.Controller"/></returns>
        public static Java.Lang.ModuleLayer.Controller DefineModulesWithOneLoader(Java.Lang.ModuleNs.Configuration arg0, Java.Util.List<Java.Lang.ModuleLayer> arg1, Java.Lang.ClassLoader arg2)
        {
            return SExecute<Java.Lang.ModuleLayer.Controller>(LocalBridgeClazz, "defineModulesWithOneLoader", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.html#findLoader(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.ClassLoader"/></returns>
        public Java.Lang.ClassLoader FindLoader(string arg0)
        {
            return IExecute<Java.Lang.ClassLoader>("findLoader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.html#configuration()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.ModuleNs.Configuration"/></returns>
        public Java.Lang.ModuleNs.Configuration Configuration()
        {
            return IExecute<Java.Lang.ModuleNs.Configuration>("configuration");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.html#defineModules(java.lang.module.Configuration,java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ModuleNs.Configuration"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Lang.ModuleLayer"/></returns>
        public Java.Lang.ModuleLayer DefineModules(Java.Lang.ModuleNs.Configuration arg0, Java.Util.Function.Function<string, Java.Lang.ClassLoader> arg1)
        {
            return IExecute<Java.Lang.ModuleLayer>("defineModules", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.html#defineModulesWithManyLoaders(java.lang.module.Configuration,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ModuleNs.Configuration"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Lang.ModuleLayer"/></returns>
        public Java.Lang.ModuleLayer DefineModulesWithManyLoaders(Java.Lang.ModuleNs.Configuration arg0, Java.Lang.ClassLoader arg1)
        {
            return IExecute<Java.Lang.ModuleLayer>("defineModulesWithManyLoaders", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.html#defineModulesWithOneLoader(java.lang.module.Configuration,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ModuleNs.Configuration"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Lang.ModuleLayer"/></returns>
        public Java.Lang.ModuleLayer DefineModulesWithOneLoader(Java.Lang.ModuleNs.Configuration arg0, Java.Lang.ClassLoader arg1)
        {
            return IExecute<Java.Lang.ModuleLayer>("defineModulesWithOneLoader", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.html#parents()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.ModuleLayer> Parents()
        {
            return IExecute<Java.Util.List<Java.Lang.ModuleLayer>>("parents");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.html#findModule(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Lang.Module> FindModule(string arg0)
        {
            return IExecute<Java.Util.Optional<Java.Lang.Module>>("findModule", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.html#modules()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Module> Modules()
        {
            return IExecute<Java.Util.Set<Java.Lang.Module>>("modules");
        }

        #endregion

        #region Nested classes
        #region Controller
        public partial class Controller
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.Controller.html#layer()"/>
            /// </summary>

            /// <returns><see cref="Java.Lang.ModuleLayer"/></returns>
            public Java.Lang.ModuleLayer Layer()
            {
                return IExecute<Java.Lang.ModuleLayer>("layer");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.Controller.html#addExports(java.lang.Module,java.lang.String,java.lang.Module)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Module"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <param name="arg2"><see cref="Java.Lang.Module"/></param>
            /// <returns><see cref="Java.Lang.ModuleLayer.Controller"/></returns>
            public Java.Lang.ModuleLayer.Controller AddExports(Java.Lang.Module arg0, string arg1, Java.Lang.Module arg2)
            {
                return IExecute<Java.Lang.ModuleLayer.Controller>("addExports", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.Controller.html#addOpens(java.lang.Module,java.lang.String,java.lang.Module)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Module"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <param name="arg2"><see cref="Java.Lang.Module"/></param>
            /// <returns><see cref="Java.Lang.ModuleLayer.Controller"/></returns>
            public Java.Lang.ModuleLayer.Controller AddOpens(Java.Lang.Module arg0, string arg1, Java.Lang.Module arg2)
            {
                return IExecute<Java.Lang.ModuleLayer.Controller>("addOpens", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ModuleLayer.Controller.html#addReads(java.lang.Module,java.lang.Module)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Module"/></param>
            /// <param name="arg1"><see cref="Java.Lang.Module"/></param>
            /// <returns><see cref="Java.Lang.ModuleLayer.Controller"/></returns>
            public Java.Lang.ModuleLayer.Controller AddReads(Java.Lang.Module arg0, Java.Lang.Module arg1)
            {
                return IExecute<Java.Lang.ModuleLayer.Controller>("addReads", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}