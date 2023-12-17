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

namespace Javax.Lang.Model.Element
{
    #region ElementVisitor
    public partial class ElementVisitor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visit(javax.lang.model.element.Element,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Visit(Javax.Lang.Model.Element.Element arg0, object arg1)
        {
            return IExecute("visit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitExecutable(javax.lang.model.element.ExecutableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitExecutable(Javax.Lang.Model.Element.ExecutableElement arg0, object arg1)
        {
            return IExecute("visitExecutable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitPackage(javax.lang.model.element.PackageElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.PackageElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitPackage(Javax.Lang.Model.Element.PackageElement arg0, object arg1)
        {
            return IExecute("visitPackage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitType(javax.lang.model.element.TypeElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitType(Javax.Lang.Model.Element.TypeElement arg0, object arg1)
        {
            return IExecute("visitType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitTypeParameter(javax.lang.model.element.TypeParameterElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeParameterElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitTypeParameter(Javax.Lang.Model.Element.TypeParameterElement arg0, object arg1)
        {
            return IExecute("visitTypeParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitUnknown(javax.lang.model.element.Element,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitUnknown(Javax.Lang.Model.Element.Element arg0, object arg1)
        {
            return IExecute("visitUnknown", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitVariable(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitVariable(Javax.Lang.Model.Element.VariableElement arg0, object arg1)
        {
            return IExecute("visitVariable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visit(javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="object"/></returns>
        public object Visit(Javax.Lang.Model.Element.Element arg0)
        {
            return IExecute("visit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitModule(javax.lang.model.element.ModuleElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object VisitModule(Javax.Lang.Model.Element.ModuleElement arg0, object arg1)
        {
            return IExecute("visitModule", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IElementVisitor<R, P>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IElementVisitor<R, P>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visit(javax.lang.model.element.Element,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R Visit(Javax.Lang.Model.Element.Element arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitExecutable(javax.lang.model.element.ExecutableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitExecutable(Javax.Lang.Model.Element.ExecutableElement arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitPackage(javax.lang.model.element.PackageElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.PackageElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitPackage(Javax.Lang.Model.Element.PackageElement arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitType(javax.lang.model.element.TypeElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitType(Javax.Lang.Model.Element.TypeElement arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitTypeParameter(javax.lang.model.element.TypeParameterElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeParameterElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitTypeParameter(Javax.Lang.Model.Element.TypeParameterElement arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitUnknown(javax.lang.model.element.Element,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitUnknown(Javax.Lang.Model.Element.Element arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitVariable(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitVariable(Javax.Lang.Model.Element.VariableElement arg0, P arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visit(javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R Visit(Javax.Lang.Model.Element.Element arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitModule(javax.lang.model.element.ModuleElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        R VisitModule(Javax.Lang.Model.Element.ModuleElement arg0, P arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ElementVisitor<R, P>
    public partial class ElementVisitor<R, P> : Javax.Lang.Model.Element.IElementVisitor<R, P>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Element.ElementVisitor{R, P}"/> to <see cref="Javax.Lang.Model.Element.ElementVisitor"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.Element.ElementVisitor(Javax.Lang.Model.Element.ElementVisitor<R, P> t) => t.Cast<Javax.Lang.Model.Element.ElementVisitor>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visit(javax.lang.model.element.Element,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Visit(Javax.Lang.Model.Element.Element arg0, P arg1)
        {
            return IExecute<R>("visit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitExecutable(javax.lang.model.element.ExecutableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitExecutable(Javax.Lang.Model.Element.ExecutableElement arg0, P arg1)
        {
            return IExecute<R>("visitExecutable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitPackage(javax.lang.model.element.PackageElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.PackageElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitPackage(Javax.Lang.Model.Element.PackageElement arg0, P arg1)
        {
            return IExecute<R>("visitPackage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitType(javax.lang.model.element.TypeElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitType(Javax.Lang.Model.Element.TypeElement arg0, P arg1)
        {
            return IExecute<R>("visitType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitTypeParameter(javax.lang.model.element.TypeParameterElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeParameterElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitTypeParameter(Javax.Lang.Model.Element.TypeParameterElement arg0, P arg1)
        {
            return IExecute<R>("visitTypeParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitUnknown(javax.lang.model.element.Element,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitUnknown(Javax.Lang.Model.Element.Element arg0, P arg1)
        {
            return IExecute<R>("visitUnknown", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitVariable(javax.lang.model.element.VariableElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.VariableElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitVariable(Javax.Lang.Model.Element.VariableElement arg0, P arg1)
        {
            return IExecute<R>("visitVariable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visit(javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Visit(Javax.Lang.Model.Element.Element arg0)
        {
            return IExecute<R>("visit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitModule(javax.lang.model.element.ModuleElement,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement"/></param>
        /// <param name="arg1"><typeparamref name="P"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R VisitModule(Javax.Lang.Model.Element.ModuleElement arg0, P arg1)
        {
            return IExecute<R>("visitModule", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}