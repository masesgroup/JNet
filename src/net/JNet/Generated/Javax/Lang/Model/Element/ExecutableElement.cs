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
    #region ExecutableElement
    public partial class ExecutableElement
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Element.ExecutableElement"/> to <see cref="Javax.Lang.Model.Element.Element"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Element.Element(Javax.Lang.Model.Element.ExecutableElement t) => t.Cast<Javax.Lang.Model.Element.Element>();
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Element.ExecutableElement"/> to <see cref="Javax.Lang.Model.Element.Parameterizable"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Element.Parameterizable(Javax.Lang.Model.Element.ExecutableElement t) => t.Cast<Javax.Lang.Model.Element.Parameterizable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getDefaultValue()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.AnnotationValue DefaultValue
        {
            get { return IExecute<Javax.Lang.Model.Element.AnnotationValue>("getDefaultValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getParameters()"/> 
        /// </summary>
        public Java.Util.List Parameters
        {
            get { return IExecute<Java.Util.List>("getParameters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getReceiverType()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.TypeMirror ReceiverType
        {
            get { return IExecute<Javax.Lang.Model.Type.TypeMirror>("getReceiverType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getReturnType()"/> 
        /// </summary>
        public Javax.Lang.Model.Type.TypeMirror ReturnType
        {
            get { return IExecute<Javax.Lang.Model.Type.TypeMirror>("getReturnType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getSimpleName()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Name SimpleName
        {
            get { return IExecute<Javax.Lang.Model.Element.Name>("getSimpleName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getThrownTypes()"/> 
        /// </summary>
        public Java.Util.List ThrownTypes
        {
            get { return IExecute<Java.Util.List>("getThrownTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#getTypeParameters()"/> 
        /// </summary>
        public Java.Util.List TypeParameters
        {
            get { return IExecute<Java.Util.List>("getTypeParameters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#isDefault()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsDefault()
        {
            return IExecute<bool>("isDefault");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ExecutableElement.html#isVarArgs()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsVarArgs()
        {
            return IExecute<bool>("isVarArgs");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}