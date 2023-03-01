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

namespace Javax.Lang.Model.Util
{
    #region ElementFilter
    public partial class ElementFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#constructorsIn(java.lang.Iterable%3C? extends javax.lang.model.element.Element%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List ConstructorsIn(Java.Lang.Iterable arg0)
        {
            return SExecute<Java.Util.List>("constructorsIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#methodsIn(java.lang.Iterable%3C? extends javax.lang.model.element.Element%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List MethodsIn(Java.Lang.Iterable arg0)
        {
            return SExecute<Java.Util.List>("methodsIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#modulesIn(java.lang.Iterable%3C? extends javax.lang.model.element.Element%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List ModulesIn(Java.Lang.Iterable arg0)
        {
            return SExecute<Java.Util.List>("modulesIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#exportsIn(java.lang.Iterable%3C? extends javax.lang.model.element.ModuleElement$Directive%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List ExportsIn(Java.Lang.Iterable arg0)
        {
            return SExecute<Java.Util.List>("exportsIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#opensIn(java.lang.Iterable%3C? extends javax.lang.model.element.ModuleElement$Directive%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List OpensIn(Java.Lang.Iterable arg0)
        {
            return SExecute<Java.Util.List>("opensIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#providesIn(java.lang.Iterable%3C? extends javax.lang.model.element.ModuleElement$Directive%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List ProvidesIn(Java.Lang.Iterable arg0)
        {
            return SExecute<Java.Util.List>("providesIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#requiresIn(java.lang.Iterable%3C? extends javax.lang.model.element.ModuleElement$Directive%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List RequiresIn(Java.Lang.Iterable arg0)
        {
            return SExecute<Java.Util.List>("requiresIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#usesIn(java.lang.Iterable%3C? extends javax.lang.model.element.ModuleElement$Directive%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List UsesIn(Java.Lang.Iterable arg0)
        {
            return SExecute<Java.Util.List>("usesIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#packagesIn(java.lang.Iterable%3C? extends javax.lang.model.element.Element%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List PackagesIn(Java.Lang.Iterable arg0)
        {
            return SExecute<Java.Util.List>("packagesIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#typesIn(java.lang.Iterable%3C? extends javax.lang.model.element.Element%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List TypesIn(Java.Lang.Iterable arg0)
        {
            return SExecute<Java.Util.List>("typesIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#fieldsIn(java.lang.Iterable%3C? extends javax.lang.model.element.Element%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List FieldsIn(Java.Lang.Iterable arg0)
        {
            return SExecute<Java.Util.List>("fieldsIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#constructorsIn(java.util.Set%3C? extends javax.lang.model.element.Element%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set ConstructorsIn(Java.Util.Set arg0)
        {
            return SExecute<Java.Util.Set>("constructorsIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#methodsIn(java.util.Set%3C? extends javax.lang.model.element.Element%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set MethodsIn(Java.Util.Set arg0)
        {
            return SExecute<Java.Util.Set>("methodsIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#modulesIn(java.util.Set%3C? extends javax.lang.model.element.Element%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set ModulesIn(Java.Util.Set arg0)
        {
            return SExecute<Java.Util.Set>("modulesIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#packagesIn(java.util.Set%3C? extends javax.lang.model.element.Element%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set PackagesIn(Java.Util.Set arg0)
        {
            return SExecute<Java.Util.Set>("packagesIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#typesIn(java.util.Set%3C? extends javax.lang.model.element.Element%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set TypesIn(Java.Util.Set arg0)
        {
            return SExecute<Java.Util.Set>("typesIn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/util/ElementFilter.html#fieldsIn(java.util.Set%3C? extends javax.lang.model.element.Element%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set FieldsIn(Java.Util.Set arg0)
        {
            return SExecute<Java.Util.Set>("fieldsIn", arg0);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}