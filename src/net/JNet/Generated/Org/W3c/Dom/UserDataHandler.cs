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

namespace Org.W3c.Dom
{
    #region UserDataHandler
    public partial class UserDataHandler
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/UserDataHandler.html#NODE_CLONED
        /// </summary>
        public static short NODE_CLONED => Clazz.GetField<short>("NODE_CLONED");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/UserDataHandler.html#NODE_IMPORTED
        /// </summary>
        public static short NODE_IMPORTED => Clazz.GetField<short>("NODE_IMPORTED");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/UserDataHandler.html#NODE_DELETED
        /// </summary>
        public static short NODE_DELETED => Clazz.GetField<short>("NODE_DELETED");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/UserDataHandler.html#NODE_RENAMED
        /// </summary>
        public static short NODE_RENAMED => Clazz.GetField<short>("NODE_RENAMED");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/UserDataHandler.html#NODE_ADOPTED
        /// </summary>
        public static short NODE_ADOPTED => Clazz.GetField<short>("NODE_ADOPTED");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/UserDataHandler.html#handle(short,java.lang.String,java.lang.Object,org.w3c.dom.Node,org.w3c.dom.Node)
        /// </summary>
        public void Handle(short arg0, string arg1, object arg2, Org.W3c.Dom.Node arg3, Org.W3c.Dom.Node arg4)
        {
            IExecute("handle", arg0, arg1, arg2, arg3, arg4);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}