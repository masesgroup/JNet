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

namespace Javax.Swing.Plaf.Synth
{
    #region SynthLookAndFeel
    public partial class SynthLookAndFeel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthLookAndFeel.html#getStyleFactory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthLookAndFeel.html#setStyleFactory(javax.swing.plaf.synth.SynthStyleFactory)"/>
        /// </summary>
        public static Javax.Swing.Plaf.Synth.SynthStyleFactory StyleFactory
        {
            get { return SExecute<Javax.Swing.Plaf.Synth.SynthStyleFactory>(LocalBridgeClazz, "getStyleFactory"); } set { SExecute(LocalBridgeClazz, "setStyleFactory", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthLookAndFeel.html#createUI(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <returns><see cref="Javax.Swing.Plaf.ComponentUI"/></returns>
        public static Javax.Swing.Plaf.ComponentUI CreateUI(Javax.Swing.JComponent arg0)
        {
            return SExecute<Javax.Swing.Plaf.ComponentUI>(LocalBridgeClazz, "createUI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthLookAndFeel.html#getRegion(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <returns><see cref="Javax.Swing.Plaf.Synth.Region"/></returns>
        public static Javax.Swing.Plaf.Synth.Region GetRegion(Javax.Swing.JComponent arg0)
        {
            return SExecute<Javax.Swing.Plaf.Synth.Region>(LocalBridgeClazz, "getRegion", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthLookAndFeel.html#getStyle(javax.swing.JComponent,javax.swing.plaf.synth.Region)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Plaf.Synth.Region"/></param>
        /// <returns><see cref="Javax.Swing.Plaf.Synth.SynthStyle"/></returns>
        public static Javax.Swing.Plaf.Synth.SynthStyle GetStyle(Javax.Swing.JComponent arg0, Javax.Swing.Plaf.Synth.Region arg1)
        {
            return SExecute<Javax.Swing.Plaf.Synth.SynthStyle>(LocalBridgeClazz, "getStyle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthLookAndFeel.html#updateStyles(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public static void UpdateStyles(Java.Awt.Component arg0)
        {
            SExecute(LocalBridgeClazz, "updateStyles", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthLookAndFeel.html#shouldUpdateStyleOnAncestorChanged()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool ShouldUpdateStyleOnAncestorChanged()
        {
            return IExecute<bool>("shouldUpdateStyleOnAncestorChanged");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthLookAndFeel.html#load(java.io.InputStream,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <exception cref="Java.Text.ParseException"/>
        public void Load(Java.Io.InputStream arg0, Java.Lang.Class arg1)
        {
            IExecute("load", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthLookAndFeel.html#load(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <exception cref="Java.Text.ParseException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void Load(Java.Net.URL arg0)
        {
            IExecute("load", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}