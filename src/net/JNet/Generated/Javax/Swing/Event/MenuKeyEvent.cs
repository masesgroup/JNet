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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Event
{
    #region MenuKeyEvent
    public partial class MenuKeyEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuKeyEvent.html#%3Cinit%3E(java.awt.Component,int,long,int,int,char,javax.swing.MenuElement[],javax.swing.MenuSelectionManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="char"/></param>
        /// <param name="arg6"><see cref="Javax.Swing.MenuElement"/></param>
        /// <param name="arg7"><see cref="Javax.Swing.MenuSelectionManager"/></param>
        public MenuKeyEvent(Java.Awt.Component arg0, int arg1, long arg2, int arg3, int arg4, char arg5, Javax.Swing.MenuElement[] arg6, Javax.Swing.MenuSelectionManager arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuKeyEvent.html#getMenuSelectionManager()"/> 
        /// </summary>
        public Javax.Swing.MenuSelectionManager MenuSelectionManager
        {
            get { return IExecuteWithSignature<Javax.Swing.MenuSelectionManager>("getMenuSelectionManager", "()Ljavax/swing/MenuSelectionManager;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuKeyEvent.html#getPath()"/> 
        /// </summary>
        public Javax.Swing.MenuElement[] Path
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.MenuElement>("getPath", "()[Ljavax/swing/MenuElement;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}