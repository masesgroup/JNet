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

namespace Javax.Swing
{
    #region DropMode
    public partial class DropMode
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#INSERT"/>
        /// </summary>
        public static Javax.Swing.DropMode INSERT => Clazz.GetField<Javax.Swing.DropMode>("INSERT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#INSERT_COLS"/>
        /// </summary>
        public static Javax.Swing.DropMode INSERT_COLS => Clazz.GetField<Javax.Swing.DropMode>("INSERT_COLS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#INSERT_ROWS"/>
        /// </summary>
        public static Javax.Swing.DropMode INSERT_ROWS => Clazz.GetField<Javax.Swing.DropMode>("INSERT_ROWS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#ON"/>
        /// </summary>
        public static Javax.Swing.DropMode ON => Clazz.GetField<Javax.Swing.DropMode>("ON");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#ON_OR_INSERT"/>
        /// </summary>
        public static Javax.Swing.DropMode ON_OR_INSERT => Clazz.GetField<Javax.Swing.DropMode>("ON_OR_INSERT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#ON_OR_INSERT_COLS"/>
        /// </summary>
        public static Javax.Swing.DropMode ON_OR_INSERT_COLS => Clazz.GetField<Javax.Swing.DropMode>("ON_OR_INSERT_COLS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#ON_OR_INSERT_ROWS"/>
        /// </summary>
        public static Javax.Swing.DropMode ON_OR_INSERT_ROWS => Clazz.GetField<Javax.Swing.DropMode>("ON_OR_INSERT_ROWS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#USE_SELECTION"/>
        /// </summary>
        public static Javax.Swing.DropMode USE_SELECTION => Clazz.GetField<Javax.Swing.DropMode>("USE_SELECTION");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.DropMode"/></returns>
        public static Javax.Swing.DropMode ValueOf(string arg0)
        {
            return SExecute<Javax.Swing.DropMode>("valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#values()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Swing.DropMode"/></returns>
        public static Javax.Swing.DropMode[] Values()
        {
            return SExecuteArray<Javax.Swing.DropMode>("values");
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