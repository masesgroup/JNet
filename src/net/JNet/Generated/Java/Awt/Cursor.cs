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
    #region Cursor
    public partial class Cursor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Cursor(int arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Cursor"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.Cursor t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#CROSSHAIR_CURSOR"/>
        /// </summary>
        public static int CROSSHAIR_CURSOR => Clazz.GetField<int>("CROSSHAIR_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#CUSTOM_CURSOR"/>
        /// </summary>
        public static int CUSTOM_CURSOR => Clazz.GetField<int>("CUSTOM_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#DEFAULT_CURSOR"/>
        /// </summary>
        public static int DEFAULT_CURSOR => Clazz.GetField<int>("DEFAULT_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#E_RESIZE_CURSOR"/>
        /// </summary>
        public static int E_RESIZE_CURSOR => Clazz.GetField<int>("E_RESIZE_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#HAND_CURSOR"/>
        /// </summary>
        public static int HAND_CURSOR => Clazz.GetField<int>("HAND_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#MOVE_CURSOR"/>
        /// </summary>
        public static int MOVE_CURSOR => Clazz.GetField<int>("MOVE_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#N_RESIZE_CURSOR"/>
        /// </summary>
        public static int N_RESIZE_CURSOR => Clazz.GetField<int>("N_RESIZE_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#NE_RESIZE_CURSOR"/>
        /// </summary>
        public static int NE_RESIZE_CURSOR => Clazz.GetField<int>("NE_RESIZE_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#NW_RESIZE_CURSOR"/>
        /// </summary>
        public static int NW_RESIZE_CURSOR => Clazz.GetField<int>("NW_RESIZE_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#S_RESIZE_CURSOR"/>
        /// </summary>
        public static int S_RESIZE_CURSOR => Clazz.GetField<int>("S_RESIZE_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#SE_RESIZE_CURSOR"/>
        /// </summary>
        public static int SE_RESIZE_CURSOR => Clazz.GetField<int>("SE_RESIZE_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#SW_RESIZE_CURSOR"/>
        /// </summary>
        public static int SW_RESIZE_CURSOR => Clazz.GetField<int>("SW_RESIZE_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#TEXT_CURSOR"/>
        /// </summary>
        public static int TEXT_CURSOR => Clazz.GetField<int>("TEXT_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#W_RESIZE_CURSOR"/>
        /// </summary>
        public static int W_RESIZE_CURSOR => Clazz.GetField<int>("W_RESIZE_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#WAIT_CURSOR"/>
        /// </summary>
        public static int WAIT_CURSOR => Clazz.GetField<int>("WAIT_CURSOR");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#getDefaultCursor()"/> 
        /// </summary>
        public static Java.Awt.Cursor DefaultCursor
        {
            get { return SExecute<Java.Awt.Cursor>("getDefaultCursor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#getPredefinedCursor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Cursor"/></returns>
        public static Java.Awt.Cursor GetPredefinedCursor(int arg0)
        {
            return SExecute<Java.Awt.Cursor>("getPredefinedCursor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#getSystemCustomCursor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Awt.Cursor"/></returns>
        /// <exception cref="Java.Awt.AWTException"/>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static Java.Awt.Cursor GetSystemCustomCursor(string arg0)
        {
            return SExecute<Java.Awt.Cursor>("getSystemCustomCursor", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Cursor.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecute<int>("getType"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}