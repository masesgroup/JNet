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

namespace Java.Lang
{
    #region ClassLoader
    public partial class ClassLoader
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getPlatformClassLoader() 
        /// </summary>
        public static Java.Lang.ClassLoader PlatformClassLoader
        {
            get { return SExecute<Java.Lang.ClassLoader>("getPlatformClassLoader"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getSystemClassLoader() 
        /// </summary>
        public static Java.Lang.ClassLoader SystemClassLoader
        {
            get { return SExecute<Java.Lang.ClassLoader>("getSystemClassLoader"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getSystemResourceAsStream(java.lang.String)
        /// </summary>
        public static Java.Io.InputStream GetSystemResourceAsStream(string arg0)
        {
            return SExecute<Java.Io.InputStream>("getSystemResourceAsStream", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getSystemResource(java.lang.String)
        /// </summary>
        public static Java.Net.URL GetSystemResource(string arg0)
        {
            return SExecute<Java.Net.URL>("getSystemResource", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getDefinedPackages() 
        /// </summary>
        public Java.Lang.Package[] DefinedPackages
        {
            get { return IExecuteArray<Java.Lang.Package>("getDefinedPackages"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getName() 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getParent() 
        /// </summary>
        public Java.Lang.ClassLoader Parent
        {
            get { return IExecute<Java.Lang.ClassLoader>("getParent"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getUnnamedModule() 
        /// </summary>
        public Java.Lang.Module UnnamedModule
        {
            get { return IExecute<Java.Lang.Module>("getUnnamedModule"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#isRegisteredAsParallelCapable()
        /// </summary>
        public bool IsRegisteredAsParallelCapable()
        {
            return IExecute<bool>("isRegisteredAsParallelCapable");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getDefinedPackage(java.lang.String)
        /// </summary>
        public Java.Lang.Package GetDefinedPackage(string arg0)
        {
            return IExecute<Java.Lang.Package>("getDefinedPackage", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getResourceAsStream(java.lang.String)
        /// </summary>
        public Java.Io.InputStream GetResourceAsStream(string arg0)
        {
            return IExecute<Java.Io.InputStream>("getResourceAsStream", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#getResource(java.lang.String)
        /// </summary>
        public Java.Net.URL GetResource(string arg0)
        {
            return IExecute<Java.Net.URL>("getResource", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#clearAssertionStatus()
        /// </summary>
        public void ClearAssertionStatus()
        {
            IExecute("clearAssertionStatus");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#setClassAssertionStatus(java.lang.String,boolean)
        /// </summary>
        public void SetClassAssertionStatus(string arg0, bool arg1)
        {
            IExecute("setClassAssertionStatus", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#setDefaultAssertionStatus(boolean)
        /// </summary>
        public void SetDefaultAssertionStatus(bool arg0)
        {
            IExecute("setDefaultAssertionStatus", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ClassLoader.html#setPackageAssertionStatus(java.lang.String,boolean)
        /// </summary>
        public void SetPackageAssertionStatus(string arg0, bool arg1)
        {
            IExecute("setPackageAssertionStatus", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}