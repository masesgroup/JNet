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

namespace Java.Awt.EventNs
{
    #region FocusEvent
    public partial class FocusEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#%3Cinit%3E(java.awt.Component,int,boolean,java.awt.Component,java.awt.event.FocusEvent$Cause)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg4"><see cref="Java.Awt.EventNs.FocusEvent.Cause"/></param>
        public FocusEvent(Java.Awt.Component arg0, int arg1, bool arg2, Java.Awt.Component arg3, Java.Awt.EventNs.FocusEvent.Cause arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#%3Cinit%3E(java.awt.Component,int,boolean,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Component"/></param>
        public FocusEvent(Java.Awt.Component arg0, int arg1, bool arg2, Java.Awt.Component arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#%3Cinit%3E(java.awt.Component,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public FocusEvent(Java.Awt.Component arg0, int arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#%3Cinit%3E(java.awt.Component,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public FocusEvent(Java.Awt.Component arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#FOCUS_FIRST"/>
        /// </summary>
        public static int FOCUS_FIRST => Clazz.GetField<int>("FOCUS_FIRST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#FOCUS_GAINED"/>
        /// </summary>
        public static int FOCUS_GAINED => Clazz.GetField<int>("FOCUS_GAINED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#FOCUS_LAST"/>
        /// </summary>
        public static int FOCUS_LAST => Clazz.GetField<int>("FOCUS_LAST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#FOCUS_LOST"/>
        /// </summary>
        public static int FOCUS_LOST => Clazz.GetField<int>("FOCUS_LOST");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#getOppositeComponent()"/> 
        /// </summary>
        public Java.Awt.Component OppositeComponent
        {
            get { return IExecute<Java.Awt.Component>("getOppositeComponent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#isTemporary()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsTemporary()
        {
            return IExecute<bool>("isTemporary");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#getCause()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Awt.EventNs.FocusEvent.Cause"/></returns>
        public Java.Awt.EventNs.FocusEvent.Cause GetCause()
        {
            return IExecute<Java.Awt.EventNs.FocusEvent.Cause>("getCause");
        }
        
        #endregion

        #region Nested classes
        #region Cause
        public partial class Cause
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#ACTIVATION"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause ACTIVATION => Clazz.GetField<Java.Awt.EventNs.FocusEvent.Cause>("ACTIVATION");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#CLEAR_GLOBAL_FOCUS_OWNER"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause CLEAR_GLOBAL_FOCUS_OWNER => Clazz.GetField<Java.Awt.EventNs.FocusEvent.Cause>("CLEAR_GLOBAL_FOCUS_OWNER");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#MOUSE_EVENT"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause MOUSE_EVENT => Clazz.GetField<Java.Awt.EventNs.FocusEvent.Cause>("MOUSE_EVENT");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#ROLLBACK"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause ROLLBACK => Clazz.GetField<Java.Awt.EventNs.FocusEvent.Cause>("ROLLBACK");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#TRAVERSAL"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause TRAVERSAL => Clazz.GetField<Java.Awt.EventNs.FocusEvent.Cause>("TRAVERSAL");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#TRAVERSAL_BACKWARD"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause TRAVERSAL_BACKWARD => Clazz.GetField<Java.Awt.EventNs.FocusEvent.Cause>("TRAVERSAL_BACKWARD");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#TRAVERSAL_DOWN"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause TRAVERSAL_DOWN => Clazz.GetField<Java.Awt.EventNs.FocusEvent.Cause>("TRAVERSAL_DOWN");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#TRAVERSAL_FORWARD"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause TRAVERSAL_FORWARD => Clazz.GetField<Java.Awt.EventNs.FocusEvent.Cause>("TRAVERSAL_FORWARD");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#TRAVERSAL_UP"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause TRAVERSAL_UP => Clazz.GetField<Java.Awt.EventNs.FocusEvent.Cause>("TRAVERSAL_UP");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#UNEXPECTED"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause UNEXPECTED => Clazz.GetField<Java.Awt.EventNs.FocusEvent.Cause>("UNEXPECTED");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#UNKNOWN"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause UNKNOWN => Clazz.GetField<Java.Awt.EventNs.FocusEvent.Cause>("UNKNOWN");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Awt.EventNs.FocusEvent.Cause"/></returns>
            public static Java.Awt.EventNs.FocusEvent.Cause ValueOf(string arg0)
            {
                return SExecute<Java.Awt.EventNs.FocusEvent.Cause>("valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#values()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Awt.EventNs.FocusEvent.Cause"/></returns>
            public static Java.Awt.EventNs.FocusEvent.Cause[] Values()
            {
                return SExecuteArray<Java.Awt.EventNs.FocusEvent.Cause>("values");
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
}