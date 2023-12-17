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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Datatype
{
    #region Duration
    public partial class Duration
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getDays()"/> 
        /// </summary>
        public int Days
        {
            get { return IExecute<int>("getDays"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getHours()"/> 
        /// </summary>
        public int Hours
        {
            get { return IExecute<int>("getHours"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getMinutes()"/> 
        /// </summary>
        public int Minutes
        {
            get { return IExecute<int>("getMinutes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getMonths()"/> 
        /// </summary>
        public int Months
        {
            get { return IExecute<int>("getMonths"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getSeconds()"/> 
        /// </summary>
        public int Seconds
        {
            get { return IExecute<int>("getSeconds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getSign()"/> 
        /// </summary>
        public int Sign
        {
            get { return IExecute<int>("getSign"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getXMLSchemaType()"/> 
        /// </summary>
        public Javax.Xml.Namespace.QName XMLSchemaType
        {
            get { return IExecute<Javax.Xml.Namespace.QName>("getXMLSchemaType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getYears()"/> 
        /// </summary>
        public int Years
        {
            get { return IExecute<int>("getYears"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#isSet(javax.xml.datatype.DatatypeConstants.Field)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.DatatypeConstants.Field"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSet(Javax.Xml.Datatype.DatatypeConstants.Field arg0)
        {
            return IExecute<bool>("isSet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#compare(javax.xml.datatype.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.Duration"/></param>
        /// <returns><see cref="int"/></returns>
        public int Compare(Javax.Xml.Datatype.Duration arg0)
        {
            return IExecute<int>("compare", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getField(javax.xml.datatype.DatatypeConstants.Field)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.DatatypeConstants.Field"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        public Java.Lang.Number GetField(Javax.Xml.Datatype.DatatypeConstants.Field arg0)
        {
            return IExecute<Java.Lang.Number>("getField", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#add(javax.xml.datatype.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.Duration"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration Add(Javax.Xml.Datatype.Duration arg0)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#multiply(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration Multiply(Java.Math.BigDecimal arg0)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("multiply", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#negate()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration Negate()
        {
            return IExecute<Javax.Xml.Datatype.Duration>("negate");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#normalizeWith(java.util.Calendar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Calendar"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration NormalizeWith(Java.Util.Calendar arg0)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("normalizeWith", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#addTo(java.util.Calendar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Calendar"/></param>
        public void AddTo(Java.Util.Calendar arg0)
        {
            IExecute("addTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#isLongerThan(javax.xml.datatype.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.Duration"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsLongerThan(Javax.Xml.Datatype.Duration arg0)
        {
            return IExecute<bool>("isLongerThan", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#isShorterThan(javax.xml.datatype.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.Duration"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsShorterThan(Javax.Xml.Datatype.Duration arg0)
        {
            return IExecute<bool>("isShorterThan", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#multiply(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration Multiply(int arg0)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("multiply", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#subtract(javax.xml.datatype.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.Duration"/></param>
        /// <returns><see cref="Javax.Xml.Datatype.Duration"/></returns>
        public Javax.Xml.Datatype.Duration Subtract(Javax.Xml.Datatype.Duration arg0)
        {
            return IExecute<Javax.Xml.Datatype.Duration>("subtract", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getTimeInMillis(java.util.Calendar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Calendar"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetTimeInMillis(Java.Util.Calendar arg0)
        {
            return IExecute<long>("getTimeInMillis", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#getTimeInMillis(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetTimeInMillis(Java.Util.Date arg0)
        {
            return IExecute<long>("getTimeInMillis", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/Duration.html#addTo(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        public void AddTo(Java.Util.Date arg0)
        {
            IExecute("addTo", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}