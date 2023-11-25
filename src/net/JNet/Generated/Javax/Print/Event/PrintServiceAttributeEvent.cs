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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Event
{
    #region PrintServiceAttributeEvent
    public partial class PrintServiceAttributeEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeEvent.html#%3Cinit%3E(javax.print.PrintService,javax.print.attribute.PrintServiceAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.PrintService"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.PrintServiceAttributeSet"/></param>
        public PrintServiceAttributeEvent(Javax.Print.PrintService arg0, Javax.Print.Attribute.PrintServiceAttributeSet arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeEvent.html#getAttributes()"/> 
        /// </summary>
        public Javax.Print.Attribute.PrintServiceAttributeSet Attributes
        {
            get { return IExecute<Javax.Print.Attribute.PrintServiceAttributeSet>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeEvent.html#getPrintService()"/> 
        /// </summary>
        public Javax.Print.PrintService PrintService
        {
            get { return IExecute<Javax.Print.PrintService>("getPrintService"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}