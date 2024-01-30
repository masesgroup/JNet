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

namespace Javax.Print
{
    #region IDoc
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDoc
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/Doc.html#getAttributes()"/> 
        /// </summary>
        Javax.Print.Attribute.DocAttributeSet Attributes { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/Doc.html#getDocFlavor()"/> 
        /// </summary>
        Javax.Print.DocFlavor DocFlavor { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/Doc.html#getPrintData()"/> 
        /// </summary>
        object PrintData { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/Doc.html#getReaderForText()"/> 
        /// </summary>
        Java.Io.Reader ReaderForText { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/Doc.html#getStreamForBytes()"/> 
        /// </summary>
        Java.Io.InputStream StreamForBytes { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Doc
    public partial class Doc : Javax.Print.IDoc
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/Doc.html#getAttributes()"/> 
        /// </summary>
        public Javax.Print.Attribute.DocAttributeSet Attributes
        {
            get { return IExecute<Javax.Print.Attribute.DocAttributeSet>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/Doc.html#getDocFlavor()"/> 
        /// </summary>
        public Javax.Print.DocFlavor DocFlavor
        {
            get { return IExecute<Javax.Print.DocFlavor>("getDocFlavor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/Doc.html#getPrintData()"/> 
        /// </summary>
        public object PrintData
        {
            get { return IExecute("getPrintData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/Doc.html#getReaderForText()"/> 
        /// </summary>
        public Java.Io.Reader ReaderForText
        {
            get { return IExecute<Java.Io.Reader>("getReaderForText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/Doc.html#getStreamForBytes()"/> 
        /// </summary>
        public Java.Io.InputStream StreamForBytes
        {
            get { return IExecute<Java.Io.InputStream>("getStreamForBytes"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}