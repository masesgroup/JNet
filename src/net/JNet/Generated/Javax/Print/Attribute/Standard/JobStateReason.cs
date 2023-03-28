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

namespace Javax.Print.Attribute.Standard
{
    #region JobStateReason
    public partial class JobStateReason
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.JobStateReason"/> to <see cref="Javax.Print.Attribute.Attribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.Attribute(Javax.Print.Attribute.Standard.JobStateReason t) => t.Cast<Javax.Print.Attribute.Attribute>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#ABORTED_BY_SYSTEM"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason ABORTED_BY_SYSTEM => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("ABORTED_BY_SYSTEM");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#COMPRESSION_ERROR"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason COMPRESSION_ERROR => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("COMPRESSION_ERROR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#DOCUMENT_ACCESS_ERROR"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason DOCUMENT_ACCESS_ERROR => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("DOCUMENT_ACCESS_ERROR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#DOCUMENT_FORMAT_ERROR"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason DOCUMENT_FORMAT_ERROR => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("DOCUMENT_FORMAT_ERROR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_CANCELED_AT_DEVICE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_CANCELED_AT_DEVICE => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_CANCELED_AT_DEVICE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_CANCELED_BY_OPERATOR"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_CANCELED_BY_OPERATOR => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_CANCELED_BY_OPERATOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_CANCELED_BY_USER"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_CANCELED_BY_USER => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_CANCELED_BY_USER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_COMPLETED_SUCCESSFULLY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_COMPLETED_SUCCESSFULLY => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_COMPLETED_SUCCESSFULLY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_COMPLETED_WITH_ERRORS"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_COMPLETED_WITH_ERRORS => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_COMPLETED_WITH_ERRORS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_COMPLETED_WITH_WARNINGS"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_COMPLETED_WITH_WARNINGS => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_COMPLETED_WITH_WARNINGS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_DATA_INSUFFICIENT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_DATA_INSUFFICIENT => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_DATA_INSUFFICIENT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_HOLD_UNTIL_SPECIFIED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_HOLD_UNTIL_SPECIFIED => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_HOLD_UNTIL_SPECIFIED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_INCOMING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_INCOMING => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_INCOMING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_INTERPRETING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_INTERPRETING => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_INTERPRETING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_OUTGOING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_OUTGOING => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_OUTGOING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_PRINTING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_PRINTING => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_PRINTING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_QUEUED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_QUEUED => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_QUEUED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_QUEUED_FOR_MARKER"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_QUEUED_FOR_MARKER => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_QUEUED_FOR_MARKER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_RESTARTABLE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_RESTARTABLE => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_RESTARTABLE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_TRANSFORMING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_TRANSFORMING => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("JOB_TRANSFORMING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#PRINTER_STOPPED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason PRINTER_STOPPED => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("PRINTER_STOPPED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#PRINTER_STOPPED_PARTLY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason PRINTER_STOPPED_PARTLY => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("PRINTER_STOPPED_PARTLY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#PROCESSING_TO_STOP_POINT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason PROCESSING_TO_STOP_POINT => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("PROCESSING_TO_STOP_POINT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#QUEUED_IN_DEVICE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason QUEUED_IN_DEVICE => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("QUEUED_IN_DEVICE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#RESOURCES_ARE_NOT_READY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason RESOURCES_ARE_NOT_READY => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("RESOURCES_ARE_NOT_READY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#SERVICE_OFF_LINE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason SERVICE_OFF_LINE => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("SERVICE_OFF_LINE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#SUBMISSION_INTERRUPTED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason SUBMISSION_INTERRUPTED => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("SUBMISSION_INTERRUPTED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#UNSUPPORTED_COMPRESSION"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason UNSUPPORTED_COMPRESSION => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("UNSUPPORTED_COMPRESSION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#UNSUPPORTED_DOCUMENT_FORMAT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason UNSUPPORTED_DOCUMENT_FORMAT => Clazz.GetField<Javax.Print.Attribute.Standard.JobStateReason>("UNSUPPORTED_DOCUMENT_FORMAT");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecute<Java.Lang.Class>("getCategory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}