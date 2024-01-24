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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Sampled
{
    #region BooleanControl
    public partial class BooleanControl
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/BooleanControl.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/BooleanControl.html#setValue(boolean)"/>
        /// </summary>
        public bool Value
        {
            get { return IExecute<bool>("getValue"); } set { IExecute("setValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/BooleanControl.html#getStateLabel(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetStateLabel(bool arg0)
        {
            return IExecute<string>("getStateLabel", arg0);
        }

        #endregion

        #region Nested classes
        #region Type
        public partial class Type
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/BooleanControl.Type.html#APPLY_REVERB"/>
            /// </summary>
            public static Javax.Sound.Sampled.BooleanControl.Type APPLY_REVERB { get { if (!_APPLY_REVERBReady) { _APPLY_REVERBContent = SGetField<Javax.Sound.Sampled.BooleanControl.Type>(LocalBridgeClazz, "APPLY_REVERB"); _APPLY_REVERBReady = true; } return _APPLY_REVERBContent; } }
            private static Javax.Sound.Sampled.BooleanControl.Type _APPLY_REVERBContent = default;
            private static bool _APPLY_REVERBReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/BooleanControl.Type.html#MUTE"/>
            /// </summary>
            public static Javax.Sound.Sampled.BooleanControl.Type MUTE { get { if (!_MUTEReady) { _MUTEContent = SGetField<Javax.Sound.Sampled.BooleanControl.Type>(LocalBridgeClazz, "MUTE"); _MUTEReady = true; } return _MUTEContent; } }
            private static Javax.Sound.Sampled.BooleanControl.Type _MUTEContent = default;
            private static bool _MUTEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}