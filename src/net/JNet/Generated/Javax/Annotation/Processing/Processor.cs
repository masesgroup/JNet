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

namespace Javax.Annotation.Processing
{
    #region Processor
    public partial class Processor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#getSupportedAnnotationTypes()"/> 
        /// </summary>
        public Java.Util.Set SupportedAnnotationTypes
        {
            get { return IExecute<Java.Util.Set>("getSupportedAnnotationTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#getSupportedOptions()"/> 
        /// </summary>
        public Java.Util.Set SupportedOptions
        {
            get { return IExecute<Java.Util.Set>("getSupportedOptions"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#getSupportedSourceVersion()"/> 
        /// </summary>
        public Javax.Lang.Model.SourceVersion SupportedSourceVersion
        {
            get { return IExecute<Javax.Lang.Model.SourceVersion>("getSupportedSourceVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#process(java.util.Set,javax.annotation.processing.RoundEnvironment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="Javax.Annotation.Processing.RoundEnvironment"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Process(Java.Util.Set arg0, Javax.Annotation.Processing.RoundEnvironment arg1)
        {
            return IExecute<bool>("process", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#getCompletions(javax.lang.model.element.Element,javax.lang.model.element.AnnotationMirror,javax.lang.model.element.ExecutableElement,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Lang.Model.Element.Element"/></param>
        /// <param name="arg1"><see cref="Javax.Lang.Model.Element.AnnotationMirror"/></param>
        /// <param name="arg2"><see cref="Javax.Lang.Model.Element.ExecutableElement"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable GetCompletions(Javax.Lang.Model.Element.Element arg0, Javax.Lang.Model.Element.AnnotationMirror arg1, Javax.Lang.Model.Element.ExecutableElement arg2, string arg3)
        {
            return IExecute<Java.Lang.Iterable>("getCompletions", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/annotation/processing/Processor.html#init(javax.annotation.processing.ProcessingEnvironment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Annotation.Processing.ProcessingEnvironment"/></param>
        public void Init(Javax.Annotation.Processing.ProcessingEnvironment arg0)
        {
            IExecute("init", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}