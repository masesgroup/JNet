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

namespace Java.Util.Spi
{
    #region IToolProvider
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IToolProvider
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/ToolProvider.html#run(java.io.PrintWriter,java.io.PrintWriter,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintWriter"/></param>
        /// <param name="arg1"><see cref="Java.Io.PrintWriter"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        int Run(Java.Io.PrintWriter arg0, Java.Io.PrintWriter arg1, params Java.Lang.String[] arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/ToolProvider.html#name()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String Name();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/ToolProvider.html#run(java.io.PrintStream,java.io.PrintStream,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintStream"/></param>
        /// <param name="arg1"><see cref="Java.Io.PrintStream"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        int Run(Java.Io.PrintStream arg0, Java.Io.PrintStream arg1, params Java.Lang.String[] arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ToolProvider
    public partial class ToolProvider : Java.Util.Spi.IToolProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/ToolProvider.html#findFirst(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional<Java.Util.Spi.ToolProvider> FindFirst(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Optional<Java.Util.Spi.ToolProvider>>(LocalBridgeClazz, "findFirst", "(Ljava/lang/String;)Ljava/util/Optional;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/ToolProvider.html#run(java.io.PrintWriter,java.io.PrintWriter,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintWriter"/></param>
        /// <param name="arg1"><see cref="Java.Io.PrintWriter"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int Run(Java.Io.PrintWriter arg0, Java.Io.PrintWriter arg1, params Java.Lang.String[] arg2)
        {
            if (arg2.Length == 0) return IExecute<int>("run", arg0, arg1); else return IExecute<int>("run", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/ToolProvider.html#name()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/ToolProvider.html#run(java.io.PrintStream,java.io.PrintStream,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintStream"/></param>
        /// <param name="arg1"><see cref="Java.Io.PrintStream"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int Run(Java.Io.PrintStream arg0, Java.Io.PrintStream arg1, params Java.Lang.String[] arg2)
        {
            if (arg2.Length == 0) return IExecute<int>("run", arg0, arg1); else return IExecute<int>("run", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}