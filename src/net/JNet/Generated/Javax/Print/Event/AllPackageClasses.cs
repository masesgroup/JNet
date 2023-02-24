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

namespace Javax.Print.Event
{
    #region PrintEvent
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintEvent.html"/>
    /// </summary>
    public partial class PrintEvent : Java.Util.EventObject
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PrintEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PrintEvent(params object[] args) : base(args) { }

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public override string ClassName => "javax.print.event.PrintEvent";

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        public override bool IsAbstract => false;

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        public override bool IsCloseable => false;

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        public override bool IsInterface => false;

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region PrintJobAdapter
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAdapter.html"/>
    /// </summary>
    public partial class PrintJobAdapter : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
#warning Remember to build the body class for event listener

        // TODO: complete the class

    }
    #endregion

    #region PrintJobAttributeEvent
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAttributeEvent.html"/>
    /// </summary>
    public partial class PrintJobAttributeEvent : Javax.Print.Event.PrintEvent
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PrintJobAttributeEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PrintJobAttributeEvent(params object[] args) : base(args) { }

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public override string ClassName => "javax.print.event.PrintJobAttributeEvent";

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        public override bool IsAbstract => false;

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        public override bool IsCloseable => false;

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        public override bool IsInterface => false;

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region PrintJobAttributeListener
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAttributeListener.html"/>
    /// </summary>
    public partial class PrintJobAttributeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
#warning Remember to build the body class for event listener

        // TODO: complete the class

    }
    #endregion

    #region PrintJobEvent
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobEvent.html"/>
    /// </summary>
    public partial class PrintJobEvent : Javax.Print.Event.PrintEvent
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PrintJobEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PrintJobEvent(params object[] args) : base(args) { }

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public override string ClassName => "javax.print.event.PrintJobEvent";

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        public override bool IsAbstract => false;

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        public override bool IsCloseable => false;

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        public override bool IsInterface => false;

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region PrintJobListener
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html"/>
    /// </summary>
    public partial class PrintJobListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
#warning Remember to build the body class for event listener

        // TODO: complete the class

    }
    #endregion

    #region PrintServiceAttributeEvent
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeEvent.html"/>
    /// </summary>
    public partial class PrintServiceAttributeEvent : Javax.Print.Event.PrintEvent
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PrintServiceAttributeEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PrintServiceAttributeEvent(params object[] args) : base(args) { }

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public override string ClassName => "javax.print.event.PrintServiceAttributeEvent";

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        public override bool IsAbstract => false;

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        public override bool IsCloseable => false;

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        public override bool IsInterface => false;

        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region PrintServiceAttributeListener
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeListener.html"/>
    /// </summary>
    public partial class PrintServiceAttributeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
#warning Remember to build the body class for event listener

        // TODO: complete the class

    }
    #endregion


}