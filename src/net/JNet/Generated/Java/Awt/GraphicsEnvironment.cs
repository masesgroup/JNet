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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region GraphicsEnvironment
    public partial class GraphicsEnvironment
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getLocalGraphicsEnvironment()"/> 
        /// </summary>
        public static Java.Awt.GraphicsEnvironment LocalGraphicsEnvironment
        {
            get { return SExecute<Java.Awt.GraphicsEnvironment>(LocalBridgeClazz, "getLocalGraphicsEnvironment"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#isHeadless()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public static bool IsHeadless()
        {
            return SExecute<bool>(LocalBridgeClazz, "isHeadless");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getAllFonts()"/> 
        /// </summary>
        public Java.Awt.Font[] AllFonts
        {
            get { return IExecuteArray<Java.Awt.Font>("getAllFonts"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getAvailableFontFamilyNames()"/> 
        /// </summary>
        public string[] AvailableFontFamilyNames
        {
            get { return IExecuteArray<string>("getAvailableFontFamilyNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getCenterPoint()"/> 
        /// </summary>
        public Java.Awt.Point CenterPoint
        {
            get { return IExecute<Java.Awt.Point>("getCenterPoint"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getDefaultScreenDevice()"/> 
        /// </summary>
        public Java.Awt.GraphicsDevice DefaultScreenDevice
        {
            get { return IExecute<Java.Awt.GraphicsDevice>("getDefaultScreenDevice"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getMaximumWindowBounds()"/> 
        /// </summary>
        public Java.Awt.Rectangle MaximumWindowBounds
        {
            get { return IExecute<Java.Awt.Rectangle>("getMaximumWindowBounds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getScreenDevices()"/> 
        /// </summary>
        public Java.Awt.GraphicsDevice[] ScreenDevices
        {
            get { return IExecuteArray<Java.Awt.GraphicsDevice>("getScreenDevices"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#createGraphics(java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.Graphics2D"/></returns>
        public Java.Awt.Graphics2D CreateGraphics(Java.Awt.ImageNs.BufferedImage arg0)
        {
            return IExecute<Java.Awt.Graphics2D>("createGraphics", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getAvailableFontFamilyNames(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] GetAvailableFontFamilyNames(Java.Util.Locale arg0)
        {
            return IExecuteArray<string>("getAvailableFontFamilyNames", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#isHeadlessInstance()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsHeadlessInstance()
        {
            return IExecute<bool>("isHeadlessInstance");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#registerFont(java.awt.Font)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Font"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RegisterFont(Java.Awt.Font arg0)
        {
            return IExecute<bool>("registerFont", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#preferLocaleFonts()"/>
        /// </summary>
        public void PreferLocaleFonts()
        {
            IExecute("preferLocaleFonts");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#preferProportionalFonts()"/>
        /// </summary>
        public void PreferProportionalFonts()
        {
            IExecute("preferProportionalFonts");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}