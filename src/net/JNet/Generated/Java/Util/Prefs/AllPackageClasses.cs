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

namespace Java.Util.Prefs
{
    #region InvalidPreferencesFormatException
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/InvalidPreferencesFormatException.html
    /// </summary>
    public partial class InvalidPreferencesFormatException : Java.Lang.Exception
    {
        public InvalidPreferencesFormatException() { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.prefs.InvalidPreferencesFormatException";

        // TODO: complete the class

    }
    #endregion

    #region PreferenceChangeListener
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/PreferenceChangeListener.html
    /// </summary>
    public partial class PreferenceChangeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
#warning Remember to build the body class for event listener

        // TODO: complete the class

    }
    #endregion

    #region NodeChangeListener
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeListener.html
    /// </summary>
    public partial class NodeChangeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
#warning Remember to build the body class for event listener

        // TODO: complete the class

    }
    #endregion

    #region AbstractPreferences
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/AbstractPreferences.html
    /// </summary>
    public partial class AbstractPreferences : Java.Util.Prefs.Preferences
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AbstractPreferences() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AbstractPreferences(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.prefs.AbstractPreferences";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => true;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region PreferenceChangeEvent
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/PreferenceChangeEvent.html
    /// </summary>
    public partial class PreferenceChangeEvent : Java.Util.EventObject
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PreferenceChangeEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PreferenceChangeEvent(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.prefs.PreferenceChangeEvent";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => false;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region BackingStoreException
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/BackingStoreException.html
    /// </summary>
    public partial class BackingStoreException : Java.Lang.Exception
    {
        public BackingStoreException() { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.prefs.BackingStoreException";

        // TODO: complete the class

    }
    #endregion

    #region NodeChangeEvent
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/NodeChangeEvent.html
    /// </summary>
    public partial class NodeChangeEvent : Java.Util.EventObject
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public NodeChangeEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public NodeChangeEvent(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.prefs.NodeChangeEvent";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => false;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region Preferences
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html
    /// </summary>
    public partial class Preferences : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Preferences>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Preferences() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Preferences(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.prefs.Preferences";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => true;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => false;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region PreferencesFactory
    /// <summary>
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/PreferencesFactory.html
    /// </summary>
    public partial class PreferencesFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PreferencesFactory>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PreferencesFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PreferencesFactory(params object[] args) : base(args) { }

        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.prefs.PreferencesFactory";

        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => true;

        /// <inheritdoc cref="JVMBridgeBase.IsCloseable"/>
        public override bool IsCloseable => false;

        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => true;

        /// <inheritdoc cref="JVMBridgeBase.IsStatic"/>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion


}