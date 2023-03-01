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
    #region LayoutStyle
    public partial class LayoutStyle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.html#getInstance()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Swing.LayoutStyle"/></returns>
        public static Javax.Swing.LayoutStyle GetInstance()
        {
            return SExecute<Javax.Swing.LayoutStyle>("getInstance");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.html#setInstance(javax.swing.LayoutStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.LayoutStyle"/></param>
        public static void SetInstance(Javax.Swing.LayoutStyle arg0)
        {
            SExecute("setInstance", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.html#getContainerGap(javax.swing.JComponent,int,java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Container"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetContainerGap(Javax.Swing.JComponent arg0, int arg1, Java.Awt.Container arg2)
        {
            return IExecute<int>("getContainerGap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.html#getPreferredGap(javax.swing.JComponent,javax.swing.JComponent,javax.swing.LayoutStyle$ComponentPlacement,int,java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.LayoutStyle.ComponentPlacement"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Container"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetPreferredGap(Javax.Swing.JComponent arg0, Javax.Swing.JComponent arg1, Javax.Swing.LayoutStyle.ComponentPlacement arg2, int arg3, Java.Awt.Container arg4)
        {
            return IExecute<int>("getPreferredGap", arg0, arg1, arg2, arg3, arg4);
        }
        
        #endregion

        #region Nested classes
        #region ComponentPlacement
        public partial class ComponentPlacement
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.ComponentPlacement.html#INDENT"/>
            /// </summary>
            public static Javax.Swing.LayoutStyle.ComponentPlacement INDENT => Clazz.GetField<Javax.Swing.LayoutStyle.ComponentPlacement>("INDENT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.ComponentPlacement.html#RELATED"/>
            /// </summary>
            public static Javax.Swing.LayoutStyle.ComponentPlacement RELATED => Clazz.GetField<Javax.Swing.LayoutStyle.ComponentPlacement>("RELATED");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.ComponentPlacement.html#UNRELATED"/>
            /// </summary>
            public static Javax.Swing.LayoutStyle.ComponentPlacement UNRELATED => Clazz.GetField<Javax.Swing.LayoutStyle.ComponentPlacement>("UNRELATED");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.ComponentPlacement.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Swing.LayoutStyle.ComponentPlacement"/></returns>
            public static Javax.Swing.LayoutStyle.ComponentPlacement ValueOf(string arg0)
            {
                return SExecute<Javax.Swing.LayoutStyle.ComponentPlacement>("valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/LayoutStyle.ComponentPlacement.html#values()"/>
            /// </summary>
            
            /// <returns><see cref="Javax.Swing.LayoutStyle.ComponentPlacement"/></returns>
            public static Javax.Swing.LayoutStyle.ComponentPlacement[] Values()
            {
                return SExecuteArray<Javax.Swing.LayoutStyle.ComponentPlacement>("values");
            }
            
            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}