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
        public static long NOPOS => LocalClazz.GetField<long>("NOPOS");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getCode()"/> 
        /// </summary>
        public string Code
        {
            get { return IExecute<string>("getCode"); }
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
        /// <returns><see cref="string"/></returns>
        public string GetMessage(Java.Util.Locale arg0)
        {
            return IExecute<string>("getMessage", arg0);
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
            public static Javax.Tools.Diagnostic.Kind ERROR => LocalClazz.GetField<Javax.Tools.Diagnostic.Kind>("ERROR");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.Kind.html#MANDATORY_WARNING"/>
            /// </summary>
            public static Javax.Tools.Diagnostic.Kind MANDATORY_WARNING => LocalClazz.GetField<Javax.Tools.Diagnostic.Kind>("MANDATORY_WARNING");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.Kind.html#NOTE"/>
            /// </summary>
            public static Javax.Tools.Diagnostic.Kind NOTE => LocalClazz.GetField<Javax.Tools.Diagnostic.Kind>("NOTE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.Kind.html#OTHER"/>
            /// </summary>
            public static Javax.Tools.Diagnostic.Kind OTHER => LocalClazz.GetField<Javax.Tools.Diagnostic.Kind>("OTHER");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.Kind.html#WARNING"/>
            /// </summary>
            public static Javax.Tools.Diagnostic.Kind WARNING => LocalClazz.GetField<Javax.Tools.Diagnostic.Kind>("WARNING");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.Kind.html#values()"/> 
            /// </summary>
            public static Javax.Tools.Diagnostic.Kind[] Values
            {
                get { return SExecuteArray<Javax.Tools.Diagnostic.Kind>(LocalClazz, "values"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.Kind.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Javax.Tools.Diagnostic.Kind"/></returns>
            public static Javax.Tools.Diagnostic.Kind ValueOf(string arg0)
            {
                return SExecute<Javax.Tools.Diagnostic.Kind>(LocalClazz, "valueOf", arg0);
            }
            
            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Diagnostic<S>
    public partial class Diagnostic<S>
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
        public static long NOPOS => LocalClazz.GetField<long>("NOPOS");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/Diagnostic.html#getCode()"/> 
        /// </summary>
        public string Code
        {
            get { return IExecute<string>("getCode"); }
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
        /// <returns><see cref="string"/></returns>
        public string GetMessage(Java.Util.Locale arg0)
        {
            return IExecute<string>("getMessage", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}