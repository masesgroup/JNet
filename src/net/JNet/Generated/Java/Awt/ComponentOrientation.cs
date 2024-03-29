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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region ComponentOrientation
    public partial class ComponentOrientation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ComponentOrientation.html#LEFT_TO_RIGHT"/>
        /// </summary>
        public static Java.Awt.ComponentOrientation LEFT_TO_RIGHT { get { if (!_LEFT_TO_RIGHTReady) { _LEFT_TO_RIGHTContent = SGetField<Java.Awt.ComponentOrientation>(LocalBridgeClazz, "LEFT_TO_RIGHT"); _LEFT_TO_RIGHTReady = true; } return _LEFT_TO_RIGHTContent; } }
        private static Java.Awt.ComponentOrientation _LEFT_TO_RIGHTContent = default;
        private static bool _LEFT_TO_RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ComponentOrientation.html#RIGHT_TO_LEFT"/>
        /// </summary>
        public static Java.Awt.ComponentOrientation RIGHT_TO_LEFT { get { if (!_RIGHT_TO_LEFTReady) { _RIGHT_TO_LEFTContent = SGetField<Java.Awt.ComponentOrientation>(LocalBridgeClazz, "RIGHT_TO_LEFT"); _RIGHT_TO_LEFTReady = true; } return _RIGHT_TO_LEFTContent; } }
        private static Java.Awt.ComponentOrientation _RIGHT_TO_LEFTContent = default;
        private static bool _RIGHT_TO_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ComponentOrientation.html#UNKNOWN"/>
        /// </summary>
        public static Java.Awt.ComponentOrientation UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Java.Awt.ComponentOrientation>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static Java.Awt.ComponentOrientation _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ComponentOrientation.html#getOrientation(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.ComponentOrientation"/></returns>
        public static Java.Awt.ComponentOrientation GetOrientation(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Awt.ComponentOrientation>(LocalBridgeClazz, "getOrientation", "(Ljava/util/Locale;)Ljava/awt/ComponentOrientation;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ComponentOrientation.html#isHorizontal()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsHorizontal()
        {
            return IExecuteWithSignature<bool>("isHorizontal", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ComponentOrientation.html#isLeftToRight()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLeftToRight()
        {
            return IExecuteWithSignature<bool>("isLeftToRight", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}