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
    #region Encoder
    public partial class Encoder
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Encoder.html#getExceptionListener() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Encoder.html#setExceptionListener(java.beans.ExceptionListener)
        /// </summary>
        public Java.Beans.ExceptionListener ExceptionListener
        {
            get { return IExecute<Java.Beans.ExceptionListener>("getExceptionListener"); } set { IExecute("setExceptionListener", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Encoder.html#get(java.lang.Object)
        /// </summary>
        public object Get(object arg0)
        {
            return IExecute("get", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Encoder.html#remove(java.lang.Object)
        /// </summary>
        public object Remove(object arg0)
        {
            return IExecute("remove", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Encoder.html#writeExpression(java.beans.Expression)
        /// </summary>
        public void WriteExpression(Java.Beans.Expression arg0)
        {
            IExecute("writeExpression", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Encoder.html#writeStatement(java.beans.Statement)
        /// </summary>
        public void WriteStatement(Java.Beans.Statement arg0)
        {
            IExecute("writeStatement", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}