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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region Keymap
    public partial class Keymap
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Keymap.html#getBoundActions()"/> 
        /// </summary>
        public Javax.Swing.Action[] BoundActions
        {
            get { return IExecuteArray<Javax.Swing.Action>("getBoundActions"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Keymap.html#getBoundKeyStrokes()"/> 
        /// </summary>
        public Javax.Swing.KeyStroke[] BoundKeyStrokes
        {
            get { return IExecuteArray<Javax.Swing.KeyStroke>("getBoundKeyStrokes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Keymap.html#getDefaultAction()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Keymap.html#setDefaultAction(javax.swing.Action)"/>
        /// </summary>
        public Javax.Swing.Action DefaultAction
        {
            get { return IExecute<Javax.Swing.Action>("getDefaultAction"); } set { IExecute("setDefaultAction", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Keymap.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Keymap.html#getResolveParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Keymap.html#setResolveParent(javax.swing.text.Keymap)"/>
        /// </summary>
        public Javax.Swing.Text.Keymap ResolveParent
        {
            get { return IExecute<Javax.Swing.Text.Keymap>("getResolveParent"); } set { IExecute("setResolveParent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Keymap.html#isLocallyDefined(javax.swing.KeyStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsLocallyDefined(Javax.Swing.KeyStroke arg0)
        {
            return IExecute<bool>("isLocallyDefined", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Keymap.html#getAction(javax.swing.KeyStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <returns><see cref="Javax.Swing.Action"/></returns>
        public Javax.Swing.Action GetAction(Javax.Swing.KeyStroke arg0)
        {
            return IExecute<Javax.Swing.Action>("getAction", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Keymap.html#getKeyStrokesForAction(javax.swing.Action)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Action"/></param>
        /// <returns><see cref="Javax.Swing.KeyStroke"/></returns>
        public Javax.Swing.KeyStroke[] GetKeyStrokesForAction(Javax.Swing.Action arg0)
        {
            return IExecuteArray<Javax.Swing.KeyStroke>("getKeyStrokesForAction", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Keymap.html#addActionForKeyStroke(javax.swing.KeyStroke,javax.swing.Action)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Action"/></param>
        public void AddActionForKeyStroke(Javax.Swing.KeyStroke arg0, Javax.Swing.Action arg1)
        {
            IExecute("addActionForKeyStroke", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Keymap.html#removeBindings()"/>
        /// </summary>
        public void RemoveBindings()
        {
            IExecute("removeBindings");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Keymap.html#removeKeyStrokeBinding(javax.swing.KeyStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        public void RemoveKeyStrokeBinding(Javax.Swing.KeyStroke arg0)
        {
            IExecute("removeKeyStrokeBinding", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}