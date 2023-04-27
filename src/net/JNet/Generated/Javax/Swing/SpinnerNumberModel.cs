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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region SpinnerNumberModel
    public partial class SpinnerNumberModel
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerNumberModel.html#%3Cinit%3E(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        public SpinnerNumberModel(double arg0, double arg1, double arg2, double arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerNumberModel.html#%3Cinit%3E(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public SpinnerNumberModel(int arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerNumberModel.html#%3Cinit%3E(java.lang.Number,java.lang.Comparable,java.lang.Comparable,java.lang.Number)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Number"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Comparable"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Comparable"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Number"/></param>
        public SpinnerNumberModel(Java.Lang.Number arg0, Java.Lang.Comparable arg1, Java.Lang.Comparable arg2, Java.Lang.Number arg3)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerNumberModel.html#getMaximum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerNumberModel.html#setMaximum(java.lang.Comparable)"/>
        /// </summary>
        public Java.Lang.Comparable Maximum
        {
            get { return IExecute<Java.Lang.Comparable>("getMaximum"); } set { IExecute("setMaximum", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerNumberModel.html#getMinimum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerNumberModel.html#setMinimum(java.lang.Comparable)"/>
        /// </summary>
        public Java.Lang.Comparable Minimum
        {
            get { return IExecute<Java.Lang.Comparable>("getMinimum"); } set { IExecute("setMinimum", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerNumberModel.html#getNumber()"/> 
        /// </summary>
        public Java.Lang.Number Number
        {
            get { return IExecute<Java.Lang.Number>("getNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerNumberModel.html#getStepSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpinnerNumberModel.html#setStepSize(java.lang.Number)"/>
        /// </summary>
        public Java.Lang.Number StepSize
        {
            get { return IExecute<Java.Lang.Number>("getStepSize"); } set { IExecute("setStepSize", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}