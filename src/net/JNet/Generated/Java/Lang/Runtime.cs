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

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Runtime
    public partial class Runtime
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#getRuntime()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Lang.Runtime"/></returns>
        public static Java.Lang.Runtime GetRuntime()
        {
            return SExecute<Java.Lang.Runtime>("getRuntime");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#version()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Lang.Runtime.Version"/></returns>
        public static Java.Lang.Runtime.Version VersionMethod()
        {
            return SExecute<Java.Lang.Runtime.Version>("version");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#removeShutdownHook(java.lang.Thread)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool RemoveShutdownHook(Java.Lang.Thread arg0)
        {
            return IExecute<bool>("removeShutdownHook", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#exec(java.lang.String,java.lang.String[],java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Process Exec(string arg0, string[] arg1, Java.Io.File arg2)
        {
            return IExecute<Java.Lang.Process>("exec", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#exec(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Process Exec(string arg0, string[] arg1)
        {
            return IExecute<Java.Lang.Process>("exec", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#exec(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Process Exec(string arg0)
        {
            return IExecute<Java.Lang.Process>("exec", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#exec(java.lang.String[],java.lang.String[],java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Process Exec(string[] arg0, string[] arg1, Java.Io.File arg2)
        {
            return IExecute<Java.Lang.Process>("exec", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#exec(java.lang.String[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Process Exec(string[] arg0, string[] arg1)
        {
            return IExecute<Java.Lang.Process>("exec", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#exec(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Process Exec(string[] arg0)
        {
            return IExecute<Java.Lang.Process>("exec", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#availableProcessors()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int AvailableProcessors()
        {
            return IExecute<int>("availableProcessors");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#freeMemory()"/>
        /// </summary>
        
        /// <returns><see langword="long"/></returns>
        public long FreeMemory()
        {
            return IExecute<long>("freeMemory");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#maxMemory()"/>
        /// </summary>
        
        /// <returns><see langword="long"/></returns>
        public long MaxMemory()
        {
            return IExecute<long>("maxMemory");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#totalMemory()"/>
        /// </summary>
        
        /// <returns><see langword="long"/></returns>
        public long TotalMemory()
        {
            return IExecute<long>("totalMemory");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#gc()"/>
        /// </summary>
        public void Gc()
        {
            IExecute("gc");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#addShutdownHook(java.lang.Thread)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        public void AddShutdownHook(Java.Lang.Thread arg0)
        {
            IExecute("addShutdownHook", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#exit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Exit(int arg0)
        {
            IExecute("exit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#halt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Halt(int arg0)
        {
            IExecute("halt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#load(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void Load(string arg0)
        {
            IExecute("load", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#loadLibrary(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void LoadLibrary(string arg0)
        {
            IExecute("loadLibrary", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.html#runFinalization()"/>
        /// </summary>
        public void RunFinalization()
        {
            IExecute("runFinalization");
        }
        
        #endregion

        #region Nested classes
        #region Version
        public partial class Version
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#parse(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Lang.Runtime.Version"/></returns>
            public static Java.Lang.Runtime.Version Parse(string arg0)
            {
                return SExecute<Java.Lang.Runtime.Version>("parse", arg0);
            }
            
            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#equalsIgnoreOptional(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see langword="bool"/></returns>
            public bool EqualsIgnoreOptional(object arg0)
            {
                return IExecute<bool>("equalsIgnoreOptional", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#compareTo(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see langword="int"/></returns>
            public int CompareTo(object arg0)
            {
                return IExecute<int>("compareTo", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#compareTo(java.lang.Runtime$Version)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Runtime.Version"/></param>
            /// <returns><see langword="int"/></returns>
            public int CompareTo(Java.Lang.Runtime.Version arg0)
            {
                return IExecute<int>("compareTo", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#compareToIgnoreOptional(java.lang.Runtime$Version)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Runtime.Version"/></param>
            /// <returns><see langword="int"/></returns>
            public int CompareToIgnoreOptional(Java.Lang.Runtime.Version arg0)
            {
                return IExecute<int>("compareToIgnoreOptional", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#feature()"/>
            /// </summary>
            
            /// <returns><see langword="int"/></returns>
            public int Feature()
            {
                return IExecute<int>("feature");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#interim()"/>
            /// </summary>
            
            /// <returns><see langword="int"/></returns>
            public int Interim()
            {
                return IExecute<int>("interim");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#patch()"/>
            /// </summary>
            
            /// <returns><see langword="int"/></returns>
            public int Patch()
            {
                return IExecute<int>("patch");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Runtime.Version.html#update()"/>
            /// </summary>
            
            /// <returns><see langword="int"/></returns>
            public int Update()
            {
                return IExecute<int>("update");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}