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

namespace Javax.Lang.Model.Type
{
    #region IWildcardType
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IWildcardType : Javax.Lang.Model.Type.ITypeMirror
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/WildcardType.html#getExtendsBound()"/> 
        /// </summary>
        Javax.Lang.Model.Type.TypeMirror ExtendsBound { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/WildcardType.html#getSuperBound()"/> 
        /// </summary>
        Javax.Lang.Model.Type.TypeMirror SuperBound { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WildcardType
    public partial class WildcardType : Javax.Lang.Model.Type.IWildcardType
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/WildcardType.html#getExtendsBound()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.TypeMirror ExtendsBound
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Type.TypeMirror>("getExtendsBound", "()Ljavax/lang/model/type/TypeMirror;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/WildcardType.html#getSuperBound()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.TypeMirror SuperBound
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Type.TypeMirror>("getSuperBound", "()Ljavax/lang/model/type/TypeMirror;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}