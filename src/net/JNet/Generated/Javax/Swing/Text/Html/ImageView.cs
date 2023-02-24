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
    #region ImageView
    public partial class ImageView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/ImageView.html#%3Cinit%3E(javax.swing.text.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        public ImageView(Javax.Swing.Text.Element arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/ImageView.html#getAltText()"/> 
        /// </summary>
        public string AltText
        {
            get { return IExecute<string>("getAltText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/ImageView.html#getImage()"/> 
        /// </summary>
        public Java.Awt.Image Image
        {
            get { return IExecute<Java.Awt.Image>("getImage"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/ImageView.html#getImageURL()"/> 
        /// </summary>
        public Java.Net.URL ImageURL
        {
            get { return IExecute<Java.Net.URL>("getImageURL"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/ImageView.html#getLoadingImageIcon()"/> 
        /// </summary>
        public Javax.Swing.Icon LoadingImageIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getLoadingImageIcon"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/ImageView.html#getLoadsSynchronously()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/ImageView.html#setLoadsSynchronously(boolean)"/>
        /// </summary>
        public bool LoadsSynchronously
        {
            get { return IExecute<bool>("getLoadsSynchronously"); } set { IExecute("setLoadsSynchronously", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/ImageView.html#getNoImageIcon()"/> 
        /// </summary>
        public Javax.Swing.Icon NoImageIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getNoImageIcon"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}