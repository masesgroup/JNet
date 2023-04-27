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

namespace Javax.Swing.Border
{
    #region BevelBorder
    public partial class BevelBorder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#%3Cinit%3E(int,java.awt.Color,java.awt.Color,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Color"/></param>
        public BevelBorder(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2, Java.Awt.Color arg3, Java.Awt.Color arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#%3Cinit%3E(int,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        public BevelBorder(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public BevelBorder(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#LOWERED"/>
        /// </summary>
        public static int LOWERED { get { return LocalClazz.GetField<int>("LOWERED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#RAISED"/>
        /// </summary>
        public static int RAISED { get { return LocalClazz.GetField<int>("RAISED"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getBevelType()"/> 
        /// </summary>
        public int BevelType
        {
            get { return IExecute<int>("getBevelType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getHighlightInnerColor()"/> 
        /// </summary>
        public Java.Awt.Color HighlightInnerColor
        {
            get { return IExecute<Java.Awt.Color>("getHighlightInnerColor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getHighlightOuterColor()"/> 
        /// </summary>
        public Java.Awt.Color HighlightOuterColor
        {
            get { return IExecute<Java.Awt.Color>("getHighlightOuterColor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getShadowInnerColor()"/> 
        /// </summary>
        public Java.Awt.Color ShadowInnerColor
        {
            get { return IExecute<Java.Awt.Color>("getShadowInnerColor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getShadowOuterColor()"/> 
        /// </summary>
        public Java.Awt.Color ShadowOuterColor
        {
            get { return IExecute<Java.Awt.Color>("getShadowOuterColor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getHighlightInnerColor(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetHighlightInnerColor(Java.Awt.Component arg0)
        {
            return IExecute<Java.Awt.Color>("getHighlightInnerColor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getHighlightOuterColor(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetHighlightOuterColor(Java.Awt.Component arg0)
        {
            return IExecute<Java.Awt.Color>("getHighlightOuterColor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getShadowInnerColor(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetShadowInnerColor(Java.Awt.Component arg0)
        {
            return IExecute<Java.Awt.Color>("getShadowInnerColor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/BevelBorder.html#getShadowOuterColor(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetShadowOuterColor(Java.Awt.Component arg0)
        {
            return IExecute<Java.Awt.Color>("getShadowOuterColor", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}