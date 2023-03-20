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
    #region AWTKeyStroke
    public partial class AWTKeyStroke
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.AWTKeyStroke"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.AWTKeyStroke t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTKeyStroke.html#getAWTKeyStroke(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Awt.AWTKeyStroke"/></returns>
        public static Java.Awt.AWTKeyStroke GetAWTKeyStroke(char arg0)
        {
            return SExecute<Java.Awt.AWTKeyStroke>("getAWTKeyStroke", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTKeyStroke.html#getAWTKeyStroke(int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Awt.AWTKeyStroke"/></returns>
        public static Java.Awt.AWTKeyStroke GetAWTKeyStroke(int arg0, int arg1, bool arg2)
        {
            return SExecute<Java.Awt.AWTKeyStroke>("getAWTKeyStroke", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTKeyStroke.html#getAWTKeyStroke(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.AWTKeyStroke"/></returns>
        public static Java.Awt.AWTKeyStroke GetAWTKeyStroke(int arg0, int arg1)
        {
            return SExecute<Java.Awt.AWTKeyStroke>("getAWTKeyStroke", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTKeyStroke.html#getAWTKeyStroke(java.lang.Character,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.AWTKeyStroke"/></returns>
        public static Java.Awt.AWTKeyStroke GetAWTKeyStroke(char? arg0, int arg1)
        {
            return SExecute<Java.Awt.AWTKeyStroke>("getAWTKeyStroke", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTKeyStroke.html#getAWTKeyStroke(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Awt.AWTKeyStroke"/></returns>
        public static Java.Awt.AWTKeyStroke GetAWTKeyStroke(string arg0)
        {
            return SExecute<Java.Awt.AWTKeyStroke>("getAWTKeyStroke", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTKeyStroke.html#getAWTKeyStrokeForEvent(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        /// <returns><see cref="Java.Awt.AWTKeyStroke"/></returns>
        public static Java.Awt.AWTKeyStroke GetAWTKeyStrokeForEvent(Java.Awt.EventNs.KeyEvent arg0)
        {
            return SExecute<Java.Awt.AWTKeyStroke>("getAWTKeyStrokeForEvent", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTKeyStroke.html#getKeyChar()"/> 
        /// </summary>
        public char KeyChar
        {
            get { return IExecute<char>("getKeyChar"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTKeyStroke.html#getKeyCode()"/> 
        /// </summary>
        public int KeyCode
        {
            get { return IExecute<int>("getKeyCode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTKeyStroke.html#getKeyEventType()"/> 
        /// </summary>
        public int KeyEventType
        {
            get { return IExecute<int>("getKeyEventType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTKeyStroke.html#getModifiers()"/> 
        /// </summary>
        public int Modifiers
        {
            get { return IExecute<int>("getModifiers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTKeyStroke.html#isOnKeyRelease()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsOnKeyRelease()
        {
            return IExecute<bool>("isOnKeyRelease");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}