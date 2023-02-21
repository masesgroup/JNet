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
    #region FileDialog
    public partial class FileDialog
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#<init>(java.awt.Dialog,java.lang.String,int)
        /// </summary>
        public FileDialog(Java.Awt.Dialog arg0, string arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#<init>(java.awt.Dialog)
        /// </summary>
        public FileDialog(Java.Awt.Dialog arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#<init>(java.awt.Frame,java.lang.String,int)
        /// </summary>
        public FileDialog(Java.Awt.Frame arg0, string arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#<init>(java.awt.Frame,java.lang.String)
        /// </summary>
        public FileDialog(Java.Awt.Frame arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#<init>(java.awt.Frame)
        /// </summary>
        public FileDialog(Java.Awt.Frame arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#<init>(java.awt.Dialog,java.lang.String)
        /// </summary>
        public FileDialog(Java.Awt.Dialog arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#LOAD
        /// </summary>
        public static int LOAD => Clazz.GetField<int>("LOAD");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#SAVE
        /// </summary>
        public static int SAVE => Clazz.GetField<int>("SAVE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getDirectory() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setDirectory(java.lang.String)
        /// </summary>
        public string Directory
        {
            get { return IExecute<string>("getDirectory"); } set { IExecute("setDirectory", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getFile() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setFile(java.lang.String)
        /// </summary>
        public string File
        {
            get { return IExecute<string>("getFile"); } set { IExecute("setFile", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getFilenameFilter() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setFilenameFilter(java.io.FilenameFilter)
        /// </summary>
        public Java.Io.FilenameFilter FilenameFilter
        {
            get { return IExecute<Java.Io.FilenameFilter>("getFilenameFilter"); } set { IExecute("setFilenameFilter", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getFiles() 
        /// </summary>
        public Java.Io.File[] Files
        {
            get { return IExecuteArray<Java.Io.File>("getFiles"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getMode() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setMode(int)
        /// </summary>
        public int Mode
        {
            get { return IExecute<int>("getMode"); } set { IExecute("setMode", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#isMultipleMode()
        /// </summary>
        public bool IsMultipleMode()
        {
            return IExecute<bool>("isMultipleMode");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setMultipleMode(boolean)
        /// </summary>
        public void SetMultipleMode(bool arg0)
        {
            IExecute("setMultipleMode", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}