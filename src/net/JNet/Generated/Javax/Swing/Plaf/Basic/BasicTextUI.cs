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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Basic
{
    #region BasicTextUI
    public partial class BasicTextUI
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicTextUI"/> to <see cref="Javax.Swing.Text.ViewFactory"/>
        /// </summary>
        public static implicit operator Javax.Swing.Text.ViewFactory(Javax.Swing.Plaf.Basic.BasicTextUI t) => t.Cast<Javax.Swing.Text.ViewFactory>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTextUI.html#create(javax.swing.text.Element,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.View"/></returns>
        public Javax.Swing.Text.View Create(Javax.Swing.Text.Element arg0, int arg1, int arg2)
        {
            return IExecute<Javax.Swing.Text.View>("create", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTextUI.html#create(javax.swing.text.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        /// <returns><see cref="Javax.Swing.Text.View"/></returns>
        public Javax.Swing.Text.View Create(Javax.Swing.Text.Element arg0)
        {
            return IExecute<Javax.Swing.Text.View>("create", arg0);
        }

        #endregion

        #region Nested classes
        #region BasicCaret
        public partial class BasicCaret
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicTextUI.BasicCaret"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.Basic.BasicTextUI.BasicCaret t) => t.Cast<Javax.Swing.Plaf.UIResource>();

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

        #region BasicHighlighter
        public partial class BasicHighlighter
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicTextUI.BasicHighlighter"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.Basic.BasicTextUI.BasicHighlighter t) => t.Cast<Javax.Swing.Plaf.UIResource>();

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