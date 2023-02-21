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

namespace Javax.Swing.Text.Html
{
    #region FormSubmitEvent
    public partial class FormSubmitEvent
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/FormSubmitEvent.html#getData() 
        /// </summary>
        public string Data
        {
            get { return IExecute<string>("getData"); }
        }
        
        #endregion

        #region Nested classes
        #region MethodType
        public partial class MethodType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/FormSubmitEvent.MethodType.html#GET
            /// </summary>
            public static Javax.Swing.Text.Html.FormSubmitEvent.MethodType GET => Clazz.GetField<Javax.Swing.Text.Html.FormSubmitEvent.MethodType>("GET");
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/FormSubmitEvent.MethodType.html#POST
            /// </summary>
            public static Javax.Swing.Text.Html.FormSubmitEvent.MethodType POST => Clazz.GetField<Javax.Swing.Text.Html.FormSubmitEvent.MethodType>("POST");
            
            #endregion

            #region Static methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/FormSubmitEvent.MethodType.html#values()
            /// </summary>
            public static Javax.Swing.Text.Html.FormSubmitEvent.MethodType[] Values()
            {
                return SExecuteArray<Javax.Swing.Text.Html.FormSubmitEvent.MethodType>("values");
            }
            
            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}