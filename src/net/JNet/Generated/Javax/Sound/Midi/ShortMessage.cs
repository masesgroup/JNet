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
        public static int ACTIVE_SENSING => Clazz.GetField<int>("ACTIVE_SENSING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#CHANNEL_PRESSURE"/>
        /// </summary>
        public static int CHANNEL_PRESSURE => Clazz.GetField<int>("CHANNEL_PRESSURE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#CONTINUE"/>
        /// </summary>
        public static int CONTINUE => Clazz.GetField<int>("CONTINUE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#CONTROL_CHANGE"/>
        /// </summary>
        public static int CONTROL_CHANGE => Clazz.GetField<int>("CONTROL_CHANGE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#END_OF_EXCLUSIVE"/>
        /// </summary>
        public static int END_OF_EXCLUSIVE => Clazz.GetField<int>("END_OF_EXCLUSIVE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#MIDI_TIME_CODE"/>
        /// </summary>
        public static int MIDI_TIME_CODE => Clazz.GetField<int>("MIDI_TIME_CODE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#NOTE_OFF"/>
        /// </summary>
        public static int NOTE_OFF => Clazz.GetField<int>("NOTE_OFF");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#NOTE_ON"/>
        /// </summary>
        public static int NOTE_ON => Clazz.GetField<int>("NOTE_ON");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#PITCH_BEND"/>
        /// </summary>
        public static int PITCH_BEND => Clazz.GetField<int>("PITCH_BEND");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#POLY_PRESSURE"/>
        /// </summary>
        public static int POLY_PRESSURE => Clazz.GetField<int>("POLY_PRESSURE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#PROGRAM_CHANGE"/>
        /// </summary>
        public static int PROGRAM_CHANGE => Clazz.GetField<int>("PROGRAM_CHANGE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#SONG_POSITION_POINTER"/>
        /// </summary>
        public static int SONG_POSITION_POINTER => Clazz.GetField<int>("SONG_POSITION_POINTER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#SONG_SELECT"/>
        /// </summary>
        public static int SONG_SELECT => Clazz.GetField<int>("SONG_SELECT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#START"/>
        /// </summary>
        public static int START => Clazz.GetField<int>("START");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#STOP"/>
        /// </summary>
        public static int STOP => Clazz.GetField<int>("STOP");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#SYSTEM_RESET"/>
        /// </summary>
        public static int SYSTEM_RESET => Clazz.GetField<int>("SYSTEM_RESET");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#TIMING_CLOCK"/>
        /// </summary>
        public static int TIMING_CLOCK => Clazz.GetField<int>("TIMING_CLOCK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ShortMessage.html#TUNE_REQUEST"/>
        /// </summary>
        public static int TUNE_REQUEST => Clazz.GetField<int>("TUNE_REQUEST");
        
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