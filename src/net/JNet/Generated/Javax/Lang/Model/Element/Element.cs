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
    #region Element
    public partial class Element
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Lang.Model.Element.Element"/> to <see cref="Javax.Lang.Model.AnnotatedConstruct"/>
        /// </summary>
        public static implicit operator Javax.Lang.Model.AnnotatedConstruct(Javax.Lang.Model.Element.Element t) => t.Cast<Javax.Lang.Model.AnnotatedConstruct>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getAnnotationMirrors()"/> 
        /// </summary>
        public Java.Util.List AnnotationMirrors
        {
            get { return IExecute<Java.Util.List>("getAnnotationMirrors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getEnclosedElements()"/> 
        /// </summary>
        public Java.Util.List EnclosedElements
        {
            get { return IExecute<Java.Util.List>("getEnclosedElements"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getEnclosingElement()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Element EnclosingElement
        {
            get { return IExecute<Javax.Lang.Model.Element.Element>("getEnclosingElement"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getKind()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.ElementKind Kind
        {
            get { return IExecute<Javax.Lang.Model.Element.ElementKind>("getKind"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getModifiers()"/> 
        /// </summary>
        public Java.Util.Set Modifiers
        {
            get { return IExecute<Java.Util.Set>("getModifiers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getSimpleName()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Name SimpleName
        {
            get { return IExecute<Javax.Lang.Model.Element.Name>("getSimpleName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#getAnnotation(java.lang.Class%3CA%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation GetAnnotation(Java.Lang.Class arg0)
        {
            return IExecute<Java.Lang.Annotation.Annotation>("getAnnotation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#accept(javax.lang.model.element.ElementVisitor%3CR, P%3E,P)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.ElementVisitor"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Accept(Javax.Lang.Model.Element.ElementVisitor arg0, object arg1)
        {
            return IExecute("accept", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/Element.html#asType()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Lang.Model.Type.TypeMirror"/></returns>
        public Javax.Lang.Model.Type.TypeMirror AsType()
        {
            return IExecute<Javax.Lang.Model.Type.TypeMirror>("asType");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}