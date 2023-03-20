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
    #region JSplitPane
    public partial class JSplitPane
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#%3Cinit%3E(int,boolean,java.awt.Component,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Component"/></param>
        public JSplitPane(int arg0, bool arg1, Java.Awt.Component arg2, Java.Awt.Component arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#%3Cinit%3E(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public JSplitPane(int arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#%3Cinit%3E(int,java.awt.Component,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        public JSplitPane(int arg0, Java.Awt.Component arg1, Java.Awt.Component arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public JSplitPane(int arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JSplitPane"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JSplitPane t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#HORIZONTAL_SPLIT"/>
        /// </summary>
        public static int HORIZONTAL_SPLIT => Clazz.GetField<int>("HORIZONTAL_SPLIT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#VERTICAL_SPLIT"/>
        /// </summary>
        public static int VERTICAL_SPLIT => Clazz.GetField<int>("VERTICAL_SPLIT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#BOTTOM"/>
        /// </summary>
        public static string BOTTOM => Clazz.GetField<string>("BOTTOM");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#CONTINUOUS_LAYOUT_PROPERTY"/>
        /// </summary>
        public static string CONTINUOUS_LAYOUT_PROPERTY => Clazz.GetField<string>("CONTINUOUS_LAYOUT_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#DIVIDER"/>
        /// </summary>
        public static string DIVIDER => Clazz.GetField<string>("DIVIDER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#DIVIDER_LOCATION_PROPERTY"/>
        /// </summary>
        public static string DIVIDER_LOCATION_PROPERTY => Clazz.GetField<string>("DIVIDER_LOCATION_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#DIVIDER_SIZE_PROPERTY"/>
        /// </summary>
        public static string DIVIDER_SIZE_PROPERTY => Clazz.GetField<string>("DIVIDER_SIZE_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#LAST_DIVIDER_LOCATION_PROPERTY"/>
        /// </summary>
        public static string LAST_DIVIDER_LOCATION_PROPERTY => Clazz.GetField<string>("LAST_DIVIDER_LOCATION_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#LEFT"/>
        /// </summary>
        public static string LEFT => Clazz.GetField<string>("LEFT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#ONE_TOUCH_EXPANDABLE_PROPERTY"/>
        /// </summary>
        public static string ONE_TOUCH_EXPANDABLE_PROPERTY => Clazz.GetField<string>("ONE_TOUCH_EXPANDABLE_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#ORIENTATION_PROPERTY"/>
        /// </summary>
        public static string ORIENTATION_PROPERTY => Clazz.GetField<string>("ORIENTATION_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#RESIZE_WEIGHT_PROPERTY"/>
        /// </summary>
        public static string RESIZE_WEIGHT_PROPERTY => Clazz.GetField<string>("RESIZE_WEIGHT_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#RIGHT"/>
        /// </summary>
        public static string RIGHT => Clazz.GetField<string>("RIGHT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#TOP"/>
        /// </summary>
        public static string TOP => Clazz.GetField<string>("TOP");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getBottomComponent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setBottomComponent(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component BottomComponent
        {
            get { return IExecute<Java.Awt.Component>("getBottomComponent"); } set { IExecute("setBottomComponent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getDividerLocation()"/> 
        /// </summary>
        public int DividerLocation
        {
            get { return IExecute<int>("getDividerLocation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getDividerSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setDividerSize(int)"/>
        /// </summary>
        public int DividerSize
        {
            get { return IExecute<int>("getDividerSize"); } set { IExecute("setDividerSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getLastDividerLocation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setLastDividerLocation(int)"/>
        /// </summary>
        public int LastDividerLocation
        {
            get { return IExecute<int>("getLastDividerLocation"); } set { IExecute("setLastDividerLocation", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getLeftComponent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setLeftComponent(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component LeftComponent
        {
            get { return IExecute<Java.Awt.Component>("getLeftComponent"); } set { IExecute("setLeftComponent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getMaximumDividerLocation()"/> 
        /// </summary>
        public int MaximumDividerLocation
        {
            get { return IExecute<int>("getMaximumDividerLocation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getMinimumDividerLocation()"/> 
        /// </summary>
        public int MinimumDividerLocation
        {
            get { return IExecute<int>("getMinimumDividerLocation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getOrientation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setOrientation(int)"/>
        /// </summary>
        public int Orientation
        {
            get { return IExecute<int>("getOrientation"); } set { IExecute("setOrientation", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getResizeWeight()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setResizeWeight(double)"/>
        /// </summary>
        public double ResizeWeight
        {
            get { return IExecute<double>("getResizeWeight"); } set { IExecute("setResizeWeight", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getRightComponent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setRightComponent(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component RightComponent
        {
            get { return IExecute<Java.Awt.Component>("getRightComponent"); } set { IExecute("setRightComponent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#getTopComponent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setTopComponent(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component TopComponent
        {
            get { return IExecute<Java.Awt.Component>("getTopComponent"); } set { IExecute("setTopComponent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#isContinuousLayout()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsContinuousLayout()
        {
            return IExecute<bool>("isContinuousLayout");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#isOneTouchExpandable()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsOneTouchExpandable()
        {
            return IExecute<bool>("isOneTouchExpandable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#resetToPreferredSizes()"/>
        /// </summary>
        public void ResetToPreferredSizes()
        {
            IExecute("resetToPreferredSizes");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setContinuousLayout(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetContinuousLayout(bool arg0)
        {
            IExecute("setContinuousLayout", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setDividerLocation(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void SetDividerLocation(double arg0)
        {
            IExecute("setDividerLocation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setDividerLocation(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDividerLocation(int arg0)
        {
            IExecute("setDividerLocation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setOneTouchExpandable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetOneTouchExpandable(bool arg0)
        {
            IExecute("setOneTouchExpandable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSplitPane.html#setUI(javax.swing.plaf.SplitPaneUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.SplitPaneUI"/></param>
        public void SetUI(Javax.Swing.Plaf.SplitPaneUI arg0)
        {
            IExecute("setUI", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}