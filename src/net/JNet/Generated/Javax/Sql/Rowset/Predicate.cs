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

namespace Javax.Sql.Rowset
{
    #region Predicate
    public partial class Predicate
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/Predicate.html#evaluate(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool Evaluate(object arg0, int arg1)
        {
            return IExecute<bool>("evaluate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/Predicate.html#evaluate(java.lang.Object,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool Evaluate(object arg0, string arg1)
        {
            return IExecute<bool>("evaluate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/Predicate.html#evaluate(javax.sql.RowSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSet"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Evaluate(Javax.Sql.RowSet arg0)
        {
            return IExecute<bool>("evaluate", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}