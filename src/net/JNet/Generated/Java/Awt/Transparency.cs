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

namespace Java.Awt
{
    #region ITransparency
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITransparency
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Transparency.html#getTransparency()"/> 
        /// </summary>
        int GetTransparency { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Transparency
    public partial class Transparency : Java.Awt.ITransparency
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Transparency.html#BITMASK"/>
        /// </summary>
        public static int BITMASK { get { if (!_BITMASKReady) { _BITMASKContent = SGetField<int>(LocalBridgeClazz, "BITMASK"); _BITMASKReady = true; } return _BITMASKContent; } }
        private static int _BITMASKContent = default;
        private static bool _BITMASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Transparency.html#OPAQUE"/>
        /// </summary>
        public static int OPAQUE { get { if (!_OPAQUEReady) { _OPAQUEContent = SGetField<int>(LocalBridgeClazz, "OPAQUE"); _OPAQUEReady = true; } return _OPAQUEContent; } }
        private static int _OPAQUEContent = default;
        private static bool _OPAQUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Transparency.html#TRANSLUCENT"/>
        /// </summary>
        public static int TRANSLUCENT { get { if (!_TRANSLUCENTReady) { _TRANSLUCENTContent = SGetField<int>(LocalBridgeClazz, "TRANSLUCENT"); _TRANSLUCENTReady = true; } return _TRANSLUCENTContent; } }
        private static int _TRANSLUCENTContent = default;
        private static bool _TRANSLUCENTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Transparency.html#getTransparency()"/> 
        /// </summary>
        public int GetTransparency
        {
            get { return IExecute<int>("getTransparency"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}