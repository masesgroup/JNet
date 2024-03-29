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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Accessibility
{
    #region IAccessibleExtendedComponent
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAccessibleExtendedComponent : Javax.Accessibility.IAccessibleComponent
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleExtendedComponent.html#getAccessibleKeyBinding()"/> 
        /// </summary>
        Javax.Accessibility.AccessibleKeyBinding AccessibleKeyBinding { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleExtendedComponent.html#getTitledBorderText()"/> 
        /// </summary>
        Java.Lang.String TitledBorderText { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleExtendedComponent.html#getToolTipText()"/> 
        /// </summary>
        Java.Lang.String ToolTipText { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AccessibleExtendedComponent
    public partial class AccessibleExtendedComponent : Javax.Accessibility.IAccessibleExtendedComponent
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleExtendedComponent.html#getAccessibleKeyBinding()"/> 
        /// </summary>
        public Javax.Accessibility.AccessibleKeyBinding AccessibleKeyBinding
        {
            get { return IExecuteWithSignature<Javax.Accessibility.AccessibleKeyBinding>("getAccessibleKeyBinding", "()Ljavax/accessibility/AccessibleKeyBinding;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleExtendedComponent.html#getTitledBorderText()"/> 
        /// </summary>
        public Java.Lang.String TitledBorderText
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTitledBorderText", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleExtendedComponent.html#getToolTipText()"/> 
        /// </summary>
        public Java.Lang.String ToolTipText
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getToolTipText", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}