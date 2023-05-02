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

namespace Java.Awt.FontNs
{
    #region GlyphJustificationInfo
    public partial class GlyphJustificationInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#%3Cinit%3E(float,boolean,int,float,float,boolean,int,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="float"/></param>
        /// <param name="arg8"><see cref="float"/></param>
        public GlyphJustificationInfo(float arg0, bool arg1, int arg2, float arg3, float arg4, bool arg5, int arg6, float arg7, float arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#growAbsorb"/>
        /// </summary>
        public bool growAbsorb { get { return IGetField<bool>("growAbsorb"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#shrinkAbsorb"/>
        /// </summary>
        public bool shrinkAbsorb { get { return IGetField<bool>("shrinkAbsorb"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#growLeftLimit"/>
        /// </summary>
        public float growLeftLimit { get { return IGetField<float>("growLeftLimit"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#growRightLimit"/>
        /// </summary>
        public float growRightLimit { get { return IGetField<float>("growRightLimit"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#shrinkLeftLimit"/>
        /// </summary>
        public float shrinkLeftLimit { get { return IGetField<float>("shrinkLeftLimit"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#shrinkRightLimit"/>
        /// </summary>
        public float shrinkRightLimit { get { return IGetField<float>("shrinkRightLimit"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#weight"/>
        /// </summary>
        public float weight { get { return IGetField<float>("weight"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#growPriority"/>
        /// </summary>
        public int growPriority { get { return IGetField<int>("growPriority"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#shrinkPriority"/>
        /// </summary>
        public int shrinkPriority { get { return IGetField<int>("shrinkPriority"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#PRIORITY_INTERCHAR"/>
        /// </summary>
        public static int PRIORITY_INTERCHAR { get { return SGetField<int>(LocalBridgeClazz, "PRIORITY_INTERCHAR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#PRIORITY_KASHIDA"/>
        /// </summary>
        public static int PRIORITY_KASHIDA { get { return SGetField<int>(LocalBridgeClazz, "PRIORITY_KASHIDA"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#PRIORITY_NONE"/>
        /// </summary>
        public static int PRIORITY_NONE { get { return SGetField<int>(LocalBridgeClazz, "PRIORITY_NONE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphJustificationInfo.html#PRIORITY_WHITESPACE"/>
        /// </summary>
        public static int PRIORITY_WHITESPACE { get { return SGetField<int>(LocalBridgeClazz, "PRIORITY_WHITESPACE"); } }

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
}