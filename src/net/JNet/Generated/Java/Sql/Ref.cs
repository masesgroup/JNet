/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Sql
{
    #region IRef
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRef
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Ref.html#getBaseTypeName()"/> 
        /// </summary>
        string BaseTypeName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Ref.html#getObject()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Ref.html#setObject(java.lang.Object)"/>
        /// </summary>
        object Object { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Ref.html#getObject(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        object GetObject(Java.Util.Map<string, Java.Lang.Class> arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Ref
    public partial class Ref : Java.Sql.IRef
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Ref.html#getBaseTypeName()"/> 
        /// </summary>
        public string BaseTypeName
        {
            get { return IExecute<string>("getBaseTypeName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Ref.html#getObject()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Ref.html#setObject(java.lang.Object)"/>
        /// </summary>
        public object Object
        {
            get { return IExecute("getObject"); } set { IExecute("setObject", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Ref.html#getObject(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public object GetObject(Java.Util.Map<string, Java.Lang.Class> arg0)
        {
            return IExecute("getObject", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}