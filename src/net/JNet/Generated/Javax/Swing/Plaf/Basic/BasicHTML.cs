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

namespace Javax.Swing.Plaf.Basic
{
    #region BasicHTML
    public partial class BasicHTML
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicHTML.html#documentBaseKey"/>
        /// </summary>
        public static string documentBaseKey { get { return SGetField<string>(LocalBridgeClazz, "documentBaseKey"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicHTML.html#propertyKey"/>
        /// </summary>
        public static string propertyKey { get { return SGetField<string>(LocalBridgeClazz, "propertyKey"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicHTML.html#isHTMLString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsHTMLString(string arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isHTMLString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicHTML.html#getHTMLBaseline(javax.swing.text.View,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetHTMLBaseline(Javax.Swing.Text.View arg0, int arg1, int arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "getHTMLBaseline", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicHTML.html#createHTMLView(javax.swing.JComponent,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.Text.View"/></returns>
        public static Javax.Swing.Text.View CreateHTMLView(Javax.Swing.JComponent arg0, string arg1)
        {
            return SExecute<Javax.Swing.Text.View>(LocalBridgeClazz, "createHTMLView", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicHTML.html#updateRenderer(javax.swing.JComponent,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public static void UpdateRenderer(Javax.Swing.JComponent arg0, string arg1)
        {
            SExecute(LocalBridgeClazz, "updateRenderer", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}