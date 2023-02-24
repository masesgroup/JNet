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

namespace Javax.Swing.Filechooser
{
    #region FileSystemView
    public partial class FileSystemView
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#getFileSystemView()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Swing.Filechooser.FileSystemView"/></returns>
        public static Javax.Swing.Filechooser.FileSystemView GetFileSystemView()
        {
            return SExecute<Javax.Swing.Filechooser.FileSystemView>("getFileSystemView");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#getChooserComboBoxFiles()"/> 
        /// </summary>
        public Java.Io.File[] ChooserComboBoxFiles
        {
            get { return IExecuteArray<Java.Io.File>("getChooserComboBoxFiles"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#getDefaultDirectory()"/> 
        /// </summary>
        public Java.Io.File DefaultDirectory
        {
            get { return IExecute<Java.Io.File>("getDefaultDirectory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#getHomeDirectory()"/> 
        /// </summary>
        public Java.Io.File HomeDirectory
        {
            get { return IExecute<Java.Io.File>("getHomeDirectory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#getRoots()"/> 
        /// </summary>
        public Java.Io.File[] Roots
        {
            get { return IExecuteArray<Java.Io.File>("getRoots"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#createNewFolder(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.File CreateNewFolder(Java.Io.File arg0)
        {
            return IExecute<Java.Io.File>("createNewFolder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#isComputerNode(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsComputerNode(Java.Io.File arg0)
        {
            return IExecute<bool>("isComputerNode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#isDrive(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsDrive(Java.Io.File arg0)
        {
            return IExecute<bool>("isDrive", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#isFileSystem(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsFileSystem(Java.Io.File arg0)
        {
            return IExecute<bool>("isFileSystem", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#isFileSystemRoot(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsFileSystemRoot(Java.Io.File arg0)
        {
            return IExecute<bool>("isFileSystemRoot", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#isFloppyDrive(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsFloppyDrive(Java.Io.File arg0)
        {
            return IExecute<bool>("isFloppyDrive", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#isHiddenFile(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsHiddenFile(Java.Io.File arg0)
        {
            return IExecute<bool>("isHiddenFile", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#isLink(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsLink(Java.Io.File arg0)
        {
            return IExecute<bool>("isLink", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#isParent(java.io.File,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Java.Io.File"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsParent(Java.Io.File arg0, Java.Io.File arg1)
        {
            return IExecute<bool>("isParent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#isRoot(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsRoot(Java.Io.File arg0)
        {
            return IExecute<bool>("isRoot", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#createFileObject(java.io.File,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see langword="string"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File CreateFileObject(Java.Io.File arg0, string arg1)
        {
            return IExecute<Java.Io.File>("createFileObject", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#createFileObject(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File CreateFileObject(string arg0)
        {
            return IExecute<Java.Io.File>("createFileObject", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#getChild(java.io.File,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see langword="string"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File GetChild(Java.Io.File arg0, string arg1)
        {
            return IExecute<Java.Io.File>("getChild", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#getLinkLocation(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Java.Io.File GetLinkLocation(Java.Io.File arg0)
        {
            return IExecute<Java.Io.File>("getLinkLocation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#getParentDirectory(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File GetParentDirectory(Java.Io.File arg0)
        {
            return IExecute<Java.Io.File>("getParentDirectory", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#getFiles(java.io.File,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see langword="bool"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File[] GetFiles(Java.Io.File arg0, bool arg1)
        {
            return IExecuteArray<Java.Io.File>("getFiles", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#isTraversable(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see langword="bool?"/></returns>
        public bool? IsTraversable(Java.Io.File arg0)
        {
            return IExecute<bool?>("isTraversable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#getSystemDisplayName(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see langword="string"/></returns>
        public string GetSystemDisplayName(Java.Io.File arg0)
        {
            return IExecute<string>("getSystemDisplayName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#getSystemTypeDescription(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see langword="string"/></returns>
        public string GetSystemTypeDescription(Java.Io.File arg0)
        {
            return IExecute<string>("getSystemTypeDescription", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileSystemView.html#getSystemIcon(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public Javax.Swing.Icon GetSystemIcon(Java.Io.File arg0)
        {
            return IExecute<Javax.Swing.Icon>("getSystemIcon", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}