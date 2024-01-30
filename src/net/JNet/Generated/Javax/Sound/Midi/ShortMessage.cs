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

namespace Javax.Sound.Midi
{
    #region ShortMessage
    public partial class ShortMessage
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#%3Cinit%3E(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        public ShortMessage(int arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        public ShortMessage(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        public ShortMessage(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#ACTIVE_SENSING"/>
        /// </summary>
        public static int ACTIVE_SENSING { get { if (!_ACTIVE_SENSINGReady) { _ACTIVE_SENSINGContent = SGetField<int>(LocalBridgeClazz, "ACTIVE_SENSING"); _ACTIVE_SENSINGReady = true; } return _ACTIVE_SENSINGContent; } }
        private static int _ACTIVE_SENSINGContent = default;
        private static bool _ACTIVE_SENSINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#CHANNEL_PRESSURE"/>
        /// </summary>
        public static int CHANNEL_PRESSURE { get { if (!_CHANNEL_PRESSUREReady) { _CHANNEL_PRESSUREContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_PRESSURE"); _CHANNEL_PRESSUREReady = true; } return _CHANNEL_PRESSUREContent; } }
        private static int _CHANNEL_PRESSUREContent = default;
        private static bool _CHANNEL_PRESSUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#CONTINUE"/>
        /// </summary>
        public static int CONTINUE { get { if (!_CONTINUEReady) { _CONTINUEContent = SGetField<int>(LocalBridgeClazz, "CONTINUE"); _CONTINUEReady = true; } return _CONTINUEContent; } }
        private static int _CONTINUEContent = default;
        private static bool _CONTINUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#CONTROL_CHANGE"/>
        /// </summary>
        public static int CONTROL_CHANGE { get { if (!_CONTROL_CHANGEReady) { _CONTROL_CHANGEContent = SGetField<int>(LocalBridgeClazz, "CONTROL_CHANGE"); _CONTROL_CHANGEReady = true; } return _CONTROL_CHANGEContent; } }
        private static int _CONTROL_CHANGEContent = default;
        private static bool _CONTROL_CHANGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#END_OF_EXCLUSIVE"/>
        /// </summary>
        public static int END_OF_EXCLUSIVE { get { if (!_END_OF_EXCLUSIVEReady) { _END_OF_EXCLUSIVEContent = SGetField<int>(LocalBridgeClazz, "END_OF_EXCLUSIVE"); _END_OF_EXCLUSIVEReady = true; } return _END_OF_EXCLUSIVEContent; } }
        private static int _END_OF_EXCLUSIVEContent = default;
        private static bool _END_OF_EXCLUSIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#MIDI_TIME_CODE"/>
        /// </summary>
        public static int MIDI_TIME_CODE { get { if (!_MIDI_TIME_CODEReady) { _MIDI_TIME_CODEContent = SGetField<int>(LocalBridgeClazz, "MIDI_TIME_CODE"); _MIDI_TIME_CODEReady = true; } return _MIDI_TIME_CODEContent; } }
        private static int _MIDI_TIME_CODEContent = default;
        private static bool _MIDI_TIME_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#NOTE_OFF"/>
        /// </summary>
        public static int NOTE_OFF { get { if (!_NOTE_OFFReady) { _NOTE_OFFContent = SGetField<int>(LocalBridgeClazz, "NOTE_OFF"); _NOTE_OFFReady = true; } return _NOTE_OFFContent; } }
        private static int _NOTE_OFFContent = default;
        private static bool _NOTE_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#NOTE_ON"/>
        /// </summary>
        public static int NOTE_ON { get { if (!_NOTE_ONReady) { _NOTE_ONContent = SGetField<int>(LocalBridgeClazz, "NOTE_ON"); _NOTE_ONReady = true; } return _NOTE_ONContent; } }
        private static int _NOTE_ONContent = default;
        private static bool _NOTE_ONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#PITCH_BEND"/>
        /// </summary>
        public static int PITCH_BEND { get { if (!_PITCH_BENDReady) { _PITCH_BENDContent = SGetField<int>(LocalBridgeClazz, "PITCH_BEND"); _PITCH_BENDReady = true; } return _PITCH_BENDContent; } }
        private static int _PITCH_BENDContent = default;
        private static bool _PITCH_BENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#POLY_PRESSURE"/>
        /// </summary>
        public static int POLY_PRESSURE { get { if (!_POLY_PRESSUREReady) { _POLY_PRESSUREContent = SGetField<int>(LocalBridgeClazz, "POLY_PRESSURE"); _POLY_PRESSUREReady = true; } return _POLY_PRESSUREContent; } }
        private static int _POLY_PRESSUREContent = default;
        private static bool _POLY_PRESSUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#PROGRAM_CHANGE"/>
        /// </summary>
        public static int PROGRAM_CHANGE { get { if (!_PROGRAM_CHANGEReady) { _PROGRAM_CHANGEContent = SGetField<int>(LocalBridgeClazz, "PROGRAM_CHANGE"); _PROGRAM_CHANGEReady = true; } return _PROGRAM_CHANGEContent; } }
        private static int _PROGRAM_CHANGEContent = default;
        private static bool _PROGRAM_CHANGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#SONG_POSITION_POINTER"/>
        /// </summary>
        public static int SONG_POSITION_POINTER { get { if (!_SONG_POSITION_POINTERReady) { _SONG_POSITION_POINTERContent = SGetField<int>(LocalBridgeClazz, "SONG_POSITION_POINTER"); _SONG_POSITION_POINTERReady = true; } return _SONG_POSITION_POINTERContent; } }
        private static int _SONG_POSITION_POINTERContent = default;
        private static bool _SONG_POSITION_POINTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#SONG_SELECT"/>
        /// </summary>
        public static int SONG_SELECT { get { if (!_SONG_SELECTReady) { _SONG_SELECTContent = SGetField<int>(LocalBridgeClazz, "SONG_SELECT"); _SONG_SELECTReady = true; } return _SONG_SELECTContent; } }
        private static int _SONG_SELECTContent = default;
        private static bool _SONG_SELECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#START"/>
        /// </summary>
        public static int START { get { if (!_STARTReady) { _STARTContent = SGetField<int>(LocalBridgeClazz, "START"); _STARTReady = true; } return _STARTContent; } }
        private static int _STARTContent = default;
        private static bool _STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#STOP"/>
        /// </summary>
        public static int STOP { get { if (!_STOPReady) { _STOPContent = SGetField<int>(LocalBridgeClazz, "STOP"); _STOPReady = true; } return _STOPContent; } }
        private static int _STOPContent = default;
        private static bool _STOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#SYSTEM_RESET"/>
        /// </summary>
        public static int SYSTEM_RESET { get { if (!_SYSTEM_RESETReady) { _SYSTEM_RESETContent = SGetField<int>(LocalBridgeClazz, "SYSTEM_RESET"); _SYSTEM_RESETReady = true; } return _SYSTEM_RESETContent; } }
        private static int _SYSTEM_RESETContent = default;
        private static bool _SYSTEM_RESETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#TIMING_CLOCK"/>
        /// </summary>
        public static int TIMING_CLOCK { get { if (!_TIMING_CLOCKReady) { _TIMING_CLOCKContent = SGetField<int>(LocalBridgeClazz, "TIMING_CLOCK"); _TIMING_CLOCKReady = true; } return _TIMING_CLOCKContent; } }
        private static int _TIMING_CLOCKContent = default;
        private static bool _TIMING_CLOCKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#TUNE_REQUEST"/>
        /// </summary>
        public static int TUNE_REQUEST { get { if (!_TUNE_REQUESTReady) { _TUNE_REQUESTContent = SGetField<int>(LocalBridgeClazz, "TUNE_REQUEST"); _TUNE_REQUESTReady = true; } return _TUNE_REQUESTContent; } }
        private static int _TUNE_REQUESTContent = default;
        private static bool _TUNE_REQUESTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#getChannel()"/> 
        /// </summary>
        public int Channel
        {
            get { return IExecute<int>("getChannel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#getCommand()"/> 
        /// </summary>
        public int Command
        {
            get { return IExecute<int>("getCommand"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#getData1()"/> 
        /// </summary>
        public int Data1
        {
            get { return IExecute<int>("getData1"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#getData2()"/> 
        /// </summary>
        public int Data2
        {
            get { return IExecute<int>("getData2"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#setMessage(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        public void SetMessage(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setMessage", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#setMessage(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        public void SetMessage(int arg0, int arg1, int arg2)
        {
            IExecute("setMessage", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#setMessage(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Javax.Sound.Midi.InvalidMidiDataException"/>
        public void SetMessage(int arg0)
        {
            IExecute("setMessage", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}