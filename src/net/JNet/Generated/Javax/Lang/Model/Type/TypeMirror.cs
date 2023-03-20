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

namespace Javax.Lang.Model.Type
{
    #region TypeMirror
    public partial class TypeMirror
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Type.TypeMirror"/> to <see cref="Javax.Lang.Model.AnnotatedConstruct"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.AnnotatedConstruct(Javax.Lang.Model.Type.TypeMirror t) => t.Cast<Javax.Lang.Model.AnnotatedConstruct>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeMirror.html#getKind()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.TypeKind Kind
        {
            get { return IExecute<Javax.Lang.Model.Type.TypeKind>("getKind"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/type/TypeMirror.html#accept(javax.lang.model.type.TypeVisitor%3CR, P%3E,P)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Type.TypeVisitor"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Accept(Javax.Lang.Model.Type.TypeVisitor arg0, object arg1)
        {
            return IExecute("accept", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}