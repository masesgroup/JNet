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

namespace Org.W3c.Dom.Stylesheets
{
    #region StyleSheet
    public partial class StyleSheet
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getDisabled() https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#setDisabled(boolean)
        /// </summary>
        public bool Disabled
        {
            get { return IExecute<bool>("getDisabled"); } set { IExecute("setDisabled", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getHref() 
        /// </summary>
        public string Href
        {
            get { return IExecute<string>("getHref"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getMedia() 
        /// </summary>
        public Org.W3c.Dom.Stylesheets.MediaList Media
        {
            get { return IExecute<Org.W3c.Dom.Stylesheets.MediaList>("getMedia"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getOwnerNode() 
        /// </summary>
        public Org.W3c.Dom.Node OwnerNode
        {
            get { return IExecute<Org.W3c.Dom.Node>("getOwnerNode"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getParentStyleSheet() 
        /// </summary>
        public Org.W3c.Dom.Stylesheets.StyleSheet ParentStyleSheet
        {
            get { return IExecute<Org.W3c.Dom.Stylesheets.StyleSheet>("getParentStyleSheet"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getTitle() 
        /// </summary>
        public string Title
        {
            get { return IExecute<string>("getTitle"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/stylesheets/StyleSheet.html#getType() 
        /// </summary>
        public string Type
        {
            get { return IExecute<string>("getType"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}