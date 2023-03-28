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

namespace Javax.Print
{
    #region DocPrintJob
    public partial class DocPrintJob
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#getAttributes()"/> 
        /// </summary>
        public Javax.Print.Attribute.PrintJobAttributeSet Attributes
        {
            get { return IExecute<Javax.Print.Attribute.PrintJobAttributeSet>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#getPrintService()"/> 
        /// </summary>
        public Javax.Print.PrintService PrintService
        {
            get { return IExecute<Javax.Print.PrintService>("getPrintService"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#addPrintJobAttributeListener(javax.print.event.PrintJobAttributeListener,javax.print.attribute.PrintJobAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobAttributeListener"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.PrintJobAttributeSet"/></param>
        public void AddPrintJobAttributeListener(Javax.Print.Event.PrintJobAttributeListener arg0, Javax.Print.Attribute.PrintJobAttributeSet arg1)
        {
            IExecute("addPrintJobAttributeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#addPrintJobListener(javax.print.event.PrintJobListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobListener"/></param>
        public void AddPrintJobListener(Javax.Print.Event.PrintJobListener arg0)
        {
            IExecute("addPrintJobListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#print(javax.print.Doc,javax.print.attribute.PrintRequestAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Doc"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></param>
        /// <exception cref="Javax.Print.PrintException"/>
        public void Print(Javax.Print.Doc arg0, Javax.Print.Attribute.PrintRequestAttributeSet arg1)
        {
            IExecute("print", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#removePrintJobAttributeListener(javax.print.event.PrintJobAttributeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobAttributeListener"/></param>
        public void RemovePrintJobAttributeListener(Javax.Print.Event.PrintJobAttributeListener arg0)
        {
            IExecute("removePrintJobAttributeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/DocPrintJob.html#removePrintJobListener(javax.print.event.PrintJobListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobListener"/></param>
        public void RemovePrintJobListener(Javax.Print.Event.PrintJobListener arg0)
        {
            IExecute("removePrintJobListener", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}