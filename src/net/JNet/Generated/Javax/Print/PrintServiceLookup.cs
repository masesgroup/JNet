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
    #region PrintServiceLookup
    public partial class PrintServiceLookup
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#registerService(javax.print.PrintService)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.PrintService"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool RegisterService(Javax.Print.PrintService arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "registerService", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#registerServiceProvider(javax.print.PrintServiceLookup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.PrintServiceLookup"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool RegisterServiceProvider(Javax.Print.PrintServiceLookup arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "registerServiceProvider", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#lookupMultiDocPrintServices(javax.print.DocFlavor[],javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="Javax.Print.MultiDocPrintService"/></returns>
        public static Javax.Print.MultiDocPrintService[] LookupMultiDocPrintServices(Javax.Print.DocFlavor[] arg0, Javax.Print.Attribute.AttributeSet arg1)
        {
            return SExecuteArray<Javax.Print.MultiDocPrintService>(LocalBridgeClazz, "lookupMultiDocPrintServices", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#lookupDefaultPrintService()"/>
        /// </summary>

        /// <returns><see cref="Javax.Print.PrintService"/></returns>
        public static Javax.Print.PrintService LookupDefaultPrintService()
        {
            return SExecute<Javax.Print.PrintService>(LocalBridgeClazz, "lookupDefaultPrintService");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#lookupPrintServices(javax.print.DocFlavor,javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="Javax.Print.PrintService"/></returns>
        public static Javax.Print.PrintService[] LookupPrintServices(Javax.Print.DocFlavor arg0, Javax.Print.Attribute.AttributeSet arg1)
        {
            return SExecuteArray<Javax.Print.PrintService>(LocalBridgeClazz, "lookupPrintServices", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#getDefaultPrintService()"/> 
        /// </summary>
        public Javax.Print.PrintService DefaultPrintService
        {
            get { return IExecute<Javax.Print.PrintService>("getDefaultPrintService"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#getPrintServices()"/> 
        /// </summary>
        public Javax.Print.PrintService[] PrintServices
        {
            get { return IExecuteArray<Javax.Print.PrintService>("getPrintServices"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#getMultiDocPrintServices(javax.print.DocFlavor[],javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="Javax.Print.MultiDocPrintService"/></returns>
        public Javax.Print.MultiDocPrintService[] GetMultiDocPrintServices(Javax.Print.DocFlavor[] arg0, Javax.Print.Attribute.AttributeSet arg1)
        {
            return IExecuteArray<Javax.Print.MultiDocPrintService>("getMultiDocPrintServices", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#getPrintServices(javax.print.DocFlavor,javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="Javax.Print.PrintService"/></returns>
        public Javax.Print.PrintService[] GetPrintServices(Javax.Print.DocFlavor arg0, Javax.Print.Attribute.AttributeSet arg1)
        {
            return IExecuteArray<Javax.Print.PrintService>("getPrintServices", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}