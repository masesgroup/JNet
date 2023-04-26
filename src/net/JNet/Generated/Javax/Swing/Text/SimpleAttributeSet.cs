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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region SimpleAttributeSet
    public partial class SimpleAttributeSet
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#%3Cinit%3E(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        public SimpleAttributeSet(Javax.Swing.Text.AttributeSet arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.SimpleAttributeSet"/> to <see cref="Javax.Swing.Text.MutableAttributeSet"/>
        /// </summary>
        public static implicit operator Javax.Swing.Text.MutableAttributeSet(Javax.Swing.Text.SimpleAttributeSet t) => t.Cast<Javax.Swing.Text.MutableAttributeSet>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.SimpleAttributeSet"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Text.SimpleAttributeSet t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.SimpleAttributeSet"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Swing.Text.SimpleAttributeSet t) => t.Cast<Java.Lang.Cloneable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#EMPTY"/>
        /// </summary>
        public static Javax.Swing.Text.AttributeSet EMPTY => LocalClazz.GetField<Javax.Swing.Text.AttributeSet>("EMPTY");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#getAttributeCount()"/> 
        /// </summary>
        public int AttributeCount
        {
            get { return IExecute<int>("getAttributeCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#getAttributeNames()"/> 
        /// </summary>
        public Java.Util.Enumeration AttributeNames
        {
            get { return IExecute<Java.Util.Enumeration>("getAttributeNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#copyAttributes()"/> 
        /// </summary>
        public Javax.Swing.Text.AttributeSet CopyAttributes
        {
            get { return IExecute<Javax.Swing.Text.AttributeSet>("copyAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#getResolveParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#setResolveParent(javax.swing.text.AttributeSet)"/>
        /// </summary>
        public Javax.Swing.Text.AttributeSet ResolveParent
        {
            get { return IExecute<Javax.Swing.Text.AttributeSet>("getResolveParent"); } set { IExecute("setResolveParent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#containsAttribute(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAttribute(object arg0, object arg1)
        {
            return IExecute<bool>("containsAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#containsAttributes(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAttributes(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecute<bool>("containsAttributes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#isDefined(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDefined(object arg0)
        {
            return IExecute<bool>("isDefined", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#isEqual(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEqual(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecute<bool>("isEqual", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#getAttribute(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAttribute(object arg0)
        {
            return IExecute("getAttribute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#addAttribute(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void AddAttribute(object arg0, object arg1)
        {
            IExecute("addAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#addAttributes(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        public void AddAttributes(Javax.Swing.Text.AttributeSet arg0)
        {
            IExecute("addAttributes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#removeAttribute(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void RemoveAttribute(object arg0)
        {
            IExecute("removeAttribute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#removeAttributes(java.util.Enumeration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Enumeration"/></param>
        public void RemoveAttributes<Arg0Extendsobject>(Java.Util.Enumeration<Arg0Extendsobject> arg0)
        {
            IExecute("removeAttributes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/SimpleAttributeSet.html#removeAttributes(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        public void RemoveAttributes(Javax.Swing.Text.AttributeSet arg0)
        {
            IExecute("removeAttributes", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}