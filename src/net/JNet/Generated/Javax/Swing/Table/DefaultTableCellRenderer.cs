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

namespace Javax.Swing.Table
{
    #region DefaultTableCellRenderer
    public partial class DefaultTableCellRenderer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.DefaultTableCellRenderer"/> to <see cref="Javax.Swing.Table.TableCellRenderer"/>
        /// </summary>
        public static implicit operator Javax.Swing.Table.TableCellRenderer(Javax.Swing.Table.DefaultTableCellRenderer t) => t.Cast<Javax.Swing.Table.TableCellRenderer>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.DefaultTableCellRenderer"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Table.DefaultTableCellRenderer t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableCellRenderer.html#getTableCellRendererComponent(javax.swing.JTable,java.lang.Object,boolean,boolean,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetTableCellRendererComponent(Javax.Swing.JTable arg0, object arg1, bool arg2, bool arg3, int arg4, int arg5)
        {
            return IExecute<Java.Awt.Component>("getTableCellRendererComponent", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Nested classes
        #region UIResource
        public partial class UIResource
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Table.DefaultTableCellRenderer.UIResource"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Table.DefaultTableCellRenderer.UIResource t) => t.Cast<Javax.Swing.Plaf.UIResource>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}