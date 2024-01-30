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

namespace Java.Util
{
    #region Properties
    public partial class Properties
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Properties(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#%3Cinit%3E(java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Properties"/></param>
        public Properties(Java.Util.Properties arg0)
            : base(arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#getProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetProperty(string arg0, string arg1)
        {
            return IExecute<string>("getProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetProperty(string arg0)
        {
            return IExecute<string>("getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#propertyNames()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<object> PropertyNames()
        {
            return IExecute<Java.Util.Enumeration<object>>("propertyNames");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#stringPropertyNames()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<string> StringPropertyNames()
        {
            return IExecute<Java.Util.Set<string>>("stringPropertyNames");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#setProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object SetProperty(string arg0, string arg1)
        {
            return IExecute("setProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#load(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Load(Java.Io.InputStream arg0)
        {
            IExecute("load", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#load(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Load(Java.Io.Reader arg0)
        {
            IExecute("load", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#loadFromXML(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Util.InvalidPropertiesFormatException"/>
        public void LoadFromXML(Java.Io.InputStream arg0)
        {
            IExecute("loadFromXML", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#list(java.io.PrintStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintStream"/></param>
        public void List(Java.Io.PrintStream arg0)
        {
            IExecute("list", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#list(java.io.PrintWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintWriter"/></param>
        public void List(Java.Io.PrintWriter arg0)
        {
            IExecute("list", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#store(java.io.OutputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Store(Java.Io.OutputStream arg0, string arg1)
        {
            IExecute("store", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#store(java.io.Writer,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Store(Java.Io.Writer arg0, string arg1)
        {
            IExecute("store", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#storeToXML(java.io.OutputStream,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void StoreToXML(Java.Io.OutputStream arg0, string arg1, string arg2)
        {
            IExecute("storeToXML", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#storeToXML(java.io.OutputStream,java.lang.String,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void StoreToXML(Java.Io.OutputStream arg0, string arg1, Java.Nio.Charset.Charset arg2)
        {
            IExecute("storeToXML", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Properties.html#storeToXML(java.io.OutputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void StoreToXML(Java.Io.OutputStream arg0, string arg1)
        {
            IExecute("storeToXML", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}