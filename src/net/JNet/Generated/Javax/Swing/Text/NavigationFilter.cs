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

namespace Javax.Swing.Text
{
    #region NavigationFilter
    public partial class NavigationFilter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/NavigationFilter.html#getNextVisualPositionFrom(javax.swing.text.JTextComponent,int,javax.swing.text.Position$Bias,int,javax.swing.text.Position$Bias[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public int GetNextVisualPositionFrom(Javax.Swing.Text.JTextComponent arg0, int arg1, Javax.Swing.Text.Position.Bias arg2, int arg3, Javax.Swing.Text.Position.Bias[] arg4)
        {
            return IExecute<int>("getNextVisualPositionFrom", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/NavigationFilter.html#moveDot(javax.swing.text.NavigationFilter$FilterBypass,int,javax.swing.text.Position$Bias)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.NavigationFilter.FilterBypass"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        public void MoveDot(Javax.Swing.Text.NavigationFilter.FilterBypass arg0, int arg1, Javax.Swing.Text.Position.Bias arg2)
        {
            IExecute("moveDot", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/NavigationFilter.html#setDot(javax.swing.text.NavigationFilter$FilterBypass,int,javax.swing.text.Position$Bias)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.NavigationFilter.FilterBypass"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.Position.Bias"/></param>
        public void SetDot(Javax.Swing.Text.NavigationFilter.FilterBypass arg0, int arg1, Javax.Swing.Text.Position.Bias arg2)
        {
            IExecute("setDot", arg0, arg1, arg2);
        }
        
        #endregion

        #region Nested classes
        #region FilterBypass
        public partial class FilterBypass
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/NavigationFilter.FilterBypass.html#getCaret()"/> 
            /// </summary>
            public Javax.Swing.Text.Caret Caret
            {
                get { return IExecute<Javax.Swing.Text.Caret>("getCaret"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/NavigationFilter.FilterBypass.html#moveDot(int,javax.swing.text.Position$Bias)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.Position.Bias"/></param>
            public void MoveDot(int arg0, Javax.Swing.Text.Position.Bias arg1)
            {
                IExecute("moveDot", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/NavigationFilter.FilterBypass.html#setDot(int,javax.swing.text.Position$Bias)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.Position.Bias"/></param>
            public void SetDot(int arg0, Javax.Swing.Text.Position.Bias arg1)
            {
                IExecute("setDot", arg0, arg1);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}