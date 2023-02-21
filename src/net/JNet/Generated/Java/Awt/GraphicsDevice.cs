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
    #region GraphicsDevice
    public partial class GraphicsDevice
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#TYPE_RASTER_SCREEN
        /// </summary>
        public static int TYPE_RASTER_SCREEN => Clazz.GetField<int>("TYPE_RASTER_SCREEN");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#TYPE_PRINTER
        /// </summary>
        public static int TYPE_PRINTER => Clazz.GetField<int>("TYPE_PRINTER");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#TYPE_IMAGE_BUFFER
        /// </summary>
        public static int TYPE_IMAGE_BUFFER => Clazz.GetField<int>("TYPE_IMAGE_BUFFER");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getAvailableAcceleratedMemory() 
        /// </summary>
        public int AvailableAcceleratedMemory
        {
            get { return IExecute<int>("getAvailableAcceleratedMemory"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getConfigurations() 
        /// </summary>
        public Java.Awt.GraphicsConfiguration[] Configurations
        {
            get { return IExecuteArray<Java.Awt.GraphicsConfiguration>("getConfigurations"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getDefaultConfiguration() 
        /// </summary>
        public Java.Awt.GraphicsConfiguration DefaultConfiguration
        {
            get { return IExecute<Java.Awt.GraphicsConfiguration>("getDefaultConfiguration"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getDisplayMode() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#setDisplayMode(java.awt.DisplayMode)
        /// </summary>
        public Java.Awt.DisplayMode DisplayMode
        {
            get { return IExecute<Java.Awt.DisplayMode>("getDisplayMode"); } set { IExecute("setDisplayMode", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getDisplayModes() 
        /// </summary>
        public Java.Awt.DisplayMode[] DisplayModes
        {
            get { return IExecuteArray<Java.Awt.DisplayMode>("getDisplayModes"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getFullScreenWindow() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#setFullScreenWindow(java.awt.Window)
        /// </summary>
        public Java.Awt.Window FullScreenWindow
        {
            get { return IExecute<Java.Awt.Window>("getFullScreenWindow"); } set { IExecute("setFullScreenWindow", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getIDstring() 
        /// </summary>
        public string IDstring
        {
            get { return IExecute<string>("getIDstring"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getType() 
        /// </summary>
        public int Type
        {
            get { return IExecute<int>("getType"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#isDisplayChangeSupported()
        /// </summary>
        public bool IsDisplayChangeSupported()
        {
            return IExecute<bool>("isDisplayChangeSupported");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#isFullScreenSupported()
        /// </summary>
        public bool IsFullScreenSupported()
        {
            return IExecute<bool>("isFullScreenSupported");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.html#getBestConfiguration(java.awt.GraphicsConfigTemplate)
        /// </summary>
        public Java.Awt.GraphicsConfiguration GetBestConfiguration(Java.Awt.GraphicsConfigTemplate arg0)
        {
            return IExecute<Java.Awt.GraphicsConfiguration>("getBestConfiguration", arg0);
        }
        
        #endregion

        #region Nested classes
        #region WindowTranslucency
        public partial class WindowTranslucency
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.WindowTranslucency.html#PERPIXEL_TRANSPARENT
            /// </summary>
            public static Java.Awt.GraphicsDevice.WindowTranslucency PERPIXEL_TRANSPARENT => Clazz.GetField<Java.Awt.GraphicsDevice.WindowTranslucency>("PERPIXEL_TRANSPARENT");
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.WindowTranslucency.html#TRANSLUCENT
            /// </summary>
            public static Java.Awt.GraphicsDevice.WindowTranslucency TRANSLUCENT => Clazz.GetField<Java.Awt.GraphicsDevice.WindowTranslucency>("TRANSLUCENT");
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.WindowTranslucency.html#PERPIXEL_TRANSLUCENT
            /// </summary>
            public static Java.Awt.GraphicsDevice.WindowTranslucency PERPIXEL_TRANSLUCENT => Clazz.GetField<Java.Awt.GraphicsDevice.WindowTranslucency>("PERPIXEL_TRANSLUCENT");
            
            #endregion

            #region Static methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsDevice.WindowTranslucency.html#values()
            /// </summary>
            public static Java.Awt.GraphicsDevice.WindowTranslucency[] Values()
            {
                return SExecuteArray<Java.Awt.GraphicsDevice.WindowTranslucency>("values");
            }
            
            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}