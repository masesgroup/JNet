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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region GraphicsConfigTemplate
    public partial class GraphicsConfigTemplate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.GraphicsConfigTemplate"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.GraphicsConfigTemplate t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfigTemplate.html#PREFERRED"/>
        /// </summary>
        public static int PREFERRED => Clazz.GetField<int>("PREFERRED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfigTemplate.html#REQUIRED"/>
        /// </summary>
        public static int REQUIRED => Clazz.GetField<int>("REQUIRED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfigTemplate.html#UNNECESSARY"/>
        /// </summary>
        public static int UNNECESSARY => Clazz.GetField<int>("UNNECESSARY");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfigTemplate.html#isGraphicsConfigSupported(java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsGraphicsConfigSupported(Java.Awt.GraphicsConfiguration arg0)
        {
            return IExecute<bool>("isGraphicsConfigSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfigTemplate.html#getBestConfiguration(java.awt.GraphicsConfiguration[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        /// <returns><see cref="Java.Awt.GraphicsConfiguration"/></returns>
        public Java.Awt.GraphicsConfiguration GetBestConfiguration(Java.Awt.GraphicsConfiguration[] arg0)
        {
            return IExecute<Java.Awt.GraphicsConfiguration>("getBestConfiguration", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}