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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans
{
    #region IPropertyEditor
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html"/>
    /// </summary>
    public partial interface IPropertyEditor
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#getAsText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#setAsText(java.lang.String)"/>
        /// </summary>
        string AsText { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#getCustomEditor()"/> 
        /// </summary>
        Java.Awt.Component CustomEditor { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#getJavaInitializationString()"/> 
        /// </summary>
        string JavaInitializationString { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#getTags()"/> 
        /// </summary>
        string[] Tags { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#setValue(java.lang.Object)"/>
        /// </summary>
        object Value { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#isPaintable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsPaintable();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#supportsCustomEditor()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool SupportsCustomEditor();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#paintValue(java.awt.Graphics,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        void PaintValue(Java.Awt.Graphics arg0, Java.Awt.Rectangle arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PropertyEditor
    public partial class PropertyEditor : Java.Beans.IPropertyEditor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#getAsText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#setAsText(java.lang.String)"/>
        /// </summary>
        public string AsText
        {
            get { return IExecute<string>("getAsText"); } set { IExecute("setAsText", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#getCustomEditor()"/> 
        /// </summary>
        public Java.Awt.Component CustomEditor
        {
            get { return IExecute<Java.Awt.Component>("getCustomEditor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#getJavaInitializationString()"/> 
        /// </summary>
        public string JavaInitializationString
        {
            get { return IExecute<string>("getJavaInitializationString"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#getTags()"/> 
        /// </summary>
        public string[] Tags
        {
            get { return IExecuteArray<string>("getTags"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#setValue(java.lang.Object)"/>
        /// </summary>
        public object Value
        {
            get { return IExecute("getValue"); } set { IExecute("setValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#isPaintable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPaintable()
        {
            return IExecute<bool>("isPaintable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#supportsCustomEditor()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool SupportsCustomEditor()
        {
            return IExecute<bool>("supportsCustomEditor");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("addPropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#paintValue(java.awt.Graphics,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        public void PaintValue(Java.Awt.Graphics arg0, Java.Awt.Rectangle arg1)
        {
            IExecute("paintValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditor.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("removePropertyChangeListener", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}