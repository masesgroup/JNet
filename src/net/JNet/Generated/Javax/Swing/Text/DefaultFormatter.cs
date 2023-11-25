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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region DefaultFormatter
    public partial class DefaultFormatter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.DefaultFormatter"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Swing.Text.DefaultFormatter t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatter.html#getAllowsInvalid()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatter.html#setAllowsInvalid(boolean)"/>
        /// </summary>
        public bool AllowsInvalid
        {
            get { return IExecute<bool>("getAllowsInvalid"); } set { IExecute("setAllowsInvalid", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatter.html#getCommitsOnValidEdit()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatter.html#setCommitsOnValidEdit(boolean)"/>
        /// </summary>
        public bool CommitsOnValidEdit
        {
            get { return IExecute<bool>("getCommitsOnValidEdit"); } set { IExecute("setCommitsOnValidEdit", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatter.html#getOverwriteMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatter.html#setOverwriteMode(boolean)"/>
        /// </summary>
        public bool OverwriteMode
        {
            get { return IExecute<bool>("getOverwriteMode"); } set { IExecute("setOverwriteMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatter.html#getValueClass()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultFormatter.html#setValueClass(java.lang.Class)"/>
        /// </summary>
        public Java.Lang.Class ValueClass
        {
            get { return IExecute<Java.Lang.Class>("getValueClass"); } set { IExecute("setValueClass", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}