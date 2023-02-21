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

namespace Org.Ietf.Jgss
{
    #region Oid
    public partial class Oid
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/Oid.html#<init>(byte[]) throws org.ietf.jgss.GSSException
        /// </summary>
        public Oid(byte[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/Oid.html#<init>(java.io.InputStream) throws org.ietf.jgss.GSSException
        /// </summary>
        public Oid(Java.Io.InputStream arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/Oid.html#<init>(java.lang.String) throws org.ietf.jgss.GSSException
        /// </summary>
        public Oid(string arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/Oid.html#getDER() throws org.ietf.jgss.GSSException 
        /// </summary>
        public byte[] DER
        {
            get { return IExecuteArray<byte>("getDER"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/Oid.html#containedIn(org.ietf.jgss.Oid[])
        /// </summary>
        public bool ContainedIn(Org.Ietf.Jgss.Oid[] arg0)
        {
            return IExecute<bool>("containedIn", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}