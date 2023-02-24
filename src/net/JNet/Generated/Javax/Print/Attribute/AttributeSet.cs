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

namespace Javax.Print.Attribute
{
    #region AttributeSet
    public partial class AttributeSet
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSet.html#add(javax.print.attribute.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.Attribute"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Add(Javax.Print.Attribute.Attribute arg0)
        {
            return IExecute<bool>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSet.html#addAll(javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool AddAll(Javax.Print.Attribute.AttributeSet arg0)
        {
            return IExecute<bool>("addAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSet.html#containsValue(javax.print.attribute.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.Attribute"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool ContainsValue(Javax.Print.Attribute.Attribute arg0)
        {
            return IExecute<bool>("containsValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSet.html#isEmpty()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSet.html#remove(javax.print.attribute.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.Attribute"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Remove(Javax.Print.Attribute.Attribute arg0)
        {
            return IExecute<bool>("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSet.html#size()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSet.html#toArray()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Print.Attribute.Attribute"/></returns>
        public Javax.Print.Attribute.Attribute[] ToArray()
        {
            return IExecuteArray<Javax.Print.Attribute.Attribute>("toArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/AttributeSet.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}