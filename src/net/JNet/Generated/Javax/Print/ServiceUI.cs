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
    #region ServiceUI
    public partial class ServiceUI
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUI.html#printDialog(java.awt.GraphicsConfiguration,int,int,javax.print.PrintService[],javax.print.PrintService,javax.print.DocFlavor,javax.print.attribute.PrintRequestAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Javax.Print.PrintService"/></param>
        /// <param name="arg4"><see cref="Javax.Print.PrintService"/></param>
        /// <param name="arg5"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg6"><see cref="Javax.Print.Attribute.PrintRequestAttributeSet"/></param>
        /// <returns><see cref="Javax.Print.PrintService"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public static Javax.Print.PrintService PrintDialog(Java.Awt.GraphicsConfiguration arg0, int arg1, int arg2, Javax.Print.PrintService[] arg3, Javax.Print.PrintService arg4, Javax.Print.DocFlavor arg5, Javax.Print.Attribute.PrintRequestAttributeSet arg6)
        {
            return SExecute<Javax.Print.PrintService>(LocalBridgeClazz, "printDialog", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}