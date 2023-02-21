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

namespace Java.Util.Logging
{
    #region Logger
    public partial class Logger
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#GLOBAL_LOGGER_NAME
        /// </summary>
        public static string GLOBAL_LOGGER_NAME => Clazz.GetField<string>("GLOBAL_LOGGER_NAME");
        
        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#getAnonymousLogger() 
        /// </summary>
        public static Java.Util.Logging.Logger AnonymousLogger
        {
            get { return SExecute<Java.Util.Logging.Logger>("getAnonymousLogger"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#getGlobal() 
        /// </summary>
        public static Java.Util.Logging.Logger Global
        {
            get { return SExecute<Java.Util.Logging.Logger>("getGlobal"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#getAnonymousLogger(java.lang.String)
        /// </summary>
        public static Java.Util.Logging.Logger GetAnonymousLogger(string arg0)
        {
            return SExecute<Java.Util.Logging.Logger>("getAnonymousLogger", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#getLogger(java.lang.String,java.lang.String)
        /// </summary>
        public static Java.Util.Logging.Logger GetLogger(string arg0, string arg1)
        {
            return SExecute<Java.Util.Logging.Logger>("getLogger", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#getLogger(java.lang.String)
        /// </summary>
        public static Java.Util.Logging.Logger GetLogger(string arg0)
        {
            return SExecute<Java.Util.Logging.Logger>("getLogger", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#getFilter() https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#setFilter(java.util.logging.Filter) throws java.lang.SecurityException
        /// </summary>
        public Java.Util.Logging.Filter Filter
        {
            get { return IExecute<Java.Util.Logging.Filter>("getFilter"); } set { IExecute("setFilter", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#getHandlers() 
        /// </summary>
        public Java.Util.Logging.Handler[] Handlers
        {
            get { return IExecuteArray<Java.Util.Logging.Handler>("getHandlers"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#getLevel() https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#setLevel(java.util.logging.Level) throws java.lang.SecurityException
        /// </summary>
        public Java.Util.Logging.Level Level
        {
            get { return IExecute<Java.Util.Logging.Level>("getLevel"); } set { IExecute("setLevel", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#getName() 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#getParent() https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#setParent(java.util.logging.Logger)
        /// </summary>
        public Java.Util.Logging.Logger Parent
        {
            get { return IExecute<Java.Util.Logging.Logger>("getParent"); } set { IExecute("setParent", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#getResourceBundle() https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#setResourceBundle(java.util.ResourceBundle)
        /// </summary>
        public Java.Util.ResourceBundle ResourceBundle
        {
            get { return IExecute<Java.Util.ResourceBundle>("getResourceBundle"); } set { IExecute("setResourceBundle", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#getResourceBundleName() 
        /// </summary>
        public string ResourceBundleName
        {
            get { return IExecute<string>("getResourceBundleName"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#getUseParentHandlers() https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#setUseParentHandlers(boolean)
        /// </summary>
        public bool UseParentHandlers
        {
            get { return IExecute<bool>("getUseParentHandlers"); } set { IExecute("setUseParentHandlers", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#isLoggable(java.util.logging.Level)
        /// </summary>
        public bool IsLoggable(Java.Util.Logging.Level arg0)
        {
            return IExecute<bool>("isLoggable", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#addHandler(java.util.logging.Handler) throws java.lang.SecurityException
        /// </summary>
        public void AddHandler(Java.Util.Logging.Handler arg0)
        {
            IExecute("addHandler", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#config(java.lang.String)
        /// </summary>
        public void Config(string arg0)
        {
            IExecute("config", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#entering(java.lang.String,java.lang.String,java.lang.Object)
        /// </summary>
        public void Entering(string arg0, string arg1, object arg2)
        {
            IExecute("entering", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#entering(java.lang.String,java.lang.String,java.lang.Object[])
        /// </summary>
        public void Entering(string arg0, string arg1, object[] arg2)
        {
            IExecute("entering", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#entering(java.lang.String,java.lang.String)
        /// </summary>
        public void Entering(string arg0, string arg1)
        {
            IExecute("entering", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#exiting(java.lang.String,java.lang.String,java.lang.Object)
        /// </summary>
        public void Exiting(string arg0, string arg1, object arg2)
        {
            IExecute("exiting", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#exiting(java.lang.String,java.lang.String)
        /// </summary>
        public void Exiting(string arg0, string arg1)
        {
            IExecute("exiting", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#fine(java.lang.String)
        /// </summary>
        public void Fine(string arg0)
        {
            IExecute("fine", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#finer(java.lang.String)
        /// </summary>
        public void Finer(string arg0)
        {
            IExecute("finer", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#finest(java.lang.String)
        /// </summary>
        public void Finest(string arg0)
        {
            IExecute("finest", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#info(java.lang.String)
        /// </summary>
        public void Info(string arg0)
        {
            IExecute("info", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#logging.Logger.log(java.util.logging.Level,java.lang.String,java.lang.Object)
        /// </summary>
        public void Log(Java.Util.Logging.Level arg0, string arg1, object arg2)
        {
            IExecute("log", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#logging.Logger.log(java.util.logging.Level,java.lang.String,java.lang.Object[])
        /// </summary>
        public void Log(Java.Util.Logging.Level arg0, string arg1, object[] arg2)
        {
            IExecute("log", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#logging.Logger.log(java.util.logging.Level,java.lang.String,java.lang.Throwable)
        /// </summary>
        public void Log(Java.Util.Logging.Level arg0, string arg1, Java.Lang.Throwable arg2)
        {
            IExecute("log", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#logging.Logger.log(java.util.logging.Level,java.lang.String)
        /// </summary>
        public void Log(Java.Util.Logging.Level arg0, string arg1)
        {
            IExecute("log", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#logging.Logger.log(java.util.logging.LogRecord)
        /// </summary>
        public void Log(Java.Util.Logging.LogRecord arg0)
        {
            IExecute("log", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#logp(java.util.logging.Level,java.lang.String,java.lang.String,java.lang.String,java.lang.Object)
        /// </summary>
        public void Logp(Java.Util.Logging.Level arg0, string arg1, string arg2, string arg3, object arg4)
        {
            IExecute("logp", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#logp(java.util.logging.Level,java.lang.String,java.lang.String,java.lang.String,java.lang.Object[])
        /// </summary>
        public void Logp(Java.Util.Logging.Level arg0, string arg1, string arg2, string arg3, object[] arg4)
        {
            IExecute("logp", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#logp(java.util.logging.Level,java.lang.String,java.lang.String,java.lang.String,java.lang.Throwable)
        /// </summary>
        public void Logp(Java.Util.Logging.Level arg0, string arg1, string arg2, string arg3, Java.Lang.Throwable arg4)
        {
            IExecute("logp", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#logp(java.util.logging.Level,java.lang.String,java.lang.String,java.lang.String)
        /// </summary>
        public void Logp(Java.Util.Logging.Level arg0, string arg1, string arg2, string arg3)
        {
            IExecute("logp", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#logrb(java.util.logging.Level,java.lang.String,java.lang.String,java.util.ResourceBundle,java.lang.String,java.lang.Object...)
        /// </summary>
        public void Logrb(Java.Util.Logging.Level arg0, string arg1, string arg2, Java.Util.ResourceBundle arg3, string arg4, params object[] arg5)
        {
            if (arg5.Length == 0) IExecute("logrb", arg0, arg1, arg2, arg3, arg4); else IExecute("logrb", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#logrb(java.util.logging.Level,java.lang.String,java.lang.String,java.util.ResourceBundle,java.lang.String,java.lang.Throwable)
        /// </summary>
        public void Logrb(Java.Util.Logging.Level arg0, string arg1, string arg2, Java.Util.ResourceBundle arg3, string arg4, Java.Lang.Throwable arg5)
        {
            IExecute("logrb", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#logrb(java.util.logging.Level,java.util.ResourceBundle,java.lang.String,java.lang.Object...)
        /// </summary>
        public void Logrb(Java.Util.Logging.Level arg0, Java.Util.ResourceBundle arg1, string arg2, params object[] arg3)
        {
            if (arg3.Length == 0) IExecute("logrb", arg0, arg1, arg2); else IExecute("logrb", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#logrb(java.util.logging.Level,java.util.ResourceBundle,java.lang.String,java.lang.Throwable)
        /// </summary>
        public void Logrb(Java.Util.Logging.Level arg0, Java.Util.ResourceBundle arg1, string arg2, Java.Lang.Throwable arg3)
        {
            IExecute("logrb", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#removeHandler(java.util.logging.Handler) throws java.lang.SecurityException
        /// </summary>
        public void RemoveHandler(Java.Util.Logging.Handler arg0)
        {
            IExecute("removeHandler", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#severe(java.lang.String)
        /// </summary>
        public void Severe(string arg0)
        {
            IExecute("severe", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#throwing(java.lang.String,java.lang.String,java.lang.Throwable)
        /// </summary>
        public void Throwing(string arg0, string arg1, Java.Lang.Throwable arg2)
        {
            IExecute("throwing", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/Logger.html#warning(java.lang.String)
        /// </summary>
        public void Warning(string arg0)
        {
            IExecute("warning", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}