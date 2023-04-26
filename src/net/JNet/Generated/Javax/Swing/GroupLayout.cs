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

namespace Javax.Swing
{
    #region GroupLayout
    public partial class GroupLayout
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#%3Cinit%3E(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public GroupLayout(Java.Awt.Container arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.GroupLayout"/> to <see cref="Java.Awt.LayoutManager2"/>
        /// </summary>
        public static implicit operator Java.Awt.LayoutManager2(Javax.Swing.GroupLayout t) => t.Cast<Java.Awt.LayoutManager2>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#DEFAULT_SIZE"/>
        /// </summary>
        public static int DEFAULT_SIZE => LocalClazz.GetField<int>("DEFAULT_SIZE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#PREFERRED_SIZE"/>
        /// </summary>
        public static int PREFERRED_SIZE => LocalClazz.GetField<int>("PREFERRED_SIZE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#getAutoCreateContainerGaps()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#setAutoCreateContainerGaps(boolean)"/>
        /// </summary>
        public bool AutoCreateContainerGaps
        {
            get { return IExecute<bool>("getAutoCreateContainerGaps"); } set { IExecute("setAutoCreateContainerGaps", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#getAutoCreateGaps()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#setAutoCreateGaps(boolean)"/>
        /// </summary>
        public bool AutoCreateGaps
        {
            get { return IExecute<bool>("getAutoCreateGaps"); } set { IExecute("setAutoCreateGaps", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#createSequentialGroup()"/> 
        /// </summary>
        public Javax.Swing.GroupLayout.SequentialGroup CreateSequentialGroup
        {
            get { return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("createSequentialGroup"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#getHonorsVisibility()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#setHonorsVisibility(boolean)"/>
        /// </summary>
        public bool HonorsVisibility
        {
            get { return IExecute<bool>("getHonorsVisibility"); } set { IExecute("setHonorsVisibility", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#getLayoutStyle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#setLayoutStyle(javax.swing.LayoutStyle)"/>
        /// </summary>
        public Javax.Swing.LayoutStyle LayoutStyle
        {
            get { return IExecute<Javax.Swing.LayoutStyle>("getLayoutStyle"); } set { IExecute("setLayoutStyle", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#getLayoutAlignmentX(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetLayoutAlignmentX(Java.Awt.Container arg0)
        {
            return IExecute<float>("getLayoutAlignmentX", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#getLayoutAlignmentY(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetLayoutAlignmentY(Java.Awt.Container arg0)
        {
            return IExecute<float>("getLayoutAlignmentY", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#maximumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MaximumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Dimension>("maximumLayoutSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#minimumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Dimension>("minimumLayoutSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#preferredLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Dimension>("preferredLayoutSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#createBaselineGroup(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Swing.GroupLayout.ParallelGroup"/></returns>
        public Javax.Swing.GroupLayout.ParallelGroup CreateBaselineGroup(bool arg0, bool arg1)
        {
            return IExecute<Javax.Swing.GroupLayout.ParallelGroup>("createBaselineGroup", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#createParallelGroup()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Swing.GroupLayout.ParallelGroup"/></returns>
        public Javax.Swing.GroupLayout.ParallelGroup CreateParallelGroup()
        {
            return IExecute<Javax.Swing.GroupLayout.ParallelGroup>("createParallelGroup");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#createParallelGroup(javax.swing.GroupLayout.Alignment,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.GroupLayout.Alignment"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Swing.GroupLayout.ParallelGroup"/></returns>
        public Javax.Swing.GroupLayout.ParallelGroup CreateParallelGroup(Javax.Swing.GroupLayout.Alignment arg0, bool arg1)
        {
            return IExecute<Javax.Swing.GroupLayout.ParallelGroup>("createParallelGroup", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#createParallelGroup(javax.swing.GroupLayout.Alignment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.GroupLayout.Alignment"/></param>
        /// <returns><see cref="Javax.Swing.GroupLayout.ParallelGroup"/></returns>
        public Javax.Swing.GroupLayout.ParallelGroup CreateParallelGroup(Javax.Swing.GroupLayout.Alignment arg0)
        {
            return IExecute<Javax.Swing.GroupLayout.ParallelGroup>("createParallelGroup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#addLayoutComponent(java.awt.Component,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void AddLayoutComponent(Java.Awt.Component arg0, object arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#addLayoutComponent(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void AddLayoutComponent(string arg0, Java.Awt.Component arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#invalidateLayout(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void InvalidateLayout(Java.Awt.Container arg0)
        {
            IExecute("invalidateLayout", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#layoutContainer(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void LayoutContainer(Java.Awt.Container arg0)
        {
            IExecute("layoutContainer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#linkSize(int,java.awt.Component[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void LinkSize(int arg0, params Java.Awt.Component[] arg1)
        {
            if (arg1.Length == 0) IExecute("linkSize", arg0); else IExecute("linkSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#linkSize(java.awt.Component[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void LinkSize(params Java.Awt.Component[] arg0)
        {
            if (arg0.Length == 0) IExecute("linkSize", new object[] { arg0 }); else IExecute("linkSize", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#removeLayoutComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void RemoveLayoutComponent(Java.Awt.Component arg0)
        {
            IExecute("removeLayoutComponent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#replace(java.awt.Component,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void Replace(Java.Awt.Component arg0, Java.Awt.Component arg1)
        {
            IExecute("replace", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#setHonorsVisibility(java.awt.Component,java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetHonorsVisibility(Java.Awt.Component arg0, bool? arg1)
        {
            IExecute("setHonorsVisibility", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#setHorizontalGroup(javax.swing.GroupLayout.Group)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.GroupLayout.Group"/></param>
        public void SetHorizontalGroup(Javax.Swing.GroupLayout.Group arg0)
        {
            IExecute("setHorizontalGroup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#setVerticalGroup(javax.swing.GroupLayout.Group)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.GroupLayout.Group"/></param>
        public void SetVerticalGroup(Javax.Swing.GroupLayout.Group arg0)
        {
            IExecute("setVerticalGroup", arg0);
        }
        
        #endregion

        #region Nested classes
        #region Alignment
        public partial class Alignment
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Alignment.html#BASELINE"/>
            /// </summary>
            public static Javax.Swing.GroupLayout.Alignment BASELINE => LocalClazz.GetField<Javax.Swing.GroupLayout.Alignment>("BASELINE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Alignment.html#CENTER"/>
            /// </summary>
            public static Javax.Swing.GroupLayout.Alignment CENTER => LocalClazz.GetField<Javax.Swing.GroupLayout.Alignment>("CENTER");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Alignment.html#LEADING"/>
            /// </summary>
            public static Javax.Swing.GroupLayout.Alignment LEADING => LocalClazz.GetField<Javax.Swing.GroupLayout.Alignment>("LEADING");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Alignment.html#TRAILING"/>
            /// </summary>
            public static Javax.Swing.GroupLayout.Alignment TRAILING => LocalClazz.GetField<Javax.Swing.GroupLayout.Alignment>("TRAILING");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Alignment.html#values()"/> 
            /// </summary>
            public static Javax.Swing.GroupLayout.Alignment[] Values
            {
                get { return SExecuteArray<Javax.Swing.GroupLayout.Alignment>(LocalClazz, "values"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Alignment.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.Alignment"/></returns>
            public static Javax.Swing.GroupLayout.Alignment ValueOf(string arg0)
            {
                return SExecute<Javax.Swing.GroupLayout.Alignment>(LocalClazz, "valueOf", arg0);
            }
            
            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Group
        public partial class Group
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Group.html#addComponent(java.awt.Component,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.Group"/></returns>
            public Javax.Swing.GroupLayout.Group AddComponent(Java.Awt.Component arg0, int arg1, int arg2, int arg3)
            {
                return IExecute<Javax.Swing.GroupLayout.Group>("addComponent", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Group.html#addComponent(java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.Group"/></returns>
            public Javax.Swing.GroupLayout.Group AddComponent(Java.Awt.Component arg0)
            {
                return IExecute<Javax.Swing.GroupLayout.Group>("addComponent", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Group.html#addGap(int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.Group"/></returns>
            public Javax.Swing.GroupLayout.Group AddGap(int arg0, int arg1, int arg2)
            {
                return IExecute<Javax.Swing.GroupLayout.Group>("addGap", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Group.html#addGap(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.Group"/></returns>
            public Javax.Swing.GroupLayout.Group AddGap(int arg0)
            {
                return IExecute<Javax.Swing.GroupLayout.Group>("addGap", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Group.html#addGroup(javax.swing.GroupLayout.Group)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.GroupLayout.Group"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.Group"/></returns>
            public Javax.Swing.GroupLayout.Group AddGroup(Javax.Swing.GroupLayout.Group arg0)
            {
                return IExecute<Javax.Swing.GroupLayout.Group>("addGroup", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ParallelGroup
        public partial class ParallelGroup
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.ParallelGroup.html#addComponent(java.awt.Component,javax.swing.GroupLayout.Alignment,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.GroupLayout.Alignment"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.ParallelGroup"/></returns>
            public Javax.Swing.GroupLayout.ParallelGroup AddComponent(Java.Awt.Component arg0, Javax.Swing.GroupLayout.Alignment arg1, int arg2, int arg3, int arg4)
            {
                return IExecute<Javax.Swing.GroupLayout.ParallelGroup>("addComponent", arg0, arg1, arg2, arg3, arg4);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.ParallelGroup.html#addComponent(java.awt.Component,javax.swing.GroupLayout.Alignment)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.GroupLayout.Alignment"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.ParallelGroup"/></returns>
            public Javax.Swing.GroupLayout.ParallelGroup AddComponent(Java.Awt.Component arg0, Javax.Swing.GroupLayout.Alignment arg1)
            {
                return IExecute<Javax.Swing.GroupLayout.ParallelGroup>("addComponent", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.ParallelGroup.html#addGroup(javax.swing.GroupLayout.Alignment,javax.swing.GroupLayout.Group)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.GroupLayout.Alignment"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.GroupLayout.Group"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.ParallelGroup"/></returns>
            public Javax.Swing.GroupLayout.ParallelGroup AddGroup(Javax.Swing.GroupLayout.Alignment arg0, Javax.Swing.GroupLayout.Group arg1)
            {
                return IExecute<Javax.Swing.GroupLayout.ParallelGroup>("addGroup", arg0, arg1);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SequentialGroup
        public partial class SequentialGroup
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addComponent(boolean,java.awt.Component,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddComponent(bool arg0, Java.Awt.Component arg1, int arg2, int arg3, int arg4)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addComponent", arg0, arg1, arg2, arg3, arg4);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addComponent(boolean,java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddComponent(bool arg0, Java.Awt.Component arg1)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addComponent", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addContainerGap()"/>
            /// </summary>
            
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddContainerGap()
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addContainerGap");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addContainerGap(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddContainerGap(int arg0, int arg1)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addContainerGap", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addGroup(boolean,javax.swing.GroupLayout.Group)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.GroupLayout.Group"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddGroup(bool arg0, Javax.Swing.GroupLayout.Group arg1)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addGroup", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addPreferredGap(javax.swing.JComponent,javax.swing.JComponent,javax.swing.LayoutStyle.ComponentPlacement,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.JComponent"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.LayoutStyle.ComponentPlacement"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddPreferredGap(Javax.Swing.JComponent arg0, Javax.Swing.JComponent arg1, Javax.Swing.LayoutStyle.ComponentPlacement arg2, int arg3, int arg4)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addPreferredGap", arg0, arg1, arg2, arg3, arg4);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addPreferredGap(javax.swing.JComponent,javax.swing.JComponent,javax.swing.LayoutStyle.ComponentPlacement)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.JComponent"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.LayoutStyle.ComponentPlacement"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddPreferredGap(Javax.Swing.JComponent arg0, Javax.Swing.JComponent arg1, Javax.Swing.LayoutStyle.ComponentPlacement arg2)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addPreferredGap", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.LayoutStyle.ComponentPlacement"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddPreferredGap(Javax.Swing.LayoutStyle.ComponentPlacement arg0, int arg1, int arg2)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addPreferredGap", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.LayoutStyle.ComponentPlacement"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddPreferredGap(Javax.Swing.LayoutStyle.ComponentPlacement arg0)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addPreferredGap", arg0);
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