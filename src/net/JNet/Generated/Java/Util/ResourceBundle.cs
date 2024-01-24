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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region ResourceBundle
    public partial class ResourceBundle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String,java.util.Locale,java.util.ResourceBundle.Control)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="Java.Util.ResourceBundle.Control"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(string arg0, Java.Util.Locale arg1, Java.Util.ResourceBundle.Control arg2)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(string arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String,java.util.ResourceBundle.Control)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.ResourceBundle.Control"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(string arg0, Java.Util.ResourceBundle.Control arg1)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(string arg0)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#clearCache()"/>
        /// </summary>
        public static void ClearCache()
        {
            SExecute(LocalBridgeClazz, "clearCache");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#clearCache(java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ClassLoader"/></param>
        public static void ClearCache(Java.Lang.ClassLoader arg0)
        {
            SExecute(LocalBridgeClazz, "clearCache", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String,java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(string arg0, Java.Lang.Module arg1)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String,java.util.Locale,java.lang.ClassLoader,java.util.ResourceBundle.Control)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg3"><see cref="Java.Util.ResourceBundle.Control"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(string arg0, Java.Util.Locale arg1, Java.Lang.ClassLoader arg2, Java.Util.ResourceBundle.Control arg3)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String,java.util.Locale,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(string arg0, Java.Util.Locale arg1, Java.Lang.ClassLoader arg2)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String,java.util.Locale,java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(string arg0, Java.Util.Locale arg1, Java.Lang.Module arg2)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#getBaseBundleName()"/> 
        /// </summary>
        public string BaseBundleName
        {
            get { return IExecute<string>("getBaseBundleName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#getKeys()"/> 
        /// </summary>
        public Java.Util.Enumeration<string> Keys
        {
            get { return IExecute<Java.Util.Enumeration<string>>("getKeys"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#getLocale()"/> 
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecute<Java.Util.Locale>("getLocale"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#containsKey(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(string arg0)
        {
            return IExecute<bool>("containsKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#getObject(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetObject(string arg0)
        {
            return IExecute("getObject", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#getString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetString(string arg0)
        {
            return IExecute<string>("getString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#getStringArray(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] GetStringArray(string arg0)
        {
            return IExecuteArray<string>("getStringArray", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.html#keySet()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<string> KeySet()
        {
            return IExecute<Java.Util.Set<string>>("keySet");
        }

        #endregion

        #region Nested classes
        #region Control
        public partial class Control
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#FORMAT_CLASS"/>
            /// </summary>
            public static Java.Util.List FORMAT_CLASS { get { if (!_FORMAT_CLASSReady) { _FORMAT_CLASSContent = SGetField<Java.Util.List>(LocalBridgeClazz, "FORMAT_CLASS"); _FORMAT_CLASSReady = true; } return _FORMAT_CLASSContent; } }
            private static Java.Util.List _FORMAT_CLASSContent = default;
            private static bool _FORMAT_CLASSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#FORMAT_DEFAULT"/>
            /// </summary>
            public static Java.Util.List FORMAT_DEFAULT { get { if (!_FORMAT_DEFAULTReady) { _FORMAT_DEFAULTContent = SGetField<Java.Util.List>(LocalBridgeClazz, "FORMAT_DEFAULT"); _FORMAT_DEFAULTReady = true; } return _FORMAT_DEFAULTContent; } }
            private static Java.Util.List _FORMAT_DEFAULTContent = default;
            private static bool _FORMAT_DEFAULTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#FORMAT_PROPERTIES"/>
            /// </summary>
            public static Java.Util.List FORMAT_PROPERTIES { get { if (!_FORMAT_PROPERTIESReady) { _FORMAT_PROPERTIESContent = SGetField<Java.Util.List>(LocalBridgeClazz, "FORMAT_PROPERTIES"); _FORMAT_PROPERTIESReady = true; } return _FORMAT_PROPERTIESContent; } }
            private static Java.Util.List _FORMAT_PROPERTIESContent = default;
            private static bool _FORMAT_PROPERTIESReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#TTL_DONT_CACHE"/>
            /// </summary>
            public static long TTL_DONT_CACHE { get { if (!_TTL_DONT_CACHEReady) { _TTL_DONT_CACHEContent = SGetField<long>(LocalBridgeClazz, "TTL_DONT_CACHE"); _TTL_DONT_CACHEReady = true; } return _TTL_DONT_CACHEContent; } }
            private static long _TTL_DONT_CACHEContent = default;
            private static bool _TTL_DONT_CACHEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#TTL_NO_EXPIRATION_CONTROL"/>
            /// </summary>
            public static long TTL_NO_EXPIRATION_CONTROL { get { if (!_TTL_NO_EXPIRATION_CONTROLReady) { _TTL_NO_EXPIRATION_CONTROLContent = SGetField<long>(LocalBridgeClazz, "TTL_NO_EXPIRATION_CONTROL"); _TTL_NO_EXPIRATION_CONTROLReady = true; } return _TTL_NO_EXPIRATION_CONTROLContent; } }
            private static long _TTL_NO_EXPIRATION_CONTROLContent = default;
            private static bool _TTL_NO_EXPIRATION_CONTROLReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#getControl(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Java.Util.ResourceBundle.Control"/></returns>
            public static Java.Util.ResourceBundle.Control GetControl(Java.Util.List<string> arg0)
            {
                return SExecute<Java.Util.ResourceBundle.Control>(LocalBridgeClazz, "getControl", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#getNoFallbackControl(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Java.Util.ResourceBundle.Control"/></returns>
            public static Java.Util.ResourceBundle.Control GetNoFallbackControl(Java.Util.List<string> arg0)
            {
                return SExecute<Java.Util.ResourceBundle.Control>(LocalBridgeClazz, "getNoFallbackControl", arg0);
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#needsReload(java.lang.String,java.util.Locale,java.lang.String,java.lang.ClassLoader,java.util.ResourceBundle,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
            /// <param name="arg2"><see cref="string"/></param>
            /// <param name="arg3"><see cref="Java.Lang.ClassLoader"/></param>
            /// <param name="arg4"><see cref="Java.Util.ResourceBundle"/></param>
            /// <param name="arg5"><see cref="long"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool NeedsReload(string arg0, Java.Util.Locale arg1, string arg2, Java.Lang.ClassLoader arg3, Java.Util.ResourceBundle arg4, long arg5)
            {
                return IExecute<bool>("needsReload", arg0, arg1, arg2, arg3, arg4, arg5);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#toResourceName(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <returns><see cref="string"/></returns>
            public string ToResourceName(string arg0, string arg1)
            {
                return IExecute<string>("toResourceName", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#toBundleName(java.lang.String,java.util.Locale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
            /// <returns><see cref="string"/></returns>
            public string ToBundleName(string arg0, Java.Util.Locale arg1)
            {
                return IExecute<string>("toBundleName", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#getFormats(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<string> GetFormats(string arg0)
            {
                return IExecute<Java.Util.List<string>>("getFormats", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#getCandidateLocales(java.lang.String,java.util.Locale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Java.Util.Locale> GetCandidateLocales(string arg0, Java.Util.Locale arg1)
            {
                return IExecute<Java.Util.List<Java.Util.Locale>>("getCandidateLocales", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#getFallbackLocale(java.lang.String,java.util.Locale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
            /// <returns><see cref="Java.Util.Locale"/></returns>
            public Java.Util.Locale GetFallbackLocale(string arg0, Java.Util.Locale arg1)
            {
                return IExecute<Java.Util.Locale>("getFallbackLocale", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#newBundle(java.lang.String,java.util.Locale,java.lang.String,java.lang.ClassLoader,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
            /// <param name="arg2"><see cref="string"/></param>
            /// <param name="arg3"><see cref="Java.Lang.ClassLoader"/></param>
            /// <param name="arg4"><see cref="bool"/></param>
            /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
            /// <exception cref="Java.Lang.IllegalAccessException"/>
            /// <exception cref="Java.Lang.InstantiationException"/>
            /// <exception cref="Java.Io.IOException"/>
            public Java.Util.ResourceBundle NewBundle(string arg0, Java.Util.Locale arg1, string arg2, Java.Lang.ClassLoader arg3, bool arg4)
            {
                return IExecute<Java.Util.ResourceBundle>("newBundle", arg0, arg1, arg2, arg3, arg4);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ResourceBundle.Control.html#getTimeToLive(java.lang.String,java.util.Locale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
            /// <returns><see cref="long"/></returns>
            public long GetTimeToLive(string arg0, Java.Util.Locale arg1)
            {
                return IExecute<long>("getTimeToLive", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}