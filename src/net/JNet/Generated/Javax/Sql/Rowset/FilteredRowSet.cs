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
    #region FilteredRowSet
    public partial class FilteredRowSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.FilteredRowSet"/> to <see cref="Javax.Sql.Rowset.WebRowSet"/>
        /// </summary>
        public static implicit operator Javax.Sql.Rowset.WebRowSet(Javax.Sql.Rowset.FilteredRowSet t) => t.Cast<Javax.Sql.Rowset.WebRowSet>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/FilteredRowSet.html#getFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/FilteredRowSet.html#setFilter(javax.sql.rowset.Predicate)"/>
        /// </summary>
        public Javax.Sql.Rowset.Predicate Filter
        {
            get { return IExecute<Javax.Sql.Rowset.Predicate>("getFilter"); } set { IExecute("setFilter", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}