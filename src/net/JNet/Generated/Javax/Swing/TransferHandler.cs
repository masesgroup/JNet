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
        /// <summary>
        /// Converter from <see cref="Javax.Swing.TransferHandler"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.TransferHandler t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#COPY"/>
        /// </summary>
        public static int COPY => Clazz.GetField<int>("COPY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#COPY_OR_MOVE"/>
        /// </summary>
        public static int COPY_OR_MOVE => Clazz.GetField<int>("COPY_OR_MOVE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#LINK"/>
        /// </summary>
        public static int LINK => Clazz.GetField<int>("LINK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#MOVE"/>
        /// </summary>
        public static int MOVE => Clazz.GetField<int>("MOVE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#NONE"/>
        /// </summary>
        public static int NONE => Clazz.GetField<int>("NONE");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#getCopyAction()"/> 
        /// </summary>
        public static Javax.Swing.Action CopyAction
        {
            get { return SExecute<Javax.Swing.Action>("getCopyAction"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#getCutAction()"/> 
        /// </summary>
        public static Javax.Swing.Action CutAction
        {
            get { return SExecute<Javax.Swing.Action>("getCutAction"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.html#getPasteAction()"/> 
        /// </summary>
        public static Javax.Swing.Action PasteAction
        {
            get { return SExecute<Javax.Swing.Action>("getPasteAction"); }
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/TransferHandler.TransferSupport.html#getDropLocation()"/>
            /// </summary>
            
            /// <returns><see cref="Javax.Swing.TransferHandler.DropLocation"/></returns>
            public Javax.Swing.TransferHandler.DropLocation GetDropLocation()
            {
                return IExecute<Javax.Swing.TransferHandler.DropLocation>("getDropLocation");
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

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}