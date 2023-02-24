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

namespace Javax.Accessibility
{
    #region AccessibleComponent
    public partial class AccessibleComponent
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getBackground()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setBackground(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color Background
        {
            get { return IExecute<Java.Awt.Color>("getBackground"); } set { IExecute("setBackground", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getBounds()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setBounds(java.awt.Rectangle)"/>
        /// </summary>
        public Java.Awt.Rectangle Bounds
        {
            get { return IExecute<Java.Awt.Rectangle>("getBounds"); } set { IExecute("setBounds", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getCursor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setCursor(java.awt.Cursor)"/>
        /// </summary>
        public Java.Awt.Cursor Cursor
        {
            get { return IExecute<Java.Awt.Cursor>("getCursor"); } set { IExecute("setCursor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getFont()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setFont(java.awt.Font)"/>
        /// </summary>
        public Java.Awt.Font Font
        {
            get { return IExecute<Java.Awt.Font>("getFont"); } set { IExecute("setFont", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getForeground()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setForeground(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color Foreground
        {
            get { return IExecute<Java.Awt.Color>("getForeground"); } set { IExecute("setForeground", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getLocation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setLocation(java.awt.Point)"/>
        /// </summary>
        public Java.Awt.Point Location
        {
            get { return IExecute<Java.Awt.Point>("getLocation"); } set { IExecute("setLocation", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getLocationOnScreen()"/> 
        /// </summary>
        public Java.Awt.Point LocationOnScreen
        {
            get { return IExecute<Java.Awt.Point>("getLocationOnScreen"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setSize(java.awt.Dimension)"/>
        /// </summary>
        public Java.Awt.Dimension Size
        {
            get { return IExecute<Java.Awt.Dimension>("getSize"); } set { IExecute("setSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#contains(java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Point"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Contains(Java.Awt.Point arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#isEnabled()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecute<bool>("isEnabled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#isFocusTraversable()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsFocusTraversable()
        {
            return IExecute<bool>("isFocusTraversable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#isShowing()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsShowing()
        {
            return IExecute<bool>("isShowing");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#isVisible()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsVisible()
        {
            return IExecute<bool>("isVisible");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getFontMetrics(java.awt.Font)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Font"/></param>
        /// <returns><see cref="Java.Awt.FontMetrics"/></returns>
        public Java.Awt.FontMetrics GetFontMetrics(Java.Awt.Font arg0)
        {
            return IExecute<Java.Awt.FontMetrics>("getFontMetrics", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getAccessibleAt(java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Javax.Accessibility.Accessible"/></returns>
        public Javax.Accessibility.Accessible GetAccessibleAt(Java.Awt.Point arg0)
        {
            return IExecute<Javax.Accessibility.Accessible>("getAccessibleAt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#addFocusListener(java.awt.event.FocusListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusListener"/></param>
        public void AddFocusListener(Java.Awt.EventNs.FocusListener arg0)
        {
            IExecute("addFocusListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#removeFocusListener(java.awt.event.FocusListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusListener"/></param>
        public void RemoveFocusListener(Java.Awt.EventNs.FocusListener arg0)
        {
            IExecute("removeFocusListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#requestFocus()"/>
        /// </summary>
        public void RequestFocus()
        {
            IExecute("requestFocus");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEnabled(bool arg0)
        {
            IExecute("setEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setVisible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetVisible(bool arg0)
        {
            IExecute("setVisible", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}