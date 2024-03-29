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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/FormSubmitEvent.html#getData()"/> 
        /// </summary>
        public Java.Lang.String Data
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getData", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/FormSubmitEvent.html#getMethod()"/> 
        /// </summary>
        public Javax.Swing.Text.Html.FormSubmitEvent.MethodType Method
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.Html.FormSubmitEvent.MethodType>("getMethod", "()Ljavax/swing/text/html/FormSubmitEvent$MethodType;"); }
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/FormSubmitEvent.MethodType.html#GET"/>
            /// </summary>
            public static Javax.Swing.Text.Html.FormSubmitEvent.MethodType GET { get { if (!_GETReady) { _GETContent = SGetField<Javax.Swing.Text.Html.FormSubmitEvent.MethodType>(LocalBridgeClazz, "GET"); _GETReady = true; } return _GETContent; } }
            private static Javax.Swing.Text.Html.FormSubmitEvent.MethodType _GETContent = default;
            private static bool _GETReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/FormSubmitEvent.MethodType.html#POST"/>
            /// </summary>
            public static Javax.Swing.Text.Html.FormSubmitEvent.MethodType POST { get { if (!_POSTReady) { _POSTContent = SGetField<Javax.Swing.Text.Html.FormSubmitEvent.MethodType>(LocalBridgeClazz, "POST"); _POSTReady = true; } return _POSTContent; } }
            private static Javax.Swing.Text.Html.FormSubmitEvent.MethodType _POSTContent = default;
            private static bool _POSTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/FormSubmitEvent.MethodType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Javax.Swing.Text.Html.FormSubmitEvent.MethodType"/></returns>
            public static Javax.Swing.Text.Html.FormSubmitEvent.MethodType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Javax.Swing.Text.Html.FormSubmitEvent.MethodType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljavax/swing/text/html/FormSubmitEvent$MethodType;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/FormSubmitEvent.MethodType.html#values()"/>
            /// </summary>

            /// <returns><see cref="Javax.Swing.Text.Html.FormSubmitEvent.MethodType"/></returns>
            public static Javax.Swing.Text.Html.FormSubmitEvent.MethodType[] Values()
            {
                return SExecuteWithSignatureArray<Javax.Swing.Text.Html.FormSubmitEvent.MethodType>(LocalBridgeClazz, "values", "()[Ljavax/swing/text/html/FormSubmitEvent$MethodType;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}