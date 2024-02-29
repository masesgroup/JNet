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

namespace Javax.Swing.Plaf
{
    #region SplitPaneUI
    public partial class SplitPaneUI
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/SplitPaneUI.html#getDividerLocation(javax.swing.JSplitPane)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JSplitPane"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetDividerLocation(Javax.Swing.JSplitPane arg0)
        {
            return IExecuteWithSignature<int>("getDividerLocation", "(Ljavax/swing/JSplitPane;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/SplitPaneUI.html#getMaximumDividerLocation(javax.swing.JSplitPane)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JSplitPane"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetMaximumDividerLocation(Javax.Swing.JSplitPane arg0)
        {
            return IExecuteWithSignature<int>("getMaximumDividerLocation", "(Ljavax/swing/JSplitPane;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/SplitPaneUI.html#getMinimumDividerLocation(javax.swing.JSplitPane)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JSplitPane"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetMinimumDividerLocation(Javax.Swing.JSplitPane arg0)
        {
            return IExecuteWithSignature<int>("getMinimumDividerLocation", "(Ljavax/swing/JSplitPane;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/SplitPaneUI.html#finishedPaintingChildren(javax.swing.JSplitPane,java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JSplitPane"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
        public void FinishedPaintingChildren(Javax.Swing.JSplitPane arg0, Java.Awt.Graphics arg1)
        {
            IExecute("finishedPaintingChildren", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/SplitPaneUI.html#resetToPreferredSizes(javax.swing.JSplitPane)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JSplitPane"/></param>
        public void ResetToPreferredSizes(Javax.Swing.JSplitPane arg0)
        {
            IExecuteWithSignature("resetToPreferredSizes", "(Ljavax/swing/JSplitPane;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/SplitPaneUI.html#setDividerLocation(javax.swing.JSplitPane,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JSplitPane"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetDividerLocation(Javax.Swing.JSplitPane arg0, int arg1)
        {
            IExecute("setDividerLocation", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}