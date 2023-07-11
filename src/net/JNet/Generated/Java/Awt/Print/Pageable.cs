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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Print
{
    #region IPageable
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPageable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/Pageable.html#getNumberOfPages()"/> 
        /// </summary>
        int NumberOfPages { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/Pageable.html#getPageFormat(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        /// <exception cref="Java.Lang.IndexOutOfBoundsException"/>
        Java.Awt.Print.PageFormat GetPageFormat(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/Pageable.html#getPrintable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Print.Printable"/></returns>
        /// <exception cref="Java.Lang.IndexOutOfBoundsException"/>
        Java.Awt.Print.Printable GetPrintable(int arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Pageable
    public partial class Pageable : Java.Awt.Print.IPageable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/Pageable.html#UNKNOWN_NUMBER_OF_PAGES"/>
        /// </summary>
        public static int UNKNOWN_NUMBER_OF_PAGES { get { return SGetField<int>(LocalBridgeClazz, "UNKNOWN_NUMBER_OF_PAGES"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/Pageable.html#getNumberOfPages()"/> 
        /// </summary>
        public int NumberOfPages
        {
            get { return IExecute<int>("getNumberOfPages"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/Pageable.html#getPageFormat(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        /// <exception cref="Java.Lang.IndexOutOfBoundsException"/>
        public Java.Awt.Print.PageFormat GetPageFormat(int arg0)
        {
            return IExecute<Java.Awt.Print.PageFormat>("getPageFormat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/Pageable.html#getPrintable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Print.Printable"/></returns>
        /// <exception cref="Java.Lang.IndexOutOfBoundsException"/>
        public Java.Awt.Print.Printable GetPrintable(int arg0)
        {
            return IExecute<Java.Awt.Print.Printable>("getPrintable", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}