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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.FontNs
{
    #region TransformAttribute
    public partial class TransformAttribute
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TransformAttribute.html#%3Cinit%3E(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public TransformAttribute(Java.Awt.Geom.AffineTransform arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TransformAttribute.html#IDENTITY"/>
        /// </summary>
        public static Java.Awt.FontNs.TransformAttribute IDENTITY { get { if (!_IDENTITYReady) { _IDENTITYContent = SGetField<Java.Awt.FontNs.TransformAttribute>(LocalBridgeClazz, "IDENTITY"); _IDENTITYReady = true; } return _IDENTITYContent; } }
        private static Java.Awt.FontNs.TransformAttribute _IDENTITYContent = default;
        private static bool _IDENTITYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TransformAttribute.html#getTransform()"/> 
        /// </summary>
        public Java.Awt.Geom.AffineTransform Transform
        {
            get { return IExecute<Java.Awt.Geom.AffineTransform>("getTransform"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/TransformAttribute.html#isIdentity()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsIdentity()
        {
            return IExecute<bool>("isIdentity");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}