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

namespace Org.Xml.Sax.Helpers
{
    #region NamespaceSupport
    public partial class NamespaceSupport
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#NSDECL"/>
        /// </summary>
        public static string NSDECL => Clazz.GetField<string>("NSDECL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#XMLNS"/>
        /// </summary>
        public static string XMLNS => Clazz.GetField<string>("XMLNS");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#getDeclaredPrefixes()"/> 
        /// </summary>
        public Java.Util.Enumeration DeclaredPrefixes
        {
            get { return IExecute<Java.Util.Enumeration>("getDeclaredPrefixes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#getPrefixes()"/> 
        /// </summary>
        public Java.Util.Enumeration Prefixes
        {
            get { return IExecute<Java.Util.Enumeration>("getPrefixes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#declarePrefix(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool DeclarePrefix(string arg0, string arg1)
        {
            return IExecute<bool>("declarePrefix", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#isNamespaceDeclUris()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsNamespaceDeclUris()
        {
            return IExecute<bool>("isNamespaceDeclUris");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#getPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see langword="string"/></returns>
        public string GetPrefix(string arg0)
        {
            return IExecute<string>("getPrefix", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#getURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see langword="string"/></returns>
        public string GetURI(string arg0)
        {
            return IExecute<string>("getURI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#processName(java.lang.String,java.lang.String[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] ProcessName(string arg0, string[] arg1, bool arg2)
        {
            return IExecuteArray<string>("processName", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#getPrefixes(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration GetPrefixes(string arg0)
        {
            return IExecute<Java.Util.Enumeration>("getPrefixes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#popContext()"/>
        /// </summary>
        public void PopContext()
        {
            IExecute("popContext");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#pushContext()"/>
        /// </summary>
        public void PushContext()
        {
            IExecute("pushContext");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#setNamespaceDeclUris(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetNamespaceDeclUris(bool arg0)
        {
            IExecute("setNamespaceDeclUris", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}