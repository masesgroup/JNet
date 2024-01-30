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

namespace Javax.Sound.Midi.Spi
{
    #region MidiFileWriter
    public partial class MidiFileWriter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiFileWriter.html#getMidiFileTypes()"/> 
        /// </summary>
        public int[] MidiFileTypes
        {
            get { return IExecuteArray<int>("getMidiFileTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiFileWriter.html#write(javax.sound.midi.Sequence,int,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Sequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Write(Javax.Sound.Midi.Sequence arg0, int arg1, Java.Io.File arg2)
        {
            return IExecute<int>("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiFileWriter.html#write(javax.sound.midi.Sequence,int,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Sequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Io.OutputStream"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Write(Javax.Sound.Midi.Sequence arg0, int arg1, Java.Io.OutputStream arg2)
        {
            return IExecute<int>("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiFileWriter.html#getMidiFileTypes(javax.sound.midi.Sequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.Sequence"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetMidiFileTypes(Javax.Sound.Midi.Sequence arg0)
        {
            return IExecuteArray<int>("getMidiFileTypes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiFileWriter.html#isFileTypeSupported(int,javax.sound.midi.Sequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Midi.Sequence"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsFileTypeSupported(int arg0, Javax.Sound.Midi.Sequence arg1)
        {
            return IExecute<bool>("isFileTypeSupported", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/spi/MidiFileWriter.html#isFileTypeSupported(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsFileTypeSupported(int arg0)
        {
            return IExecute<bool>("isFileTypeSupported", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}