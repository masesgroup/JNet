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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio
{
    #region IIOParam
    public partial class IIOParam
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getController()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#setController(javax.imageio.IIOParamController)"/>
        /// </summary>
        public Javax.Imageio.IIOParamController Controller
        {
            get { return IExecute<Javax.Imageio.IIOParamController>("getController"); } set { IExecute("setController", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getDefaultController()"/> 
        /// </summary>
        public Javax.Imageio.IIOParamController DefaultController
        {
            get { return IExecute<Javax.Imageio.IIOParamController>("getDefaultController"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getDestinationOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#setDestinationOffset(java.awt.Point)"/>
        /// </summary>
        public Java.Awt.Point DestinationOffset
        {
            get { return IExecute<Java.Awt.Point>("getDestinationOffset"); } set { IExecute("setDestinationOffset", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getDestinationType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#setDestinationType(javax.imageio.ImageTypeSpecifier)"/>
        /// </summary>
        public Javax.Imageio.ImageTypeSpecifier DestinationType
        {
            get { return IExecute<Javax.Imageio.ImageTypeSpecifier>("getDestinationType"); } set { IExecute("setDestinationType", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getSourceBands()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#setSourceBands(int[])"/>
        /// </summary>
        public int[] SourceBands
        {
            get { return IExecuteArray<int>("getSourceBands"); } set { IExecute("setSourceBands", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getSourceRegion()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#setSourceRegion(java.awt.Rectangle)"/>
        /// </summary>
        public Java.Awt.Rectangle SourceRegion
        {
            get { return IExecute<Java.Awt.Rectangle>("getSourceRegion"); } set { IExecute("setSourceRegion", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getSourceXSubsampling()"/> 
        /// </summary>
        public int SourceXSubsampling
        {
            get { return IExecute<int>("getSourceXSubsampling"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getSourceYSubsampling()"/> 
        /// </summary>
        public int SourceYSubsampling
        {
            get { return IExecute<int>("getSourceYSubsampling"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getSubsamplingXOffset()"/> 
        /// </summary>
        public int SubsamplingXOffset
        {
            get { return IExecute<int>("getSubsamplingXOffset"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getSubsamplingYOffset()"/> 
        /// </summary>
        public int SubsamplingYOffset
        {
            get { return IExecute<int>("getSubsamplingYOffset"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#activateController()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool ActivateController()
        {
            return IExecute<bool>("activateController");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#hasController()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasController()
        {
            return IExecute<bool>("hasController");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#setSourceSubsampling(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetSourceSubsampling(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setSourceSubsampling", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}