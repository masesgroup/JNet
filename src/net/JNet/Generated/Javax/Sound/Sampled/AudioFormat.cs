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

namespace Javax.Sound.Sampled
{
    #region AudioFormat
    public partial class AudioFormat
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#%3Cinit%3E(float,int,int,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        public AudioFormat(float arg0, int arg1, int arg2, bool arg3, bool arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#%3Cinit%3E(javax.sound.sampled.AudioFormat.Encoding,float,int,int,int,float,boolean,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <param name="arg7"><see cref="Java.Util.Map"/></param>
        public AudioFormat(Javax.Sound.Sampled.AudioFormat.Encoding arg0, float arg1, int arg2, int arg3, int arg4, float arg5, bool arg6, Java.Util.Map arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#%3Cinit%3E(javax.sound.sampled.AudioFormat.Encoding,float,int,int,int,float,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat.Encoding"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        public AudioFormat(Javax.Sound.Sampled.AudioFormat.Encoding arg0, float arg1, int arg2, int arg3, int arg4, float arg5, bool arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#getChannels()"/> 
        /// </summary>
        public int Channels
        {
            get { return IExecute<int>("getChannels"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#getFrameRate()"/> 
        /// </summary>
        public float FrameRate
        {
            get { return IExecute<float>("getFrameRate"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#getFrameSize()"/> 
        /// </summary>
        public int FrameSize
        {
            get { return IExecute<int>("getFrameSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#getEncoding()"/> 
        /// </summary>
        public Javax.Sound.Sampled.AudioFormat.Encoding GetEncoding
        {
            get { return IExecute<Javax.Sound.Sampled.AudioFormat.Encoding>("getEncoding"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#isBigEndian()"/> 
        /// </summary>
        public bool IsBigEndian
        {
            get { return IExecute<bool>("isBigEndian"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#properties()"/> 
        /// </summary>
        public Java.Util.Map<string, object> Properties
        {
            get { return IExecute<Java.Util.Map<string, object>>("properties"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#getSampleRate()"/> 
        /// </summary>
        public float SampleRate
        {
            get { return IExecute<float>("getSampleRate"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#getSampleSizeInBits()"/> 
        /// </summary>
        public int SampleSizeInBits
        {
            get { return IExecute<int>("getSampleSizeInBits"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#matches(javax.sound.sampled.AudioFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Matches(Javax.Sound.Sampled.AudioFormat arg0)
        {
            return IExecute<bool>("matches", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }
        
        #endregion

        #region Nested classes
        #region Encoding
        public partial class Encoding
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.Encoding.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            public Encoding(string arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.Encoding.html#ALAW"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFormat.Encoding ALAW { get { return LocalClazz.GetField<Javax.Sound.Sampled.AudioFormat.Encoding>("ALAW"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.Encoding.html#PCM_FLOAT"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFormat.Encoding PCM_FLOAT { get { return LocalClazz.GetField<Javax.Sound.Sampled.AudioFormat.Encoding>("PCM_FLOAT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.Encoding.html#PCM_SIGNED"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFormat.Encoding PCM_SIGNED { get { return LocalClazz.GetField<Javax.Sound.Sampled.AudioFormat.Encoding>("PCM_SIGNED"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.Encoding.html#PCM_UNSIGNED"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFormat.Encoding PCM_UNSIGNED { get { return LocalClazz.GetField<Javax.Sound.Sampled.AudioFormat.Encoding>("PCM_UNSIGNED"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/AudioFormat.Encoding.html#ULAW"/>
            /// </summary>
            public static Javax.Sound.Sampled.AudioFormat.Encoding ULAW { get { return LocalClazz.GetField<Javax.Sound.Sampled.AudioFormat.Encoding>("ULAW"); } }
            
            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}