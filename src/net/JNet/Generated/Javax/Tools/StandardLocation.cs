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

namespace Javax.Tools
{
    #region StandardLocation
    public partial class StandardLocation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#ANNOTATION_PROCESSOR_MODULE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation ANNOTATION_PROCESSOR_MODULE_PATH { get { if (!_ANNOTATION_PROCESSOR_MODULE_PATHReady) { _ANNOTATION_PROCESSOR_MODULE_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "ANNOTATION_PROCESSOR_MODULE_PATH"); _ANNOTATION_PROCESSOR_MODULE_PATHReady = true; } return _ANNOTATION_PROCESSOR_MODULE_PATHContent; } }
        private static Javax.Tools.StandardLocation _ANNOTATION_PROCESSOR_MODULE_PATHContent = default;
        private static bool _ANNOTATION_PROCESSOR_MODULE_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#ANNOTATION_PROCESSOR_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation ANNOTATION_PROCESSOR_PATH { get { if (!_ANNOTATION_PROCESSOR_PATHReady) { _ANNOTATION_PROCESSOR_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "ANNOTATION_PROCESSOR_PATH"); _ANNOTATION_PROCESSOR_PATHReady = true; } return _ANNOTATION_PROCESSOR_PATHContent; } }
        private static Javax.Tools.StandardLocation _ANNOTATION_PROCESSOR_PATHContent = default;
        private static bool _ANNOTATION_PROCESSOR_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#CLASS_OUTPUT"/>
        /// </summary>
        public static Javax.Tools.StandardLocation CLASS_OUTPUT { get { if (!_CLASS_OUTPUTReady) { _CLASS_OUTPUTContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "CLASS_OUTPUT"); _CLASS_OUTPUTReady = true; } return _CLASS_OUTPUTContent; } }
        private static Javax.Tools.StandardLocation _CLASS_OUTPUTContent = default;
        private static bool _CLASS_OUTPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#CLASS_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation CLASS_PATH { get { if (!_CLASS_PATHReady) { _CLASS_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "CLASS_PATH"); _CLASS_PATHReady = true; } return _CLASS_PATHContent; } }
        private static Javax.Tools.StandardLocation _CLASS_PATHContent = default;
        private static bool _CLASS_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#MODULE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation MODULE_PATH { get { if (!_MODULE_PATHReady) { _MODULE_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "MODULE_PATH"); _MODULE_PATHReady = true; } return _MODULE_PATHContent; } }
        private static Javax.Tools.StandardLocation _MODULE_PATHContent = default;
        private static bool _MODULE_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#MODULE_SOURCE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation MODULE_SOURCE_PATH { get { if (!_MODULE_SOURCE_PATHReady) { _MODULE_SOURCE_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "MODULE_SOURCE_PATH"); _MODULE_SOURCE_PATHReady = true; } return _MODULE_SOURCE_PATHContent; } }
        private static Javax.Tools.StandardLocation _MODULE_SOURCE_PATHContent = default;
        private static bool _MODULE_SOURCE_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#NATIVE_HEADER_OUTPUT"/>
        /// </summary>
        public static Javax.Tools.StandardLocation NATIVE_HEADER_OUTPUT { get { if (!_NATIVE_HEADER_OUTPUTReady) { _NATIVE_HEADER_OUTPUTContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "NATIVE_HEADER_OUTPUT"); _NATIVE_HEADER_OUTPUTReady = true; } return _NATIVE_HEADER_OUTPUTContent; } }
        private static Javax.Tools.StandardLocation _NATIVE_HEADER_OUTPUTContent = default;
        private static bool _NATIVE_HEADER_OUTPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#PATCH_MODULE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation PATCH_MODULE_PATH { get { if (!_PATCH_MODULE_PATHReady) { _PATCH_MODULE_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "PATCH_MODULE_PATH"); _PATCH_MODULE_PATHReady = true; } return _PATCH_MODULE_PATHContent; } }
        private static Javax.Tools.StandardLocation _PATCH_MODULE_PATHContent = default;
        private static bool _PATCH_MODULE_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#PLATFORM_CLASS_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation PLATFORM_CLASS_PATH { get { if (!_PLATFORM_CLASS_PATHReady) { _PLATFORM_CLASS_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "PLATFORM_CLASS_PATH"); _PLATFORM_CLASS_PATHReady = true; } return _PLATFORM_CLASS_PATHContent; } }
        private static Javax.Tools.StandardLocation _PLATFORM_CLASS_PATHContent = default;
        private static bool _PLATFORM_CLASS_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#SOURCE_OUTPUT"/>
        /// </summary>
        public static Javax.Tools.StandardLocation SOURCE_OUTPUT { get { if (!_SOURCE_OUTPUTReady) { _SOURCE_OUTPUTContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "SOURCE_OUTPUT"); _SOURCE_OUTPUTReady = true; } return _SOURCE_OUTPUTContent; } }
        private static Javax.Tools.StandardLocation _SOURCE_OUTPUTContent = default;
        private static bool _SOURCE_OUTPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#SOURCE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation SOURCE_PATH { get { if (!_SOURCE_PATHReady) { _SOURCE_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "SOURCE_PATH"); _SOURCE_PATHReady = true; } return _SOURCE_PATHContent; } }
        private static Javax.Tools.StandardLocation _SOURCE_PATHContent = default;
        private static bool _SOURCE_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#SYSTEM_MODULES"/>
        /// </summary>
        public static Javax.Tools.StandardLocation SYSTEM_MODULES { get { if (!_SYSTEM_MODULESReady) { _SYSTEM_MODULESContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "SYSTEM_MODULES"); _SYSTEM_MODULESReady = true; } return _SYSTEM_MODULESContent; } }
        private static Javax.Tools.StandardLocation _SYSTEM_MODULESContent = default;
        private static bool _SYSTEM_MODULESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#UPGRADE_MODULE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation UPGRADE_MODULE_PATH { get { if (!_UPGRADE_MODULE_PATHReady) { _UPGRADE_MODULE_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "UPGRADE_MODULE_PATH"); _UPGRADE_MODULE_PATHReady = true; } return _UPGRADE_MODULE_PATHContent; } }
        private static Javax.Tools.StandardLocation _UPGRADE_MODULE_PATHContent = default;
        private static bool _UPGRADE_MODULE_PATHReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#locationFor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileManager.Location"/></returns>
        public static Javax.Tools.JavaFileManager.Location LocationFor(string arg0)
        {
            return SExecute<Javax.Tools.JavaFileManager.Location>(LocalBridgeClazz, "locationFor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Tools.StandardLocation"/></returns>
        public static Javax.Tools.StandardLocation ValueOf(string arg0)
        {
            return SExecute<Javax.Tools.StandardLocation>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#values()"/>
        /// </summary>

        /// <returns><see cref="Javax.Tools.StandardLocation"/></returns>
        public static Javax.Tools.StandardLocation[] Values()
        {
            return SExecuteArray<Javax.Tools.StandardLocation>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#isModuleOrientedLocation()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsModuleOrientedLocation()
        {
            return IExecute<bool>("isModuleOrientedLocation");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#isOutputLocation()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsOutputLocation()
        {
            return IExecute<bool>("isOutputLocation");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}