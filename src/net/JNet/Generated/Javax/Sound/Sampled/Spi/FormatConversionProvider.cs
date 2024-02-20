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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Sampled.Spi
{
    #region FormatConversionProvider
    public partial class FormatConversionProvider
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/FormatConversionProvider.html#getSourceEncodings()"/> 
        /// </summary>
        public Javax.Sound.Sampled.AudioFormat.Encoding[] SourceEncodings
        {
            get { return IExecuteArray<Javax.Sound.Sampled.AudioFormat.Encoding>("getSourceEncodings"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/FormatConversionProvider.html#getTargetEncodings()"/> 
        /// </summary>
        public Javax.Sound.Sampled.AudioFormat.Encoding[] TargetEncodings
        {
            get { return IExecuteArray<Javax.Sound.Sampled.AudioFormat.Encoding>("getTargetEncodings"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/FormatConversionProvider.html#getTargetFormats(javax.sound.sampled.AudioFormat.Encoding,javax.sound.sampled.AudioFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFormat"/></returns>
        public Javax.Sound.Sampled.AudioFormat[] GetTargetFormats(Javax.Sound.Sampled.AudioFormat.Encoding arg0, Javax.Sound.Sampled.AudioFormat arg1)
        {
            return IExecuteArray<Javax.Sound.Sampled.AudioFormat>("getTargetFormats", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/FormatConversionProvider.html#getTargetEncodings(javax.sound.sampled.AudioFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></returns>
        public Javax.Sound.Sampled.AudioFormat.Encoding[] GetTargetEncodings(Javax.Sound.Sampled.AudioFormat arg0)
        {
            return IExecuteArray<Javax.Sound.Sampled.AudioFormat.Encoding>("getTargetEncodings", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/FormatConversionProvider.html#getAudioInputStream(javax.sound.sampled.AudioFormat,javax.sound.sampled.AudioInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioInputStream"/></returns>
        public Javax.Sound.Sampled.AudioInputStream GetAudioInputStream(Javax.Sound.Sampled.AudioFormat arg0, Javax.Sound.Sampled.AudioInputStream arg1)
        {
            return IExecute<Javax.Sound.Sampled.AudioInputStream>("getAudioInputStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/FormatConversionProvider.html#getAudioInputStream(javax.sound.sampled.AudioFormat.Encoding,javax.sound.sampled.AudioInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioInputStream"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.AudioInputStream"/></returns>
        public Javax.Sound.Sampled.AudioInputStream GetAudioInputStream(Javax.Sound.Sampled.AudioFormat.Encoding arg0, Javax.Sound.Sampled.AudioInputStream arg1)
        {
            return IExecute<Javax.Sound.Sampled.AudioInputStream>("getAudioInputStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/FormatConversionProvider.html#isConversionSupported(javax.sound.sampled.AudioFormat,javax.sound.sampled.AudioFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsConversionSupported(Javax.Sound.Sampled.AudioFormat arg0, Javax.Sound.Sampled.AudioFormat arg1)
        {
            return IExecute<bool>("isConversionSupported", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/FormatConversionProvider.html#isConversionSupported(javax.sound.sampled.AudioFormat.Encoding,javax.sound.sampled.AudioFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></param>
        /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsConversionSupported(Javax.Sound.Sampled.AudioFormat.Encoding arg0, Javax.Sound.Sampled.AudioFormat arg1)
        {
            return IExecute<bool>("isConversionSupported", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/FormatConversionProvider.html#isSourceEncodingSupported(javax.sound.sampled.AudioFormat.Encoding)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSourceEncodingSupported(Javax.Sound.Sampled.AudioFormat.Encoding arg0)
        {
            return IExecute<bool>("isSourceEncodingSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/spi/FormatConversionProvider.html#isTargetEncodingSupported(javax.sound.sampled.AudioFormat.Encoding)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsTargetEncodingSupported(Javax.Sound.Sampled.AudioFormat.Encoding arg0)
        {
            return IExecute<bool>("isTargetEncodingSupported", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}