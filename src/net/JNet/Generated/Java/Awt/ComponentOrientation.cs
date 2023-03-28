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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region ComponentOrientation
    public partial class ComponentOrientation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.ComponentOrientation"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.ComponentOrientation t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ComponentOrientation.html#LEFT_TO_RIGHT"/>
        /// </summary>
        public static Java.Awt.ComponentOrientation LEFT_TO_RIGHT => Clazz.GetField<Java.Awt.ComponentOrientation>("LEFT_TO_RIGHT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ComponentOrientation.html#RIGHT_TO_LEFT"/>
        /// </summary>
        public static Java.Awt.ComponentOrientation RIGHT_TO_LEFT => Clazz.GetField<Java.Awt.ComponentOrientation>("RIGHT_TO_LEFT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ComponentOrientation.html#UNKNOWN"/>
        /// </summary>
        public static Java.Awt.ComponentOrientation UNKNOWN => Clazz.GetField<Java.Awt.ComponentOrientation>("UNKNOWN");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ComponentOrientation.html#getOrientation(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.ComponentOrientation"/></returns>
        public static Java.Awt.ComponentOrientation GetOrientation(Java.Util.Locale arg0)
        {
            return SExecute<Java.Awt.ComponentOrientation>("getOrientation", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ComponentOrientation.html#isHorizontal()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsHorizontal()
        {
            return IExecute<bool>("isHorizontal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ComponentOrientation.html#isLeftToRight()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsLeftToRight()
        {
            return IExecute<bool>("isLeftToRight");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}