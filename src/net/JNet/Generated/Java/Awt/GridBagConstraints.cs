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

namespace Java.Awt
{
    #region GridBagConstraints
    public partial class GridBagConstraints
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#%3Cinit%3E(int,int,int,int,double,double,int,int,java.awt.Insets,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="Java.Awt.Insets"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        /// <param name="arg10"><see cref="int"/></param>
        public GridBagConstraints(int arg0, int arg1, int arg2, int arg3, double arg4, double arg5, int arg6, int arg7, Java.Awt.Insets arg8, int arg9, int arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.GridBagConstraints"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.GridBagConstraints t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.GridBagConstraints"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.GridBagConstraints t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#weightx"/>
        /// </summary>
        public double weightx { get { return IGetField<double>("weightx"); } set { ISetField("weightx", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#weighty"/>
        /// </summary>
        public double weighty { get { return IGetField<double>("weighty"); } set { ISetField("weighty", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#anchor"/>
        /// </summary>
        public int anchor { get { return IGetField<int>("anchor"); } set { ISetField("anchor", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#fill"/>
        /// </summary>
        public int fill { get { return IGetField<int>("fill"); } set { ISetField("fill", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#gridheight"/>
        /// </summary>
        public int gridheight { get { return IGetField<int>("gridheight"); } set { ISetField("gridheight", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#gridwidth"/>
        /// </summary>
        public int gridwidth { get { return IGetField<int>("gridwidth"); } set { ISetField("gridwidth", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#gridx"/>
        /// </summary>
        public int gridx { get { return IGetField<int>("gridx"); } set { ISetField("gridx", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#gridy"/>
        /// </summary>
        public int gridy { get { return IGetField<int>("gridy"); } set { ISetField("gridy", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ipadx"/>
        /// </summary>
        public int ipadx { get { return IGetField<int>("ipadx"); } set { ISetField("ipadx", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ipady"/>
        /// </summary>
        public int ipady { get { return IGetField<int>("ipady"); } set { ISetField("ipady", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#insets"/>
        /// </summary>
        public Java.Awt.Insets insets { get { return IGetField<Java.Awt.Insets>("insets"); } set { ISetField("insets", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ABOVE_BASELINE"/>
        /// </summary>
        public static int ABOVE_BASELINE { get { return SGetField<int>(LocalClazz, "ABOVE_BASELINE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ABOVE_BASELINE_LEADING"/>
        /// </summary>
        public static int ABOVE_BASELINE_LEADING { get { return SGetField<int>(LocalClazz, "ABOVE_BASELINE_LEADING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#ABOVE_BASELINE_TRAILING"/>
        /// </summary>
        public static int ABOVE_BASELINE_TRAILING { get { return SGetField<int>(LocalClazz, "ABOVE_BASELINE_TRAILING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BASELINE"/>
        /// </summary>
        public static int BASELINE { get { return SGetField<int>(LocalClazz, "BASELINE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BASELINE_LEADING"/>
        /// </summary>
        public static int BASELINE_LEADING { get { return SGetField<int>(LocalClazz, "BASELINE_LEADING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BASELINE_TRAILING"/>
        /// </summary>
        public static int BASELINE_TRAILING { get { return SGetField<int>(LocalClazz, "BASELINE_TRAILING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BELOW_BASELINE"/>
        /// </summary>
        public static int BELOW_BASELINE { get { return SGetField<int>(LocalClazz, "BELOW_BASELINE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BELOW_BASELINE_LEADING"/>
        /// </summary>
        public static int BELOW_BASELINE_LEADING { get { return SGetField<int>(LocalClazz, "BELOW_BASELINE_LEADING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BELOW_BASELINE_TRAILING"/>
        /// </summary>
        public static int BELOW_BASELINE_TRAILING { get { return SGetField<int>(LocalClazz, "BELOW_BASELINE_TRAILING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#BOTH"/>
        /// </summary>
        public static int BOTH { get { return SGetField<int>(LocalClazz, "BOTH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#CENTER"/>
        /// </summary>
        public static int CENTER { get { return SGetField<int>(LocalClazz, "CENTER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#EAST"/>
        /// </summary>
        public static int EAST { get { return SGetField<int>(LocalClazz, "EAST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#FIRST_LINE_END"/>
        /// </summary>
        public static int FIRST_LINE_END { get { return SGetField<int>(LocalClazz, "FIRST_LINE_END"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#FIRST_LINE_START"/>
        /// </summary>
        public static int FIRST_LINE_START { get { return SGetField<int>(LocalClazz, "FIRST_LINE_START"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#HORIZONTAL"/>
        /// </summary>
        public static int HORIZONTAL { get { return SGetField<int>(LocalClazz, "HORIZONTAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#LAST_LINE_END"/>
        /// </summary>
        public static int LAST_LINE_END { get { return SGetField<int>(LocalClazz, "LAST_LINE_END"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#LAST_LINE_START"/>
        /// </summary>
        public static int LAST_LINE_START { get { return SGetField<int>(LocalClazz, "LAST_LINE_START"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#LINE_END"/>
        /// </summary>
        public static int LINE_END { get { return SGetField<int>(LocalClazz, "LINE_END"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#LINE_START"/>
        /// </summary>
        public static int LINE_START { get { return SGetField<int>(LocalClazz, "LINE_START"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#NONE"/>
        /// </summary>
        public static int NONE { get { return SGetField<int>(LocalClazz, "NONE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#NORTH"/>
        /// </summary>
        public static int NORTH { get { return SGetField<int>(LocalClazz, "NORTH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#NORTHEAST"/>
        /// </summary>
        public static int NORTHEAST { get { return SGetField<int>(LocalClazz, "NORTHEAST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#NORTHWEST"/>
        /// </summary>
        public static int NORTHWEST { get { return SGetField<int>(LocalClazz, "NORTHWEST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#PAGE_END"/>
        /// </summary>
        public static int PAGE_END { get { return SGetField<int>(LocalClazz, "PAGE_END"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#PAGE_START"/>
        /// </summary>
        public static int PAGE_START { get { return SGetField<int>(LocalClazz, "PAGE_START"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#RELATIVE"/>
        /// </summary>
        public static int RELATIVE { get { return SGetField<int>(LocalClazz, "RELATIVE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#REMAINDER"/>
        /// </summary>
        public static int REMAINDER { get { return SGetField<int>(LocalClazz, "REMAINDER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#SOUTH"/>
        /// </summary>
        public static int SOUTH { get { return SGetField<int>(LocalClazz, "SOUTH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#SOUTHEAST"/>
        /// </summary>
        public static int SOUTHEAST { get { return SGetField<int>(LocalClazz, "SOUTHEAST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#SOUTHWEST"/>
        /// </summary>
        public static int SOUTHWEST { get { return SGetField<int>(LocalClazz, "SOUTHWEST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#VERTICAL"/>
        /// </summary>
        public static int VERTICAL { get { return SGetField<int>(LocalClazz, "VERTICAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagConstraints.html#WEST"/>
        /// </summary>
        public static int WEST { get { return SGetField<int>(LocalClazz, "WEST"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}