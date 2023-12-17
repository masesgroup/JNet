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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Tools
{
    #region ITool
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITool
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Tool.html#getSourceVersions()"/> 
        /// </summary>
        Java.Util.Set<Javax.Lang.Model.SourceVersion> SourceVersions { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Tool.html#run(java.io.InputStream,java.io.OutputStream,java.io.OutputStream,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg2"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        int Run(Java.Io.InputStream arg0, Java.Io.OutputStream arg1, Java.Io.OutputStream arg2, params string[] arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Tool.html#name()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        string Name();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Tool
    public partial class Tool : Javax.Tools.ITool
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Tool.html#getSourceVersions()"/> 
        /// </summary>
        public Java.Util.Set<Javax.Lang.Model.SourceVersion> SourceVersions
        {
            get { return IExecute<Java.Util.Set<Javax.Lang.Model.SourceVersion>>("getSourceVersions"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Tool.html#run(java.io.InputStream,java.io.OutputStream,java.io.OutputStream,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg2"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int Run(Java.Io.InputStream arg0, Java.Io.OutputStream arg1, Java.Io.OutputStream arg2, params string[] arg3)
        {
            if (arg3.Length == 0) return IExecute<int>("run", arg0, arg1, arg2); else return IExecute<int>("run", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Tool.html#name()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}