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

namespace Javax.Security.Auth.Login
{
    #region AccountException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AccountException.html"/>
    /// </summary>
    public partial class AccountException : Javax.Security.Auth.Login.LoginException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.security.auth.login.AccountException";

        // TODO: complete the class

    }
    #endregion

    #region AccountExpiredException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AccountExpiredException.html"/>
    /// </summary>
    public partial class AccountExpiredException : Javax.Security.Auth.Login.AccountException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.security.auth.login.AccountExpiredException";

        // TODO: complete the class

    }
    #endregion

    #region AccountLockedException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AccountLockedException.html"/>
    /// </summary>
    public partial class AccountLockedException : Javax.Security.Auth.Login.AccountException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.security.auth.login.AccountLockedException";

        // TODO: complete the class

    }
    #endregion

    #region AccountNotFoundException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AccountNotFoundException.html"/>
    /// </summary>
    public partial class AccountNotFoundException : Javax.Security.Auth.Login.AccountException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.security.auth.login.AccountNotFoundException";

        // TODO: complete the class

    }
    #endregion

    #region AppConfigurationEntry
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.html"/>
    /// </summary>
    public partial class AppConfigurationEntry : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AppConfigurationEntry>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AppConfigurationEntry() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AppConfigurationEntry(params object[] args) : base(args) { }

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.security.auth.login.AppConfigurationEntry";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class
        #region LoginModuleControlFlag
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.LoginModuleControlFlag.html"/>
        /// </summary>
        public partial class LoginModuleControlFlag : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LoginModuleControlFlag>
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public LoginModuleControlFlag() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public LoginModuleControlFlag(params object[] args) : base(args) { }

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
            /// </summary>
            public override string ClassName => "javax.security.auth.login.AppConfigurationEntry$LoginModuleControlFlag";
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
            /// </summary>
            public override bool IsAbstract => false;         
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
            /// </summary>
            public override bool IsCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
            /// </summary>
            public override bool IsInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
            /// </summary>
            public override bool IsStatic => true;

            // TODO: complete the class
        }
        #endregion


    }
    #endregion

    #region Configuration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/Configuration.html"/>
    /// </summary>
    public partial class Configuration : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Configuration>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Configuration() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Configuration(params object[] args) : base(args) { }

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.security.auth.login.Configuration";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class
        #region Parameters
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/Configuration.Parameters.html"/>
        /// </summary>
        public partial class Parameters : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Parameters>
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Parameters() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Parameters(params object[] args) : base(args) { }

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
            /// </summary>
            public override string ClassName => "javax.security.auth.login.Configuration$Parameters";
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
            /// </summary>
            public override bool IsAbstract => true;         
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
            /// </summary>
            public override bool IsCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
            /// </summary>
            public override bool IsInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
            /// </summary>
            public override bool IsStatic => true;

            // TODO: complete the class
        }
        #endregion


    }
    #endregion

    #region ConfigurationSpi
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/ConfigurationSpi.html"/>
    /// </summary>
    public partial class ConfigurationSpi : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConfigurationSpi>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ConfigurationSpi() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ConfigurationSpi(params object[] args) : base(args) { }

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.security.auth.login.ConfigurationSpi";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region CredentialException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/CredentialException.html"/>
    /// </summary>
    public partial class CredentialException : Javax.Security.Auth.Login.LoginException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.security.auth.login.CredentialException";

        // TODO: complete the class

    }
    #endregion

    #region CredentialExpiredException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/CredentialExpiredException.html"/>
    /// </summary>
    public partial class CredentialExpiredException : Javax.Security.Auth.Login.CredentialException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.security.auth.login.CredentialExpiredException";

        // TODO: complete the class

    }
    #endregion

    #region CredentialNotFoundException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/CredentialNotFoundException.html"/>
    /// </summary>
    public partial class CredentialNotFoundException : Javax.Security.Auth.Login.CredentialException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.security.auth.login.CredentialNotFoundException";

        // TODO: complete the class

    }
    #endregion

    #region FailedLoginException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/FailedLoginException.html"/>
    /// </summary>
    public partial class FailedLoginException : Javax.Security.Auth.Login.LoginException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.security.auth.login.FailedLoginException";

        // TODO: complete the class

    }
    #endregion

    #region LoginContext
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/LoginContext.html"/>
    /// </summary>
    public partial class LoginContext : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LoginContext>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LoginContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LoginContext(params object[] args) : base(args) { }

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.security.auth.login.LoginContext";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsCloseable.htm"/>
        /// </summary>
        public override bool IsCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsStatic.htm"/>
        /// </summary>
        public override bool IsStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region LoginException
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/LoginException.html"/>
    /// </summary>
    public partial class LoginException : Java.Security.GeneralSecurityException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "javax.security.auth.login.LoginException";

        // TODO: complete the class

    }
    #endregion


}