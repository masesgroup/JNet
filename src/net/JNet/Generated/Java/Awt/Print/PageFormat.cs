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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Print
{
    #region PageFormat
    public partial class PageFormat
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PageFormat.html#LANDSCAPE"/>
        /// </summary>
        public static int LANDSCAPE { get { if (!_LANDSCAPEReady) { _LANDSCAPEContent = SGetField<int>(LocalBridgeClazz, "LANDSCAPE"); _LANDSCAPEReady = true; } return _LANDSCAPEContent; } }
        private static int _LANDSCAPEContent = default;
        private static bool _LANDSCAPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PageFormat.html#PORTRAIT"/>
        /// </summary>
        public static int PORTRAIT { get { if (!_PORTRAITReady) { _PORTRAITContent = SGetField<int>(LocalBridgeClazz, "PORTRAIT"); _PORTRAITReady = true; } return _PORTRAITContent; } }
        private static int _PORTRAITContent = default;
        private static bool _PORTRAITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PageFormat.html#REVERSE_LANDSCAPE"/>
        /// </summary>
        public static int REVERSE_LANDSCAPE { get { if (!_REVERSE_LANDSCAPEReady) { _REVERSE_LANDSCAPEContent = SGetField<int>(LocalBridgeClazz, "REVERSE_LANDSCAPE"); _REVERSE_LANDSCAPEReady = true; } return _REVERSE_LANDSCAPEContent; } }
        private static int _REVERSE_LANDSCAPEContent = default;
        private static bool _REVERSE_LANDSCAPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PageFormat.html#getHeight()"/> 
        /// </summary>
        public double Height
        {
            get { return IExecute<double>("getHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PageFormat.html#getImageableHeight()"/> 
        /// </summary>
        public double ImageableHeight
        {
            get { return IExecute<double>("getImageableHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PageFormat.html#getImageableWidth()"/> 
        /// </summary>
        public double ImageableWidth
        {
            get { return IExecute<double>("getImageableWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PageFormat.html#getImageableX()"/> 
        /// </summary>
        public double ImageableX
        {
            get { return IExecute<double>("getImageableX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PageFormat.html#getImageableY()"/> 
        /// </summary>
        public double ImageableY
        {
            get { return IExecute<double>("getImageableY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PageFormat.html#getMatrix()"/> 
        /// </summary>
        public double[] Matrix
        {
            get { return IExecuteArray<double>("getMatrix"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PageFormat.html#getOrientation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PageFormat.html#setOrientation(int)"/>
        /// </summary>
        public int Orientation
        {
            get { return IExecute<int>("getOrientation"); } set { IExecute("setOrientation", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PageFormat.html#getPaper()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PageFormat.html#setPaper(java.awt.print.Paper)"/>
        /// </summary>
        public Java.Awt.Print.Paper Paper
        {
            get { return IExecute<Java.Awt.Print.Paper>("getPaper"); } set { IExecute("setPaper", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PageFormat.html#getWidth()"/> 
        /// </summary>
        public double Width
        {
            get { return IExecute<double>("getWidth"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}