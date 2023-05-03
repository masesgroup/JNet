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
    #region MidiChannel
    public partial class MidiChannel
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#getChannelPressure()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#setChannelPressure(int)"/>
        /// </summary>
        public int ChannelPressure
        {
            get { return IExecute<int>("getChannelPressure"); } set { IExecute("setChannelPressure", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#getMono()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#setMono(boolean)"/>
        /// </summary>
        public bool Mono
        {
            get { return IExecute<bool>("getMono"); } set { IExecute("setMono", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#getMute()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#setMute(boolean)"/>
        /// </summary>
        public bool Mute
        {
            get { return IExecute<bool>("getMute"); } set { IExecute("setMute", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#getOmni()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#setOmni(boolean)"/>
        /// </summary>
        public bool Omni
        {
            get { return IExecute<bool>("getOmni"); } set { IExecute("setOmni", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#getPitchBend()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#setPitchBend(int)"/>
        /// </summary>
        public int PitchBend
        {
            get { return IExecute<int>("getPitchBend"); } set { IExecute("setPitchBend", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#getProgram()"/> 
        /// </summary>
        public int Program
        {
            get { return IExecute<int>("getProgram"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#getSolo()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#setSolo(boolean)"/>
        /// </summary>
        public bool Solo
        {
            get { return IExecute<bool>("getSolo"); } set { IExecute("setSolo", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#localControl(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool LocalControl(bool arg0)
        {
            return IExecute<bool>("localControl", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#getController(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetController(int arg0)
        {
            return IExecute<int>("getController", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#getPolyPressure(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetPolyPressure(int arg0)
        {
            return IExecute<int>("getPolyPressure", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#allNotesOff()"/>
        /// </summary>
        public void AllNotesOff()
        {
            IExecute("allNotesOff");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#allSoundOff()"/>
        /// </summary>
        public void AllSoundOff()
        {
            IExecute("allSoundOff");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#controlChange(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void ControlChange(int arg0, int arg1)
        {
            IExecute("controlChange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#noteOff(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void NoteOff(int arg0, int arg1)
        {
            IExecute("noteOff", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#noteOff(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void NoteOff(int arg0)
        {
            IExecute("noteOff", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#noteOn(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void NoteOn(int arg0, int arg1)
        {
            IExecute("noteOn", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#programChange(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void ProgramChange(int arg0, int arg1)
        {
            IExecute("programChange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#programChange(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void ProgramChange(int arg0)
        {
            IExecute("programChange", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#resetAllControllers()"/>
        /// </summary>
        public void ResetAllControllers()
        {
            IExecute("resetAllControllers");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiChannel.html#setPolyPressure(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetPolyPressure(int arg0, int arg1)
        {
            IExecute("setPolyPressure", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}