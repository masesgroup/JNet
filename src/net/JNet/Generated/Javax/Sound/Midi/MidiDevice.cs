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

namespace Javax.Sound.Midi
{
    #region IMidiDevice
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMidiDevice : Java.Lang.IAutoCloseable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getDeviceInfo()"/> 
        /// </summary>
        Javax.Sound.Midi.MidiDevice.Info DeviceInfo { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getMaxReceivers()"/> 
        /// </summary>
        int MaxReceivers { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getMaxTransmitters()"/> 
        /// </summary>
        int MaxTransmitters { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getMicrosecondPosition()"/> 
        /// </summary>
        long MicrosecondPosition { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getReceiver()"/> 
        /// </summary>
        Javax.Sound.Midi.Receiver Receiver { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getReceivers()"/> 
        /// </summary>
        Java.Util.List<Javax.Sound.Midi.Receiver> Receivers { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getTransmitter()"/> 
        /// </summary>
        Javax.Sound.Midi.Transmitter Transmitter { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getTransmitters()"/> 
        /// </summary>
        Java.Util.List<Javax.Sound.Midi.Transmitter> Transmitters { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#isOpen()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsOpen();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#close()"/>
        /// </summary>
        void Close();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#open()"/>
        /// </summary>

        /// <exception cref="Javax.Sound.Midi.MidiUnavailableException"/>
        void Open();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MidiDevice
    public partial class MidiDevice : Javax.Sound.Midi.IMidiDevice
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
            get { return IExecuteWithSignature<Javax.Sound.Midi.MidiDevice.Info>("getDeviceInfo", "()Ljavax/sound/midi/MidiDevice$Info;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getMaxReceivers()"/> 
        /// </summary>
        public int MaxReceivers
        {
            get { return IExecuteWithSignature<int>("getMaxReceivers", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getMaxTransmitters()"/> 
        /// </summary>
        public int MaxTransmitters
        {
            get { return IExecuteWithSignature<int>("getMaxTransmitters", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getMicrosecondPosition()"/> 
        /// </summary>
        public long MicrosecondPosition
        {
            get { return IExecuteWithSignature<long>("getMicrosecondPosition", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getReceiver()"/> 
        /// </summary>
        public Javax.Sound.Midi.Receiver Receiver
        {
            get { return IExecuteWithSignature<Javax.Sound.Midi.Receiver>("getReceiver", "()Ljavax/sound/midi/Receiver;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getReceivers()"/> 
        /// </summary>
        public Java.Util.List<Javax.Sound.Midi.Receiver> Receivers
        {
            get { return IExecuteWithSignature<Java.Util.List<Javax.Sound.Midi.Receiver>>("getReceivers", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getTransmitter()"/> 
        /// </summary>
        public Javax.Sound.Midi.Transmitter Transmitter
        {
            get { return IExecuteWithSignature<Javax.Sound.Midi.Transmitter>("getTransmitter", "()Ljavax/sound/midi/Transmitter;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#getTransmitters()"/> 
        /// </summary>
        public Java.Util.List<Javax.Sound.Midi.Transmitter> Transmitters
        {
            get { return IExecuteWithSignature<Java.Util.List<Javax.Sound.Midi.Transmitter>>("getTransmitters", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#isOpen()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsOpen()
        {
            return IExecuteWithSignature<bool>("isOpen", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.html#open()"/>
        /// </summary>

        /// <exception cref="Javax.Sound.Midi.MidiUnavailableException"/>
        public void Open()
        {
            IExecuteWithSignature("open", "()V");
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
            public Java.Lang.String Description
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.Info.html#getName()"/> 
            /// </summary>
            public Java.Lang.String Name
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.Info.html#getVendor()"/> 
            /// </summary>
            public Java.Lang.String Vendor
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getVendor", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MidiDevice.Info.html#getVersion()"/> 
            /// </summary>
            public Java.Lang.String Version
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getVersion", "()Ljava/lang/String;"); }
            }

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