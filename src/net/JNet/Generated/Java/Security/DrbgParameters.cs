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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security
{
    #region DrbgParameters
    public partial class DrbgParameters
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.html#instantiation(int,java.security.DrbgParameters.Capability,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.DrbgParameters.Capability"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><see cref="Java.Security.DrbgParameters.Instantiation"/></returns>
        public static Java.Security.DrbgParameters.Instantiation InstantiationMethod(int arg0, Java.Security.DrbgParameters.Capability arg1, byte[] arg2)
        {
            return SExecute<Java.Security.DrbgParameters.Instantiation>(LocalBridgeClazz, "instantiation", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.html#nextBytes(int,boolean,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><see cref="Java.Security.DrbgParameters.NextBytes"/></returns>
        public static Java.Security.DrbgParameters.NextBytes NextBytesMethod(int arg0, bool arg1, byte[] arg2)
        {
            return SExecute<Java.Security.DrbgParameters.NextBytes>(LocalBridgeClazz, "nextBytes", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.html#reseed(boolean,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Java.Security.DrbgParameters.Reseed"/></returns>
        public static Java.Security.DrbgParameters.Reseed ReseedMethod(bool arg0, byte[] arg1)
        {
            return SExecute<Java.Security.DrbgParameters.Reseed>(LocalBridgeClazz, "reseed", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Capability
        public partial class Capability
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.Capability.html#NONE"/>
            /// </summary>
            public static Java.Security.DrbgParameters.Capability NONE { get { return SGetField<Java.Security.DrbgParameters.Capability>(LocalBridgeClazz, "NONE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.Capability.html#PR_AND_RESEED"/>
            /// </summary>
            public static Java.Security.DrbgParameters.Capability PR_AND_RESEED { get { return SGetField<Java.Security.DrbgParameters.Capability>(LocalBridgeClazz, "PR_AND_RESEED"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.Capability.html#RESEED_ONLY"/>
            /// </summary>
            public static Java.Security.DrbgParameters.Capability RESEED_ONLY { get { return SGetField<Java.Security.DrbgParameters.Capability>(LocalBridgeClazz, "RESEED_ONLY"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.Capability.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Security.DrbgParameters.Capability"/></returns>
            public static Java.Security.DrbgParameters.Capability ValueOf(string arg0)
            {
                return SExecute<Java.Security.DrbgParameters.Capability>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.Capability.html#values()"/>
            /// </summary>

            /// <returns><see cref="Java.Security.DrbgParameters.Capability"/></returns>
            public static Java.Security.DrbgParameters.Capability[] Values()
            {
                return SExecuteArray<Java.Security.DrbgParameters.Capability>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.Capability.html#supportsPredictionResistance()"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool SupportsPredictionResistance()
            {
                return IExecute<bool>("supportsPredictionResistance");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.Capability.html#supportsReseeding()"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool SupportsReseeding()
            {
                return IExecute<bool>("supportsReseeding");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Instantiation
        public partial class Instantiation
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.Instantiation.html#getCapability()"/> 
            /// </summary>
            public Java.Security.DrbgParameters.Capability GetCapability
            {
                get { return IExecute<Java.Security.DrbgParameters.Capability>("getCapability"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.Instantiation.html#getPersonalizationString()"/> 
            /// </summary>
            public byte[] PersonalizationString
            {
                get { return IExecuteArray<byte>("getPersonalizationString"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.Instantiation.html#getStrength()"/> 
            /// </summary>
            public int Strength
            {
                get { return IExecute<int>("getStrength"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region NextBytes
        public partial class NextBytes
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.NextBytes.html#getAdditionalInput()"/> 
            /// </summary>
            public byte[] AdditionalInput
            {
                get { return IExecuteArray<byte>("getAdditionalInput"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.NextBytes.html#getPredictionResistance()"/> 
            /// </summary>
            public bool PredictionResistance
            {
                get { return IExecute<bool>("getPredictionResistance"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.NextBytes.html#getStrength()"/> 
            /// </summary>
            public int Strength
            {
                get { return IExecute<int>("getStrength"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Reseed
        public partial class Reseed
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.Reseed.html#getAdditionalInput()"/> 
            /// </summary>
            public byte[] AdditionalInput
            {
                get { return IExecuteArray<byte>("getAdditionalInput"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/DrbgParameters.Reseed.html#getPredictionResistance()"/> 
            /// </summary>
            public bool PredictionResistance
            {
                get { return IExecute<bool>("getPredictionResistance"); }
            }

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