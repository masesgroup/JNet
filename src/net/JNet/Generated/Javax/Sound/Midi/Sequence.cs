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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Midi
{
    #region Sequence
    public partial class Sequence
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#%3Cinit%3E(float,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        public Sequence(float arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#%3Cinit%3E(float,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        public Sequence(float arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#PPQ"/>
        /// </summary>
        public static float PPQ { get { return SGetField<float>(LocalBridgeClazz, "PPQ"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#SMPTE_24"/>
        /// </summary>
        public static float SMPTE_24 { get { return SGetField<float>(LocalBridgeClazz, "SMPTE_24"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#SMPTE_25"/>
        /// </summary>
        public static float SMPTE_25 { get { return SGetField<float>(LocalBridgeClazz, "SMPTE_25"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#SMPTE_30"/>
        /// </summary>
        public static float SMPTE_30 { get { return SGetField<float>(LocalBridgeClazz, "SMPTE_30"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#SMPTE_30DROP"/>
        /// </summary>
        public static float SMPTE_30DROP { get { return SGetField<float>(LocalBridgeClazz, "SMPTE_30DROP"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#getDivisionType()"/> 
        /// </summary>
        public float DivisionType
        {
            get { return IExecute<float>("getDivisionType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#getMicrosecondLength()"/> 
        /// </summary>
        public long MicrosecondLength
        {
            get { return IExecute<long>("getMicrosecondLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#getPatchList()"/> 
        /// </summary>
        public Javax.Sound.Midi.Patch[] PatchList
        {
            get { return IExecuteArray<Javax.Sound.Midi.Patch>("getPatchList"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#getResolution()"/> 
        /// </summary>
        public int Resolution
        {
            get { return IExecute<int>("getResolution"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#getTickLength()"/> 
        /// </summary>
        public long TickLength
        {
            get { return IExecute<long>("getTickLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#getTracks()"/> 
        /// </summary>
        public Javax.Sound.Midi.Track[] Tracks
        {
            get { return IExecuteArray<Javax.Sound.Midi.Track>("getTracks"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#deleteTrack(javax.sound.midi.Track)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Track"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DeleteTrack(Javax.Sound.Midi.Track arg0)
        {
            return IExecute<bool>("deleteTrack", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Sequence.html#createTrack()"/>
        /// </summary>

        /// <returns><see cref="Javax.Sound.Midi.Track"/></returns>
        public Javax.Sound.Midi.Track CreateTrack()
        {
            return IExecute<Javax.Sound.Midi.Track>("createTrack");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}