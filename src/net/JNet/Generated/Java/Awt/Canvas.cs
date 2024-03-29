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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region Canvas
    public partial class Canvas
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Canvas.html#%3Cinit%3E(java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        public Canvas(Java.Awt.GraphicsConfiguration arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Canvas"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Java.Awt.Canvas t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Canvas.html#getBufferStrategy()"/> 
        /// </summary>
        public Java.Awt.ImageNs.BufferStrategy BufferStrategy
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.BufferStrategy>("getBufferStrategy", "()Ljava/awt/image/BufferStrategy;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Canvas.html#createBufferStrategy(int,java.awt.BufferCapabilities)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.BufferCapabilities"/></param>
        /// <exception cref="Java.Awt.AWTException"/>
        public void CreateBufferStrategy(int arg0, Java.Awt.BufferCapabilities arg1)
        {
            IExecute("createBufferStrategy", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Canvas.html#createBufferStrategy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void CreateBufferStrategy(int arg0)
        {
            IExecuteWithSignature("createBufferStrategy", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}