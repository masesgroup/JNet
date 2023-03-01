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

namespace Java.Util.Concurrent
{
    #region CompletionStage
    public partial class CompletionStage
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenCombine(java.util.concurrent.CompletionStage%3C? extends U%3E,java.util.function.BiFunction%3C? super T, ? super U, ? extends V%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenCombine(Java.Util.Concurrent.CompletionStage arg0, Java.Util.Function.BiFunction arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenCombine", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenCombineAsync(java.util.concurrent.CompletionStage%3C? extends U%3E,java.util.function.BiFunction%3C? super T, ? super U, ? extends V%3E,java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenCombineAsync(Java.Util.Concurrent.CompletionStage arg0, Java.Util.Function.BiFunction arg1, Java.Util.Concurrent.Executor arg2)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenCombineAsync", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenCombineAsync(java.util.concurrent.CompletionStage%3C? extends U%3E,java.util.function.BiFunction%3C? super T, ? super U, ? extends V%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenCombineAsync(Java.Util.Concurrent.CompletionStage arg0, Java.Util.Function.BiFunction arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenCombineAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenAcceptBoth(java.util.concurrent.CompletionStage%3C? extends U%3E,java.util.function.BiConsumer%3C? super T, ? super U%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenAcceptBoth(Java.Util.Concurrent.CompletionStage arg0, Java.Util.Function.BiConsumer arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenAcceptBoth", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenAcceptBothAsync(java.util.concurrent.CompletionStage%3C? extends U%3E,java.util.function.BiConsumer%3C? super T, ? super U%3E,java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenAcceptBothAsync(Java.Util.Concurrent.CompletionStage arg0, Java.Util.Function.BiConsumer arg1, Java.Util.Concurrent.Executor arg2)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenAcceptBothAsync", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenAcceptBothAsync(java.util.concurrent.CompletionStage%3C? extends U%3E,java.util.function.BiConsumer%3C? super T, ? super U%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenAcceptBothAsync(Java.Util.Concurrent.CompletionStage arg0, Java.Util.Function.BiConsumer arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenAcceptBothAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#applyToEither(java.util.concurrent.CompletionStage%3C? extends T%3E,java.util.function.Function%3C? super T, U%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ApplyToEither(Java.Util.Concurrent.CompletionStage arg0, Java.Util.Function.Function arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("applyToEither", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#applyToEitherAsync(java.util.concurrent.CompletionStage%3C? extends T%3E,java.util.function.Function%3C? super T, U%3E,java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ApplyToEitherAsync(Java.Util.Concurrent.CompletionStage arg0, Java.Util.Function.Function arg1, Java.Util.Concurrent.Executor arg2)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("applyToEitherAsync", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#applyToEitherAsync(java.util.concurrent.CompletionStage%3C? extends T%3E,java.util.function.Function%3C? super T, U%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ApplyToEitherAsync(Java.Util.Concurrent.CompletionStage arg0, Java.Util.Function.Function arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("applyToEitherAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#handle(java.util.function.BiFunction%3C? super T, java.lang.Throwable, ? extends U%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage Handle(Java.Util.Function.BiFunction arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("handle", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#handleAsync(java.util.function.BiFunction%3C? super T, java.lang.Throwable, ? extends U%3E,java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage HandleAsync(Java.Util.Function.BiFunction arg0, Java.Util.Concurrent.Executor arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("handleAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#handleAsync(java.util.function.BiFunction%3C? super T, java.lang.Throwable, ? extends U%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage HandleAsync(Java.Util.Function.BiFunction arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("handleAsync", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenApply(java.util.function.Function%3C? super T, ? extends U%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenApply(Java.Util.Function.Function arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenApply", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenApplyAsync(java.util.function.Function%3C? super T, ? extends U%3E,java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenApplyAsync(Java.Util.Function.Function arg0, Java.Util.Concurrent.Executor arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenApplyAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenApplyAsync(java.util.function.Function%3C? super T, ? extends U%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenApplyAsync(Java.Util.Function.Function arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenApplyAsync", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenCompose(java.util.function.Function%3C? super T, ? extends java.util.concurrent.CompletionStage%3CU%3E%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenCompose(Java.Util.Function.Function arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenCompose", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenComposeAsync(java.util.function.Function%3C? super T, ? extends java.util.concurrent.CompletionStage%3CU%3E%3E,java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenComposeAsync(Java.Util.Function.Function arg0, Java.Util.Concurrent.Executor arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenComposeAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenComposeAsync(java.util.function.Function%3C? super T, ? extends java.util.concurrent.CompletionStage%3CU%3E%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenComposeAsync(Java.Util.Function.Function arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenComposeAsync", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#toCompletableFuture()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture ToCompletableFuture()
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture>("toCompletableFuture");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#acceptEither(java.util.concurrent.CompletionStage%3C? extends T%3E,java.util.function.Consumer%3C? super T%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage AcceptEither(Java.Util.Concurrent.CompletionStage arg0, Java.Util.Function.Consumer arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("acceptEither", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#acceptEitherAsync(java.util.concurrent.CompletionStage%3C? extends T%3E,java.util.function.Consumer%3C? super T%3E,java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage AcceptEitherAsync(Java.Util.Concurrent.CompletionStage arg0, Java.Util.Function.Consumer arg1, Java.Util.Concurrent.Executor arg2)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("acceptEitherAsync", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#acceptEitherAsync(java.util.concurrent.CompletionStage%3C? extends T%3E,java.util.function.Consumer%3C? super T%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage AcceptEitherAsync(Java.Util.Concurrent.CompletionStage arg0, Java.Util.Function.Consumer arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("acceptEitherAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#runAfterBoth(java.util.concurrent.CompletionStage%3C?%3E,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage RunAfterBoth(Java.Util.Concurrent.CompletionStage arg0, Java.Lang.Runnable arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("runAfterBoth", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#runAfterBothAsync(java.util.concurrent.CompletionStage%3C?%3E,java.lang.Runnable,java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage RunAfterBothAsync(Java.Util.Concurrent.CompletionStage arg0, Java.Lang.Runnable arg1, Java.Util.Concurrent.Executor arg2)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("runAfterBothAsync", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#runAfterBothAsync(java.util.concurrent.CompletionStage%3C?%3E,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage RunAfterBothAsync(Java.Util.Concurrent.CompletionStage arg0, Java.Lang.Runnable arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("runAfterBothAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#runAfterEither(java.util.concurrent.CompletionStage%3C?%3E,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage RunAfterEither(Java.Util.Concurrent.CompletionStage arg0, Java.Lang.Runnable arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("runAfterEither", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#runAfterEitherAsync(java.util.concurrent.CompletionStage%3C?%3E,java.lang.Runnable,java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage RunAfterEitherAsync(Java.Util.Concurrent.CompletionStage arg0, Java.Lang.Runnable arg1, Java.Util.Concurrent.Executor arg2)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("runAfterEitherAsync", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#runAfterEitherAsync(java.util.concurrent.CompletionStage%3C?%3E,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletionStage"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage RunAfterEitherAsync(Java.Util.Concurrent.CompletionStage arg0, Java.Lang.Runnable arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("runAfterEitherAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenAccept(java.util.function.Consumer%3C? super T%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenAccept(Java.Util.Function.Consumer arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenAccept", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenAcceptAsync(java.util.function.Consumer%3C? super T%3E,java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenAcceptAsync(Java.Util.Function.Consumer arg0, Java.Util.Concurrent.Executor arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenAcceptAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenAcceptAsync(java.util.function.Consumer%3C? super T%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenAcceptAsync(Java.Util.Function.Consumer arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenAcceptAsync", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenRun(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenRun(Java.Lang.Runnable arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenRun", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenRunAsync(java.lang.Runnable,java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenRunAsync(Java.Lang.Runnable arg0, Java.Util.Concurrent.Executor arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenRunAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#thenRunAsync(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ThenRunAsync(Java.Lang.Runnable arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("thenRunAsync", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#exceptionally(java.util.function.Function%3Cjava.lang.Throwable, ? extends T%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage Exceptionally(Java.Util.Function.Function arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("exceptionally", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#whenComplete(java.util.function.BiConsumer%3C? super T, ? super java.lang.Throwable%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage WhenComplete(Java.Util.Function.BiConsumer arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("whenComplete", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#whenCompleteAsync(java.util.function.BiConsumer%3C? super T, ? super java.lang.Throwable%3E,java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage WhenCompleteAsync(Java.Util.Function.BiConsumer arg0, Java.Util.Concurrent.Executor arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("whenCompleteAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CompletionStage.html#whenCompleteAsync(java.util.function.BiConsumer%3C? super T, ? super java.lang.Throwable%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage WhenCompleteAsync(Java.Util.Function.BiConsumer arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletionStage>("whenCompleteAsync", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}