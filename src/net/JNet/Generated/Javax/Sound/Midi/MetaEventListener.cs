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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Midi
{
    #region IMetaEventListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.sound.midi.MetaEventListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MetaEventListener.html"/>
    /// </summary>
    public partial interface IMetaEventListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MetaEventListener.html#meta(javax.sound.midi.MetaMessage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.MetaMessage"/></param>
        void Meta(Javax.Sound.Midi.MetaMessage arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MetaEventListener
    public partial class MetaEventListener : Javax.Sound.Midi.IMetaEventListener
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
        /// Handlers initializer for <see cref="MetaEventListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("meta", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Sound.Midi.MetaMessage>>>(MetaEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MetaEventListener.html#meta(javax.sound.midi.MetaMessage)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMeta"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Sound.Midi.MetaMessage> OnMeta { get; set; } = null;

        void MetaEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Sound.Midi.MetaMessage>> data)
        {
            var methodToExecute = (OnMeta != null) ? OnMeta : Meta;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/MetaEventListener.html#meta(javax.sound.midi.MetaMessage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.MetaMessage"/></param>
        public virtual void Meta(Javax.Sound.Midi.MetaMessage arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}