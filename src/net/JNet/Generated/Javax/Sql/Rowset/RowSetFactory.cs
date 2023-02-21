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
    #region RowSetFactory
    public partial class RowSetFactory
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createCachedRowSet() throws java.sql.SQLException
        /// </summary>
        public Javax.Sql.Rowset.CachedRowSet CreateCachedRowSet()
        {
            return IExecute<Javax.Sql.Rowset.CachedRowSet>("createCachedRowSet");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createFilteredRowSet() throws java.sql.SQLException
        /// </summary>
        public Javax.Sql.Rowset.FilteredRowSet CreateFilteredRowSet()
        {
            return IExecute<Javax.Sql.Rowset.FilteredRowSet>("createFilteredRowSet");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createJdbcRowSet() throws java.sql.SQLException
        /// </summary>
        public Javax.Sql.Rowset.JdbcRowSet CreateJdbcRowSet()
        {
            return IExecute<Javax.Sql.Rowset.JdbcRowSet>("createJdbcRowSet");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createJoinRowSet() throws java.sql.SQLException
        /// </summary>
        public Javax.Sql.Rowset.JoinRowSet CreateJoinRowSet()
        {
            return IExecute<Javax.Sql.Rowset.JoinRowSet>("createJoinRowSet");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetFactory.html#createWebRowSet() throws java.sql.SQLException
        /// </summary>
        public Javax.Sql.Rowset.WebRowSet CreateWebRowSet()
        {
            return IExecute<Javax.Sql.Rowset.WebRowSet>("createWebRowSet");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}