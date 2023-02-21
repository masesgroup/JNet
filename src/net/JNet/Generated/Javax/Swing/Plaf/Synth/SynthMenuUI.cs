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

namespace Javax.Swing.Plaf.Synth
{
    #region SynthMenuUI
    public partial class SynthMenuUI
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Plaf.Synth.SynthMenuUI t) => t.Cast<Java.Beans.PropertyChangeListener>();
        public static implicit operator Javax.Swing.Plaf.Synth.SynthUI(Javax.Swing.Plaf.Synth.SynthMenuUI t) => t.Cast<Javax.Swing.Plaf.Synth.SynthUI>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthMenuUI.html#getContext(javax.swing.JComponent)
        /// </summary>
        public Javax.Swing.Plaf.Synth.SynthContext GetContext(Javax.Swing.JComponent arg0)
        {
            return IExecute<Javax.Swing.Plaf.Synth.SynthContext>("getContext", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthMenuUI.html#paintBorder(javax.swing.plaf.synth.SynthContext,java.awt.Graphics,int,int,int,int)
        /// </summary>
        public void PaintBorder(Javax.Swing.Plaf.Synth.SynthContext arg0, Java.Awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5)
        {
            IExecute("paintBorder", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthMenuUI.html#propertyChange(java.beans.PropertyChangeEvent)
        /// </summary>
        public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
        {
            IExecute("propertyChange", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}