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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region AttributeList
    public partial class AttributeList
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeList.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public AttributeList(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeList.html#%3Cinit%3E(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public AttributeList(Java.Util.List<Javax.Management.Attribute> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeList.html#%3Cinit%3E(javax.management.AttributeList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.AttributeList"/></param>
        public AttributeList(Javax.Management.AttributeList arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeList.html#addAll(int,javax.management.AttributeList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Management.AttributeList"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll(int arg0, Javax.Management.AttributeList arg1)
        {
            return IExecute<bool>("addAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeList.html#addAll(javax.management.AttributeList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.AttributeList"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll(Javax.Management.AttributeList arg0)
        {
            return IExecute<bool>("addAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeList.html#asList()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Javax.Management.Attribute> AsList()
        {
            return IExecute<Java.Util.List<Javax.Management.Attribute>>("asList");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeList.html#add(int,javax.management.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Attribute"/></param>
        public void Add(int arg0, Javax.Management.Attribute arg1)
        {
            IExecute("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeList.html#add(javax.management.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Attribute"/></param>
        public void Add(Javax.Management.Attribute arg0)
        {
            IExecute("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeList.html#set(int,javax.management.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Attribute"/></param>
        public void Set(int arg0, Javax.Management.Attribute arg1)
        {
            IExecute("set", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}