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

namespace Javax.Naming.Event
{
    #region NamingEvent
    public partial class NamingEvent
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#<init>(javax.naming.event.EventContext,int,javax.naming.Binding,javax.naming.Binding,java.lang.Object)
        /// </summary>
        public NamingEvent(Javax.Naming.Event.EventContext arg0, int arg1, Javax.Naming.Binding arg2, Javax.Naming.Binding arg3, object arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#OBJECT_ADDED
        /// </summary>
        public static int OBJECT_ADDED => Clazz.GetField<int>("OBJECT_ADDED");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#OBJECT_REMOVED
        /// </summary>
        public static int OBJECT_REMOVED => Clazz.GetField<int>("OBJECT_REMOVED");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#OBJECT_RENAMED
        /// </summary>
        public static int OBJECT_RENAMED => Clazz.GetField<int>("OBJECT_RENAMED");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#OBJECT_CHANGED
        /// </summary>
        public static int OBJECT_CHANGED => Clazz.GetField<int>("OBJECT_CHANGED");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getChangeInfo() 
        /// </summary>
        public object ChangeInfo
        {
            get { return IExecute("getChangeInfo"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getEventContext() 
        /// </summary>
        public Javax.Naming.Event.EventContext EventContext
        {
            get { return IExecute<Javax.Naming.Event.EventContext>("getEventContext"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getNewBinding() 
        /// </summary>
        public Javax.Naming.Binding NewBinding
        {
            get { return IExecute<Javax.Naming.Binding>("getNewBinding"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getOldBinding() 
        /// </summary>
        public Javax.Naming.Binding OldBinding
        {
            get { return IExecute<Javax.Naming.Binding>("getOldBinding"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#getType() 
        /// </summary>
        public int Type
        {
            get { return IExecute<int>("getType"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingEvent.html#dispatch(javax.naming.event.NamingListener)
        /// </summary>
        public void Dispatch(Javax.Naming.Event.NamingListener arg0)
        {
            IExecute("dispatch", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}