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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Sampled
{
    #region LineEvent
    public partial class LineEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.html#%3Cinit%3E(javax.sound.sampled.Line,javax.sound.sampled.LineEvent.Type,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.LineEvent.Type"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public LineEvent(Javax.Sound.Sampled.Line arg0, Javax.Sound.Sampled.LineEvent.Type arg1, long arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.html#getFramePosition()"/> 
        /// </summary>
        public long FramePosition
        {
            get { return IExecute<long>("getFramePosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.html#getType()"/> 
        /// </summary>
        public Javax.Sound.Sampled.LineEvent.Type GetType
        {
            get { return IExecute<Javax.Sound.Sampled.LineEvent.Type>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.html#getLine()"/> 
        /// </summary>
        public Javax.Sound.Sampled.Line Line
        {
            get { return IExecute<Javax.Sound.Sampled.Line>("getLine"); }
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.Type.html#CLOSE"/>
            /// </summary>
            public static Javax.Sound.Sampled.LineEvent.Type CLOSE { get { return SGetField<Javax.Sound.Sampled.LineEvent.Type>(LocalBridgeClazz, "CLOSE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.Type.html#OPEN"/>
            /// </summary>
            public static Javax.Sound.Sampled.LineEvent.Type OPEN { get { return SGetField<Javax.Sound.Sampled.LineEvent.Type>(LocalBridgeClazz, "OPEN"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.Type.html#START"/>
            /// </summary>
            public static Javax.Sound.Sampled.LineEvent.Type START { get { return SGetField<Javax.Sound.Sampled.LineEvent.Type>(LocalBridgeClazz, "START"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/LineEvent.Type.html#STOP"/>
            /// </summary>
            public static Javax.Sound.Sampled.LineEvent.Type STOP { get { return SGetField<Javax.Sound.Sampled.LineEvent.Type>(LocalBridgeClazz, "STOP"); } }

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