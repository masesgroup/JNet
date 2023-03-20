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

namespace Java.Awt
{
    #region AWTEvent
    public partial class AWTEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#%3Cinit%3E(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public AWTEvent(object arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#RESERVED_ID_MAX"/>
        /// </summary>
        public static int RESERVED_ID_MAX => Clazz.GetField<int>("RESERVED_ID_MAX");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#ACTION_EVENT_MASK"/>
        /// </summary>
        public static long ACTION_EVENT_MASK => Clazz.GetField<long>("ACTION_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#ADJUSTMENT_EVENT_MASK"/>
        /// </summary>
        public static long ADJUSTMENT_EVENT_MASK => Clazz.GetField<long>("ADJUSTMENT_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#COMPONENT_EVENT_MASK"/>
        /// </summary>
        public static long COMPONENT_EVENT_MASK => Clazz.GetField<long>("COMPONENT_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#CONTAINER_EVENT_MASK"/>
        /// </summary>
        public static long CONTAINER_EVENT_MASK => Clazz.GetField<long>("CONTAINER_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#FOCUS_EVENT_MASK"/>
        /// </summary>
        public static long FOCUS_EVENT_MASK => Clazz.GetField<long>("FOCUS_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#HIERARCHY_BOUNDS_EVENT_MASK"/>
        /// </summary>
        public static long HIERARCHY_BOUNDS_EVENT_MASK => Clazz.GetField<long>("HIERARCHY_BOUNDS_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#HIERARCHY_EVENT_MASK"/>
        /// </summary>
        public static long HIERARCHY_EVENT_MASK => Clazz.GetField<long>("HIERARCHY_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#INPUT_METHOD_EVENT_MASK"/>
        /// </summary>
        public static long INPUT_METHOD_EVENT_MASK => Clazz.GetField<long>("INPUT_METHOD_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#INVOCATION_EVENT_MASK"/>
        /// </summary>
        public static long INVOCATION_EVENT_MASK => Clazz.GetField<long>("INVOCATION_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#ITEM_EVENT_MASK"/>
        /// </summary>
        public static long ITEM_EVENT_MASK => Clazz.GetField<long>("ITEM_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#KEY_EVENT_MASK"/>
        /// </summary>
        public static long KEY_EVENT_MASK => Clazz.GetField<long>("KEY_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#MOUSE_EVENT_MASK"/>
        /// </summary>
        public static long MOUSE_EVENT_MASK => Clazz.GetField<long>("MOUSE_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#MOUSE_MOTION_EVENT_MASK"/>
        /// </summary>
        public static long MOUSE_MOTION_EVENT_MASK => Clazz.GetField<long>("MOUSE_MOTION_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#MOUSE_WHEEL_EVENT_MASK"/>
        /// </summary>
        public static long MOUSE_WHEEL_EVENT_MASK => Clazz.GetField<long>("MOUSE_WHEEL_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#PAINT_EVENT_MASK"/>
        /// </summary>
        public static long PAINT_EVENT_MASK => Clazz.GetField<long>("PAINT_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#TEXT_EVENT_MASK"/>
        /// </summary>
        public static long TEXT_EVENT_MASK => Clazz.GetField<long>("TEXT_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#WINDOW_EVENT_MASK"/>
        /// </summary>
        public static long WINDOW_EVENT_MASK => Clazz.GetField<long>("WINDOW_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#WINDOW_FOCUS_EVENT_MASK"/>
        /// </summary>
        public static long WINDOW_FOCUS_EVENT_MASK => Clazz.GetField<long>("WINDOW_FOCUS_EVENT_MASK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#WINDOW_STATE_EVENT_MASK"/>
        /// </summary>
        public static long WINDOW_STATE_EVENT_MASK => Clazz.GetField<long>("WINDOW_STATE_EVENT_MASK");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#getID()"/> 
        /// </summary>
        public int ID
        {
            get { return IExecute<int>("getID"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#paramString()"/>
        /// </summary>
        
        /// <returns><see cref="string"/></returns>
        public string ParamString()
        {
            return IExecute<string>("paramString");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#setSource(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetSource(object arg0)
        {
            IExecute("setSource", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}