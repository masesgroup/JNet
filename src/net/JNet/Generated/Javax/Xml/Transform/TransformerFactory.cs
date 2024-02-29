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

namespace Javax.Xml.Transform
{
    #region TransformerFactory
    public partial class TransformerFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#newDefaultInstance()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Transform.TransformerFactory"/></returns>
        public static Javax.Xml.Transform.TransformerFactory NewDefaultInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Transform.TransformerFactory>(LocalBridgeClazz, "newDefaultInstance", "()Ljavax/xml/transform/TransformerFactory;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#newInstance()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Transform.TransformerFactory"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerFactoryConfigurationError"/>
        public static Javax.Xml.Transform.TransformerFactory NewInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Transform.TransformerFactory>(LocalBridgeClazz, "newInstance", "()Ljavax/xml/transform/TransformerFactory;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#newInstance(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Transform.TransformerFactory"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerFactoryConfigurationError"/>
        public static Javax.Xml.Transform.TransformerFactory NewInstance(Java.Lang.String arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Javax.Xml.Transform.TransformerFactory>(LocalBridgeClazz, "newInstance", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#getErrorListener()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#setErrorListener(javax.xml.transform.ErrorListener)"/>
        /// </summary>
        public Javax.Xml.Transform.ErrorListener ErrorListener
        {
            get { return IExecuteWithSignature<Javax.Xml.Transform.ErrorListener>("getErrorListener", "()Ljavax/xml/transform/ErrorListener;"); } set { IExecuteWithSignature("setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#getURIResolver()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#setURIResolver(javax.xml.transform.URIResolver)"/>
        /// </summary>
        public Javax.Xml.Transform.URIResolver URIResolver
        {
            get { return IExecuteWithSignature<Javax.Xml.Transform.URIResolver>("getURIResolver", "()Ljavax/xml/transform/URIResolver;"); } set { IExecuteWithSignature("setURIResolver", "(Ljavax/xml/transform/URIResolver;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetFeature(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("getFeature", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAttribute(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#getAssociatedStylesheet(javax.xml.transform.Source,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Transform.Source"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Source GetAssociatedStylesheet(Javax.Xml.Transform.Source arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3)
        {
            return IExecute<Javax.Xml.Transform.Source>("getAssociatedStylesheet", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#newTemplates(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Javax.Xml.Transform.Templates"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Templates NewTemplates(Javax.Xml.Transform.Source arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Templates>("newTemplates", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Templates;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#newTransformer()"/>
        /// </summary>

        /// <returns><see cref="Javax.Xml.Transform.Transformer"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Transformer NewTransformer()
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Transformer>("newTransformer", "()Ljavax/xml/transform/Transformer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#newTransformer(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Javax.Xml.Transform.Transformer"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Transformer NewTransformer(Javax.Xml.Transform.Source arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Transformer>("newTransformer", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Transformer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#setAttribute(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void SetAttribute(Java.Lang.String arg0, object arg1)
        {
            IExecute("setAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/javax/xml/transform/TransformerFactory.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public void SetFeature(Java.Lang.String arg0, bool arg1)
        {
            IExecute("setFeature", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}