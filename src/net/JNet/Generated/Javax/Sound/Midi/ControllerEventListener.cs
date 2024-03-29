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

namespace Javax.Sound.Midi
{
    #region IControllerEventListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.sound.midi.ControllerEventListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ControllerEventListener.html"/>
    /// </summary>
    public partial interface IControllerEventListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ControllerEventListener.html#controlChange(javax.sound.midi.ShortMessage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.ShortMessage"/></param>
        void ControlChange(Javax.Sound.Midi.ShortMessage arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ControllerEventListener
    public partial class ControllerEventListener : Javax.Sound.Midi.IControllerEventListener
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
        /// Handlers initializer for <see cref="ControllerEventListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("controlChange", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Sound.Midi.ShortMessage>>>(ControlChangeEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ControllerEventListener.html#controlChange(javax.sound.midi.ShortMessage)"/>
        /// </summary>
        /// <remarks>If <see cref="OnControlChange"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Sound.Midi.ShortMessage> OnControlChange { get; set; } = null;

        void ControlChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Sound.Midi.ShortMessage>> data)
        {
            var methodToExecute = (OnControlChange != null) ? OnControlChange : ControlChange;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ControllerEventListener.html#controlChange(javax.sound.midi.ShortMessage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.ShortMessage"/></param>
        public virtual void ControlChange(Javax.Sound.Midi.ShortMessage arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}