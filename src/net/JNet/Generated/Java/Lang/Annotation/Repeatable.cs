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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Annotation
{
    #region IRepeatable
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRepeatable : Java.Lang.Annotation.IAnnotation
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/annotation/Repeatable.html#value()"/>
        /// </summary>

        /// <typeparam name="ReturnExtendsJava_Lang_Annotation_Annotation"><see cref="Java.Lang.Annotation.Annotation"/></typeparam>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        Java.Lang.Class Value<ReturnExtendsJava_Lang_Annotation_Annotation>() where ReturnExtendsJava_Lang_Annotation_Annotation: Java.Lang.Annotation.Annotation;

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Repeatable
    public partial class Repeatable : Java.Lang.Annotation.IRepeatable
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/annotation/Repeatable.html#value()"/>
        /// </summary>

        /// <typeparam name="ReturnExtendsJava_Lang_Annotation_Annotation"><see cref="Java.Lang.Annotation.Annotation"/></typeparam>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class Value<ReturnExtendsJava_Lang_Annotation_Annotation>() where ReturnExtendsJava_Lang_Annotation_Annotation: Java.Lang.Annotation.Annotation
        {
            return IExecute<Java.Lang.Class>("value");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}