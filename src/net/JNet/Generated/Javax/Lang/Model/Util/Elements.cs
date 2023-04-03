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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Lang.Model.Util
{
    #region Elements
    public partial class Elements
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getAllModuleElements()"/> 
        /// </summary>
        public Java.Util.Set AllModuleElements
        {
            get { return IExecute<Java.Util.Set>("getAllModuleElements"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#hides(javax.lang.model.element.Element,javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Hides(Javax.Lang.Model.Element.Element arg0, Javax.Lang.Model.Element.Element arg1)
        {
            return IExecute<bool>("hides", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#isDeprecated(javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDeprecated(Javax.Lang.Model.Element.Element arg0)
        {
            return IExecute<bool>("isDeprecated", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#isFunctionalInterface(javax.lang.model.element.TypeElement)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsFunctionalInterface(Javax.Lang.Model.Element.TypeElement arg0)
        {
            return IExecute<bool>("isFunctionalInterface", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#overrides(javax.lang.model.element.ExecutableElement,javax.lang.model.element.ExecutableElement,javax.lang.model.element.TypeElement)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg2"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Overrides(Javax.Lang.Model.Element.ExecutableElement arg0, Javax.Lang.Model.Element.ExecutableElement arg1, Javax.Lang.Model.Element.TypeElement arg2)
        {
            return IExecute<bool>("overrides", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getConstantExpression(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetConstantExpression(object arg0)
        {
            return IExecute<string>("getConstantExpression", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getDocComment(javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetDocComment(Javax.Lang.Model.Element.Element arg0)
        {
            return IExecute<string>("getDocComment", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getAllAnnotationMirrors(javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<ReturnExtendsJavax_Lang_Model_Element_AnnotationMirror> GetAllAnnotationMirrors<ReturnExtendsJavax_Lang_Model_Element_AnnotationMirror>(Javax.Lang.Model.Element.Element arg0) where ReturnExtendsJavax_Lang_Model_Element_AnnotationMirror: Javax.Lang.Model.Element.AnnotationMirror
        {
            return IExecute<Java.Util.List<ReturnExtendsJavax_Lang_Model_Element_AnnotationMirror>>("getAllAnnotationMirrors", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getAllMembers(javax.lang.model.element.TypeElement)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<ReturnExtendsJavax_Lang_Model_Element_Element> GetAllMembers<ReturnExtendsJavax_Lang_Model_Element_Element>(Javax.Lang.Model.Element.TypeElement arg0) where ReturnExtendsJavax_Lang_Model_Element_Element: Javax.Lang.Model.Element.Element
        {
            return IExecute<Java.Util.List<ReturnExtendsJavax_Lang_Model_Element_Element>>("getAllMembers", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getElementValuesWithDefaults(javax.lang.model.element.AnnotationMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.AnnotationMirror"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<ReturnExtendsJavax_Lang_Model_Element_ExecutableElement, ReturnExtendsJavax_Lang_Model_Element_AnnotationValue> GetElementValuesWithDefaults<ReturnExtendsJavax_Lang_Model_Element_ExecutableElement, ReturnExtendsJavax_Lang_Model_Element_AnnotationValue>(Javax.Lang.Model.Element.AnnotationMirror arg0) where ReturnExtendsJavax_Lang_Model_Element_ExecutableElement: Javax.Lang.Model.Element.ExecutableElement where ReturnExtendsJavax_Lang_Model_Element_AnnotationValue: Javax.Lang.Model.Element.AnnotationValue
        {
            return IExecute<Java.Util.Map<ReturnExtendsJavax_Lang_Model_Element_ExecutableElement, ReturnExtendsJavax_Lang_Model_Element_AnnotationValue>>("getElementValuesWithDefaults", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getBinaryName(javax.lang.model.element.TypeElement)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <returns><see cref="Javax.Lang.Model.Element.Name"/></returns>
        public Javax.Lang.Model.Element.Name GetBinaryName(Javax.Lang.Model.Element.TypeElement arg0)
        {
            return IExecute<Javax.Lang.Model.Element.Name>("getBinaryName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getName(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Javax.Lang.Model.Element.Name"/></returns>
        public Javax.Lang.Model.Element.Name GetName(Java.Lang.CharSequence arg0)
        {
            return IExecute<Javax.Lang.Model.Element.Name>("getName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getPackageElement(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Javax.Lang.Model.Element.PackageElement"/></returns>
        public Javax.Lang.Model.Element.PackageElement GetPackageElement(Java.Lang.CharSequence arg0)
        {
            return IExecute<Javax.Lang.Model.Element.PackageElement>("getPackageElement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getPackageOf(javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="Javax.Lang.Model.Element.PackageElement"/></returns>
        public Javax.Lang.Model.Element.PackageElement GetPackageOf(Javax.Lang.Model.Element.Element arg0)
        {
            return IExecute<Javax.Lang.Model.Element.PackageElement>("getPackageOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getTypeElement(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Javax.Lang.Model.Element.TypeElement"/></returns>
        public Javax.Lang.Model.Element.TypeElement GetTypeElement(Java.Lang.CharSequence arg0)
        {
            return IExecute<Javax.Lang.Model.Element.TypeElement>("getTypeElement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#printElements(java.io.Writer,javax.lang.model.element.Element[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.Element"/></param>
        public void PrintElements(Java.Io.Writer arg0, params Javax.Lang.Model.Element.Element[] arg1)
        {
            if (arg1.Length == 0) IExecute("printElements", arg0); else IExecute("printElements", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#isBridge(javax.lang.model.element.ExecutableElement)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsBridge(Javax.Lang.Model.Element.ExecutableElement arg0)
        {
            return IExecute<bool>("isBridge", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getAllPackageElements(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_PackageElement> GetAllPackageElements<ReturnExtendsJavax_Lang_Model_Element_PackageElement>(Java.Lang.CharSequence arg0) where ReturnExtendsJavax_Lang_Model_Element_PackageElement: Javax.Lang.Model.Element.PackageElement
        {
            return IExecute<Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_PackageElement>>("getAllPackageElements", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getAllTypeElements(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_TypeElement> GetAllTypeElements<ReturnExtendsJavax_Lang_Model_Element_TypeElement>(Java.Lang.CharSequence arg0) where ReturnExtendsJavax_Lang_Model_Element_TypeElement: Javax.Lang.Model.Element.TypeElement
        {
            return IExecute<Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_TypeElement>>("getAllTypeElements", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getModuleElement(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Javax.Lang.Model.Element.ModuleElement"/></returns>
        public Javax.Lang.Model.Element.ModuleElement GetModuleElement(Java.Lang.CharSequence arg0)
        {
            return IExecute<Javax.Lang.Model.Element.ModuleElement>("getModuleElement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getModuleOf(javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="Javax.Lang.Model.Element.ModuleElement"/></returns>
        public Javax.Lang.Model.Element.ModuleElement GetModuleOf(Javax.Lang.Model.Element.Element arg0)
        {
            return IExecute<Javax.Lang.Model.Element.ModuleElement>("getModuleOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getPackageElement(javax.lang.model.element.ModuleElement,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Javax.Lang.Model.Element.PackageElement"/></returns>
        public Javax.Lang.Model.Element.PackageElement GetPackageElement(Javax.Lang.Model.Element.ModuleElement arg0, Java.Lang.CharSequence arg1)
        {
            return IExecute<Javax.Lang.Model.Element.PackageElement>("getPackageElement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getTypeElement(javax.lang.model.element.ModuleElement,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Javax.Lang.Model.Element.TypeElement"/></returns>
        public Javax.Lang.Model.Element.TypeElement GetTypeElement(Javax.Lang.Model.Element.ModuleElement arg0, Java.Lang.CharSequence arg1)
        {
            return IExecute<Javax.Lang.Model.Element.TypeElement>("getTypeElement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getOrigin(javax.lang.model.AnnotatedConstruct,javax.lang.model.element.AnnotationMirror)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.AnnotatedConstruct"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.AnnotationMirror"/></param>
        /// <returns><see cref="Javax.Lang.Model.Util.Elements.Origin"/></returns>
        public Javax.Lang.Model.Util.Elements.Origin GetOrigin(Javax.Lang.Model.AnnotatedConstruct arg0, Javax.Lang.Model.Element.AnnotationMirror arg1)
        {
            return IExecute<Javax.Lang.Model.Util.Elements.Origin>("getOrigin", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getOrigin(javax.lang.model.element.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <returns><see cref="Javax.Lang.Model.Util.Elements.Origin"/></returns>
        public Javax.Lang.Model.Util.Elements.Origin GetOrigin(Javax.Lang.Model.Element.Element arg0)
        {
            return IExecute<Javax.Lang.Model.Util.Elements.Origin>("getOrigin", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.html#getOrigin(javax.lang.model.element.ModuleElement,javax.lang.model.element.ModuleElement.Directive)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ModuleElement"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.ModuleElement.Directive"/></param>
        /// <returns><see cref="Javax.Lang.Model.Util.Elements.Origin"/></returns>
        public Javax.Lang.Model.Util.Elements.Origin GetOrigin(Javax.Lang.Model.Element.ModuleElement arg0, Javax.Lang.Model.Element.ModuleElement.Directive arg1)
        {
            return IExecute<Javax.Lang.Model.Util.Elements.Origin>("getOrigin", arg0, arg1);
        }
        
        #endregion

        #region Nested classes
        #region Origin
        public partial class Origin
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.Origin.html#EXPLICIT"/>
            /// </summary>
            public static Javax.Lang.Model.Util.Elements.Origin EXPLICIT => Clazz.GetField<Javax.Lang.Model.Util.Elements.Origin>("EXPLICIT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.Origin.html#MANDATED"/>
            /// </summary>
            public static Javax.Lang.Model.Util.Elements.Origin MANDATED => Clazz.GetField<Javax.Lang.Model.Util.Elements.Origin>("MANDATED");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.Origin.html#SYNTHETIC"/>
            /// </summary>
            public static Javax.Lang.Model.Util.Elements.Origin SYNTHETIC => Clazz.GetField<Javax.Lang.Model.Util.Elements.Origin>("SYNTHETIC");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.Origin.html#values()"/> 
            /// </summary>
            public static Javax.Lang.Model.Util.Elements.Origin[] Values
            {
                get { return SExecuteArray<Javax.Lang.Model.Util.Elements.Origin>("values"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.Origin.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Lang.Model.Util.Elements.Origin"/></returns>
            public static Javax.Lang.Model.Util.Elements.Origin ValueOf(string arg0)
            {
                return SExecute<Javax.Lang.Model.Util.Elements.Origin>("valueOf", arg0);
            }
            
            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/Elements.Origin.html#isDeclared()"/> 
            /// </summary>
            public bool IsDeclared
            {
                get { return IExecute<bool>("isDeclared"); }
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}