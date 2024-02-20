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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Tools
{
    #region Diagnostic
    public partial class Diagnostic
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#NOPOS"/>
        /// </summary>
        public static long NOPOS { get { if (!_NOPOSReady) { _NOPOSContent = SGetField<long>(LocalBridgeClazz, "NOPOS"); _NOPOSReady = true; } return _NOPOSContent; } }
        private static long _NOPOSContent = default;
        private static bool _NOPOSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getCode()"/> 
        /// </summary>
        public Java.Lang.String Code
        {
            get { return IExecute<Java.Lang.String>("getCode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getColumnNumber()"/> 
        /// </summary>
        public long ColumnNumber
        {
            get { return IExecute<long>("getColumnNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getEndPosition()"/> 
        /// </summary>
        public long EndPosition
        {
            get { return IExecute<long>("getEndPosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getKind()"/> 
        /// </summary>
        public Javax.Tools.Diagnostic.Kind GetKind
        {
            get { return IExecute<Javax.Tools.Diagnostic.Kind>("getKind"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getLineNumber()"/> 
        /// </summary>
        public long LineNumber
        {
            get { return IExecute<long>("getLineNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getPosition()"/> 
        /// </summary>
        public long Position
        {
            get { return IExecute<long>("getPosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getSource()"/> 
        /// </summary>
        public object Source
        {
            get { return IExecute("getSource"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getStartPosition()"/> 
        /// </summary>
        public long StartPosition
        {
            get { return IExecute<long>("getStartPosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getMessage(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMessage(Java.Util.Locale arg0)
        {
            return IExecute<Java.Lang.String>("getMessage", arg0);
        }

        #endregion

        #region Nested classes
        #region Kind
        public partial class Kind
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.Kind.html#ERROR"/>
            /// </summary>
            public static Javax.Tools.Diagnostic.Kind ERROR { get { if (!_ERRORReady) { _ERRORContent = SGetField<Javax.Tools.Diagnostic.Kind>(LocalBridgeClazz, "ERROR"); _ERRORReady = true; } return _ERRORContent; } }
            private static Javax.Tools.Diagnostic.Kind _ERRORContent = default;
            private static bool _ERRORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.Kind.html#MANDATORY_WARNING"/>
            /// </summary>
            public static Javax.Tools.Diagnostic.Kind MANDATORY_WARNING { get { if (!_MANDATORY_WARNINGReady) { _MANDATORY_WARNINGContent = SGetField<Javax.Tools.Diagnostic.Kind>(LocalBridgeClazz, "MANDATORY_WARNING"); _MANDATORY_WARNINGReady = true; } return _MANDATORY_WARNINGContent; } }
            private static Javax.Tools.Diagnostic.Kind _MANDATORY_WARNINGContent = default;
            private static bool _MANDATORY_WARNINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.Kind.html#NOTE"/>
            /// </summary>
            public static Javax.Tools.Diagnostic.Kind NOTE { get { if (!_NOTEReady) { _NOTEContent = SGetField<Javax.Tools.Diagnostic.Kind>(LocalBridgeClazz, "NOTE"); _NOTEReady = true; } return _NOTEContent; } }
            private static Javax.Tools.Diagnostic.Kind _NOTEContent = default;
            private static bool _NOTEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.Kind.html#OTHER"/>
            /// </summary>
            public static Javax.Tools.Diagnostic.Kind OTHER { get { if (!_OTHERReady) { _OTHERContent = SGetField<Javax.Tools.Diagnostic.Kind>(LocalBridgeClazz, "OTHER"); _OTHERReady = true; } return _OTHERContent; } }
            private static Javax.Tools.Diagnostic.Kind _OTHERContent = default;
            private static bool _OTHERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.Kind.html#WARNING"/>
            /// </summary>
            public static Javax.Tools.Diagnostic.Kind WARNING { get { if (!_WARNINGReady) { _WARNINGContent = SGetField<Javax.Tools.Diagnostic.Kind>(LocalBridgeClazz, "WARNING"); _WARNINGReady = true; } return _WARNINGContent; } }
            private static Javax.Tools.Diagnostic.Kind _WARNINGContent = default;
            private static bool _WARNINGReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.Kind.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Javax.Tools.Diagnostic.Kind"/></returns>
            public static Javax.Tools.Diagnostic.Kind ValueOf(Java.Lang.String arg0)
            {
                return SExecute<Javax.Tools.Diagnostic.Kind>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.Kind.html#values()"/>
            /// </summary>

            /// <returns><see cref="Javax.Tools.Diagnostic.Kind"/></returns>
            public static Javax.Tools.Diagnostic.Kind[] Values()
            {
                return SExecuteArray<Javax.Tools.Diagnostic.Kind>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

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

    #region IDiagnostic<S>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDiagnostic<S>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getCode()"/> 
        /// </summary>
        Java.Lang.String Code { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getColumnNumber()"/> 
        /// </summary>
        long ColumnNumber { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getEndPosition()"/> 
        /// </summary>
        long EndPosition { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getKind()"/> 
        /// </summary>
        Javax.Tools.Diagnostic.Kind GetKind { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getLineNumber()"/> 
        /// </summary>
        long LineNumber { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getPosition()"/> 
        /// </summary>
        long Position { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getSource()"/> 
        /// </summary>
        S Source { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getStartPosition()"/> 
        /// </summary>
        long StartPosition { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getMessage(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String GetMessage(Java.Util.Locale arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Diagnostic<S>
    public partial class Diagnostic<S> : Javax.Tools.IDiagnostic<S>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Tools.Diagnostic{S}"/> to <see cref="Javax.Tools.Diagnostic"/>
        /// </summary>
        public static implicit operator Javax.Tools.Diagnostic(Javax.Tools.Diagnostic<S> t) => t.Cast<Javax.Tools.Diagnostic>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#NOPOS"/>
        /// </summary>
        public static long NOPOS { get { if (!_NOPOSReady) { _NOPOSContent = SGetField<long>(LocalBridgeClazz, "NOPOS"); _NOPOSReady = true; } return _NOPOSContent; } }
        private static long _NOPOSContent = default;
        private static bool _NOPOSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getCode()"/> 
        /// </summary>
        public Java.Lang.String Code
        {
            get { return IExecute<Java.Lang.String>("getCode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getColumnNumber()"/> 
        /// </summary>
        public long ColumnNumber
        {
            get { return IExecute<long>("getColumnNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getEndPosition()"/> 
        /// </summary>
        public long EndPosition
        {
            get { return IExecute<long>("getEndPosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getKind()"/> 
        /// </summary>
        public Javax.Tools.Diagnostic.Kind GetKind
        {
            get { return IExecute<Javax.Tools.Diagnostic.Kind>("getKind"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getLineNumber()"/> 
        /// </summary>
        public long LineNumber
        {
            get { return IExecute<long>("getLineNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getPosition()"/> 
        /// </summary>
        public long Position
        {
            get { return IExecute<long>("getPosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getSource()"/> 
        /// </summary>
        public S Source
        {
            get { return IExecute<S>("getSource"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getStartPosition()"/> 
        /// </summary>
        public long StartPosition
        {
            get { return IExecute<long>("getStartPosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getMessage(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMessage(Java.Util.Locale arg0)
        {
            return IExecute<Java.Lang.String>("getMessage", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}