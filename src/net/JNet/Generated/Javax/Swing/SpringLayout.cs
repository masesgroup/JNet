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

namespace Javax.Swing
{
    #region SpringLayout
    public partial class SpringLayout
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.SpringLayout"/> to <see cref="Java.Awt.LayoutManager2"/>
        /// </summary>
        public static implicit operator Java.Awt.LayoutManager2(Javax.Swing.SpringLayout t) => t.Cast<Java.Awt.LayoutManager2>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#BASELINE"/>
        /// </summary>
        public static string BASELINE => Clazz.GetField<string>("BASELINE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#EAST"/>
        /// </summary>
        public static string EAST => Clazz.GetField<string>("EAST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#HEIGHT"/>
        /// </summary>
        public static string HEIGHT => Clazz.GetField<string>("HEIGHT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#HORIZONTAL_CENTER"/>
        /// </summary>
        public static string HORIZONTAL_CENTER => Clazz.GetField<string>("HORIZONTAL_CENTER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#NORTH"/>
        /// </summary>
        public static string NORTH => Clazz.GetField<string>("NORTH");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#SOUTH"/>
        /// </summary>
        public static string SOUTH => Clazz.GetField<string>("SOUTH");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#VERTICAL_CENTER"/>
        /// </summary>
        public static string VERTICAL_CENTER => Clazz.GetField<string>("VERTICAL_CENTER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#WEST"/>
        /// </summary>
        public static string WEST => Clazz.GetField<string>("WEST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#WIDTH"/>
        /// </summary>
        public static string WIDTH => Clazz.GetField<string>("WIDTH");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#getLayoutAlignmentX(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see langword="float"/></returns>
        public float GetLayoutAlignmentX(Java.Awt.Container arg0)
        {
            return IExecute<float>("getLayoutAlignmentX", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#getLayoutAlignmentY(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see langword="float"/></returns>
        public float GetLayoutAlignmentY(Java.Awt.Container arg0)
        {
            return IExecute<float>("getLayoutAlignmentY", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#maximumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MaximumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Dimension>("maximumLayoutSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#minimumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Dimension>("minimumLayoutSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#preferredLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Dimension>("preferredLayoutSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#getConstraint(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public Javax.Swing.Spring GetConstraint(string arg0, Java.Awt.Component arg1)
        {
            return IExecute<Javax.Swing.Spring>("getConstraint", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#getConstraints(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Javax.Swing.SpringLayout.Constraints"/></returns>
        public Javax.Swing.SpringLayout.Constraints GetConstraints(Java.Awt.Component arg0)
        {
            return IExecute<Javax.Swing.SpringLayout.Constraints>("getConstraints", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#addLayoutComponent(java.awt.Component,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void AddLayoutComponent(Java.Awt.Component arg0, object arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#addLayoutComponent(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void AddLayoutComponent(string arg0, Java.Awt.Component arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#invalidateLayout(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void InvalidateLayout(Java.Awt.Container arg0)
        {
            IExecute("invalidateLayout", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#layoutContainer(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void LayoutContainer(Java.Awt.Container arg0)
        {
            IExecute("layoutContainer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#putConstraint(java.lang.String,java.awt.Component,int,java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Component"/></param>
        public void PutConstraint(string arg0, Java.Awt.Component arg1, int arg2, string arg3, Java.Awt.Component arg4)
        {
            IExecute("putConstraint", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#putConstraint(java.lang.String,java.awt.Component,javax.swing.Spring,java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Spring"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Component"/></param>
        public void PutConstraint(string arg0, Java.Awt.Component arg1, Javax.Swing.Spring arg2, string arg3, Java.Awt.Component arg4)
        {
            IExecute("putConstraint", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#removeLayoutComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void RemoveLayoutComponent(Java.Awt.Component arg0)
        {
            IExecute("removeLayoutComponent", arg0);
        }
        
        #endregion

        #region Nested classes
        #region Constraints
        public partial class Constraints
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#%3Cinit%3E(java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            public Constraints(Java.Awt.Component arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#%3Cinit%3E(javax.swing.Spring,javax.swing.Spring,javax.swing.Spring,javax.swing.Spring)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Spring"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Spring"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Spring"/></param>
            /// <param name="arg3"><see cref="Javax.Swing.Spring"/></param>
            public Constraints(Javax.Swing.Spring arg0, Javax.Swing.Spring arg1, Javax.Swing.Spring arg2, Javax.Swing.Spring arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#%3Cinit%3E(javax.swing.Spring,javax.swing.Spring)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Spring"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Spring"/></param>
            public Constraints(Javax.Swing.Spring arg0, Javax.Swing.Spring arg1)
                : base(arg0, arg1)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#getHeight()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#setHeight(javax.swing.Spring)"/>
            /// </summary>
            public Javax.Swing.Spring Height
            {
                get { return IExecute<Javax.Swing.Spring>("getHeight"); } set { IExecute("setHeight", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#getWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#setWidth(javax.swing.Spring)"/>
            /// </summary>
            public Javax.Swing.Spring Width
            {
                get { return IExecute<Javax.Swing.Spring>("getWidth"); } set { IExecute("setWidth", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#getX()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#setX(javax.swing.Spring)"/>
            /// </summary>
            public Javax.Swing.Spring X
            {
                get { return IExecute<Javax.Swing.Spring>("getX"); } set { IExecute("setX", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#getY()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#setY(javax.swing.Spring)"/>
            /// </summary>
            public Javax.Swing.Spring Y
            {
                get { return IExecute<Javax.Swing.Spring>("getY"); } set { IExecute("setY", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#getConstraint(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Swing.Spring"/></returns>
            public Javax.Swing.Spring GetConstraint(string arg0)
            {
                return IExecute<Javax.Swing.Spring>("getConstraint", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#setConstraint(java.lang.String,javax.swing.Spring)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Spring"/></param>
            public void SetConstraint(string arg0, Javax.Swing.Spring arg1)
            {
                IExecute("setConstraint", arg0, arg1);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}