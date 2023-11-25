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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Border
{
    #region TitledBorder
    public partial class TitledBorder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public TitledBorder(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#%3Cinit%3E(javax.swing.border.Border,java.lang.String,int,int,java.awt.Font,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Font"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Color"/></param>
        public TitledBorder(Javax.Swing.Border.Border arg0, string arg1, int arg2, int arg3, Java.Awt.Font arg4, Java.Awt.Color arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#%3Cinit%3E(javax.swing.border.Border,java.lang.String,int,int,java.awt.Font)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Font"/></param>
        public TitledBorder(Javax.Swing.Border.Border arg0, string arg1, int arg2, int arg3, Java.Awt.Font arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#%3Cinit%3E(javax.swing.border.Border,java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public TitledBorder(Javax.Swing.Border.Border arg0, string arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#%3Cinit%3E(javax.swing.border.Border,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public TitledBorder(Javax.Swing.Border.Border arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#%3Cinit%3E(javax.swing.border.Border)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        public TitledBorder(Javax.Swing.Border.Border arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#ABOVE_BOTTOM"/>
        /// </summary>
        public static int ABOVE_BOTTOM { get { return SGetField<int>(LocalBridgeClazz, "ABOVE_BOTTOM"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#ABOVE_TOP"/>
        /// </summary>
        public static int ABOVE_TOP { get { return SGetField<int>(LocalBridgeClazz, "ABOVE_TOP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#BELOW_BOTTOM"/>
        /// </summary>
        public static int BELOW_BOTTOM { get { return SGetField<int>(LocalBridgeClazz, "BELOW_BOTTOM"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#BELOW_TOP"/>
        /// </summary>
        public static int BELOW_TOP { get { return SGetField<int>(LocalBridgeClazz, "BELOW_TOP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#BOTTOM"/>
        /// </summary>
        public static int BOTTOM { get { return SGetField<int>(LocalBridgeClazz, "BOTTOM"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#CENTER"/>
        /// </summary>
        public static int CENTER { get { return SGetField<int>(LocalBridgeClazz, "CENTER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#DEFAULT_JUSTIFICATION"/>
        /// </summary>
        public static int DEFAULT_JUSTIFICATION { get { return SGetField<int>(LocalBridgeClazz, "DEFAULT_JUSTIFICATION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#DEFAULT_POSITION"/>
        /// </summary>
        public static int DEFAULT_POSITION { get { return SGetField<int>(LocalBridgeClazz, "DEFAULT_POSITION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#LEADING"/>
        /// </summary>
        public static int LEADING { get { return SGetField<int>(LocalBridgeClazz, "LEADING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#LEFT"/>
        /// </summary>
        public static int LEFT { get { return SGetField<int>(LocalBridgeClazz, "LEFT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#RIGHT"/>
        /// </summary>
        public static int RIGHT { get { return SGetField<int>(LocalBridgeClazz, "RIGHT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#TOP"/>
        /// </summary>
        public static int TOP { get { return SGetField<int>(LocalBridgeClazz, "TOP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#TRAILING"/>
        /// </summary>
        public static int TRAILING { get { return SGetField<int>(LocalBridgeClazz, "TRAILING"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#getBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#setBorder(javax.swing.border.Border)"/>
        /// </summary>
        public Javax.Swing.Border.Border Border
        {
            get { return IExecute<Javax.Swing.Border.Border>("getBorder"); } set { IExecute("setBorder", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#getTitle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#setTitle(java.lang.String)"/>
        /// </summary>
        public string Title
        {
            get { return IExecute<string>("getTitle"); } set { IExecute("setTitle", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#getTitleColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#setTitleColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color TitleColor
        {
            get { return IExecute<Java.Awt.Color>("getTitleColor"); } set { IExecute("setTitleColor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#getTitleFont()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#setTitleFont(java.awt.Font)"/>
        /// </summary>
        public Java.Awt.Font TitleFont
        {
            get { return IExecute<Java.Awt.Font>("getTitleFont"); } set { IExecute("setTitleFont", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#getTitleJustification()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#setTitleJustification(int)"/>
        /// </summary>
        public int TitleJustification
        {
            get { return IExecute<int>("getTitleJustification"); } set { IExecute("setTitleJustification", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#getTitlePosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#setTitlePosition(int)"/>
        /// </summary>
        public int TitlePosition
        {
            get { return IExecute<int>("getTitlePosition"); } set { IExecute("setTitlePosition", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/TitledBorder.html#getMinimumSize(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension GetMinimumSize(Java.Awt.Component arg0)
        {
            return IExecute<Java.Awt.Dimension>("getMinimumSize", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}