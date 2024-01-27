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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Datatransfer
{
    #region SystemFlavorMap
    public partial class SystemFlavorMap
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Datatransfer.SystemFlavorMap"/> to <see cref="Java.Awt.Datatransfer.FlavorMap"/>
        /// </summary>
        public static implicit operator Java.Awt.Datatransfer.FlavorMap(Java.Awt.Datatransfer.SystemFlavorMap t) => t.Cast<Java.Awt.Datatransfer.FlavorMap>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Datatransfer.SystemFlavorMap"/> to <see cref="Java.Awt.Datatransfer.FlavorTable"/>
        /// </summary>
        public static implicit operator Java.Awt.Datatransfer.FlavorTable(Java.Awt.Datatransfer.SystemFlavorMap t) => t.Cast<Java.Awt.Datatransfer.FlavorTable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#getDefaultFlavorMap()"/> 
        /// </summary>
        public static Java.Awt.Datatransfer.FlavorMap DefaultFlavorMap
        {
            get { return SExecute<Java.Awt.Datatransfer.FlavorMap>(LocalBridgeClazz, "getDefaultFlavorMap"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#isJavaMIMEType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsJavaMIMEType(string arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isJavaMIMEType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#decodeDataFlavor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Awt.Datatransfer.DataFlavor"/></returns>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public static Java.Awt.Datatransfer.DataFlavor DecodeDataFlavor(string arg0)
        {
            return SExecute<Java.Awt.Datatransfer.DataFlavor>(LocalBridgeClazz, "decodeDataFlavor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#decodeJavaMIMEType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public static string DecodeJavaMIMEType(string arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "decodeJavaMIMEType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#encodeDataFlavor(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="string"/></returns>
        public static string EncodeDataFlavor(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "encodeDataFlavor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#encodeJavaMIMEType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public static string EncodeJavaMIMEType(string arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "encodeJavaMIMEType", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#getFlavorsForNative(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Awt.Datatransfer.DataFlavor> GetFlavorsForNative(string arg0)
        {
            return IExecute<Java.Util.List<Java.Awt.Datatransfer.DataFlavor>>("getFlavorsForNative", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#getNativesForFlavor(java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<string> GetNativesForFlavor(Java.Awt.Datatransfer.DataFlavor arg0)
        {
            return IExecute<Java.Util.List<string>>("getNativesForFlavor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#getNativesForFlavors(java.awt.datatransfer.DataFlavor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Awt.Datatransfer.DataFlavor, string> GetNativesForFlavors(Java.Awt.Datatransfer.DataFlavor[] arg0)
        {
            return IExecute<Java.Util.Map<Java.Awt.Datatransfer.DataFlavor, string>>("getNativesForFlavors", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#getFlavorsForNatives(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, Java.Awt.Datatransfer.DataFlavor> GetFlavorsForNatives(string[] arg0)
        {
            return IExecute<Java.Util.Map<string, Java.Awt.Datatransfer.DataFlavor>>("getFlavorsForNatives", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#addFlavorForUnencodedNative(java.lang.String,java.awt.datatransfer.DataFlavor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        public void AddFlavorForUnencodedNative(string arg0, Java.Awt.Datatransfer.DataFlavor arg1)
        {
            IExecute("addFlavorForUnencodedNative", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#addUnencodedNativeForFlavor(java.awt.datatransfer.DataFlavor,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public void AddUnencodedNativeForFlavor(Java.Awt.Datatransfer.DataFlavor arg0, string arg1)
        {
            IExecute("addUnencodedNativeForFlavor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#setFlavorsForNative(java.lang.String,java.awt.datatransfer.DataFlavor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        public void SetFlavorsForNative(string arg0, Java.Awt.Datatransfer.DataFlavor[] arg1)
        {
            IExecute("setFlavorsForNative", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/SystemFlavorMap.html#setNativesForFlavor(java.awt.datatransfer.DataFlavor,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public void SetNativesForFlavor(Java.Awt.Datatransfer.DataFlavor arg0, string[] arg1)
        {
            IExecute("setNativesForFlavor", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}