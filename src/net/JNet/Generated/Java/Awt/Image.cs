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

namespace Java.Awt
{
    #region Image
    public partial class Image
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#SCALE_AREA_AVERAGING"/>
        /// </summary>
        public static int SCALE_AREA_AVERAGING => Clazz.GetField<int>("SCALE_AREA_AVERAGING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#SCALE_DEFAULT"/>
        /// </summary>
        public static int SCALE_DEFAULT => Clazz.GetField<int>("SCALE_DEFAULT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#SCALE_FAST"/>
        /// </summary>
        public static int SCALE_FAST => Clazz.GetField<int>("SCALE_FAST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#SCALE_REPLICATE"/>
        /// </summary>
        public static int SCALE_REPLICATE => Clazz.GetField<int>("SCALE_REPLICATE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#SCALE_SMOOTH"/>
        /// </summary>
        public static int SCALE_SMOOTH => Clazz.GetField<int>("SCALE_SMOOTH");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#UndefinedProperty"/>
        /// </summary>
        public static object UndefinedProperty => Clazz.GetField("UndefinedProperty");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getAccelerationPriority()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#setAccelerationPriority(float)"/>
        /// </summary>
        public float AccelerationPriority
        {
            get { return IExecute<float>("getAccelerationPriority"); } set { IExecute("setAccelerationPriority", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getGraphics()"/> 
        /// </summary>
        public Java.Awt.Graphics Graphics
        {
            get { return IExecute<Java.Awt.Graphics>("getGraphics"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getSource()"/> 
        /// </summary>
        public Java.Awt.ImageNs.ImageProducer Source
        {
            get { return IExecute<Java.Awt.ImageNs.ImageProducer>("getSource"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getHeight(java.awt.image.ImageObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageObserver"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetHeight(Java.Awt.ImageNs.ImageObserver arg0)
        {
            return IExecute<int>("getHeight", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getWidth(java.awt.image.ImageObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageObserver"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetWidth(Java.Awt.ImageNs.ImageObserver arg0)
        {
            return IExecute<int>("getWidth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getProperty(java.lang.String,java.awt.image.ImageObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.ImageObserver"/></param>
        /// <returns><see langword="object"/></returns>
        public object GetProperty(string arg0, Java.Awt.ImageNs.ImageObserver arg1)
        {
            return IExecute("getProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getScaledInstance(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image GetScaledInstance(int arg0, int arg1, int arg2)
        {
            return IExecute<Java.Awt.Image>("getScaledInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#getCapabilities(java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        /// <returns><see cref="Java.Awt.ImageCapabilities"/></returns>
        public Java.Awt.ImageCapabilities GetCapabilities(Java.Awt.GraphicsConfiguration arg0)
        {
            return IExecute<Java.Awt.ImageCapabilities>("getCapabilities", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Image.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecute("flush");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}