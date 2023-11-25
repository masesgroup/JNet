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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Annotation
{
    #region IAnnotation
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAnnotation
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/annotation/Annotation.html#annotationType()"/>
        /// </summary>

        /// <typeparam name="ReturnExtendsJava_Lang_Annotation_Annotation"><see cref="Java.Lang.Annotation.Annotation"/></typeparam>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        Java.Lang.Class AnnotationType<ReturnExtendsJava_Lang_Annotation_Annotation>() where ReturnExtendsJava_Lang_Annotation_Annotation: Java.Lang.Annotation.Annotation;

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Annotation
    public partial class Annotation : Java.Lang.Annotation.IAnnotation
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/annotation/Annotation.html#annotationType()"/>
        /// </summary>

        /// <typeparam name="ReturnExtendsJava_Lang_Annotation_Annotation"><see cref="Java.Lang.Annotation.Annotation"/></typeparam>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class AnnotationType<ReturnExtendsJava_Lang_Annotation_Annotation>() where ReturnExtendsJava_Lang_Annotation_Annotation: Java.Lang.Annotation.Annotation
        {
            return IExecute<Java.Lang.Class>("annotationType");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}