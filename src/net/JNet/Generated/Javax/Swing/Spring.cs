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

namespace Javax.Swing
{
    #region Spring
    public partial class Spring
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#UNSET"/>
        /// </summary>
        public static int UNSET { get { if (!_UNSETReady) { _UNSETContent = SGetField<int>(LocalBridgeClazz, "UNSET"); _UNSETReady = true; } return _UNSETContent; } }
        private static int _UNSETContent = default;
        private static bool _UNSETReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#constant(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Constant(int arg0, int arg1, int arg2)
        {
            return SExecute<Javax.Swing.Spring>(LocalBridgeClazz, "constant", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#constant(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Constant(int arg0)
        {
            return SExecuteWithSignature<Javax.Swing.Spring>(LocalBridgeClazz, "constant", "(I)Ljavax/swing/Spring;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#height(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Height(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<Javax.Swing.Spring>(LocalBridgeClazz, "height", "(Ljava/awt/Component;)Ljavax/swing/Spring;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#max(javax.swing.Spring,javax.swing.Spring)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Spring"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Spring"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Max(Javax.Swing.Spring arg0, Javax.Swing.Spring arg1)
        {
            return SExecute<Javax.Swing.Spring>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#minus(javax.swing.Spring)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Spring"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Minus(Javax.Swing.Spring arg0)
        {
            return SExecuteWithSignature<Javax.Swing.Spring>(LocalBridgeClazz, "minus", "(Ljavax/swing/Spring;)Ljavax/swing/Spring;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#scale(javax.swing.Spring,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Spring"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Scale(Javax.Swing.Spring arg0, float arg1)
        {
            return SExecute<Javax.Swing.Spring>(LocalBridgeClazz, "scale", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#sum(javax.swing.Spring,javax.swing.Spring)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Spring"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Spring"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Sum(Javax.Swing.Spring arg0, Javax.Swing.Spring arg1)
        {
            return SExecute<Javax.Swing.Spring>(LocalBridgeClazz, "sum", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#width(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public static Javax.Swing.Spring Width(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<Javax.Swing.Spring>(LocalBridgeClazz, "width", "(Ljava/awt/Component;)Ljavax/swing/Spring;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#getMaximumValue()"/> 
        /// </summary>
        public int MaximumValue
        {
            get { return IExecuteWithSignature<int>("getMaximumValue", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#getMinimumValue()"/> 
        /// </summary>
        public int MinimumValue
        {
            get { return IExecuteWithSignature<int>("getMinimumValue", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#getPreferredValue()"/> 
        /// </summary>
        public int PreferredValue
        {
            get { return IExecuteWithSignature<int>("getPreferredValue", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Spring.html#setValue(int)"/>
        /// </summary>
        public int Value
        {
            get { return IExecuteWithSignature<int>("getValue", "()I"); } set { IExecuteWithSignature("setValue", "(I)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}