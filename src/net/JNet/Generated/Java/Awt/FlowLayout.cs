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

namespace Java.Awt
{
    #region FlowLayout
    public partial class FlowLayout
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public FlowLayout(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public FlowLayout(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.FlowLayout"/> to <see cref="Java.Awt.LayoutManager"/>
        /// </summary>
        public static implicit operator Java.Awt.LayoutManager(Java.Awt.FlowLayout t) => t.Cast<Java.Awt.LayoutManager>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.FlowLayout"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.FlowLayout t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#CENTER"/>
        /// </summary>
        public static int CENTER { get { return SGetField<int>(LocalBridgeClazz, "CENTER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#LEADING"/>
        /// </summary>
        public static int LEADING { get { return SGetField<int>(LocalBridgeClazz, "LEADING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#LEFT"/>
        /// </summary>
        public static int LEFT { get { return SGetField<int>(LocalBridgeClazz, "LEFT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#RIGHT"/>
        /// </summary>
        public static int RIGHT { get { return SGetField<int>(LocalBridgeClazz, "RIGHT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#TRAILING"/>
        /// </summary>
        public static int TRAILING { get { return SGetField<int>(LocalBridgeClazz, "TRAILING"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#getAlignment()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#setAlignment(int)"/>
        /// </summary>
        public int Alignment
        {
            get { return IExecute<int>("getAlignment"); } set { IExecute("setAlignment", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#getAlignOnBaseline()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#setAlignOnBaseline(boolean)"/>
        /// </summary>
        public bool AlignOnBaseline
        {
            get { return IExecute<bool>("getAlignOnBaseline"); } set { IExecute("setAlignOnBaseline", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#getHgap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#setHgap(int)"/>
        /// </summary>
        public int Hgap
        {
            get { return IExecute<int>("getHgap"); } set { IExecute("setHgap", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#getVgap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#setVgap(int)"/>
        /// </summary>
        public int Vgap
        {
            get { return IExecute<int>("getVgap"); } set { IExecute("setVgap", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#minimumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Dimension>("minimumLayoutSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#preferredLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Dimension>("preferredLayoutSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#addLayoutComponent(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void AddLayoutComponent(string arg0, Java.Awt.Component arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#layoutContainer(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void LayoutContainer(Java.Awt.Container arg0)
        {
            IExecute("layoutContainer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FlowLayout.html#removeLayoutComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void RemoveLayoutComponent(Java.Awt.Component arg0)
        {
            IExecute("removeLayoutComponent", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}