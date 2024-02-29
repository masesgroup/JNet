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

namespace Java.Awt.ImageNs
{
    #region BufferStrategy
    public partial class BufferStrategy
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferStrategy.html#getCapabilities()"/> 
        /// </summary>
        public Java.Awt.BufferCapabilities Capabilities
        {
            get { return IExecuteWithSignature<Java.Awt.BufferCapabilities>("getCapabilities", "()Ljava/awt/BufferCapabilities;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferStrategy.html#getDrawGraphics()"/> 
        /// </summary>
        public Java.Awt.Graphics DrawGraphics
        {
            get { return IExecuteWithSignature<Java.Awt.Graphics>("getDrawGraphics", "()Ljava/awt/Graphics;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferStrategy.html#contentsLost()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool ContentsLost()
        {
            return IExecuteWithSignature<bool>("contentsLost", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferStrategy.html#contentsRestored()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool ContentsRestored()
        {
            return IExecuteWithSignature<bool>("contentsRestored", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferStrategy.html#show()"/>
        /// </summary>
        public void Show()
        {
            IExecuteWithSignature("show", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferStrategy.html#dispose()"/>
        /// </summary>
        public new void Dispose()
        {
            IExecuteWithSignature("dispose", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}