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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans
{
    #region XMLDecoder
    public partial class XMLDecoder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLDecoder.html#%3Cinit%3E(java.io.InputStream,java.lang.Object,java.beans.ExceptionListener,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Beans.ExceptionListener"/></param>
        /// <param name="arg3"><see cref="Java.Lang.ClassLoader"/></param>
        public XMLDecoder(Java.Io.InputStream arg0, object arg1, Java.Beans.ExceptionListener arg2, Java.Lang.ClassLoader arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLDecoder.html#%3Cinit%3E(java.io.InputStream,java.lang.Object,java.beans.ExceptionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Beans.ExceptionListener"/></param>
        public XMLDecoder(Java.Io.InputStream arg0, object arg1, Java.Beans.ExceptionListener arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLDecoder.html#%3Cinit%3E(java.io.InputStream,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public XMLDecoder(Java.Io.InputStream arg0, object arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLDecoder.html#%3Cinit%3E(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        public XMLDecoder(Java.Io.InputStream arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLDecoder.html#%3Cinit%3E(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        public XMLDecoder(Org.Xml.Sax.InputSource arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLDecoder.html#createHandler(java.lang.Object,java.beans.ExceptionListener,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Beans.ExceptionListener"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Org.Xml.Sax.Helpers.DefaultHandler"/></returns>
        public static Org.Xml.Sax.Helpers.DefaultHandler CreateHandler(object arg0, Java.Beans.ExceptionListener arg1, Java.Lang.ClassLoader arg2)
        {
            return SExecute<Org.Xml.Sax.Helpers.DefaultHandler>(LocalBridgeClazz, "createHandler", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLDecoder.html#getExceptionListener()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLDecoder.html#setExceptionListener(java.beans.ExceptionListener)"/>
        /// </summary>
        public Java.Beans.ExceptionListener ExceptionListener
        {
            get { return IExecute<Java.Beans.ExceptionListener>("getExceptionListener"); } set { IExecute("setExceptionListener", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLDecoder.html#getOwner()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLDecoder.html#setOwner(java.lang.Object)"/>
        /// </summary>
        public object Owner
        {
            get { return IExecute("getOwner"); } set { IExecute("setOwner", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLDecoder.html#readObject()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object ReadObject()
        {
            return IExecute("readObject");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLDecoder.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}