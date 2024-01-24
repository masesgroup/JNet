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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Midi
{
    #region ISynthesizer
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISynthesizer : Javax.Sound.Midi.IMidiDevice
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#getAvailableInstruments()"/> 
        /// </summary>
        Javax.Sound.Midi.Instrument[] AvailableInstruments { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#getChannels()"/> 
        /// </summary>
        Javax.Sound.Midi.MidiChannel[] Channels { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#getDefaultSoundbank()"/> 
        /// </summary>
        Javax.Sound.Midi.Soundbank DefaultSoundbank { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#getLatency()"/> 
        /// </summary>
        long Latency { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#getLoadedInstruments()"/> 
        /// </summary>
        Javax.Sound.Midi.Instrument[] LoadedInstruments { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#getMaxPolyphony()"/> 
        /// </summary>
        int MaxPolyphony { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#getVoiceStatus()"/> 
        /// </summary>
        Javax.Sound.Midi.VoiceStatus[] VoiceStatus { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#isSoundbankSupported(javax.sound.midi.Soundbank)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Soundbank"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsSoundbankSupported(Javax.Sound.Midi.Soundbank arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#loadAllInstruments(javax.sound.midi.Soundbank)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Soundbank"/></param>
        /// <returns><see cref="bool"/></returns>
        bool LoadAllInstruments(Javax.Sound.Midi.Soundbank arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#loadInstrument(javax.sound.midi.Instrument)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Instrument"/></param>
        /// <returns><see cref="bool"/></returns>
        bool LoadInstrument(Javax.Sound.Midi.Instrument arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#loadInstruments(javax.sound.midi.Soundbank,javax.sound.midi.Patch[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Soundbank"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Midi.Patch"/></param>
        /// <returns><see cref="bool"/></returns>
        bool LoadInstruments(Javax.Sound.Midi.Soundbank arg0, Javax.Sound.Midi.Patch[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#remapInstrument(javax.sound.midi.Instrument,javax.sound.midi.Instrument)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Instrument"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Midi.Instrument"/></param>
        /// <returns><see cref="bool"/></returns>
        bool RemapInstrument(Javax.Sound.Midi.Instrument arg0, Javax.Sound.Midi.Instrument arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#unloadAllInstruments(javax.sound.midi.Soundbank)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Soundbank"/></param>
        void UnloadAllInstruments(Javax.Sound.Midi.Soundbank arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#unloadInstrument(javax.sound.midi.Instrument)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Instrument"/></param>
        void UnloadInstrument(Javax.Sound.Midi.Instrument arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#unloadInstruments(javax.sound.midi.Soundbank,javax.sound.midi.Patch[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Soundbank"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Midi.Patch"/></param>
        void UnloadInstruments(Javax.Sound.Midi.Soundbank arg0, Javax.Sound.Midi.Patch[] arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Synthesizer
    public partial class Synthesizer : Javax.Sound.Midi.ISynthesizer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#getAvailableInstruments()"/> 
        /// </summary>
        public Javax.Sound.Midi.Instrument[] AvailableInstruments
        {
            get { return IExecuteArray<Javax.Sound.Midi.Instrument>("getAvailableInstruments"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#getChannels()"/> 
        /// </summary>
        public Javax.Sound.Midi.MidiChannel[] Channels
        {
            get { return IExecuteArray<Javax.Sound.Midi.MidiChannel>("getChannels"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#getDefaultSoundbank()"/> 
        /// </summary>
        public Javax.Sound.Midi.Soundbank DefaultSoundbank
        {
            get { return IExecute<Javax.Sound.Midi.Soundbank>("getDefaultSoundbank"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#getLatency()"/> 
        /// </summary>
        public long Latency
        {
            get { return IExecute<long>("getLatency"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#getLoadedInstruments()"/> 
        /// </summary>
        public Javax.Sound.Midi.Instrument[] LoadedInstruments
        {
            get { return IExecuteArray<Javax.Sound.Midi.Instrument>("getLoadedInstruments"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#getMaxPolyphony()"/> 
        /// </summary>
        public int MaxPolyphony
        {
            get { return IExecute<int>("getMaxPolyphony"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#getVoiceStatus()"/> 
        /// </summary>
        public Javax.Sound.Midi.VoiceStatus[] VoiceStatus
        {
            get { return IExecuteArray<Javax.Sound.Midi.VoiceStatus>("getVoiceStatus"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#isSoundbankSupported(javax.sound.midi.Soundbank)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Soundbank"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSoundbankSupported(Javax.Sound.Midi.Soundbank arg0)
        {
            return IExecute<bool>("isSoundbankSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#loadAllInstruments(javax.sound.midi.Soundbank)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Soundbank"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool LoadAllInstruments(Javax.Sound.Midi.Soundbank arg0)
        {
            return IExecute<bool>("loadAllInstruments", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#loadInstrument(javax.sound.midi.Instrument)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Instrument"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool LoadInstrument(Javax.Sound.Midi.Instrument arg0)
        {
            return IExecute<bool>("loadInstrument", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#loadInstruments(javax.sound.midi.Soundbank,javax.sound.midi.Patch[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Soundbank"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Midi.Patch"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool LoadInstruments(Javax.Sound.Midi.Soundbank arg0, Javax.Sound.Midi.Patch[] arg1)
        {
            return IExecute<bool>("loadInstruments", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#remapInstrument(javax.sound.midi.Instrument,javax.sound.midi.Instrument)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Instrument"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Midi.Instrument"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemapInstrument(Javax.Sound.Midi.Instrument arg0, Javax.Sound.Midi.Instrument arg1)
        {
            return IExecute<bool>("remapInstrument", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#unloadAllInstruments(javax.sound.midi.Soundbank)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Soundbank"/></param>
        public void UnloadAllInstruments(Javax.Sound.Midi.Soundbank arg0)
        {
            IExecute("unloadAllInstruments", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#unloadInstrument(javax.sound.midi.Instrument)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Instrument"/></param>
        public void UnloadInstrument(Javax.Sound.Midi.Instrument arg0)
        {
            IExecute("unloadInstrument", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Synthesizer.html#unloadInstruments(javax.sound.midi.Soundbank,javax.sound.midi.Patch[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Soundbank"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Midi.Patch"/></param>
        public void UnloadInstruments(Javax.Sound.Midi.Soundbank arg0, Javax.Sound.Midi.Patch[] arg1)
        {
            IExecute("unloadInstruments", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}