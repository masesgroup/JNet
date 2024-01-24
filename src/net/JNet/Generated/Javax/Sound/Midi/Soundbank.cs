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

namespace Javax.Sound.Midi
{
    #region ISoundbank
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISoundbank
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getDescription()"/> 
        /// </summary>
        string Description { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getInstruments()"/> 
        /// </summary>
        Javax.Sound.Midi.Instrument[] Instruments { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getName()"/> 
        /// </summary>
        string Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getResources()"/> 
        /// </summary>
        Javax.Sound.Midi.SoundbankResource[] Resources { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getVendor()"/> 
        /// </summary>
        string Vendor { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getVersion()"/> 
        /// </summary>
        string Version { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getInstrument(javax.sound.midi.Patch)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Patch"/></param>
        /// <returns><see cref="Javax.Sound.Midi.Instrument"/></returns>
        Javax.Sound.Midi.Instrument GetInstrument(Javax.Sound.Midi.Patch arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Soundbank
    public partial class Soundbank : Javax.Sound.Midi.ISoundbank
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getDescription()"/> 
        /// </summary>
        public string Description
        {
            get { return IExecute<string>("getDescription"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getInstruments()"/> 
        /// </summary>
        public Javax.Sound.Midi.Instrument[] Instruments
        {
            get { return IExecuteArray<Javax.Sound.Midi.Instrument>("getInstruments"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getResources()"/> 
        /// </summary>
        public Javax.Sound.Midi.SoundbankResource[] Resources
        {
            get { return IExecuteArray<Javax.Sound.Midi.SoundbankResource>("getResources"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getVendor()"/> 
        /// </summary>
        public string Vendor
        {
            get { return IExecute<string>("getVendor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getVersion()"/> 
        /// </summary>
        public string Version
        {
            get { return IExecute<string>("getVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/Soundbank.html#getInstrument(javax.sound.midi.Patch)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Patch"/></param>
        /// <returns><see cref="Javax.Sound.Midi.Instrument"/></returns>
        public Javax.Sound.Midi.Instrument GetInstrument(Javax.Sound.Midi.Patch arg0)
        {
            return IExecute<Javax.Sound.Midi.Instrument>("getInstrument", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}