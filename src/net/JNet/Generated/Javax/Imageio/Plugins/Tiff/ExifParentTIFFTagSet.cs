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

namespace Javax.Imageio.Plugins.Tiff
{
    #region ExifParentTIFFTagSet
    public partial class ExifParentTIFFTagSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifParentTIFFTagSet.html#TAG_EXIF_IFD_POINTER"/>
        /// </summary>
        public static int TAG_EXIF_IFD_POINTER { get { if (!_TAG_EXIF_IFD_POINTERReady) { _TAG_EXIF_IFD_POINTERContent = SGetField<int>(LocalBridgeClazz, "TAG_EXIF_IFD_POINTER"); _TAG_EXIF_IFD_POINTERReady = true; } return _TAG_EXIF_IFD_POINTERContent; } }
        private static int _TAG_EXIF_IFD_POINTERContent = default;
        private static bool _TAG_EXIF_IFD_POINTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifParentTIFFTagSet.html#TAG_GPS_INFO_IFD_POINTER"/>
        /// </summary>
        public static int TAG_GPS_INFO_IFD_POINTER { get { if (!_TAG_GPS_INFO_IFD_POINTERReady) { _TAG_GPS_INFO_IFD_POINTERContent = SGetField<int>(LocalBridgeClazz, "TAG_GPS_INFO_IFD_POINTER"); _TAG_GPS_INFO_IFD_POINTERReady = true; } return _TAG_GPS_INFO_IFD_POINTERContent; } }
        private static int _TAG_GPS_INFO_IFD_POINTERContent = default;
        private static bool _TAG_GPS_INFO_IFD_POINTERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifParentTIFFTagSet.html#getInstance()"/> 
        /// </summary>
        public static Javax.Imageio.Plugins.Tiff.ExifParentTIFFTagSet Instance
        {
            get { return SExecute<Javax.Imageio.Plugins.Tiff.ExifParentTIFFTagSet>(LocalBridgeClazz, "getInstance"); }
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