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

namespace Java.Awt.EventNs
{
    #region WindowEvent
    public partial class WindowEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#%3Cinit%3E(java.awt.Window,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public WindowEvent(Java.Awt.Window arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#%3Cinit%3E(java.awt.Window,int,java.awt.Window,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public WindowEvent(Java.Awt.Window arg0, int arg1, Java.Awt.Window arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#%3Cinit%3E(java.awt.Window,int,java.awt.Window)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Window"/></param>
        public WindowEvent(Java.Awt.Window arg0, int arg1, Java.Awt.Window arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#%3Cinit%3E(java.awt.Window,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public WindowEvent(Java.Awt.Window arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_ACTIVATED"/>
        /// </summary>
        public static int WINDOW_ACTIVATED => LocalClazz.GetField<int>("WINDOW_ACTIVATED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_CLOSED"/>
        /// </summary>
        public static int WINDOW_CLOSED => LocalClazz.GetField<int>("WINDOW_CLOSED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_CLOSING"/>
        /// </summary>
        public static int WINDOW_CLOSING => LocalClazz.GetField<int>("WINDOW_CLOSING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_DEACTIVATED"/>
        /// </summary>
        public static int WINDOW_DEACTIVATED => LocalClazz.GetField<int>("WINDOW_DEACTIVATED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_DEICONIFIED"/>
        /// </summary>
        public static int WINDOW_DEICONIFIED => LocalClazz.GetField<int>("WINDOW_DEICONIFIED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_FIRST"/>
        /// </summary>
        public static int WINDOW_FIRST => LocalClazz.GetField<int>("WINDOW_FIRST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_GAINED_FOCUS"/>
        /// </summary>
        public static int WINDOW_GAINED_FOCUS => LocalClazz.GetField<int>("WINDOW_GAINED_FOCUS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_ICONIFIED"/>
        /// </summary>
        public static int WINDOW_ICONIFIED => LocalClazz.GetField<int>("WINDOW_ICONIFIED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_LAST"/>
        /// </summary>
        public static int WINDOW_LAST => LocalClazz.GetField<int>("WINDOW_LAST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_LOST_FOCUS"/>
        /// </summary>
        public static int WINDOW_LOST_FOCUS => LocalClazz.GetField<int>("WINDOW_LOST_FOCUS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_OPENED"/>
        /// </summary>
        public static int WINDOW_OPENED => LocalClazz.GetField<int>("WINDOW_OPENED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_STATE_CHANGED"/>
        /// </summary>
        public static int WINDOW_STATE_CHANGED => LocalClazz.GetField<int>("WINDOW_STATE_CHANGED");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#getNewState()"/> 
        /// </summary>
        public int NewState
        {
            get { return IExecute<int>("getNewState"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#getOldState()"/> 
        /// </summary>
        public int OldState
        {
            get { return IExecute<int>("getOldState"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#getOppositeWindow()"/> 
        /// </summary>
        public Java.Awt.Window OppositeWindow
        {
            get { return IExecute<Java.Awt.Window>("getOppositeWindow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#getWindow()"/> 
        /// </summary>
        public Java.Awt.Window Window
        {
            get { return IExecute<Java.Awt.Window>("getWindow"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}