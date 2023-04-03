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

namespace Javax.Swing
{
    #region JSlider
    public partial class JSlider
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#%3Cinit%3E(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public JSlider(int arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public JSlider(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public JSlider(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public JSlider(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#%3Cinit%3E(javax.swing.BoundedRangeModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.BoundedRangeModel"/></param>
        public JSlider(Javax.Swing.BoundedRangeModel arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JSlider"/> to <see cref="Javax.Swing.SwingConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.SwingConstants(Javax.Swing.JSlider t) => t.Cast<Javax.Swing.SwingConstants>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JSlider"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JSlider t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getChangeListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ChangeListener[] ChangeListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.ChangeListener>("getChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getExtent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setExtent(int)"/>
        /// </summary>
        public int Extent
        {
            get { return IExecute<int>("getExtent"); } set { IExecute("setExtent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getInverted()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setInverted(boolean)"/>
        /// </summary>
        public bool Inverted
        {
            get { return IExecute<bool>("getInverted"); } set { IExecute("setInverted", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getLabelTable()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setLabelTable(java.util.Dictionary)"/>
        /// </summary>
        public Java.Util.Dictionary LabelTable
        {
            get { return IExecute<Java.Util.Dictionary>("getLabelTable"); } set { IExecute("setLabelTable", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getMajorTickSpacing()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setMajorTickSpacing(int)"/>
        /// </summary>
        public int MajorTickSpacing
        {
            get { return IExecute<int>("getMajorTickSpacing"); } set { IExecute("setMajorTickSpacing", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getMaximum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setMaximum(int)"/>
        /// </summary>
        public int Maximum
        {
            get { return IExecute<int>("getMaximum"); } set { IExecute("setMaximum", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getMinimum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setMinimum(int)"/>
        /// </summary>
        public int Minimum
        {
            get { return IExecute<int>("getMinimum"); } set { IExecute("setMinimum", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getMinorTickSpacing()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setMinorTickSpacing(int)"/>
        /// </summary>
        public int MinorTickSpacing
        {
            get { return IExecute<int>("getMinorTickSpacing"); } set { IExecute("setMinorTickSpacing", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setModel(javax.swing.BoundedRangeModel)"/>
        /// </summary>
        public Javax.Swing.BoundedRangeModel Model
        {
            get { return IExecute<Javax.Swing.BoundedRangeModel>("getModel"); } set { IExecute("setModel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getOrientation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setOrientation(int)"/>
        /// </summary>
        public int Orientation
        {
            get { return IExecute<int>("getOrientation"); } set { IExecute("setOrientation", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getPaintLabels()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setPaintLabels(boolean)"/>
        /// </summary>
        public bool PaintLabels
        {
            get { return IExecute<bool>("getPaintLabels"); } set { IExecute("setPaintLabels", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getPaintTicks()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setPaintTicks(boolean)"/>
        /// </summary>
        public bool PaintTicks
        {
            get { return IExecute<bool>("getPaintTicks"); } set { IExecute("setPaintTicks", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getPaintTrack()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setPaintTrack(boolean)"/>
        /// </summary>
        public bool PaintTrack
        {
            get { return IExecute<bool>("getPaintTrack"); } set { IExecute("setPaintTrack", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getSnapToTicks()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setSnapToTicks(boolean)"/>
        /// </summary>
        public bool SnapToTicks
        {
            get { return IExecute<bool>("getSnapToTicks"); } set { IExecute("setSnapToTicks", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setValue(int)"/>
        /// </summary>
        public int Value
        {
            get { return IExecute<int>("getValue"); } set { IExecute("setValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#getValueIsAdjusting()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setValueIsAdjusting(boolean)"/>
        /// </summary>
        public bool ValueIsAdjusting
        {
            get { return IExecute<bool>("getValueIsAdjusting"); } set { IExecute("setValueIsAdjusting", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#createStandardLabels(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Hashtable"/></returns>
        public Java.Util.Hashtable<int?, Javax.Swing.JComponent> CreateStandardLabels(int arg0, int arg1)
        {
            return IExecute<Java.Util.Hashtable<int?, Javax.Swing.JComponent>>("createStandardLabels", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#createStandardLabels(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Hashtable"/></returns>
        public Java.Util.Hashtable<int?, Javax.Swing.JComponent> CreateStandardLabels(int arg0)
        {
            return IExecute<Java.Util.Hashtable<int?, Javax.Swing.JComponent>>("createStandardLabels", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("addChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("removeChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSlider.html#setUI(javax.swing.plaf.SliderUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.SliderUI"/></param>
        public void SetUI(Javax.Swing.Plaf.SliderUI arg0)
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