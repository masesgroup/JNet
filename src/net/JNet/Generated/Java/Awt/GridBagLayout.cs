/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region GridBagLayout
    public partial class GridBagLayout
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.GridBagLayout"/> to <see cref="Java.Awt.LayoutManager2"/>
        /// </summary>
        public static implicit operator Java.Awt.LayoutManager2(Java.Awt.GridBagLayout t) => t.Cast<Java.Awt.LayoutManager2>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.GridBagLayout"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.GridBagLayout t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#columnWeights"/>
        /// </summary>
        public double[] columnWeights { get { return IGetFieldArray<double>("columnWeights"); } set { ISetField("columnWeights", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#rowWeights"/>
        /// </summary>
        public double[] rowWeights { get { return IGetFieldArray<double>("rowWeights"); } set { ISetField("rowWeights", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#columnWidths"/>
        /// </summary>
        public int[] columnWidths { get { return IGetFieldArray<int>("columnWidths"); } set { ISetField("columnWidths", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#rowHeights"/>
        /// </summary>
        public int[] rowHeights { get { return IGetFieldArray<int>("rowHeights"); } set { ISetField("rowHeights", value); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#getLayoutDimensions()"/> 
        /// </summary>
        public int[] LayoutDimensions
        {
            get { return IExecuteArray<int>("getLayoutDimensions"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#getLayoutOrigin()"/> 
        /// </summary>
        public Java.Awt.Point LayoutOrigin
        {
            get { return IExecute<Java.Awt.Point>("getLayoutOrigin"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#getLayoutWeights()"/> 
        /// </summary>
        public double[] LayoutWeights
        {
            get { return IExecuteArray<double>("getLayoutWeights"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#getLayoutAlignmentX(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetLayoutAlignmentX(Java.Awt.Container arg0)
        {
            return IExecute<float>("getLayoutAlignmentX", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#getLayoutAlignmentY(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetLayoutAlignmentY(Java.Awt.Container arg0)
        {
            return IExecute<float>("getLayoutAlignmentY", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#maximumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MaximumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Dimension>("maximumLayoutSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#minimumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Dimension>("minimumLayoutSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#preferredLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Dimension>("preferredLayoutSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#getConstraints(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.GridBagConstraints"/></returns>
        public Java.Awt.GridBagConstraints GetConstraints(Java.Awt.Component arg0)
        {
            return IExecute<Java.Awt.GridBagConstraints>("getConstraints", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#location(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Point"/></returns>
        public Java.Awt.Point Location(int arg0, int arg1)
        {
            return IExecute<Java.Awt.Point>("location", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#addLayoutComponent(java.awt.Component,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void AddLayoutComponent(Java.Awt.Component arg0, object arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#addLayoutComponent(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void AddLayoutComponent(string arg0, Java.Awt.Component arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#invalidateLayout(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void InvalidateLayout(Java.Awt.Container arg0)
        {
            IExecute("invalidateLayout", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#layoutContainer(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void LayoutContainer(Java.Awt.Container arg0)
        {
            IExecute("layoutContainer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#removeLayoutComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void RemoveLayoutComponent(Java.Awt.Component arg0)
        {
            IExecute("removeLayoutComponent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GridBagLayout.html#setConstraints(java.awt.Component,java.awt.GridBagConstraints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.GridBagConstraints"/></param>
        public void SetConstraints(Java.Awt.Component arg0, Java.Awt.GridBagConstraints arg1)
        {
            IExecute("setConstraints", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}