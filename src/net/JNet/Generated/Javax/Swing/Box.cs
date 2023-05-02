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

namespace Javax.Swing
{
    #region Box
    public partial class Box
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Box(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Box"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.Box t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createGlue()"/> 
        /// </summary>
        public static Java.Awt.Component CreateGlue
        {
            get { return SExecute<Java.Awt.Component>(LocalBridgeClazz, "createGlue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createHorizontalBox()"/> 
        /// </summary>
        public static Javax.Swing.Box CreateHorizontalBox
        {
            get { return SExecute<Javax.Swing.Box>(LocalBridgeClazz, "createHorizontalBox"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createHorizontalGlue()"/> 
        /// </summary>
        public static Java.Awt.Component CreateHorizontalGlue
        {
            get { return SExecute<Java.Awt.Component>(LocalBridgeClazz, "createHorizontalGlue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createVerticalBox()"/> 
        /// </summary>
        public static Javax.Swing.Box CreateVerticalBox
        {
            get { return SExecute<Javax.Swing.Box>(LocalBridgeClazz, "createVerticalBox"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createVerticalGlue()"/> 
        /// </summary>
        public static Java.Awt.Component CreateVerticalGlue
        {
            get { return SExecute<Java.Awt.Component>(LocalBridgeClazz, "createVerticalGlue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createHorizontalStrut(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public static Java.Awt.Component CreateHorizontalStrut(int arg0)
        {
            return SExecute<Java.Awt.Component>(LocalBridgeClazz, "createHorizontalStrut", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createRigidArea(java.awt.Dimension)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dimension"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public static Java.Awt.Component CreateRigidArea(Java.Awt.Dimension arg0)
        {
            return SExecute<Java.Awt.Component>(LocalBridgeClazz, "createRigidArea", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createVerticalStrut(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public static Java.Awt.Component CreateVerticalStrut(int arg0)
        {
            return SExecute<Java.Awt.Component>(LocalBridgeClazz, "createVerticalStrut", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Filler
        public partial class Filler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.Filler.html#%3Cinit%3E(java.awt.Dimension,java.awt.Dimension,java.awt.Dimension)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Dimension"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Dimension"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Dimension"/></param>
            public Filler(Java.Awt.Dimension arg0, Java.Awt.Dimension arg1, Java.Awt.Dimension arg2)
                : base(arg0, arg1, arg2)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Box.Filler"/> to <see cref="Javax.Accessibility.Accessible"/>
            /// </summary>
            public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.Box.Filler t) => t.Cast<Javax.Accessibility.Accessible>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.Filler.html#changeShape(java.awt.Dimension,java.awt.Dimension,java.awt.Dimension)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Dimension"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Dimension"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Dimension"/></param>
            public void ChangeShape(Java.Awt.Dimension arg0, Java.Awt.Dimension arg1, Java.Awt.Dimension arg2)
            {
                IExecute("changeShape", arg0, arg1, arg2);
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