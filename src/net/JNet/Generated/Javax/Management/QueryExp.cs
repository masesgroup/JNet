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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region IQueryExp
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IQueryExp : Java.Io.ISerializable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/QueryExp.html#apply(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Management.BadStringOperationException"/>
        /// <exception cref="Javax.Management.BadBinaryOpValueExpException"/>
        /// <exception cref="Javax.Management.BadAttributeValueExpException"/>
        /// <exception cref="Javax.Management.InvalidApplicationException"/>
        bool Apply(Javax.Management.ObjectName arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/QueryExp.html#setMBeanServer(javax.management.MBeanServer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        void SetMBeanServer(Javax.Management.MBeanServer arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region QueryExp
    public partial class QueryExp : Javax.Management.IQueryExp
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/QueryExp.html#apply(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Management.BadStringOperationException"/>
        /// <exception cref="Javax.Management.BadBinaryOpValueExpException"/>
        /// <exception cref="Javax.Management.BadAttributeValueExpException"/>
        /// <exception cref="Javax.Management.InvalidApplicationException"/>
        public bool Apply(Javax.Management.ObjectName arg0)
        {
            return IExecute<bool>("apply", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/QueryExp.html#setMBeanServer(javax.management.MBeanServer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        public void SetMBeanServer(Javax.Management.MBeanServer arg0)
        {
            IExecute("setMBeanServer", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}