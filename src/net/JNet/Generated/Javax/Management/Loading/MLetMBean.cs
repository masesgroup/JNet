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

namespace Javax.Management.Loading
{
    #region MLetMBean
    public partial class MLetMBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getLibraryDirectory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#setLibraryDirectory(java.lang.String)"/>
        /// </summary>
        public string LibraryDirectory
        {
            get { return IExecute<string>("getLibraryDirectory"); } set { IExecute("setLibraryDirectory", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getURLs()"/> 
        /// </summary>
        public Java.Net.URL[] URLs
        {
            get { return IExecuteArray<Java.Net.URL>("getURLs"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getResourceAsStream(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        public Java.Io.InputStream GetResourceAsStream(string arg0)
        {
            return IExecute<Java.Io.InputStream>("getResourceAsStream", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getResource(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Net.URL"/></returns>
        public Java.Net.URL GetResource(string arg0)
        {
            return IExecute<Java.Net.URL>("getResource", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getResources(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Enumeration<Java.Net.URL> GetResources(string arg0)
        {
            return IExecute<Java.Util.Enumeration<Java.Net.URL>>("getResources", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getMBeansFromURL(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        public Java.Util.Set<object> GetMBeansFromURL(string arg0)
        {
            return IExecute<Java.Util.Set<object>>("getMBeansFromURL", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#getMBeansFromURL(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        public Java.Util.Set<object> GetMBeansFromURL(Java.Net.URL arg0)
        {
            return IExecute<Java.Util.Set<object>>("getMBeansFromURL", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#addURL(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Management.ServiceNotFoundException"/>
        public void AddURL(string arg0)
        {
            IExecute("addURL", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/loading/MLetMBean.html#addURL(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        public void AddURL(Java.Net.URL arg0)
        {
            IExecute("addURL", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}