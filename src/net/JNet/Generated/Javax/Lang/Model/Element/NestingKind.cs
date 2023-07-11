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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#ANONYMOUS"/>
        /// </summary>
        public static Javax.Lang.Model.Element.NestingKind ANONYMOUS { get { return SGetField<Javax.Lang.Model.Element.NestingKind>(LocalBridgeClazz, "ANONYMOUS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#LOCAL"/>
        /// </summary>
        public static Javax.Lang.Model.Element.NestingKind LOCAL { get { return SGetField<Javax.Lang.Model.Element.NestingKind>(LocalBridgeClazz, "LOCAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#MEMBER"/>
        /// </summary>
        public static Javax.Lang.Model.Element.NestingKind MEMBER { get { return SGetField<Javax.Lang.Model.Element.NestingKind>(LocalBridgeClazz, "MEMBER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#TOP_LEVEL"/>
        /// </summary>
        public static Javax.Lang.Model.Element.NestingKind TOP_LEVEL { get { return SGetField<Javax.Lang.Model.Element.NestingKind>(LocalBridgeClazz, "TOP_LEVEL"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Lang.Model.Element.NestingKind"/></returns>
        public static Javax.Lang.Model.Element.NestingKind ValueOf(string arg0)
        {
            return SExecute<Javax.Lang.Model.Element.NestingKind>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#values()"/>
        /// </summary>

        /// <returns><see cref="Javax.Lang.Model.Element.NestingKind"/></returns>
        public static Javax.Lang.Model.Element.NestingKind[] Values()
        {
            return SExecuteArray<Javax.Lang.Model.Element.NestingKind>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#isNested()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
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