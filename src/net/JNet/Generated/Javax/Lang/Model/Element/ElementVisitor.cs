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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visit(javax.lang.model.element.Element,P)
        /// </summary>
        public object Visit(Javax.Lang.Model.Element.Element arg0, object arg1)
        {
            return IExecute("visit", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitExecutable(javax.lang.model.element.ExecutableElement,P)
        /// </summary>
        public object VisitExecutable(Javax.Lang.Model.Element.ExecutableElement arg0, object arg1)
        {
            return IExecute("visitExecutable", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitPackage(javax.lang.model.element.PackageElement,P)
        /// </summary>
        public object VisitPackage(Javax.Lang.Model.Element.PackageElement arg0, object arg1)
        {
            return IExecute("visitPackage", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitType(javax.lang.model.element.TypeElement,P)
        /// </summary>
        public object VisitType(Javax.Lang.Model.Element.TypeElement arg0, object arg1)
        {
            return IExecute("visitType", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitTypeParameter(javax.lang.model.element.TypeParameterElement,P)
        /// </summary>
        public object VisitTypeParameter(Javax.Lang.Model.Element.TypeParameterElement arg0, object arg1)
        {
            return IExecute("visitTypeParameter", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitUnknown(javax.lang.model.element.Element,P)
        /// </summary>
        public object VisitUnknown(Javax.Lang.Model.Element.Element arg0, object arg1)
        {
            return IExecute("visitUnknown", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitVariable(javax.lang.model.element.VariableElement,P)
        /// </summary>
        public object VisitVariable(Javax.Lang.Model.Element.VariableElement arg0, object arg1)
        {
            return IExecute("visitVariable", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visit(javax.lang.model.element.Element)
        /// </summary>
        public object Visit(Javax.Lang.Model.Element.Element arg0)
        {
            return IExecute("visit", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/ElementVisitor.html#visitModule(javax.lang.model.element.ModuleElement,P)
        /// </summary>
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
}