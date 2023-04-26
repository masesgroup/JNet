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

namespace Javax.Smartcardio
{
    #region CardTerminals
    public partial class CardTerminals
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.html#waitForChange(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public bool WaitForChange(long arg0)
        {
            return IExecute<bool>("waitForChange", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.html#list(javax.smartcardio.CardTerminals.State)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Smartcardio.CardTerminals.State"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public Java.Util.List<Javax.Smartcardio.CardTerminal> List(Javax.Smartcardio.CardTerminals.State arg0)
        {
            return IExecute<Java.Util.List<Javax.Smartcardio.CardTerminal>>("list", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.html#list()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public Java.Util.List<Javax.Smartcardio.CardTerminal> List()
        {
            return IExecute<Java.Util.List<Javax.Smartcardio.CardTerminal>>("list");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.html#getTerminal(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Smartcardio.CardTerminal"/></returns>
        public Javax.Smartcardio.CardTerminal GetTerminal(string arg0)
        {
            return IExecute<Javax.Smartcardio.CardTerminal>("getTerminal", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.html#waitForChange()"/>
        /// </summary>
        
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public void WaitForChange()
        {
            IExecute("waitForChange");
        }
        
        #endregion

        #region Nested classes
        #region State
        public partial class State
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html#ALL"/>
            /// </summary>
            public static Javax.Smartcardio.CardTerminals.State ALL => LocalClazz.GetField<Javax.Smartcardio.CardTerminals.State>("ALL");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html#CARD_ABSENT"/>
            /// </summary>
            public static Javax.Smartcardio.CardTerminals.State CARD_ABSENT => LocalClazz.GetField<Javax.Smartcardio.CardTerminals.State>("CARD_ABSENT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html#CARD_INSERTION"/>
            /// </summary>
            public static Javax.Smartcardio.CardTerminals.State CARD_INSERTION => LocalClazz.GetField<Javax.Smartcardio.CardTerminals.State>("CARD_INSERTION");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html#CARD_PRESENT"/>
            /// </summary>
            public static Javax.Smartcardio.CardTerminals.State CARD_PRESENT => LocalClazz.GetField<Javax.Smartcardio.CardTerminals.State>("CARD_PRESENT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html#CARD_REMOVAL"/>
            /// </summary>
            public static Javax.Smartcardio.CardTerminals.State CARD_REMOVAL => LocalClazz.GetField<Javax.Smartcardio.CardTerminals.State>("CARD_REMOVAL");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html#values()"/> 
            /// </summary>
            public static Javax.Smartcardio.CardTerminals.State[] Values
            {
                get { return SExecuteArray<Javax.Smartcardio.CardTerminals.State>(LocalClazz, "values"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Smartcardio.CardTerminals.State"/></returns>
            public static Javax.Smartcardio.CardTerminals.State ValueOf(string arg0)
            {
                return SExecute<Javax.Smartcardio.CardTerminals.State>(LocalClazz, "valueOf", arg0);
            }
            
            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}