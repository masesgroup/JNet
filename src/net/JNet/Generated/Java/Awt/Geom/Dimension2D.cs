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

namespace Java.Awt.Geom
{
    #region Dimension2D
    public partial class Dimension2D
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Geom.Dimension2D"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.Geom.Dimension2D t) => t.Cast<Java.Lang.Cloneable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Dimension2D.html#getHeight()"/> 
        /// </summary>
        public double Height
        {
            get { return IExecute<double>("getHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Dimension2D.html#getWidth()"/> 
        /// </summary>
        public double Width
        {
            get { return IExecute<double>("getWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Dimension2D.html#setSize(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void SetSize(double arg0, double arg1)
        {
            IExecute("setSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Dimension2D.html#setSize(java.awt.geom.Dimension2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Dimension2D"/></param>
        public void SetSize(Java.Awt.Geom.Dimension2D arg0)
        {
            IExecute("setSize", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}