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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Datatransfer
{
    #region DataFlavor
    public partial class DataFlavor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#%3Cinit%3E(java.lang.Class,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public DataFlavor(Java.Lang.Class arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public DataFlavor(string arg0, string arg1, Java.Lang.ClassLoader arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public DataFlavor(string arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public DataFlavor(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Datatransfer.DataFlavor"/> to <see cref="Java.Io.Externalizable"/>
        /// </summary>
        public static implicit operator Java.Io.Externalizable(Java.Awt.Datatransfer.DataFlavor t) => t.Cast<Java.Io.Externalizable>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Datatransfer.DataFlavor"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.Datatransfer.DataFlavor t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#imageFlavor"/>
        /// </summary>
        public static Java.Awt.Datatransfer.DataFlavor imageFlavor { get { return SGetField<Java.Awt.Datatransfer.DataFlavor>(LocalClazz, "imageFlavor"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#javaFileListFlavor"/>
        /// </summary>
        public static Java.Awt.Datatransfer.DataFlavor javaFileListFlavor { get { return SGetField<Java.Awt.Datatransfer.DataFlavor>(LocalClazz, "javaFileListFlavor"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#stringFlavor"/>
        /// </summary>
        public static Java.Awt.Datatransfer.DataFlavor stringFlavor { get { return SGetField<Java.Awt.Datatransfer.DataFlavor>(LocalClazz, "stringFlavor"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#javaJVMLocalObjectMimeType"/>
        /// </summary>
        public static string javaJVMLocalObjectMimeType { get { return SGetField<string>(LocalClazz, "javaJVMLocalObjectMimeType"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#javaRemoteObjectMimeType"/>
        /// </summary>
        public static string javaRemoteObjectMimeType { get { return SGetField<string>(LocalClazz, "javaRemoteObjectMimeType"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#javaSerializedObjectMimeType"/>
        /// </summary>
        public static string javaSerializedObjectMimeType { get { return SGetField<string>(LocalClazz, "javaSerializedObjectMimeType"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#allHtmlFlavor"/>
        /// </summary>
        public static Java.Awt.Datatransfer.DataFlavor allHtmlFlavor { get { return SGetField<Java.Awt.Datatransfer.DataFlavor>(LocalClazz, "allHtmlFlavor"); } set { SSetField(LocalClazz, "allHtmlFlavor", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#fragmentHtmlFlavor"/>
        /// </summary>
        public static Java.Awt.Datatransfer.DataFlavor fragmentHtmlFlavor { get { return SGetField<Java.Awt.Datatransfer.DataFlavor>(LocalClazz, "fragmentHtmlFlavor"); } set { SSetField(LocalClazz, "fragmentHtmlFlavor", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#selectionHtmlFlavor"/>
        /// </summary>
        public static Java.Awt.Datatransfer.DataFlavor selectionHtmlFlavor { get { return SGetField<Java.Awt.Datatransfer.DataFlavor>(LocalClazz, "selectionHtmlFlavor"); } set { SSetField(LocalClazz, "selectionHtmlFlavor", value); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getTextPlainUnicodeFlavor()"/> 
        /// </summary>
        public static Java.Awt.Datatransfer.DataFlavor TextPlainUnicodeFlavor
        {
            get { return SExecute<Java.Awt.Datatransfer.DataFlavor>(LocalClazz, "getTextPlainUnicodeFlavor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#selectBestTextFlavor(java.awt.datatransfer.DataFlavor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="Java.Awt.Datatransfer.DataFlavor"/></returns>
        public static Java.Awt.Datatransfer.DataFlavor SelectBestTextFlavor(Java.Awt.Datatransfer.DataFlavor[] arg0)
        {
            return SExecute<Java.Awt.Datatransfer.DataFlavor>(LocalClazz, "selectBestTextFlavor", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getDefaultRepresentationClass()"/> 
        /// </summary>
        public Java.Lang.Class DefaultRepresentationClass
        {
            get { return IExecute<Java.Lang.Class>("getDefaultRepresentationClass"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getDefaultRepresentationClassAsString()"/> 
        /// </summary>
        public string DefaultRepresentationClassAsString
        {
            get { return IExecute<string>("getDefaultRepresentationClassAsString"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getHumanPresentableName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#setHumanPresentableName(java.lang.String)"/>
        /// </summary>
        public string HumanPresentableName
        {
            get { return IExecute<string>("getHumanPresentableName"); } set { IExecute("setHumanPresentableName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isFlavorJavaFileListType()"/> 
        /// </summary>
        public bool IsFlavorJavaFileListType
        {
            get { return IExecute<bool>("isFlavorJavaFileListType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isFlavorRemoteObjectType()"/> 
        /// </summary>
        public bool IsFlavorRemoteObjectType
        {
            get { return IExecute<bool>("isFlavorRemoteObjectType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isFlavorSerializedObjectType()"/> 
        /// </summary>
        public bool IsFlavorSerializedObjectType
        {
            get { return IExecute<bool>("isFlavorSerializedObjectType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isFlavorTextType()"/> 
        /// </summary>
        public bool IsFlavorTextType
        {
            get { return IExecute<bool>("isFlavorTextType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isMimeTypeSerializedObject()"/> 
        /// </summary>
        public bool IsMimeTypeSerializedObject
        {
            get { return IExecute<bool>("isMimeTypeSerializedObject"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isRepresentationClassByteBuffer()"/> 
        /// </summary>
        public bool IsRepresentationClassByteBuffer
        {
            get { return IExecute<bool>("isRepresentationClassByteBuffer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isRepresentationClassCharBuffer()"/> 
        /// </summary>
        public bool IsRepresentationClassCharBuffer
        {
            get { return IExecute<bool>("isRepresentationClassCharBuffer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isRepresentationClassInputStream()"/> 
        /// </summary>
        public bool IsRepresentationClassInputStream
        {
            get { return IExecute<bool>("isRepresentationClassInputStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isRepresentationClassReader()"/> 
        /// </summary>
        public bool IsRepresentationClassReader
        {
            get { return IExecute<bool>("isRepresentationClassReader"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isRepresentationClassRemote()"/> 
        /// </summary>
        public bool IsRepresentationClassRemote
        {
            get { return IExecute<bool>("isRepresentationClassRemote"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isRepresentationClassSerializable()"/> 
        /// </summary>
        public bool IsRepresentationClassSerializable
        {
            get { return IExecute<bool>("isRepresentationClassSerializable"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getMimeType()"/> 
        /// </summary>
        public string MimeType
        {
            get { return IExecute<string>("getMimeType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getPrimaryType()"/> 
        /// </summary>
        public string PrimaryType
        {
            get { return IExecute<string>("getPrimaryType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getRepresentationClass()"/> 
        /// </summary>
        public Java.Lang.Class RepresentationClass
        {
            get { return IExecute<Java.Lang.Class>("getRepresentationClass"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getSubType()"/> 
        /// </summary>
        public string SubType
        {
            get { return IExecute<string>("getSubType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isMimeTypeEqual(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsMimeTypeEqual(string arg0)
        {
            return IExecute<bool>("isMimeTypeEqual", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#match(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Match(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return IExecute<bool>("match", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#isMimeTypeEqual(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsMimeTypeEqual(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return IExecute<bool>("isMimeTypeEqual", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getReaderForText(java.awt.datatransfer.Transferable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.Transferable"/></param>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        /// <exception cref="Java.Awt.Datatransfer.UnsupportedFlavorException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.Reader GetReaderForText(Java.Awt.Datatransfer.Transferable arg0)
        {
            return IExecute<Java.Io.Reader>("getReaderForText", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#getParameter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetParameter(string arg0)
        {
            return IExecute<string>("getParameter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#readExternal(java.io.ObjectInput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectInput"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public void ReadExternal(Java.Io.ObjectInput arg0)
        {
            IExecute("readExternal", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/DataFlavor.html#writeExternal(java.io.ObjectOutput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectOutput"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteExternal(Java.Io.ObjectOutput arg0)
        {
            IExecute("writeExternal", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}