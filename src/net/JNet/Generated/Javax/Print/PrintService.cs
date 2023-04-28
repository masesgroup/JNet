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

namespace Javax.Print
{
    #region PrintService
    public partial class PrintService
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getAttributes()"/> 
        /// </summary>
        public Javax.Print.Attribute.PrintServiceAttributeSet Attributes
        {
            get { return IExecute<Javax.Print.Attribute.PrintServiceAttributeSet>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#createPrintJob()"/> 
        /// </summary>
        public Javax.Print.DocPrintJob CreatePrintJob
        {
            get { return IExecute<Javax.Print.DocPrintJob>("createPrintJob"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getServiceUIFactory()"/> 
        /// </summary>
        public Javax.Print.ServiceUIFactory ServiceUIFactory
        {
            get { return IExecute<Javax.Print.ServiceUIFactory>("getServiceUIFactory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getSupportedAttributeCategories()"/> 
        /// </summary>
        public Java.Lang.Class[] SupportedAttributeCategories
        {
            get { return IExecuteArray<Java.Lang.Class>("getSupportedAttributeCategories"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getSupportedDocFlavors()"/> 
        /// </summary>
        public Javax.Print.DocFlavor[] SupportedDocFlavors
        {
            get { return IExecuteArray<Javax.Print.DocFlavor>("getSupportedDocFlavors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getAttribute(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="T"/></returns>
        public T GetAttribute<T>(Java.Lang.Class arg0) where T: Javax.Print.Attribute.PrintServiceAttribute
        {
            return IExecute<T>("getAttribute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#isAttributeCategorySupported(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAttributeCategorySupported(Java.Lang.Class arg0)
        {
            return IExecute<bool>("isAttributeCategorySupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#isAttributeValueSupported(javax.print.attribute.Attribute,javax.print.DocFlavor,javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.Attribute"/></param>
        /// <param name="arg1"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg2"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAttributeValueSupported(Javax.Print.Attribute.Attribute arg0, Javax.Print.DocFlavor arg1, Javax.Print.Attribute.AttributeSet arg2)
        {
            return IExecute<bool>("isAttributeValueSupported", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#isDocFlavorSupported(javax.print.DocFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.DocFlavor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDocFlavorSupported(Javax.Print.DocFlavor arg0)
        {
            return IExecute<bool>("isDocFlavorSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getDefaultAttributeValue(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetDefaultAttributeValue(Java.Lang.Class arg0)
        {
            return IExecute("getDefaultAttributeValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getSupportedAttributeValues(java.lang.Class,javax.print.DocFlavor,javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg2"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetSupportedAttributeValues(Java.Lang.Class arg0, Javax.Print.DocFlavor arg1, Javax.Print.Attribute.AttributeSet arg2)
        {
            return IExecute("getSupportedAttributeValues", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#getUnsupportedAttributes(javax.print.DocFlavor,javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="Javax.Print.Attribute.AttributeSet"/></returns>
        public Javax.Print.Attribute.AttributeSet GetUnsupportedAttributes(Javax.Print.DocFlavor arg0, Javax.Print.Attribute.AttributeSet arg1)
        {
            return IExecute<Javax.Print.Attribute.AttributeSet>("getUnsupportedAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#addPrintServiceAttributeListener(javax.print.event.PrintServiceAttributeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintServiceAttributeListener"/></param>
        public void AddPrintServiceAttributeListener(Javax.Print.Event.PrintServiceAttributeListener arg0)
        {
            IExecute("addPrintServiceAttributeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintService.html#removePrintServiceAttributeListener(javax.print.event.PrintServiceAttributeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintServiceAttributeListener"/></param>
        public void RemovePrintServiceAttributeListener(Javax.Print.Event.PrintServiceAttributeListener arg0)
        {
            IExecute("removePrintServiceAttributeListener", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}