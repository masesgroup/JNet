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
    #region IJavaFileObject
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IJavaFileObject : Javax.Tools.IFileObject
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getAccessLevel()"/> 
        /// </summary>
        Javax.Lang.Model.Element.Modifier AccessLevel { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getKind()"/> 
        /// </summary>
        Javax.Tools.JavaFileObject.Kind GetKind { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getNestingKind()"/> 
        /// </summary>
        Javax.Lang.Model.Element.NestingKind NestingKind { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#isNameCompatible(java.lang.String,javax.tools.JavaFileObject.Kind)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsNameCompatible(string arg0, Javax.Tools.JavaFileObject.Kind arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region JavaFileObject
    public partial class JavaFileObject : Javax.Tools.IJavaFileObject
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getAccessLevel()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Modifier AccessLevel
        {
            get { return IExecute<Javax.Lang.Model.Element.Modifier>("getAccessLevel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getKind()"/> 
        /// </summary>
        public Javax.Tools.JavaFileObject.Kind GetKind
        {
            get { return IExecute<Javax.Tools.JavaFileObject.Kind>("getKind"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getNestingKind()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.NestingKind NestingKind
        {
            get { return IExecute<Javax.Lang.Model.Element.NestingKind>("getNestingKind"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#isNameCompatible(java.lang.String,javax.tools.JavaFileObject.Kind)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNameCompatible(string arg0, Javax.Tools.JavaFileObject.Kind arg1)
        {
            return IExecute<bool>("isNameCompatible", arg0, arg1);
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#extension"/>
            /// </summary>
            public string extension { get { if (!_extensionReady) { _extensionContent = IGetField<string>("extension"); _extensionReady = true; } return _extensionContent; } }
            private string _extensionContent = default;
            private bool _extensionReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#CLASS"/>
            /// </summary>
            public static Javax.Tools.JavaFileObject.Kind CLASS { get { if (!_CLASSReady) { _CLASSContent = SGetField<Javax.Tools.JavaFileObject.Kind>(LocalBridgeClazz, "CLASS"); _CLASSReady = true; } return _CLASSContent; } }
            private static Javax.Tools.JavaFileObject.Kind _CLASSContent = default;
            private static bool _CLASSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#HTML"/>
            /// </summary>
            public static Javax.Tools.JavaFileObject.Kind HTML { get { if (!_HTMLReady) { _HTMLContent = SGetField<Javax.Tools.JavaFileObject.Kind>(LocalBridgeClazz, "HTML"); _HTMLReady = true; } return _HTMLContent; } }
            private static Javax.Tools.JavaFileObject.Kind _HTMLContent = default;
            private static bool _HTMLReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#OTHER"/>
            /// </summary>
            public static Javax.Tools.JavaFileObject.Kind OTHER { get { if (!_OTHERReady) { _OTHERContent = SGetField<Javax.Tools.JavaFileObject.Kind>(LocalBridgeClazz, "OTHER"); _OTHERReady = true; } return _OTHERContent; } }
            private static Javax.Tools.JavaFileObject.Kind _OTHERContent = default;
            private static bool _OTHERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#SOURCE"/>
            /// </summary>
            public static Javax.Tools.JavaFileObject.Kind SOURCE { get { if (!_SOURCEReady) { _SOURCEContent = SGetField<Javax.Tools.JavaFileObject.Kind>(LocalBridgeClazz, "SOURCE"); _SOURCEReady = true; } return _SOURCEContent; } }
            private static Javax.Tools.JavaFileObject.Kind _SOURCEContent = default;
            private static bool _SOURCEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Tools.JavaFileObject.Kind"/></returns>
            public static Javax.Tools.JavaFileObject.Kind ValueOf(string arg0)
            {
                return SExecute<Javax.Tools.JavaFileObject.Kind>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#values()"/>
            /// </summary>

            /// <returns><see cref="Javax.Tools.JavaFileObject.Kind"/></returns>
            public static Javax.Tools.JavaFileObject.Kind[] Values()
            {
                return SExecuteArray<Javax.Tools.JavaFileObject.Kind>(LocalBridgeClazz, "values");
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
}