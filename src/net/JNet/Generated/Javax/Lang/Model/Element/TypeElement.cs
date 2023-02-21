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

namespace Javax.Lang.Model.Element
{
    #region TypeElement
    public partial class TypeElement
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Lang.Model.Element.Element(Javax.Lang.Model.Element.TypeElement t) => t.Cast<Javax.Lang.Model.Element.Element>();
        public static implicit operator Javax.Lang.Model.Element.Parameterizable(Javax.Lang.Model.Element.TypeElement t) => t.Cast<Javax.Lang.Model.Element.Parameterizable>();
        public static implicit operator Javax.Lang.Model.Element.QualifiedNameable(Javax.Lang.Model.Element.TypeElement t) => t.Cast<Javax.Lang.Model.Element.QualifiedNameable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getEnclosingElement() 
        /// </summary>
        public Javax.Lang.Model.Element.Element EnclosingElement
        {
            get { return IExecute<Javax.Lang.Model.Element.Element>("getEnclosingElement"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getQualifiedName() 
        /// </summary>
        public Javax.Lang.Model.Element.Name QualifiedName
        {
            get { return IExecute<Javax.Lang.Model.Element.Name>("getQualifiedName"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getSimpleName() 
        /// </summary>
        public Javax.Lang.Model.Element.Name SimpleName
        {
            get { return IExecute<Javax.Lang.Model.Element.Name>("getSimpleName"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/TypeElement.html#getSuperclass() 
        /// </summary>
        public Javax.Lang.Model.Type.TypeMirror Superclass
        {
            get { return IExecute<Javax.Lang.Model.Type.TypeMirror>("getSuperclass"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}