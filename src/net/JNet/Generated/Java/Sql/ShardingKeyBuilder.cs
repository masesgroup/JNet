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

namespace Java.Sql
{
    #region ShardingKeyBuilder
    public partial class ShardingKeyBuilder
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ShardingKeyBuilder.html#build()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Sql.ShardingKey"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.ShardingKey Build()
        {
            return IExecute<Java.Sql.ShardingKey>("build");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ShardingKeyBuilder.html#subkey(java.lang.Object,java.sql.SQLType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Sql.SQLType"/></param>
        /// <returns><see cref="Java.Sql.ShardingKeyBuilder"/></returns>
        public Java.Sql.ShardingKeyBuilder Subkey(object arg0, Java.Sql.SQLType arg1)
        {
            return IExecute<Java.Sql.ShardingKeyBuilder>("subkey", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}