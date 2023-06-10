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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Datatype
{
    #region XMLGregorianCalendar
    public partial class XMLGregorianCalendar
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getDay()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setDay(int)"/>
        /// </summary>
        public int Day
        {
            get { return IExecute<int>("getDay"); } set { IExecute("setDay", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getEon()"/> 
        /// </summary>
        public Java.Math.BigInteger Eon
        {
            get { return IExecute<Java.Math.BigInteger>("getEon"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getEonAndYear()"/> 
        /// </summary>
        public Java.Math.BigInteger EonAndYear
        {
            get { return IExecute<Java.Math.BigInteger>("getEonAndYear"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getFractionalSecond()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setFractionalSecond(java.math.BigDecimal)"/>
        /// </summary>
        public Java.Math.BigDecimal FractionalSecond
        {
            get { return IExecute<Java.Math.BigDecimal>("getFractionalSecond"); } set { IExecute("setFractionalSecond", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getHour()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setHour(int)"/>
        /// </summary>
        public int Hour
        {
            get { return IExecute<int>("getHour"); } set { IExecute("setHour", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#isValid()"/> 
        /// </summary>
        public bool IsValid
        {
            get { return IExecute<bool>("isValid"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getMillisecond()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setMillisecond(int)"/>
        /// </summary>
        public int Millisecond
        {
            get { return IExecute<int>("getMillisecond"); } set { IExecute("setMillisecond", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getMinute()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setMinute(int)"/>
        /// </summary>
        public int Minute
        {
            get { return IExecute<int>("getMinute"); } set { IExecute("setMinute", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getMonth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setMonth(int)"/>
        /// </summary>
        public int Month
        {
            get { return IExecute<int>("getMonth"); } set { IExecute("setMonth", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#normalize()"/> 
        /// </summary>
        public Javax.Xml.Datatype.XMLGregorianCalendar Normalize
        {
            get { return IExecute<Javax.Xml.Datatype.XMLGregorianCalendar>("normalize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getSecond()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setSecond(int)"/>
        /// </summary>
        public int Second
        {
            get { return IExecute<int>("getSecond"); } set { IExecute("setSecond", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getTimezone()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setTimezone(int)"/>
        /// </summary>
        public int Timezone
        {
            get { return IExecute<int>("getTimezone"); } set { IExecute("setTimezone", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#toXMLFormat()"/> 
        /// </summary>
        public string ToXMLFormat
        {
            get { return IExecute<string>("toXMLFormat"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getXMLSchemaType()"/> 
        /// </summary>
        public Javax.Xml.Namespace.QName XMLSchemaType
        {
            get { return IExecute<Javax.Xml.Namespace.QName>("getXMLSchemaType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getYear()"/> 
        /// </summary>
        public int Year
        {
            get { return IExecute<int>("getYear"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#compare(javax.xml.datatype.XMLGregorianCalendar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.XMLGregorianCalendar"/></param>
        /// <returns><see cref="int"/></returns>
        public int Compare(Javax.Xml.Datatype.XMLGregorianCalendar arg0)
        {
            return IExecute<int>("compare", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#toGregorianCalendar()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.GregorianCalendar"/></returns>
        public Java.Util.GregorianCalendar ToGregorianCalendar()
        {
            return IExecute<Java.Util.GregorianCalendar>("toGregorianCalendar");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#toGregorianCalendar(java.util.TimeZone,java.util.Locale,javax.xml.datatype.XMLGregorianCalendar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.TimeZone"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="Javax.Xml.Datatype.XMLGregorianCalendar"/></param>
        /// <returns><see cref="Java.Util.GregorianCalendar"/></returns>
        public Java.Util.GregorianCalendar ToGregorianCalendar(Java.Util.TimeZone arg0, Java.Util.Locale arg1, Javax.Xml.Datatype.XMLGregorianCalendar arg2)
        {
            return IExecute<Java.Util.GregorianCalendar>("toGregorianCalendar", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getTimeZone(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.TimeZone"/></returns>
        public Java.Util.TimeZone GetTimeZone(int arg0)
        {
            return IExecute<Java.Util.TimeZone>("getTimeZone", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#add(javax.xml.datatype.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.Duration"/></param>
        public void Add(Javax.Xml.Datatype.Duration arg0)
        {
            IExecute("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetYear(int arg0)
        {
            IExecute("setYear", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setYear(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        public void SetYear(Java.Math.BigInteger arg0)
        {
            IExecute("setYear", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setTime(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetTime(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setTime", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setTime(int,int,int,java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Math.BigDecimal"/></param>
        public void SetTime(int arg0, int arg1, int arg2, Java.Math.BigDecimal arg3)
        {
            IExecute("setTime", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setTime(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetTime(int arg0, int arg1, int arg2)
        {
            IExecute("setTime", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}