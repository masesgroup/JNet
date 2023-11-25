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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Sampled
{
    #region IDataLine
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDataLine : Javax.Sound.Sampled.ILine
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#getBufferSize()"/> 
        /// </summary>
        int BufferSize { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#getFormat()"/> 
        /// </summary>
        Javax.Sound.Sampled.AudioFormat Format { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#getFramePosition()"/> 
        /// </summary>
        int FramePosition { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#getLevel()"/> 
        /// </summary>
        float Level { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#getLongFramePosition()"/> 
        /// </summary>
        long LongFramePosition { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#getMicrosecondPosition()"/> 
        /// </summary>
        long MicrosecondPosition { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#isActive()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsActive();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#isRunning()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsRunning();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#available()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        int Available();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#drain()"/>
        /// </summary>
        void Drain();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#flush()"/>
        /// </summary>
        void Flush();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#start()"/>
        /// </summary>
        void Start();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#stop()"/>
        /// </summary>
        void Stop();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DataLine
    public partial class DataLine : Javax.Sound.Sampled.IDataLine
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#getBufferSize()"/> 
        /// </summary>
        public int BufferSize
        {
            get { return IExecute<int>("getBufferSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#getFormat()"/> 
        /// </summary>
        public Javax.Sound.Sampled.AudioFormat Format
        {
            get { return IExecute<Javax.Sound.Sampled.AudioFormat>("getFormat"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#getFramePosition()"/> 
        /// </summary>
        public int FramePosition
        {
            get { return IExecute<int>("getFramePosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#getLevel()"/> 
        /// </summary>
        public float Level
        {
            get { return IExecute<float>("getLevel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#getLongFramePosition()"/> 
        /// </summary>
        public long LongFramePosition
        {
            get { return IExecute<long>("getLongFramePosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#getMicrosecondPosition()"/> 
        /// </summary>
        public long MicrosecondPosition
        {
            get { return IExecute<long>("getMicrosecondPosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#isActive()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsActive()
        {
            return IExecute<bool>("isActive");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#isRunning()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsRunning()
        {
            return IExecute<bool>("isRunning");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#available()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Available()
        {
            return IExecute<int>("available");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#drain()"/>
        /// </summary>
        public void Drain()
        {
            IExecute("drain");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecute("flush");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecute("start");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.html#stop()"/>
        /// </summary>
        public void Stop()
        {
            IExecute("stop");
        }

        #endregion

        #region Nested classes
        #region Info
        public partial class Info
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.Info.html#%3Cinit%3E(java.lang.Class,javax.sound.sampled.AudioFormat,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public Info(Java.Lang.Class arg0, Javax.Sound.Sampled.AudioFormat arg1, int arg2)
                : base(arg0, arg1, arg2)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.Info.html#%3Cinit%3E(java.lang.Class,javax.sound.sampled.AudioFormat)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
            public Info(Java.Lang.Class arg0, Javax.Sound.Sampled.AudioFormat arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.Info.html#%3Cinit%3E(java.lang.Class,javax.sound.sampled.AudioFormat[],int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            /// <param name="arg1"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public Info(Java.Lang.Class arg0, Javax.Sound.Sampled.AudioFormat[] arg1, int arg2, int arg3)
                : base(arg0, arg1, arg2, arg3)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.Info.html#getFormats()"/> 
            /// </summary>
            public Javax.Sound.Sampled.AudioFormat[] Formats
            {
                get { return IExecuteArray<Javax.Sound.Sampled.AudioFormat>("getFormats"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.Info.html#getMaxBufferSize()"/> 
            /// </summary>
            public int MaxBufferSize
            {
                get { return IExecute<int>("getMaxBufferSize"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.Info.html#getMinBufferSize()"/> 
            /// </summary>
            public int MinBufferSize
            {
                get { return IExecute<int>("getMinBufferSize"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/DataLine.Info.html#isFormatSupported(javax.sound.sampled.AudioFormat)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Sound.Sampled.AudioFormat"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsFormatSupported(Javax.Sound.Sampled.AudioFormat arg0)
            {
                return IExecute<bool>("isFormatSupported", arg0);
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