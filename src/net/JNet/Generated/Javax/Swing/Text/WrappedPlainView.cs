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
    #region WrappedPlainView
    public partial class WrappedPlainView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/WrappedPlainView.html#%3Cinit%3E(javax.swing.text.Element,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public WrappedPlainView(Javax.Swing.Text.Element arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/WrappedPlainView.html#%3Cinit%3E(javax.swing.text.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        public WrappedPlainView(Javax.Swing.Text.Element arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.WrappedPlainView"/> to <see cref="Javax.Swing.Text.TabExpander"/>
        /// </summary>
        public static implicit operator Javax.Swing.Text.TabExpander(Javax.Swing.Text.WrappedPlainView t) => t.Cast<Javax.Swing.Text.TabExpander>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/WrappedPlainView.html#nextTabStop(float,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float NextTabStop(float arg0, int arg1)
        {
            return IExecute<float>("nextTabStop", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}