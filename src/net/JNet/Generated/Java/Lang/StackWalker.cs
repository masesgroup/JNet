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

namespace Java.Lang
{
    #region StackWalker
    public partial class StackWalker
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.html#getInstance()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.StackWalker"/></returns>
        public static Java.Lang.StackWalker GetInstance()
        {
            return SExecute<Java.Lang.StackWalker>(LocalClazz, "getInstance");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.html#getInstance(java.lang.StackWalker.Option)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.StackWalker.Option"/></param>
        /// <returns><see cref="Java.Lang.StackWalker"/></returns>
        public static Java.Lang.StackWalker GetInstance(Java.Lang.StackWalker.Option arg0)
        {
            return SExecute<Java.Lang.StackWalker>(LocalClazz, "getInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.html#getInstance(java.util.Set,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.StackWalker"/></returns>
        public static Java.Lang.StackWalker GetInstance(Java.Util.Set<Java.Lang.StackWalker.Option> arg0, int arg1)
        {
            return SExecute<Java.Lang.StackWalker>(LocalClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.html#getInstance(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Lang.StackWalker"/></returns>
        public static Java.Lang.StackWalker GetInstance(Java.Util.Set<Java.Lang.StackWalker.Option> arg0)
        {
            return SExecute<Java.Lang.StackWalker>(LocalClazz, "getInstance", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.html#getCallerClass()"/> 
        /// </summary>
        public Java.Lang.Class CallerClass
        {
            get { return IExecute<Java.Lang.Class>("getCallerClass"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.html#walk(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0objectSuperJava_Util_Stream_Stream_Java_Lang_StackWalker_StackFrame_"><see cref="Java.Util.Stream.Stream{Java.Lang.StackWalker.StackFrame}"/></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T Walk<T, Arg0objectSuperJava_Util_Stream_Stream_Java_Lang_StackWalker_StackFrame_, Arg0ExtendsT>(Java.Util.Function.Function<Arg0objectSuperJava_Util_Stream_Stream_Java_Lang_StackWalker_StackFrame_, Arg0ExtendsT> arg0) where Arg0objectSuperJava_Util_Stream_Stream_Java_Lang_StackWalker_StackFrame_: Java.Util.Stream.Stream<Java.Lang.StackWalker.StackFrame> where Arg0ExtendsT: T
        {
            return IExecute<T>("walk", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.html#forEach(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperJava_Lang_StackWalker_StackFrame"><see cref="Java.Lang.StackWalker.StackFrame"/></typeparam>
        public void ForEach<Arg0objectSuperJava_Lang_StackWalker_StackFrame>(Java.Util.Function.Consumer<Arg0objectSuperJava_Lang_StackWalker_StackFrame> arg0) where Arg0objectSuperJava_Lang_StackWalker_StackFrame: Java.Lang.StackWalker.StackFrame
        {
            IExecute("forEach", arg0);
        }

        #endregion

        #region Nested classes
        #region Option
        public partial class Option
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.Option.html#RETAIN_CLASS_REFERENCE"/>
            /// </summary>
            public static Java.Lang.StackWalker.Option RETAIN_CLASS_REFERENCE { get { return SGetField<Java.Lang.StackWalker.Option>(LocalClazz, "RETAIN_CLASS_REFERENCE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.Option.html#SHOW_HIDDEN_FRAMES"/>
            /// </summary>
            public static Java.Lang.StackWalker.Option SHOW_HIDDEN_FRAMES { get { return SGetField<Java.Lang.StackWalker.Option>(LocalClazz, "SHOW_HIDDEN_FRAMES"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.Option.html#SHOW_REFLECT_FRAMES"/>
            /// </summary>
            public static Java.Lang.StackWalker.Option SHOW_REFLECT_FRAMES { get { return SGetField<Java.Lang.StackWalker.Option>(LocalClazz, "SHOW_REFLECT_FRAMES"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.Option.html#values()"/> 
            /// </summary>
            public static Java.Lang.StackWalker.Option[] Values
            {
                get { return SExecuteArray<Java.Lang.StackWalker.Option>(LocalClazz, "values"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.Option.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Lang.StackWalker.Option"/></returns>
            public static Java.Lang.StackWalker.Option ValueOf(string arg0)
            {
                return SExecute<Java.Lang.StackWalker.Option>(LocalClazz, "valueOf", arg0);
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region StackFrame
        public partial class StackFrame
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getByteCodeIndex()"/> 
            /// </summary>
            public int ByteCodeIndex
            {
                get { return IExecute<int>("getByteCodeIndex"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getDeclaringClass()"/> 
            /// </summary>
            public Java.Lang.Class DeclaringClass
            {
                get { return IExecute<Java.Lang.Class>("getDeclaringClass"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getDescriptor()"/> 
            /// </summary>
            public string Descriptor
            {
                get { return IExecute<string>("getDescriptor"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getFileName()"/> 
            /// </summary>
            public string FileName
            {
                get { return IExecute<string>("getFileName"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getClassName()"/> 
            /// </summary>
            public string GetClassName
            {
                get { return IExecute<string>("getClassName"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#isNativeMethod()"/> 
            /// </summary>
            public bool IsNativeMethod
            {
                get { return IExecute<bool>("isNativeMethod"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getLineNumber()"/> 
            /// </summary>
            public int LineNumber
            {
                get { return IExecute<int>("getLineNumber"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getMethodName()"/> 
            /// </summary>
            public string MethodName
            {
                get { return IExecute<string>("getMethodName"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#getMethodType()"/> 
            /// </summary>
            public Java.Lang.Invoke.MethodType MethodType
            {
                get { return IExecute<Java.Lang.Invoke.MethodType>("getMethodType"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/StackWalker.StackFrame.html#toStackTraceElement()"/> 
            /// </summary>
            public Java.Lang.StackTraceElement ToStackTraceElement
            {
                get { return IExecute<Java.Lang.StackTraceElement>("toStackTraceElement"); }
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