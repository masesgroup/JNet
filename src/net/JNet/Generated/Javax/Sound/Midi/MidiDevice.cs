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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Midi
{
    #region MidiDevice
    public partial class MidiDevice
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getDeviceInfo()"/> 
        /// </summary>
        public Javax.Sound.Midi.MidiDevice.Info DeviceInfo
        {
            get { return IExecute<Javax.Sound.Midi.MidiDevice.Info>("getDeviceInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#isOpen()"/> 
        /// </summary>
        public bool IsOpen
        {
            get { return IExecute<bool>("isOpen"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getMaxReceivers()"/> 
        /// </summary>
        public int MaxReceivers
        {
            get { return IExecute<int>("getMaxReceivers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getMaxTransmitters()"/> 
        /// </summary>
        public int MaxTransmitters
        {
            get { return IExecute<int>("getMaxTransmitters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getMicrosecondPosition()"/> 
        /// </summary>
        public long MicrosecondPosition
        {
            get { return IExecute<long>("getMicrosecondPosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getReceiver()"/> 
        /// </summary>
        public Javax.Sound.Midi.Receiver Receiver
        {
            get { return IExecute<Javax.Sound.Midi.Receiver>("getReceiver"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getReceivers()"/> 
        /// </summary>
        public Java.Util.List<Javax.Sound.Midi.Receiver> Receivers
        {
            get { return IExecute<Java.Util.List<Javax.Sound.Midi.Receiver>>("getReceivers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getTransmitter()"/> 
        /// </summary>
        public Javax.Sound.Midi.Transmitter Transmitter
        {
            get { return IExecute<Javax.Sound.Midi.Transmitter>("getTransmitter"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getTransmitters()"/> 
        /// </summary>
        public Java.Util.List<Javax.Sound.Midi.Transmitter> Transmitters
        {
            get { return IExecute<Java.Util.List<Javax.Sound.Midi.Transmitter>>("getTransmitters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#open()"/>
        /// </summary>
        
        /// <exception cref="Javax.Sound.Midi.MidiUnavailableException"/>
        public void Open()
        {
            IExecute("open");
        }
        
        #endregion

        #region Nested classes
        #region Info
        public partial class Info
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.Info.html#getDescription()"/> 
            /// </summary>
            public string Description
            {
                get { return IExecute<string>("getDescription"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.Info.html#getName()"/> 
            /// </summary>
            public string Name
            {
                get { return IExecute<string>("getName"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.Info.html#getVendor()"/> 
            /// </summary>
            public string Vendor
            {
                get { return IExecute<string>("getVendor"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.Info.html#getVersion()"/> 
            /// </summary>
            public string Version
            {
                get { return IExecute<string>("getVersion"); }
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}