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
    #region MouseWheelEvent
    public partial class MouseWheelEvent
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelEvent.html#<init>(java.awt.Component,int,long,int,int,int,int,int,int,boolean,int,int,int,double)
        /// </summary>
        public MouseWheelEvent(Java.Awt.Component arg0, int arg1, long arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, bool arg9, int arg10, int arg11, int arg12, double arg13)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelEvent.html#<init>(java.awt.Component,int,long,int,int,int,int,int,int,boolean,int,int,int)
        /// </summary>
        public MouseWheelEvent(Java.Awt.Component arg0, int arg1, long arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, bool arg9, int arg10, int arg11, int arg12)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelEvent.html#<init>(java.awt.Component,int,long,int,int,int,int,boolean,int,int,int)
        /// </summary>
        public MouseWheelEvent(Java.Awt.Component arg0, int arg1, long arg2, int arg3, int arg4, int arg5, int arg6, bool arg7, int arg8, int arg9, int arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelEvent.html#WHEEL_UNIT_SCROLL
        /// </summary>
        public static int WHEEL_UNIT_SCROLL => Clazz.GetField<int>("WHEEL_UNIT_SCROLL");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelEvent.html#WHEEL_BLOCK_SCROLL
        /// </summary>
        public static int WHEEL_BLOCK_SCROLL => Clazz.GetField<int>("WHEEL_BLOCK_SCROLL");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelEvent.html#getPreciseWheelRotation() 
        /// </summary>
        public double PreciseWheelRotation
        {
            get { return IExecute<double>("getPreciseWheelRotation"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelEvent.html#getScrollAmount() 
        /// </summary>
        public int ScrollAmount
        {
            get { return IExecute<int>("getScrollAmount"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelEvent.html#getScrollType() 
        /// </summary>
        public int ScrollType
        {
            get { return IExecute<int>("getScrollType"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelEvent.html#getUnitsToScroll() 
        /// </summary>
        public int UnitsToScroll
        {
            get { return IExecute<int>("getUnitsToScroll"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseWheelEvent.html#getWheelRotation() 
        /// </summary>
        public int WheelRotation
        {
            get { return IExecute<int>("getWheelRotation"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}