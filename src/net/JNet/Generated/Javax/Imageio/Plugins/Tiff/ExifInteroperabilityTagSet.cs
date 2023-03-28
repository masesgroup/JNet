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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Plugins.Tiff
{
    #region ExifInteroperabilityTagSet
    public partial class ExifInteroperabilityTagSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifInteroperabilityTagSet.html#TAG_INTEROPERABILITY_INDEX"/>
        /// </summary>
        public static int TAG_INTEROPERABILITY_INDEX => Clazz.GetField<int>("TAG_INTEROPERABILITY_INDEX");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifInteroperabilityTagSet.html#INTEROPERABILITY_INDEX_R98"/>
        /// </summary>
        public static string INTEROPERABILITY_INDEX_R98 => Clazz.GetField<string>("INTEROPERABILITY_INDEX_R98");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifInteroperabilityTagSet.html#INTEROPERABILITY_INDEX_THM"/>
        /// </summary>
        public static string INTEROPERABILITY_INDEX_THM => Clazz.GetField<string>("INTEROPERABILITY_INDEX_THM");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/ExifInteroperabilityTagSet.html#getInstance()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Imageio.Plugins.Tiff.ExifInteroperabilityTagSet"/></returns>
        public static Javax.Imageio.Plugins.Tiff.ExifInteroperabilityTagSet GetInstance()
        {
            return SExecute<Javax.Imageio.Plugins.Tiff.ExifInteroperabilityTagSet>("getInstance");
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}