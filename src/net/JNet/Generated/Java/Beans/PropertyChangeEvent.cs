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

namespace Java.Beans
{
    #region PropertyChangeEvent
    public partial class PropertyChangeEvent
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyChangeEvent.html#<init>(java.lang.Object,java.lang.String,java.lang.Object,java.lang.Object)
        /// </summary>
        public PropertyChangeEvent(object arg0, string arg1, object arg2, object arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyChangeEvent.html#getNewValue() 
        /// </summary>
        public object NewValue
        {
            get { return IExecute("getNewValue"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyChangeEvent.html#getOldValue() 
        /// </summary>
        public object OldValue
        {
            get { return IExecute("getOldValue"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyChangeEvent.html#getPropagationId() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyChangeEvent.html#setPropagationId(java.lang.Object)
        /// </summary>
        public object PropagationId
        {
            get { return IExecute("getPropagationId"); } set { IExecute("setPropagationId", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyChangeEvent.html#getPropertyName() 
        /// </summary>
        public string PropertyName
        {
            get { return IExecute<string>("getPropertyName"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}