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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Logging
{
    #region Level
    public partial class Level
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Logging.Level"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Logging.Level t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#ALL"/>
        /// </summary>
        public static Java.Util.Logging.Level ALL => Clazz.GetField<Java.Util.Logging.Level>("ALL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#CONFIG"/>
        /// </summary>
        public static Java.Util.Logging.Level CONFIG => Clazz.GetField<Java.Util.Logging.Level>("CONFIG");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#FINE"/>
        /// </summary>
        public static Java.Util.Logging.Level FINE => Clazz.GetField<Java.Util.Logging.Level>("FINE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#FINER"/>
        /// </summary>
        public static Java.Util.Logging.Level FINER => Clazz.GetField<Java.Util.Logging.Level>("FINER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#FINEST"/>
        /// </summary>
        public static Java.Util.Logging.Level FINEST => Clazz.GetField<Java.Util.Logging.Level>("FINEST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#INFO"/>
        /// </summary>
        public static Java.Util.Logging.Level INFO => Clazz.GetField<Java.Util.Logging.Level>("INFO");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#OFF"/>
        /// </summary>
        public static Java.Util.Logging.Level OFF => Clazz.GetField<Java.Util.Logging.Level>("OFF");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#SEVERE"/>
        /// </summary>
        public static Java.Util.Logging.Level SEVERE => Clazz.GetField<Java.Util.Logging.Level>("SEVERE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#WARNING"/>
        /// </summary>
        public static Java.Util.Logging.Level WARNING => Clazz.GetField<Java.Util.Logging.Level>("WARNING");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Logging.Level"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public static Java.Util.Logging.Level Parse(string arg0)
        {
            return SExecute<Java.Util.Logging.Level>("parse", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#getLocalizedName()"/> 
        /// </summary>
        public string LocalizedName
        {
            get { return IExecute<string>("getLocalizedName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#getResourceBundleName()"/> 
        /// </summary>
        public string ResourceBundleName
        {
            get { return IExecute<string>("getResourceBundleName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Level.html#intValue()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int IntValue()
        {
            return IExecute<int>("intValue");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}