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

namespace Java.Awt
{
    #region MenuComponent
    public partial class MenuComponent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Io.Serializable(Java.Awt.MenuComponent t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuComponent.html#getAccessibleContext() 
        /// </summary>
        public Javax.Accessibility.AccessibleContext AccessibleContext
        {
            get { return IExecute<Javax.Accessibility.AccessibleContext>("getAccessibleContext"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuComponent.html#getFont() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuComponent.html#setFont(java.awt.Font)
        /// </summary>
        public Java.Awt.Font Font
        {
            get { return IExecute<Java.Awt.Font>("getFont"); } set { IExecute("setFont", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuComponent.html#getName() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuComponent.html#setName(java.lang.String)
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); } set { IExecute("setName", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuComponent.html#getParent() 
        /// </summary>
        public Java.Awt.MenuContainer Parent
        {
            get { return IExecute<Java.Awt.MenuContainer>("getParent"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuComponent.html#dispatchEvent(java.awt.AWTEvent)
        /// </summary>
        public void DispatchEvent(Java.Awt.AWTEvent arg0)
        {
            IExecute("dispatchEvent", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MenuComponent.html#removeNotify()
        /// </summary>
        public void RemoveNotify()
        {
            IExecute("removeNotify");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}