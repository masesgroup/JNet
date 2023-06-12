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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region SortOrder
    public partial class SortOrder
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SortOrder.html#ASCENDING"/>
        /// </summary>
        public static Javax.Swing.SortOrder ASCENDING { get { return SGetField<Javax.Swing.SortOrder>(LocalBridgeClazz, "ASCENDING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SortOrder.html#DESCENDING"/>
        /// </summary>
        public static Javax.Swing.SortOrder DESCENDING { get { return SGetField<Javax.Swing.SortOrder>(LocalBridgeClazz, "DESCENDING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SortOrder.html#UNSORTED"/>
        /// </summary>
        public static Javax.Swing.SortOrder UNSORTED { get { return SGetField<Javax.Swing.SortOrder>(LocalBridgeClazz, "UNSORTED"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SortOrder.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.SortOrder"/></returns>
        public static Javax.Swing.SortOrder ValueOf(string arg0)
        {
            return SExecute<Javax.Swing.SortOrder>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SortOrder.html#values()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.SortOrder"/></returns>
        public static Javax.Swing.SortOrder[] Values()
        {
            return SExecuteArray<Javax.Swing.SortOrder>(LocalBridgeClazz, "values");
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