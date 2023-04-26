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
    #region JViewport
    public partial class JViewport
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JViewport"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JViewport t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#BACKINGSTORE_SCROLL_MODE"/>
        /// </summary>
        public static int BACKINGSTORE_SCROLL_MODE => LocalClazz.GetField<int>("BACKINGSTORE_SCROLL_MODE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#BLIT_SCROLL_MODE"/>
        /// </summary>
        public static int BLIT_SCROLL_MODE => LocalClazz.GetField<int>("BLIT_SCROLL_MODE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#SIMPLE_SCROLL_MODE"/>
        /// </summary>
        public static int SIMPLE_SCROLL_MODE => LocalClazz.GetField<int>("SIMPLE_SCROLL_MODE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#getChangeListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ChangeListener[] ChangeListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.ChangeListener>("getChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#getExtentSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#setExtentSize(java.awt.Dimension)"/>
        /// </summary>
        public Java.Awt.Dimension ExtentSize
        {
            get { return IExecute<Java.Awt.Dimension>("getExtentSize"); } set { IExecute("setExtentSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#getScrollMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#setScrollMode(int)"/>
        /// </summary>
        public int ScrollMode
        {
            get { return IExecute<int>("getScrollMode"); } set { IExecute("setScrollMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#getView()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#setView(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component View
        {
            get { return IExecute<Java.Awt.Component>("getView"); } set { IExecute("setView", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#getViewPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#setViewPosition(java.awt.Point)"/>
        /// </summary>
        public Java.Awt.Point ViewPosition
        {
            get { return IExecute<Java.Awt.Point>("getViewPosition"); } set { IExecute("setViewPosition", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#getViewRect()"/> 
        /// </summary>
        public Java.Awt.Rectangle ViewRect
        {
            get { return IExecute<Java.Awt.Rectangle>("getViewRect"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#getViewSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#setViewSize(java.awt.Dimension)"/>
        /// </summary>
        public Java.Awt.Dimension ViewSize
        {
            get { return IExecute<Java.Awt.Dimension>("getViewSize"); } set { IExecute("setViewSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#toViewCoordinates(java.awt.Dimension)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dimension"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension ToViewCoordinates(Java.Awt.Dimension arg0)
        {
            return IExecute<Java.Awt.Dimension>("toViewCoordinates", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#toViewCoordinates(java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.Point"/></returns>
        public Java.Awt.Point ToViewCoordinates(Java.Awt.Point arg0)
        {
            return IExecute<Java.Awt.Point>("toViewCoordinates", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("addChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("removeChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#setUI(javax.swing.plaf.ViewportUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.ViewportUI"/></param>
        public void SetUI(Javax.Swing.Plaf.ViewportUI arg0)
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