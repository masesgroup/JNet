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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Tools
{
    #region ToolProvider
    public partial class ToolProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ToolProvider.html#getSystemDocumentationTool()"/> 
        /// </summary>
        public static Javax.Tools.DocumentationTool SystemDocumentationTool
        {
            get { return SExecuteWithSignature<Javax.Tools.DocumentationTool>(LocalBridgeClazz, "getSystemDocumentationTool", "()Ljavax/tools/DocumentationTool;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/ToolProvider.html#getSystemJavaCompiler()"/> 
        /// </summary>
        public static Javax.Tools.JavaCompiler SystemJavaCompiler
        {
            get { return SExecuteWithSignature<Javax.Tools.JavaCompiler>(LocalBridgeClazz, "getSystemJavaCompiler", "()Ljavax/tools/JavaCompiler;"); }
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}