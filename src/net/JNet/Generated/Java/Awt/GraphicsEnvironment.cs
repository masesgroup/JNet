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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getLocalGraphicsEnvironment() 
        /// </summary>
        public static Java.Awt.GraphicsEnvironment LocalGraphicsEnvironment
        {
            get { return SExecute<Java.Awt.GraphicsEnvironment>("getLocalGraphicsEnvironment"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#isHeadless()
        /// </summary>
        public static bool IsHeadless()
        {
            return SExecute<bool>("isHeadless");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getAllFonts() 
        /// </summary>
        public Java.Awt.Font[] AllFonts
        {
            get { return IExecuteArray<Java.Awt.Font>("getAllFonts"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getAvailableFontFamilyNames() 
        /// </summary>
        public string[] AvailableFontFamilyNames
        {
            get { return IExecuteArray<string>("getAvailableFontFamilyNames"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getCenterPoint() throws java.awt.HeadlessException 
        /// </summary>
        public Java.Awt.Point CenterPoint
        {
            get { return IExecute<Java.Awt.Point>("getCenterPoint"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getDefaultScreenDevice() throws java.awt.HeadlessException 
        /// </summary>
        public Java.Awt.GraphicsDevice DefaultScreenDevice
        {
            get { return IExecute<Java.Awt.GraphicsDevice>("getDefaultScreenDevice"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getMaximumWindowBounds() throws java.awt.HeadlessException 
        /// </summary>
        public Java.Awt.Rectangle MaximumWindowBounds
        {
            get { return IExecute<Java.Awt.Rectangle>("getMaximumWindowBounds"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getScreenDevices() throws java.awt.HeadlessException 
        /// </summary>
        public Java.Awt.GraphicsDevice[] ScreenDevices
        {
            get { return IExecuteArray<Java.Awt.GraphicsDevice>("getScreenDevices"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#createGraphics(java.awt.image.BufferedImage)
        /// </summary>
        public Java.Awt.Graphics2D CreateGraphics(Java.Awt.ImageNs.BufferedImage arg0)
        {
            return IExecute<Java.Awt.Graphics2D>("createGraphics", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#getAvailableFontFamilyNames(java.util.Locale)
        /// </summary>
        public string[] GetAvailableFontFamilyNames(Java.Util.Locale arg0)
        {
            return IExecuteArray<string>("getAvailableFontFamilyNames", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#isHeadlessInstance()
        /// </summary>
        public bool IsHeadlessInstance()
        {
            return IExecute<bool>("isHeadlessInstance");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#registerFont(java.awt.Font)
        /// </summary>
        public bool RegisterFont(Java.Awt.Font arg0)
        {
            return IExecute<bool>("registerFont", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#preferLocaleFonts()
        /// </summary>
        public void PreferLocaleFonts()
        {
            IExecute("preferLocaleFonts");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsEnvironment.html#preferProportionalFonts()
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