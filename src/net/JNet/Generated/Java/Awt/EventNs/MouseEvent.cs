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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region MouseEvent
    public partial class MouseEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#%3Cinit%3E(java.awt.Component,int,long,int,int,int,int,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="bool"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        public MouseEvent(Java.Awt.Component arg0, int arg1, long arg2, int arg3, int arg4, int arg5, int arg6, bool arg7, int arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#%3Cinit%3E(java.awt.Component,int,long,int,int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="bool"/></param>
        public MouseEvent(Java.Awt.Component arg0, int arg1, long arg2, int arg3, int arg4, int arg5, int arg6, bool arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#%3Cinit%3E(java.awt.Component,int,long,int,int,int,int,int,int,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="bool"/></param>
        /// <param name="arg10"><see cref="int"/></param>
        public MouseEvent(Java.Awt.Component arg0, int arg1, long arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, bool arg9, int arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#BUTTON1"/>
        /// </summary>
        public static int BUTTON1 => Clazz.GetField<int>("BUTTON1");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#BUTTON2"/>
        /// </summary>
        public static int BUTTON2 => Clazz.GetField<int>("BUTTON2");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#BUTTON3"/>
        /// </summary>
        public static int BUTTON3 => Clazz.GetField<int>("BUTTON3");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_CLICKED"/>
        /// </summary>
        public static int MOUSE_CLICKED => Clazz.GetField<int>("MOUSE_CLICKED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_DRAGGED"/>
        /// </summary>
        public static int MOUSE_DRAGGED => Clazz.GetField<int>("MOUSE_DRAGGED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_ENTERED"/>
        /// </summary>
        public static int MOUSE_ENTERED => Clazz.GetField<int>("MOUSE_ENTERED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_EXITED"/>
        /// </summary>
        public static int MOUSE_EXITED => Clazz.GetField<int>("MOUSE_EXITED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_FIRST"/>
        /// </summary>
        public static int MOUSE_FIRST => Clazz.GetField<int>("MOUSE_FIRST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_LAST"/>
        /// </summary>
        public static int MOUSE_LAST => Clazz.GetField<int>("MOUSE_LAST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_MOVED"/>
        /// </summary>
        public static int MOUSE_MOVED => Clazz.GetField<int>("MOUSE_MOVED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_PRESSED"/>
        /// </summary>
        public static int MOUSE_PRESSED => Clazz.GetField<int>("MOUSE_PRESSED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_RELEASED"/>
        /// </summary>
        public static int MOUSE_RELEASED => Clazz.GetField<int>("MOUSE_RELEASED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_WHEEL"/>
        /// </summary>
        public static int MOUSE_WHEEL => Clazz.GetField<int>("MOUSE_WHEEL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#NOBUTTON"/>
        /// </summary>
        public static int NOBUTTON => Clazz.GetField<int>("NOBUTTON");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getMouseModifiersText(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="string"/></returns>
        public static string GetMouseModifiersText(int arg0)
        {
            return SExecute<string>("getMouseModifiersText", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getButton()"/> 
        /// </summary>
        public int Button
        {
            get { return IExecute<int>("getButton"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getClickCount()"/> 
        /// </summary>
        public int ClickCount
        {
            get { return IExecute<int>("getClickCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getLocationOnScreen()"/> 
        /// </summary>
        public Java.Awt.Point LocationOnScreen
        {
            get { return IExecute<Java.Awt.Point>("getLocationOnScreen"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getPoint()"/> 
        /// </summary>
        public Java.Awt.Point Point
        {
            get { return IExecute<Java.Awt.Point>("getPoint"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getX()"/> 
        /// </summary>
        public int X
        {
            get { return IExecute<int>("getX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getXOnScreen()"/> 
        /// </summary>
        public int XOnScreen
        {
            get { return IExecute<int>("getXOnScreen"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getY()"/> 
        /// </summary>
        public int Y
        {
            get { return IExecute<int>("getY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getYOnScreen()"/> 
        /// </summary>
        public int YOnScreen
        {
            get { return IExecute<int>("getYOnScreen"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#isPopupTrigger()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsPopupTrigger()
        {
            return IExecute<bool>("isPopupTrigger");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#translatePoint(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void TranslatePoint(int arg0, int arg1)
        {
            IExecute("translatePoint", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}