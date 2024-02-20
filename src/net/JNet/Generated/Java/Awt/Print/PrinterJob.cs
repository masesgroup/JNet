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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Print
{
    #region PrinterJob
    public partial class PrinterJob
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#getPrinterJob()"/> 
        /// </summary>
        public static Java.Awt.Print.PrinterJob GetPrinterJob
        {
            get { return SExecute<Java.Awt.Print.PrinterJob>(LocalBridgeClazz, "getPrinterJob"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#lookupPrintServices()"/>
        /// </summary>

        /// <returns><see cref="Javax.Print.PrintService"/></returns>
        public static Javax.Print.PrintService[] LookupPrintServices()
        {
            return SExecuteArray<Javax.Print.PrintService>(LocalBridgeClazz, "lookupPrintServices");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#lookupStreamPrintServices(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Print.StreamPrintServiceFactory"/></returns>
        public static Javax.Print.StreamPrintServiceFactory[] LookupStreamPrintServices(Java.Lang.String arg0)
        {
            return SExecuteArray<Javax.Print.StreamPrintServiceFactory>(LocalBridgeClazz, "lookupStreamPrintServices", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#getCopies()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#setCopies(int)"/>
        /// </summary>
        public int Copies
        {
            get { return IExecute<int>("getCopies"); } set { IExecute("setCopies", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#getJobName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#setJobName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String JobName
        {
            get { return IExecute<Java.Lang.String>("getJobName"); } set { IExecute("setJobName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#getPrintService()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#setPrintService(javax.print.PrintService)"/>
        /// </summary>
        public Javax.Print.PrintService PrintService
        {
            get { return IExecute<Javax.Print.PrintService>("getPrintService"); } set { IExecute("setPrintService", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#getUserName()"/> 
        /// </summary>
        public Java.Lang.String UserName
        {
            get { return IExecute<Java.Lang.String>("getUserName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#isCancelled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCancelled()
        {
            return IExecute<bool>("isCancelled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#printDialog()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public bool PrintDialog()
        {
            return IExecute<bool>("printDialog");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#defaultPage(java.awt.print.PageFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Print.PageFormat"/></param>
        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        public Java.Awt.Print.PageFormat DefaultPage(Java.Awt.Print.PageFormat arg0)
        {
            return IExecute<Java.Awt.Print.PageFormat>("defaultPage", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#pageDialog(java.awt.print.PageFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Print.PageFormat"/></param>
        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Java.Awt.Print.PageFormat PageDialog(Java.Awt.Print.PageFormat arg0)
        {
            return IExecute<Java.Awt.Print.PageFormat>("pageDialog", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#validatePage(java.awt.print.PageFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Print.PageFormat"/></param>
        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        public Java.Awt.Print.PageFormat ValidatePage(Java.Awt.Print.PageFormat arg0)
        {
            return IExecute<Java.Awt.Print.PageFormat>("validatePage", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecute("cancel");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#print()"/>
        /// </summary>

        /// <exception cref="Java.Awt.Print.PrinterException"/>
        public void Print()
        {
            IExecute("print");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#setPageable(java.awt.print.Pageable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Print.Pageable"/></param>
        /// <exception cref="Java.Lang.NullPointerException"/>
        public void SetPageable(Java.Awt.Print.Pageable arg0)
        {
            IExecute("setPageable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#setPrintable(java.awt.print.Printable,java.awt.print.PageFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Print.Printable"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Print.PageFormat"/></param>
        public void SetPrintable(Java.Awt.Print.Printable arg0, Java.Awt.Print.PageFormat arg1)
        {
            IExecute("setPrintable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#setPrintable(java.awt.print.Printable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Print.Printable"/></param>
        public void SetPrintable(Java.Awt.Print.Printable arg0)
        {
            IExecute("setPrintable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#printDialog(javax.print.attribute.PrintRequestAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public bool PrintDialog(Javax.Print.Attribute.PrintRequestAttributeSet arg0)
        {
            return IExecute<bool>("printDialog", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#defaultPage()"/>
        /// </summary>

        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        public Java.Awt.Print.PageFormat DefaultPage()
        {
            return IExecute<Java.Awt.Print.PageFormat>("defaultPage");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#getPageFormat(javax.print.attribute.PrintRequestAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        public Java.Awt.Print.PageFormat GetPageFormat(Javax.Print.Attribute.PrintRequestAttributeSet arg0)
        {
            return IExecute<Java.Awt.Print.PageFormat>("getPageFormat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#pageDialog(javax.print.attribute.PrintRequestAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></param>
        /// <returns><see cref="Java.Awt.Print.PageFormat"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Java.Awt.Print.PageFormat PageDialog(Javax.Print.Attribute.PrintRequestAttributeSet arg0)
        {
            return IExecute<Java.Awt.Print.PageFormat>("pageDialog", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/print/PrinterJob.html#print(javax.print.attribute.PrintRequestAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></param>
        /// <exception cref="Java.Awt.Print.PrinterException"/>
        public void Print(Javax.Print.Attribute.PrintRequestAttributeSet arg0)
        {
            IExecute("print", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}