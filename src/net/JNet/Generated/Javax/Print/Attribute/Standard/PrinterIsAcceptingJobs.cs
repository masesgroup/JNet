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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Attribute.Standard
{
    #region PrinterIsAcceptingJobs
    public partial class PrinterIsAcceptingJobs
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.PrinterIsAcceptingJobs"/> to <see cref="Javax.Print.Attribute.PrintServiceAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintServiceAttribute(Javax.Print.Attribute.Standard.PrinterIsAcceptingJobs t) => t.Cast<Javax.Print.Attribute.PrintServiceAttribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterIsAcceptingJobs.html#ACCEPTING_JOBS"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterIsAcceptingJobs ACCEPTING_JOBS { get { if (!_ACCEPTING_JOBSReady) { _ACCEPTING_JOBSContent = SGetField<Javax.Print.Attribute.Standard.PrinterIsAcceptingJobs>(LocalBridgeClazz, "ACCEPTING_JOBS"); _ACCEPTING_JOBSReady = true; } return _ACCEPTING_JOBSContent; } }
        private static Javax.Print.Attribute.Standard.PrinterIsAcceptingJobs _ACCEPTING_JOBSContent = default;
        private static bool _ACCEPTING_JOBSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterIsAcceptingJobs.html#NOT_ACCEPTING_JOBS"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterIsAcceptingJobs NOT_ACCEPTING_JOBS { get { if (!_NOT_ACCEPTING_JOBSReady) { _NOT_ACCEPTING_JOBSContent = SGetField<Javax.Print.Attribute.Standard.PrinterIsAcceptingJobs>(LocalBridgeClazz, "NOT_ACCEPTING_JOBS"); _NOT_ACCEPTING_JOBSReady = true; } return _NOT_ACCEPTING_JOBSContent; } }
        private static Javax.Print.Attribute.Standard.PrinterIsAcceptingJobs _NOT_ACCEPTING_JOBSContent = default;
        private static bool _NOT_ACCEPTING_JOBSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterIsAcceptingJobs.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getCategory", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterIsAcceptingJobs.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}