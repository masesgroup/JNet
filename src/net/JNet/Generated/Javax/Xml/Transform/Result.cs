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

namespace Javax.Xml.Transform
{
    #region IResult
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IResult
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/Result.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/Result.html#setSystemId(java.lang.String)"/>
        /// </summary>
        string SystemId { get; set; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Result
    public partial class Result : Javax.Xml.Transform.IResult
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/Result.html#PI_DISABLE_OUTPUT_ESCAPING"/>
        /// </summary>
        public static string PI_DISABLE_OUTPUT_ESCAPING { get { return SGetField<string>(LocalBridgeClazz, "PI_DISABLE_OUTPUT_ESCAPING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/Result.html#PI_ENABLE_OUTPUT_ESCAPING"/>
        /// </summary>
        public static string PI_ENABLE_OUTPUT_ESCAPING { get { return SGetField<string>(LocalBridgeClazz, "PI_ENABLE_OUTPUT_ESCAPING"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/Result.html#getSystemId()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/Result.html#setSystemId(java.lang.String)"/>
        /// </summary>
        public string SystemId
        {
            get { return IExecute<string>("getSystemId"); } set { IExecute("setSystemId", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}