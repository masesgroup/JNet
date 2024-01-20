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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region ItemEvent
    public partial class ItemEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemEvent.html#%3Cinit%3E(java.awt.ItemSelectable,int,java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ItemSelectable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ItemEvent(Java.Awt.ItemSelectable arg0, int arg1, object arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemEvent.html#DESELECTED"/>
        /// </summary>
        public static int DESELECTED { get { return SGetField<int>(LocalBridgeClazz, "DESELECTED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemEvent.html#ITEM_FIRST"/>
        /// </summary>
        public static int ITEM_FIRST { get { return SGetField<int>(LocalBridgeClazz, "ITEM_FIRST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemEvent.html#ITEM_LAST"/>
        /// </summary>
        public static int ITEM_LAST { get { return SGetField<int>(LocalBridgeClazz, "ITEM_LAST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemEvent.html#ITEM_STATE_CHANGED"/>
        /// </summary>
        public static int ITEM_STATE_CHANGED { get { return SGetField<int>(LocalBridgeClazz, "ITEM_STATE_CHANGED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemEvent.html#SELECTED"/>
        /// </summary>
        public static int SELECTED { get { return SGetField<int>(LocalBridgeClazz, "SELECTED"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemEvent.html#getItem()"/> 
        /// </summary>
        public object Item
        {
            get { return IExecute("getItem"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemEvent.html#getItemSelectable()"/> 
        /// </summary>
        public Java.Awt.ItemSelectable ItemSelectable
        {
            get { return IExecute<Java.Awt.ItemSelectable>("getItemSelectable"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemEvent.html#getStateChange()"/> 
        /// </summary>
        public int StateChange
        {
            get { return IExecute<int>("getStateChange"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}