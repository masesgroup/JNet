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

namespace Javax.Imageio.Plugins.Jpeg
{
    #region JPEGImageReadParam
    public partial class JPEGImageReadParam
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGImageReadParam.html#getACHuffmanTables()"/> 
        /// </summary>
        public Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable[] ACHuffmanTables
        {
            get { return IExecuteArray<Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable>("getACHuffmanTables"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGImageReadParam.html#getDCHuffmanTables()"/> 
        /// </summary>
        public Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable[] DCHuffmanTables
        {
            get { return IExecuteArray<Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable>("getDCHuffmanTables"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGImageReadParam.html#getQTables()"/> 
        /// </summary>
        public Javax.Imageio.Plugins.Jpeg.JPEGQTable[] QTables
        {
            get { return IExecuteArray<Javax.Imageio.Plugins.Jpeg.JPEGQTable>("getQTables"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGImageReadParam.html#areTablesSet()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool AreTablesSet()
        {
            return IExecute<bool>("areTablesSet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGImageReadParam.html#setDecodeTables(javax.imageio.plugins.jpeg.JPEGQTable[],javax.imageio.plugins.jpeg.JPEGHuffmanTable[],javax.imageio.plugins.jpeg.JPEGHuffmanTable[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Plugins.Jpeg.JPEGQTable"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable"/></param>
        public void SetDecodeTables(Javax.Imageio.Plugins.Jpeg.JPEGQTable[] arg0, Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable[] arg1, Javax.Imageio.Plugins.Jpeg.JPEGHuffmanTable[] arg2)
        {
            IExecute("setDecodeTables", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/jpeg/JPEGImageReadParam.html#unsetDecodeTables()"/>
        /// </summary>
        public void UnsetDecodeTables()
        {
            IExecute("unsetDecodeTables");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}