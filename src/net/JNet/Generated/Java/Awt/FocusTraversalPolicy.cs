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
    #region FocusTraversalPolicy
    public partial class FocusTraversalPolicy
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FocusTraversalPolicy.html#getComponentAfter(java.awt.Container,java.awt.Component)
        /// </summary>
        public Java.Awt.Component GetComponentAfter(Java.Awt.Container arg0, Java.Awt.Component arg1)
        {
            return IExecute<Java.Awt.Component>("getComponentAfter", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FocusTraversalPolicy.html#getComponentBefore(java.awt.Container,java.awt.Component)
        /// </summary>
        public Java.Awt.Component GetComponentBefore(Java.Awt.Container arg0, Java.Awt.Component arg1)
        {
            return IExecute<Java.Awt.Component>("getComponentBefore", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FocusTraversalPolicy.html#getDefaultComponent(java.awt.Container)
        /// </summary>
        public Java.Awt.Component GetDefaultComponent(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Component>("getDefaultComponent", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FocusTraversalPolicy.html#getFirstComponent(java.awt.Container)
        /// </summary>
        public Java.Awt.Component GetFirstComponent(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Component>("getFirstComponent", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FocusTraversalPolicy.html#getLastComponent(java.awt.Container)
        /// </summary>
        public Java.Awt.Component GetLastComponent(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Component>("getLastComponent", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FocusTraversalPolicy.html#getInitialComponent(java.awt.Window)
        /// </summary>
        public Java.Awt.Component GetInitialComponent(Java.Awt.Window arg0)
        {
            return IExecute<Java.Awt.Component>("getInitialComponent", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}