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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs
{
    #region IImageProducer
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IImageProducer
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageProducer.html#isConsumer(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsConsumer(Java.Awt.ImageNs.ImageConsumer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageProducer.html#addConsumer(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        void AddConsumer(Java.Awt.ImageNs.ImageConsumer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageProducer.html#removeConsumer(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        void RemoveConsumer(Java.Awt.ImageNs.ImageConsumer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageProducer.html#requestTopDownLeftRightResend(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        void RequestTopDownLeftRightResend(Java.Awt.ImageNs.ImageConsumer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageProducer.html#startProduction(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        void StartProduction(Java.Awt.ImageNs.ImageConsumer arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ImageProducer
    public partial class ImageProducer : Java.Awt.ImageNs.IImageProducer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageProducer.html#isConsumer(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsConsumer(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            return IExecute<bool>("isConsumer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageProducer.html#addConsumer(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        public void AddConsumer(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            IExecute("addConsumer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageProducer.html#removeConsumer(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        public void RemoveConsumer(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            IExecute("removeConsumer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageProducer.html#requestTopDownLeftRightResend(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        public void RequestTopDownLeftRightResend(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            IExecute("requestTopDownLeftRightResend", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageProducer.html#startProduction(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        public void StartProduction(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            IExecute("startProduction", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}