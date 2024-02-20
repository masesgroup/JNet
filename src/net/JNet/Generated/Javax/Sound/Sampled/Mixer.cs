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

namespace Javax.Sound.Sampled
{
    #region IMixer
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMixer : Javax.Sound.Sampled.ILine
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getMixerInfo()"/> 
        /// </summary>
        Javax.Sound.Sampled.Mixer.Info MixerInfo { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getSourceLineInfo()"/> 
        /// </summary>
        Javax.Sound.Sampled.Line.Info[] SourceLineInfo { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getSourceLines()"/> 
        /// </summary>
        Javax.Sound.Sampled.Line[] SourceLines { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getTargetLineInfo()"/> 
        /// </summary>
        Javax.Sound.Sampled.Line.Info[] TargetLineInfo { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getTargetLines()"/> 
        /// </summary>
        Javax.Sound.Sampled.Line[] TargetLines { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#isLineSupported(javax.sound.sampled.Line.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsLineSupported(Javax.Sound.Sampled.Line.Info arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#isSynchronizationSupported(javax.sound.sampled.Line[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsSynchronizationSupported(Javax.Sound.Sampled.Line[] arg0, bool arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getMaxLines(javax.sound.sampled.Line.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
        /// <returns><see cref="int"/></returns>
        int GetMaxLines(Javax.Sound.Sampled.Line.Info arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getLine(javax.sound.sampled.Line.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Line"/></returns>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        Javax.Sound.Sampled.Line GetLine(Javax.Sound.Sampled.Line.Info arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getSourceLineInfo(javax.sound.sampled.Line.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Line.Info"/></returns>
        Javax.Sound.Sampled.Line.Info[] GetSourceLineInfo(Javax.Sound.Sampled.Line.Info arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getTargetLineInfo(javax.sound.sampled.Line.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Line.Info"/></returns>
        Javax.Sound.Sampled.Line.Info[] GetTargetLineInfo(Javax.Sound.Sampled.Line.Info arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#synchronize(javax.sound.sampled.Line[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        void Synchronize(Javax.Sound.Sampled.Line[] arg0, bool arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#unsynchronize(javax.sound.sampled.Line[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line"/></param>
        void Unsynchronize(Javax.Sound.Sampled.Line[] arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Mixer
    public partial class Mixer : Javax.Sound.Sampled.IMixer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getMixerInfo()"/> 
        /// </summary>
        public Javax.Sound.Sampled.Mixer.Info MixerInfo
        {
            get { return IExecute<Javax.Sound.Sampled.Mixer.Info>("getMixerInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getSourceLineInfo()"/> 
        /// </summary>
        public Javax.Sound.Sampled.Line.Info[] SourceLineInfo
        {
            get { return IExecuteArray<Javax.Sound.Sampled.Line.Info>("getSourceLineInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getSourceLines()"/> 
        /// </summary>
        public Javax.Sound.Sampled.Line[] SourceLines
        {
            get { return IExecuteArray<Javax.Sound.Sampled.Line>("getSourceLines"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getTargetLineInfo()"/> 
        /// </summary>
        public Javax.Sound.Sampled.Line.Info[] TargetLineInfo
        {
            get { return IExecuteArray<Javax.Sound.Sampled.Line.Info>("getTargetLineInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getTargetLines()"/> 
        /// </summary>
        public Javax.Sound.Sampled.Line[] TargetLines
        {
            get { return IExecuteArray<Javax.Sound.Sampled.Line>("getTargetLines"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#isLineSupported(javax.sound.sampled.Line.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsLineSupported(Javax.Sound.Sampled.Line.Info arg0)
        {
            return IExecute<bool>("isLineSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#isSynchronizationSupported(javax.sound.sampled.Line[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSynchronizationSupported(Javax.Sound.Sampled.Line[] arg0, bool arg1)
        {
            return IExecute<bool>("isSynchronizationSupported", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getMaxLines(javax.sound.sampled.Line.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetMaxLines(Javax.Sound.Sampled.Line.Info arg0)
        {
            return IExecute<int>("getMaxLines", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getLine(javax.sound.sampled.Line.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Line"/></returns>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        public Javax.Sound.Sampled.Line GetLine(Javax.Sound.Sampled.Line.Info arg0)
        {
            return IExecute<Javax.Sound.Sampled.Line>("getLine", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getSourceLineInfo(javax.sound.sampled.Line.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Line.Info"/></returns>
        public Javax.Sound.Sampled.Line.Info[] GetSourceLineInfo(Javax.Sound.Sampled.Line.Info arg0)
        {
            return IExecuteArray<Javax.Sound.Sampled.Line.Info>("getSourceLineInfo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#getTargetLineInfo(javax.sound.sampled.Line.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Line.Info"/></returns>
        public Javax.Sound.Sampled.Line.Info[] GetTargetLineInfo(Javax.Sound.Sampled.Line.Info arg0)
        {
            return IExecuteArray<Javax.Sound.Sampled.Line.Info>("getTargetLineInfo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#synchronize(javax.sound.sampled.Line[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Synchronize(Javax.Sound.Sampled.Line[] arg0, bool arg1)
        {
            IExecute("synchronize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.html#unsynchronize(javax.sound.sampled.Line[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line"/></param>
        public void Unsynchronize(Javax.Sound.Sampled.Line[] arg0)
        {
            IExecute("unsynchronize", new object[] { arg0 });
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.Info.html#getDescription()"/> 
            /// </summary>
            public Java.Lang.String Description
            {
                get { return IExecute<Java.Lang.String>("getDescription"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.Info.html#getName()"/> 
            /// </summary>
            public Java.Lang.String Name
            {
                get { return IExecute<Java.Lang.String>("getName"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.Info.html#getVendor()"/> 
            /// </summary>
            public Java.Lang.String Vendor
            {
                get { return IExecute<Java.Lang.String>("getVendor"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Mixer.Info.html#getVersion()"/> 
            /// </summary>
            public Java.Lang.String Version
            {
                get { return IExecute<Java.Lang.String>("getVersion"); }
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