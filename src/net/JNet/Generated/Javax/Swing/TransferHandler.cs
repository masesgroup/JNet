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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region TransferHandler
    public partial class TransferHandler
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public TransferHandler(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#COPY"/>
        /// </summary>
        public static int COPY { get { if (!_COPYReady) { _COPYContent = SGetField<int>(LocalBridgeClazz, "COPY"); _COPYReady = true; } return _COPYContent; } }
        private static int _COPYContent = default;
        private static bool _COPYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#COPY_OR_MOVE"/>
        /// </summary>
        public static int COPY_OR_MOVE { get { if (!_COPY_OR_MOVEReady) { _COPY_OR_MOVEContent = SGetField<int>(LocalBridgeClazz, "COPY_OR_MOVE"); _COPY_OR_MOVEReady = true; } return _COPY_OR_MOVEContent; } }
        private static int _COPY_OR_MOVEContent = default;
        private static bool _COPY_OR_MOVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#LINK"/>
        /// </summary>
        public static int LINK { get { if (!_LINKReady) { _LINKContent = SGetField<int>(LocalBridgeClazz, "LINK"); _LINKReady = true; } return _LINKContent; } }
        private static int _LINKContent = default;
        private static bool _LINKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#MOVE"/>
        /// </summary>
        public static int MOVE { get { if (!_MOVEReady) { _MOVEContent = SGetField<int>(LocalBridgeClazz, "MOVE"); _MOVEReady = true; } return _MOVEContent; } }
        private static int _MOVEContent = default;
        private static bool _MOVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#NONE"/>
        /// </summary>
        public static int NONE { get { if (!_NONEReady) { _NONEContent = SGetField<int>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
        private static int _NONEContent = default;
        private static bool _NONEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#getCopyAction()"/> 
        /// </summary>
        public static Javax.Swing.Action CopyAction
        {
            get { return SExecute<Javax.Swing.Action>(LocalBridgeClazz, "getCopyAction"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#getCutAction()"/> 
        /// </summary>
        public static Javax.Swing.Action CutAction
        {
            get { return SExecute<Javax.Swing.Action>(LocalBridgeClazz, "getCutAction"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#getPasteAction()"/> 
        /// </summary>
        public static Javax.Swing.Action PasteAction
        {
            get { return SExecute<Javax.Swing.Action>(LocalBridgeClazz, "getPasteAction"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#getDragImage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#setDragImage(java.awt.Image)"/>
        /// </summary>
        public Java.Awt.Image DragImage
        {
            get { return IExecute<Java.Awt.Image>("getDragImage"); } set { IExecute("setDragImage", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#getDragImageOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#setDragImageOffset(java.awt.Point)"/>
        /// </summary>
        public Java.Awt.Point DragImageOffset
        {
            get { return IExecute<Java.Awt.Point>("getDragImageOffset"); } set { IExecute("setDragImageOffset", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#canImport(javax.swing.JComponent,java.awt.datatransfer.DataFlavor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanImport(Javax.Swing.JComponent arg0, Java.Awt.Datatransfer.DataFlavor[] arg1)
        {
            return IExecute<bool>("canImport", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#canImport(javax.swing.TransferHandler.TransferSupport)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.TransferHandler.TransferSupport"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanImport(Javax.Swing.TransferHandler.TransferSupport arg0)
        {
            return IExecute<bool>("canImport", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#importData(javax.swing.JComponent,java.awt.datatransfer.Transferable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ImportData(Javax.Swing.JComponent arg0, Java.Awt.Datatransfer.Transferable arg1)
        {
            return IExecute<bool>("importData", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#importData(javax.swing.TransferHandler.TransferSupport)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.TransferHandler.TransferSupport"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ImportData(Javax.Swing.TransferHandler.TransferSupport arg0)
        {
            return IExecute<bool>("importData", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#getSourceActions(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSourceActions(Javax.Swing.JComponent arg0)
        {
            return IExecute<int>("getSourceActions", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#getVisualRepresentation(java.awt.datatransfer.Transferable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public Javax.Swing.Icon GetVisualRepresentation(Java.Awt.Datatransfer.Transferable arg0)
        {
            return IExecute<Javax.Swing.Icon>("getVisualRepresentation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#exportAsDrag(javax.swing.JComponent,java.awt.event.InputEvent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.EventNs.InputEvent"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void ExportAsDrag(Javax.Swing.JComponent arg0, Java.Awt.EventNs.InputEvent arg1, int arg2)
        {
            IExecute("exportAsDrag", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#exportToClipboard(javax.swing.JComponent,java.awt.datatransfer.Clipboard,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Datatransfer.Clipboard"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public void ExportToClipboard(Javax.Swing.JComponent arg0, Java.Awt.Datatransfer.Clipboard arg1, int arg2)
        {
            IExecute("exportToClipboard", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region DropLocation
        public partial class DropLocation
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.DropLocation.html#getDropPoint()"/> 
            /// </summary>
            public Java.Awt.Point DropPoint
            {
                get { return IExecute<Java.Awt.Point>("getDropPoint"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TransferSupport
        public partial class TransferSupport
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.TransferSupport.html#%3Cinit%3E(java.awt.Component,java.awt.datatransfer.Transferable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
            public TransferSupport(Java.Awt.Component arg0, Java.Awt.Datatransfer.Transferable arg1)
                : base(arg0, arg1)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.TransferSupport.html#getComponent()"/> 
            /// </summary>
            public Java.Awt.Component Component
            {
                get { return IExecute<Java.Awt.Component>("getComponent"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.TransferSupport.html#getDataFlavors()"/> 
            /// </summary>
            public Java.Awt.Datatransfer.DataFlavor[] DataFlavors
            {
                get { return IExecuteArray<Java.Awt.Datatransfer.DataFlavor>("getDataFlavors"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.TransferSupport.html#getDropAction()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.TransferSupport.html#setDropAction(int)"/>
            /// </summary>
            public int DropAction
            {
                get { return IExecute<int>("getDropAction"); } set { IExecute("setDropAction", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.TransferSupport.html#getDropLocation()"/> 
            /// </summary>
            public Javax.Swing.TransferHandler.DropLocation GetDropLocation
            {
                get { return IExecute<Javax.Swing.TransferHandler.DropLocation>("getDropLocation"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.TransferSupport.html#getSourceDropActions()"/> 
            /// </summary>
            public int SourceDropActions
            {
                get { return IExecute<int>("getSourceDropActions"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.TransferSupport.html#getTransferable()"/> 
            /// </summary>
            public Java.Awt.Datatransfer.Transferable Transferable
            {
                get { return IExecute<Java.Awt.Datatransfer.Transferable>("getTransferable"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.TransferSupport.html#getUserDropAction()"/> 
            /// </summary>
            public int UserDropAction
            {
                get { return IExecute<int>("getUserDropAction"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.TransferSupport.html#isDataFlavorSupported(java.awt.datatransfer.DataFlavor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsDataFlavorSupported(Java.Awt.Datatransfer.DataFlavor arg0)
            {
                return IExecute<bool>("isDataFlavorSupported", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.TransferSupport.html#isDrop()"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool IsDrop()
            {
                return IExecute<bool>("isDrop");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.TransferSupport.html#setShowDropLocation(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public void SetShowDropLocation(bool arg0)
            {
                IExecute("setShowDropLocation", arg0);
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