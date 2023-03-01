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
    #region CellRendererPane
    public partial class CellRendererPane
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.CellRendererPane"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.CellRendererPane t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellRendererPane.html#paintComponent(java.awt.Graphics,java.awt.Component,java.awt.Container,int,int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="bool"/></param>
        public void PaintComponent(Java.Awt.Graphics arg0, Java.Awt.Component arg1, Java.Awt.Container arg2, int arg3, int arg4, int arg5, int arg6, bool arg7)
        {
            IExecute("paintComponent", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellRendererPane.html#paintComponent(java.awt.Graphics,java.awt.Component,java.awt.Container,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        public void PaintComponent(Java.Awt.Graphics arg0, Java.Awt.Component arg1, Java.Awt.Container arg2, int arg3, int arg4, int arg5, int arg6)
        {
            IExecute("paintComponent", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellRendererPane.html#paintComponent(java.awt.Graphics,java.awt.Component,java.awt.Container,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Rectangle"/></param>
        public void PaintComponent(Java.Awt.Graphics arg0, Java.Awt.Component arg1, Java.Awt.Container arg2, Java.Awt.Rectangle arg3)
        {
            IExecute("paintComponent", arg0, arg1, arg2, arg3);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}