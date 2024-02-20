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

namespace Javax.Imageio.Event
{
    #region IIIOReadWarningListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.imageio.event.IIOReadWarningListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadWarningListener.html"/>
    /// </summary>
    public partial interface IIIOReadWarningListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadWarningListener.html#warningOccurred(javax.imageio.ImageReader,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        void WarningOccurred(Javax.Imageio.ImageReader arg0, Java.Lang.String arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IIOReadWarningListener
    public partial class IIOReadWarningListener : Javax.Imageio.Event.IIIOReadWarningListener
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
        /// Handlers initializer for <see cref="IIOReadWarningListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("warningOccurred", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>>>(WarningOccurredEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadWarningListener.html#warningOccurred(javax.imageio.ImageReader,java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWarningOccurred"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Imageio.ImageReader, Java.Lang.String> OnWarningOccurred { get; set; } = null;

        void WarningOccurredEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>> data)
        {
            var methodToExecute = (OnWarningOccurred != null) ? OnWarningOccurred : WarningOccurred;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadWarningListener.html#warningOccurred(javax.imageio.ImageReader,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public virtual void WarningOccurred(Javax.Imageio.ImageReader arg0, Java.Lang.String arg1)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}