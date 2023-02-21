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
    #region NestingKind
    public partial class NestingKind
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#TOP_LEVEL
        /// </summary>
        public static Javax.Lang.Model.Element.NestingKind TOP_LEVEL => Clazz.GetField<Javax.Lang.Model.Element.NestingKind>("TOP_LEVEL");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#MEMBER
        /// </summary>
        public static Javax.Lang.Model.Element.NestingKind MEMBER => Clazz.GetField<Javax.Lang.Model.Element.NestingKind>("MEMBER");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#LOCAL
        /// </summary>
        public static Javax.Lang.Model.Element.NestingKind LOCAL => Clazz.GetField<Javax.Lang.Model.Element.NestingKind>("LOCAL");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#ANONYMOUS
        /// </summary>
        public static Javax.Lang.Model.Element.NestingKind ANONYMOUS => Clazz.GetField<Javax.Lang.Model.Element.NestingKind>("ANONYMOUS");
        
        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#values()
        /// </summary>
        public static Javax.Lang.Model.Element.NestingKind[] Values()
        {
            return SExecuteArray<Javax.Lang.Model.Element.NestingKind>("values");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#isNested()
        /// </summary>
        public bool IsNested()
        {
            return IExecute<bool>("isNested");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}