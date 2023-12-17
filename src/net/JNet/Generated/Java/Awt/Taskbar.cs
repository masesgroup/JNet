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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region Taskbar
    public partial class Taskbar
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#getTaskbar()"/> 
        /// </summary>
        public static Java.Awt.Taskbar GetTaskbar
        {
            get { return SExecute<Java.Awt.Taskbar>(LocalBridgeClazz, "getTaskbar"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#isTaskbarSupported()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public static bool IsTaskbarSupported()
        {
            return SExecute<bool>(LocalBridgeClazz, "isTaskbarSupported");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#getIconImage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#setIconImage(java.awt.Image)"/>
        /// </summary>
        public Java.Awt.Image IconImage
        {
            get { return IExecute<Java.Awt.Image>("getIconImage"); } set { IExecute("setIconImage", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#getMenu()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#setMenu(java.awt.PopupMenu)"/>
        /// </summary>
        public Java.Awt.PopupMenu Menu
        {
            get { return IExecute<Java.Awt.PopupMenu>("getMenu"); } set { IExecute("setMenu", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#isSupported(java.awt.Taskbar.Feature)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Taskbar.Feature"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Awt.Taskbar.Feature arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#requestUserAttention(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void RequestUserAttention(bool arg0, bool arg1)
        {
            IExecute("requestUserAttention", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#requestWindowUserAttention(java.awt.Window)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        public void RequestWindowUserAttention(Java.Awt.Window arg0)
        {
            IExecute("requestWindowUserAttention", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#setIconBadge(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void SetIconBadge(string arg0)
        {
            IExecute("setIconBadge", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#setProgressValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetProgressValue(int arg0)
        {
            IExecute("setProgressValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#setWindowIconBadge(java.awt.Window,java.awt.Image)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Image"/></param>
        public void SetWindowIconBadge(Java.Awt.Window arg0, Java.Awt.Image arg1)
        {
            IExecute("setWindowIconBadge", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#setWindowProgressState(java.awt.Window,java.awt.Taskbar.State)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Taskbar.State"/></param>
        public void SetWindowProgressState(Java.Awt.Window arg0, Java.Awt.Taskbar.State arg1)
        {
            IExecute("setWindowProgressState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.html#setWindowProgressValue(java.awt.Window,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetWindowProgressValue(Java.Awt.Window arg0, int arg1)
        {
            IExecute("setWindowProgressValue", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Feature
        public partial class Feature
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#ICON_BADGE_IMAGE_WINDOW"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature ICON_BADGE_IMAGE_WINDOW { get { return SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "ICON_BADGE_IMAGE_WINDOW"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#ICON_BADGE_NUMBER"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature ICON_BADGE_NUMBER { get { return SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "ICON_BADGE_NUMBER"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#ICON_BADGE_TEXT"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature ICON_BADGE_TEXT { get { return SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "ICON_BADGE_TEXT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#ICON_IMAGE"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature ICON_IMAGE { get { return SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "ICON_IMAGE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#MENU"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature MENU { get { return SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "MENU"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#PROGRESS_STATE_WINDOW"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature PROGRESS_STATE_WINDOW { get { return SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "PROGRESS_STATE_WINDOW"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#PROGRESS_VALUE"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature PROGRESS_VALUE { get { return SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "PROGRESS_VALUE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#PROGRESS_VALUE_WINDOW"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature PROGRESS_VALUE_WINDOW { get { return SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "PROGRESS_VALUE_WINDOW"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#USER_ATTENTION"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature USER_ATTENTION { get { return SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "USER_ATTENTION"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#USER_ATTENTION_WINDOW"/>
            /// </summary>
            public static Java.Awt.Taskbar.Feature USER_ATTENTION_WINDOW { get { return SGetField<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "USER_ATTENTION_WINDOW"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Awt.Taskbar.Feature"/></returns>
            public static Java.Awt.Taskbar.Feature ValueOf(string arg0)
            {
                return SExecute<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.Feature.html#values()"/>
            /// </summary>

            /// <returns><see cref="Java.Awt.Taskbar.Feature"/></returns>
            public static Java.Awt.Taskbar.Feature[] Values()
            {
                return SExecuteArray<Java.Awt.Taskbar.Feature>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region State
        public partial class State
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.State.html#ERROR"/>
            /// </summary>
            public static Java.Awt.Taskbar.State ERROR { get { return SGetField<Java.Awt.Taskbar.State>(LocalBridgeClazz, "ERROR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.State.html#INDETERMINATE"/>
            /// </summary>
            public static Java.Awt.Taskbar.State INDETERMINATE { get { return SGetField<Java.Awt.Taskbar.State>(LocalBridgeClazz, "INDETERMINATE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.State.html#NORMAL"/>
            /// </summary>
            public static Java.Awt.Taskbar.State NORMAL { get { return SGetField<Java.Awt.Taskbar.State>(LocalBridgeClazz, "NORMAL"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.State.html#OFF"/>
            /// </summary>
            public static Java.Awt.Taskbar.State OFF { get { return SGetField<Java.Awt.Taskbar.State>(LocalBridgeClazz, "OFF"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.State.html#PAUSED"/>
            /// </summary>
            public static Java.Awt.Taskbar.State PAUSED { get { return SGetField<Java.Awt.Taskbar.State>(LocalBridgeClazz, "PAUSED"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.State.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Awt.Taskbar.State"/></returns>
            public static Java.Awt.Taskbar.State ValueOf(string arg0)
            {
                return SExecute<Java.Awt.Taskbar.State>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Taskbar.State.html#values()"/>
            /// </summary>

            /// <returns><see cref="Java.Awt.Taskbar.State"/></returns>
            public static Java.Awt.Taskbar.State[] Values()
            {
                return SExecuteArray<Java.Awt.Taskbar.State>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

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