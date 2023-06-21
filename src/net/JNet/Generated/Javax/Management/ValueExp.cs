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

namespace Javax.Management
{
    #region IValueExp
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IValueExp : Java.Io.ISerializable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ValueExp.html#apply(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Javax.Management.ValueExp"/></returns>
        /// <exception cref="Javax.Management.BadStringOperationException"/>
        /// <exception cref="Javax.Management.BadBinaryOpValueExpException"/>
        /// <exception cref="Javax.Management.BadAttributeValueExpException"/>
        /// <exception cref="Javax.Management.InvalidApplicationException"/>
        Javax.Management.ValueExp Apply(Javax.Management.ObjectName arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ValueExp
    public partial class ValueExp : Javax.Management.IValueExp
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ValueExp.html#apply(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Javax.Management.ValueExp"/></returns>
        /// <exception cref="Javax.Management.BadStringOperationException"/>
        /// <exception cref="Javax.Management.BadBinaryOpValueExpException"/>
        /// <exception cref="Javax.Management.BadAttributeValueExpException"/>
        /// <exception cref="Javax.Management.InvalidApplicationException"/>
        public Javax.Management.ValueExp Apply(Javax.Management.ObjectName arg0)
        {
            return IExecute<Javax.Management.ValueExp>("apply", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}