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

namespace Java.Awt.Datatransfer
{
    #region Clipboard
    public partial class Clipboard
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public Clipboard(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#getAvailableDataFlavors()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.DataFlavor[] AvailableDataFlavors
        {
            get { return IExecuteArray<Java.Awt.Datatransfer.DataFlavor>("getAvailableDataFlavors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#getFlavorListeners()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.FlavorListener[] FlavorListeners
        {
            get { return IExecuteArray<Java.Awt.Datatransfer.FlavorListener>("getFlavorListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#isDataFlavorAvailable(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDataFlavorAvailable(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return IExecute<bool>("isDataFlavorAvailable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#getData(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Awt.Datatransfer.UnsupportedFlavorException"/>
        /// <exception cref="Java.Io.IOException"/>
        public object GetData(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return IExecute("getData", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#getContents(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Awt.Datatransfer.Transferable"/></returns>
        public Java.Awt.Datatransfer.Transferable GetContents(object arg0)
        {
            return IExecute<Java.Awt.Datatransfer.Transferable>("getContents", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#addFlavorListener(java.awt.datatransfer.FlavorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.FlavorListener"/></param>
        public void AddFlavorListener(Java.Awt.Datatransfer.FlavorListener arg0)
        {
            IExecute("addFlavorListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#removeFlavorListener(java.awt.datatransfer.FlavorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.FlavorListener"/></param>
        public void RemoveFlavorListener(Java.Awt.Datatransfer.FlavorListener arg0)
        {
            IExecute("removeFlavorListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/Clipboard.html#setContents(java.awt.datatransfer.Transferable,java.awt.datatransfer.ClipboardOwner)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Datatransfer.ClipboardOwner"/></param>
        public void SetContents(Java.Awt.Datatransfer.Transferable arg0, Java.Awt.Datatransfer.ClipboardOwner arg1)
        {
            IExecute("setContents", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}