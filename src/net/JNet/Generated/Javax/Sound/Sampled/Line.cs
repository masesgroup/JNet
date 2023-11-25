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
    #region ILine
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILine : Java.Lang.IAutoCloseable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#getControls()"/> 
        /// </summary>
        Javax.Sound.Sampled.Control[] Controls { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#getLineInfo()"/> 
        /// </summary>
        Javax.Sound.Sampled.Line.Info LineInfo { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#isControlSupported(javax.sound.sampled.Control.Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Control.Type"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsControlSupported(Javax.Sound.Sampled.Control.Type arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#isOpen()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsOpen();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#getControl(javax.sound.sampled.Control.Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Control.Type"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Control"/></returns>
        Javax.Sound.Sampled.Control GetControl(Javax.Sound.Sampled.Control.Type arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#addLineListener(javax.sound.sampled.LineListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.LineListener"/></param>
        void AddLineListener(Javax.Sound.Sampled.LineListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#close()"/>
        /// </summary>
        void Close();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#open()"/>
        /// </summary>

        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        void Open();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#removeLineListener(javax.sound.sampled.LineListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.LineListener"/></param>
        void RemoveLineListener(Javax.Sound.Sampled.LineListener arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Line
    public partial class Line : Javax.Sound.Sampled.ILine
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#getControls()"/> 
        /// </summary>
        public Javax.Sound.Sampled.Control[] Controls
        {
            get { return IExecuteArray<Javax.Sound.Sampled.Control>("getControls"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#getLineInfo()"/> 
        /// </summary>
        public Javax.Sound.Sampled.Line.Info LineInfo
        {
            get { return IExecute<Javax.Sound.Sampled.Line.Info>("getLineInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#isControlSupported(javax.sound.sampled.Control.Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Control.Type"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsControlSupported(Javax.Sound.Sampled.Control.Type arg0)
        {
            return IExecute<bool>("isControlSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#isOpen()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsOpen()
        {
            return IExecute<bool>("isOpen");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#getControl(javax.sound.sampled.Control.Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Control.Type"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Control"/></returns>
        public Javax.Sound.Sampled.Control GetControl(Javax.Sound.Sampled.Control.Type arg0)
        {
            return IExecute<Javax.Sound.Sampled.Control>("getControl", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#addLineListener(javax.sound.sampled.LineListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.LineListener"/></param>
        public void AddLineListener(Javax.Sound.Sampled.LineListener arg0)
        {
            IExecute("addLineListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#open()"/>
        /// </summary>

        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        public void Open()
        {
            IExecute("open");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#removeLineListener(javax.sound.sampled.LineListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.LineListener"/></param>
        public void RemoveLineListener(Javax.Sound.Sampled.LineListener arg0)
        {
            IExecute("removeLineListener", arg0);
        }

        #endregion

        #region Nested classes
        #region Info
        public partial class Info
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.Info.html#%3Cinit%3E(java.lang.Class)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            public Info(Java.Lang.Class arg0)
                : base(arg0)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.Info.html#getLineClass()"/> 
            /// </summary>
            public Java.Lang.Class LineClass
            {
                get { return IExecute<Java.Lang.Class>("getLineClass"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.Info.html#matches(javax.sound.sampled.Line.Info)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool Matches(Javax.Sound.Sampled.Line.Info arg0)
            {
                return IExecute<bool>("matches", arg0);
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