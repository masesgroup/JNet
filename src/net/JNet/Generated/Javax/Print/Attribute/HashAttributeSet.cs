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
    #region HashAttributeSet
    public partial class HashAttributeSet
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#<init>(javax.print.attribute.Attribute[])
        /// </summary>
        public HashAttributeSet(Javax.Print.Attribute.Attribute[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#<init>(javax.print.attribute.AttributeSet)
        /// </summary>
        public HashAttributeSet(Javax.Print.Attribute.AttributeSet arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#<init>(javax.print.attribute.Attribute)
        /// </summary>
        public HashAttributeSet(Javax.Print.Attribute.Attribute arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Print.Attribute.AttributeSet(Javax.Print.Attribute.HashAttributeSet t) => t.Cast<Javax.Print.Attribute.AttributeSet>();
        public static implicit operator Java.Io.Serializable(Javax.Print.Attribute.HashAttributeSet t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#add(javax.print.attribute.Attribute)
        /// </summary>
        public bool Add(Javax.Print.Attribute.Attribute arg0)
        {
            return IExecute<bool>("add", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#addAll(javax.print.attribute.AttributeSet)
        /// </summary>
        public bool AddAll(Javax.Print.Attribute.AttributeSet arg0)
        {
            return IExecute<bool>("addAll", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#containsValue(javax.print.attribute.Attribute)
        /// </summary>
        public bool ContainsValue(Javax.Print.Attribute.Attribute arg0)
        {
            return IExecute<bool>("containsValue", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#isEmpty()
        /// </summary>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#remove(javax.print.attribute.Attribute)
        /// </summary>
        public bool Remove(Javax.Print.Attribute.Attribute arg0)
        {
            return IExecute<bool>("remove", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#size()
        /// </summary>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#toArray()
        /// </summary>
        public Javax.Print.Attribute.Attribute[] ToArray()
        {
            return IExecuteArray<Javax.Print.Attribute.Attribute>("toArray");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/HashAttributeSet.html#clear()
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