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

namespace Javax.Swing.Plaf.Basic
{
    #region BasicFileChooserUI
    public partial class BasicFileChooserUI
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#<init>(javax.swing.JFileChooser)
        /// </summary>
        public BasicFileChooserUI(Javax.Swing.JFileChooser arg0)
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getAccessoryPanel() 
        /// </summary>
        public Javax.Swing.JPanel AccessoryPanel
        {
            get { return IExecute<Javax.Swing.JPanel>("getAccessoryPanel"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getDirectoryName() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#setDirectoryName(java.lang.String)
        /// </summary>
        public string DirectoryName
        {
            get { return IExecute<string>("getDirectoryName"); } set { IExecute("setDirectoryName", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getFileChooser() 
        /// </summary>
        public Javax.Swing.JFileChooser FileChooser
        {
            get { return IExecute<Javax.Swing.JFileChooser>("getFileChooser"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getFileName() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#setFileName(java.lang.String)
        /// </summary>
        public string FileName
        {
            get { return IExecute<string>("getFileName"); } set { IExecute("setFileName", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getApproveButtonMnemonic(javax.swing.JFileChooser)
        /// </summary>
        public int GetApproveButtonMnemonic(Javax.Swing.JFileChooser arg0)
        {
            return IExecute<int>("getApproveButtonMnemonic", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#createPropertyChangeListener(javax.swing.JFileChooser)
        /// </summary>
        public Java.Beans.PropertyChangeListener CreatePropertyChangeListener(Javax.Swing.JFileChooser arg0)
        {
            return IExecute<Java.Beans.PropertyChangeListener>("createPropertyChangeListener", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getApproveButtonToolTipText(javax.swing.JFileChooser)
        /// </summary>
        public string GetApproveButtonToolTipText(Javax.Swing.JFileChooser arg0)
        {
            return IExecute<string>("getApproveButtonToolTipText", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getApproveSelectionAction()
        /// </summary>
        public Javax.Swing.Action GetApproveSelectionAction()
        {
            return IExecute<Javax.Swing.Action>("getApproveSelectionAction");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getCancelSelectionAction()
        /// </summary>
        public Javax.Swing.Action GetCancelSelectionAction()
        {
            return IExecute<Javax.Swing.Action>("getCancelSelectionAction");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getChangeToParentDirectoryAction()
        /// </summary>
        public Javax.Swing.Action GetChangeToParentDirectoryAction()
        {
            return IExecute<Javax.Swing.Action>("getChangeToParentDirectoryAction");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getGoHomeAction()
        /// </summary>
        public Javax.Swing.Action GetGoHomeAction()
        {
            return IExecute<Javax.Swing.Action>("getGoHomeAction");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getNewFolderAction()
        /// </summary>
        public Javax.Swing.Action GetNewFolderAction()
        {
            return IExecute<Javax.Swing.Action>("getNewFolderAction");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getUpdateAction()
        /// </summary>
        public Javax.Swing.Action GetUpdateAction()
        {
            return IExecute<Javax.Swing.Action>("getUpdateAction");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#createListSelectionListener(javax.swing.JFileChooser)
        /// </summary>
        public Javax.Swing.Event.ListSelectionListener CreateListSelectionListener(Javax.Swing.JFileChooser arg0)
        {
            return IExecute<Javax.Swing.Event.ListSelectionListener>("createListSelectionListener", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#clearIconCache()
        /// </summary>
        public void ClearIconCache()
        {
            IExecute("clearIconCache");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#installComponents(javax.swing.JFileChooser)
        /// </summary>
        public void InstallComponents(Javax.Swing.JFileChooser arg0)
        {
            IExecute("installComponents", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#uninstallComponents(javax.swing.JFileChooser)
        /// </summary>
        public void UninstallComponents(Javax.Swing.JFileChooser arg0)
        {
            IExecute("uninstallComponents", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}