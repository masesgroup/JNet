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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region AttributeChangeNotification
    public partial class AttributeChangeNotification
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeChangeNotification.html#%3Cinit%3E(java.lang.Object,long,long,java.lang.String,java.lang.String,java.lang.String,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        public AttributeChangeNotification(object arg0, long arg1, long arg2, string arg3, string arg4, string arg5, object arg6, object arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeChangeNotification.html#ATTRIBUTE_CHANGE"/>
        /// </summary>
        public static string ATTRIBUTE_CHANGE { get { return LocalClazz.GetField<string>("ATTRIBUTE_CHANGE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeChangeNotification.html#getAttributeName()"/> 
        /// </summary>
        public string AttributeName
        {
            get { return IExecute<string>("getAttributeName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeChangeNotification.html#getAttributeType()"/> 
        /// </summary>
        public string AttributeType
        {
            get { return IExecute<string>("getAttributeType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeChangeNotification.html#getNewValue()"/> 
        /// </summary>
        public object NewValue
        {
            get { return IExecute("getNewValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/AttributeChangeNotification.html#getOldValue()"/> 
        /// </summary>
        public object OldValue
        {
            get { return IExecute("getOldValue"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}