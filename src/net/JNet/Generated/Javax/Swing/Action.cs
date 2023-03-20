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
    #region Action
    public partial class Action
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Action"/> to <see cref="Java.Awt.EventNs.ActionListener"/>
        /// </summary>
        public static implicit operator Java.Awt.EventNs.ActionListener(Javax.Swing.Action t) => t.Cast<Java.Awt.EventNs.ActionListener>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#ACCELERATOR_KEY"/>
        /// </summary>
        public static string ACCELERATOR_KEY => Clazz.GetField<string>("ACCELERATOR_KEY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#ACTION_COMMAND_KEY"/>
        /// </summary>
        public static string ACTION_COMMAND_KEY => Clazz.GetField<string>("ACTION_COMMAND_KEY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#DEFAULT"/>
        /// </summary>
        public static string DEFAULT => Clazz.GetField<string>("DEFAULT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#DISPLAYED_MNEMONIC_INDEX_KEY"/>
        /// </summary>
        public static string DISPLAYED_MNEMONIC_INDEX_KEY => Clazz.GetField<string>("DISPLAYED_MNEMONIC_INDEX_KEY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#LARGE_ICON_KEY"/>
        /// </summary>
        public static string LARGE_ICON_KEY => Clazz.GetField<string>("LARGE_ICON_KEY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#LONG_DESCRIPTION"/>
        /// </summary>
        public static string LONG_DESCRIPTION => Clazz.GetField<string>("LONG_DESCRIPTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#MNEMONIC_KEY"/>
        /// </summary>
        public static string MNEMONIC_KEY => Clazz.GetField<string>("MNEMONIC_KEY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#NAME"/>
        /// </summary>
        public static string NAME => Clazz.GetField<string>("NAME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#SELECTED_KEY"/>
        /// </summary>
        public static string SELECTED_KEY => Clazz.GetField<string>("SELECTED_KEY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#SHORT_DESCRIPTION"/>
        /// </summary>
        public static string SHORT_DESCRIPTION => Clazz.GetField<string>("SHORT_DESCRIPTION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#SMALL_ICON"/>
        /// </summary>
        public static string SMALL_ICON => Clazz.GetField<string>("SMALL_ICON");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#isEnabled()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecute<bool>("isEnabled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetValue(string arg0)
        {
            return IExecute("getValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("addPropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#putValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void PutValue(string arg0, object arg1)
        {
            IExecute("putValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("removePropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEnabled(bool arg0)
        {
            IExecute("setEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Action.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Accept(object arg0)
        {
            return IExecute<bool>("accept", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}