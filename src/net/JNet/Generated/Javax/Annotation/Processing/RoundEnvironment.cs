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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Annotation.Processing
{
    #region RoundEnvironment
    public partial class RoundEnvironment
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#errorRaised()"/> 
        /// </summary>
        public bool ErrorRaised
        {
            get { return IExecute<bool>("errorRaised"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#processingOver()"/> 
        /// </summary>
        public bool ProcessingOver
        {
            get { return IExecute<bool>("processingOver"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getRootElements()"/> 
        /// </summary>
        public Java.Util.Set RootElements
        {
            get { return IExecute<Java.Util.Set>("getRootElements"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getElementsAnnotatedWith(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="ReturnExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element> GetElementsAnnotatedWith<ReturnExtendsJavax_Lang_Model_Element_Element>(Java.Lang.Class arg0) where ReturnExtendsJavax_Lang_Model_Element_Element: Javax.Lang.Model.Element.Element
        {
            return IExecute<Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element>>("getElementsAnnotatedWith", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getElementsAnnotatedWith(javax.lang.model.element.TypeElement)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <typeparam name="ReturnExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element> GetElementsAnnotatedWith<ReturnExtendsJavax_Lang_Model_Element_Element>(Javax.Lang.Model.Element.TypeElement arg0) where ReturnExtendsJavax_Lang_Model_Element_Element: Javax.Lang.Model.Element.Element
        {
            return IExecute<Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element>>("getElementsAnnotatedWith", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getElementsAnnotatedWithAny(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <typeparam name="ReturnExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Lang_Annotation_Annotation"><see cref="Java.Lang.Annotation.Annotation"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element> GetElementsAnnotatedWithAny<ReturnExtendsJavax_Lang_Model_Element_Element, Arg0ExtendsJava_Lang_Annotation_Annotation>(Java.Util.Set<Java.Lang.Class> arg0) where ReturnExtendsJavax_Lang_Model_Element_Element: Javax.Lang.Model.Element.Element where Arg0ExtendsJava_Lang_Annotation_Annotation: Java.Lang.Annotation.Annotation
        {
            return IExecute<Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element>>("getElementsAnnotatedWithAny", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/RoundEnvironment.html#getElementsAnnotatedWithAny(javax.lang.model.element.TypeElement[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.TypeElement"/></param>
        /// <typeparam name="ReturnExtendsJavax_Lang_Model_Element_Element"><see cref="Javax.Lang.Model.Element.Element"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element> GetElementsAnnotatedWithAny<ReturnExtendsJavax_Lang_Model_Element_Element>(params Javax.Lang.Model.Element.TypeElement[] arg0) where ReturnExtendsJavax_Lang_Model_Element_Element: Javax.Lang.Model.Element.Element
        {
            if (arg0.Length == 0) return IExecute<Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element>>("getElementsAnnotatedWithAny", new object[] { arg0 }); else return IExecute<Java.Util.Set<ReturnExtendsJavax_Lang_Model_Element_Element>>("getElementsAnnotatedWithAny", new object[] { arg0 }, arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}