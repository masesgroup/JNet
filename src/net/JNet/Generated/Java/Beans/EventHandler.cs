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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans
{
    #region EventHandler
    public partial class EventHandler
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventHandler.html#%3Cinit%3E(java.lang.Object,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        public EventHandler(object arg0, string arg1, string arg2, string arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Beans.EventHandler"/> to <see cref="Java.Lang.Reflect.InvocationHandler"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.InvocationHandler(Java.Beans.EventHandler t) => t.Cast<Java.Lang.Reflect.InvocationHandler>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventHandler.html#create(java.lang.Class,java.lang.Object,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <returns><see cref="T"/></returns>
        public static T Create<T>(Java.Lang.Class arg0, object arg1, string arg2, string arg3, string arg4)
        {
            return SExecute<T>("create", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventHandler.html#create(java.lang.Class,java.lang.Object,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <returns><see cref="T"/></returns>
        public static T Create<T>(Java.Lang.Class arg0, object arg1, string arg2, string arg3)
        {
            return SExecute<T>("create", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventHandler.html#create(java.lang.Class,java.lang.Object,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="T"/></returns>
        public static T Create<T>(Java.Lang.Class arg0, object arg1, string arg2)
        {
            return SExecute<T>("create", arg0, arg1, arg2);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventHandler.html#getAction()"/> 
        /// </summary>
        public string Action
        {
            get { return IExecute<string>("getAction"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventHandler.html#getEventPropertyName()"/> 
        /// </summary>
        public string EventPropertyName
        {
            get { return IExecute<string>("getEventPropertyName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventHandler.html#getListenerMethodName()"/> 
        /// </summary>
        public string ListenerMethodName
        {
            get { return IExecute<string>("getListenerMethodName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventHandler.html#getTarget()"/> 
        /// </summary>
        public object Target
        {
            get { return IExecute("getTarget"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/EventHandler.html#invoke(java.lang.Object,java.lang.reflect.Method,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Invoke(object arg0, Java.Lang.Reflect.Method arg1, object[] arg2)
        {
            return IExecute("invoke", arg0, arg1, arg2);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}