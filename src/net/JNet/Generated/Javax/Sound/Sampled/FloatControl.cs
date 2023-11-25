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

namespace Javax.Sound.Sampled
{
    #region FloatControl
    public partial class FloatControl
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getMaximum()"/> 
        /// </summary>
        public float Maximum
        {
            get { return IExecute<float>("getMaximum"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getMaxLabel()"/> 
        /// </summary>
        public string MaxLabel
        {
            get { return IExecute<string>("getMaxLabel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getMidLabel()"/> 
        /// </summary>
        public string MidLabel
        {
            get { return IExecute<string>("getMidLabel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getMinimum()"/> 
        /// </summary>
        public float Minimum
        {
            get { return IExecute<float>("getMinimum"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getMinLabel()"/> 
        /// </summary>
        public string MinLabel
        {
            get { return IExecute<string>("getMinLabel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getPrecision()"/> 
        /// </summary>
        public float Precision
        {
            get { return IExecute<float>("getPrecision"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getUnits()"/> 
        /// </summary>
        public string Units
        {
            get { return IExecute<string>("getUnits"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getUpdatePeriod()"/> 
        /// </summary>
        public int UpdatePeriod
        {
            get { return IExecute<int>("getUpdatePeriod"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#setValue(float)"/>
        /// </summary>
        public float Value
        {
            get { return IExecute<float>("getValue"); } set { IExecute("setValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#shift(float,float,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void Shift(float arg0, float arg1, int arg2)
        {
            IExecute("shift", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region Type
        public partial class Type
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#AUX_RETURN"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type AUX_RETURN { get { return SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "AUX_RETURN"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#AUX_SEND"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type AUX_SEND { get { return SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "AUX_SEND"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#BALANCE"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type BALANCE { get { return SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "BALANCE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#MASTER_GAIN"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type MASTER_GAIN { get { return SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "MASTER_GAIN"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#PAN"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type PAN { get { return SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "PAN"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#REVERB_RETURN"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type REVERB_RETURN { get { return SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "REVERB_RETURN"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#REVERB_SEND"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type REVERB_SEND { get { return SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "REVERB_SEND"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#SAMPLE_RATE"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type SAMPLE_RATE { get { return SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "SAMPLE_RATE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#VOLUME"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type VOLUME { get { return SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "VOLUME"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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