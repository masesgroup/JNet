/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Spi
{
    #region IRegisterableService
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRegisterableService
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/RegisterableService.html#onDeregistration(javax.imageio.spi.ServiceRegistry,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Spi.ServiceRegistry"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        void OnDeregistration(Javax.Imageio.Spi.ServiceRegistry arg0, Java.Lang.Class arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/RegisterableService.html#onRegistration(javax.imageio.spi.ServiceRegistry,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Spi.ServiceRegistry"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        void OnRegistration(Javax.Imageio.Spi.ServiceRegistry arg0, Java.Lang.Class arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RegisterableService
    public partial class RegisterableService : Javax.Imageio.Spi.IRegisterableService
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/RegisterableService.html#onDeregistration(javax.imageio.spi.ServiceRegistry,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Spi.ServiceRegistry"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        public void OnDeregistration(Javax.Imageio.Spi.ServiceRegistry arg0, Java.Lang.Class arg1)
        {
            IExecute("onDeregistration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/RegisterableService.html#onRegistration(javax.imageio.spi.ServiceRegistry,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Spi.ServiceRegistry"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        public void OnRegistration(Javax.Imageio.Spi.ServiceRegistry arg0, Java.Lang.Class arg1)
        {
            IExecute("onRegistration", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}