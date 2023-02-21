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

namespace Java.Awt.ImageNs
{
    #region SinglePixelPackedSampleModel
    public partial class SinglePixelPackedSampleModel
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SinglePixelPackedSampleModel.html#<init>(int,int,int,int,int[])
        /// </summary>
        public SinglePixelPackedSampleModel(int arg0, int arg1, int arg2, int arg3, int[] arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SinglePixelPackedSampleModel.html#<init>(int,int,int,int[])
        /// </summary>
        public SinglePixelPackedSampleModel(int arg0, int arg1, int arg2, int[] arg3)
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SinglePixelPackedSampleModel.html#getBitMasks() 
        /// </summary>
        public int[] BitMasks
        {
            get { return IExecuteArray<int>("getBitMasks"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SinglePixelPackedSampleModel.html#getBitOffsets() 
        /// </summary>
        public int[] BitOffsets
        {
            get { return IExecuteArray<int>("getBitOffsets"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SinglePixelPackedSampleModel.html#getScanlineStride() 
        /// </summary>
        public int ScanlineStride
        {
            get { return IExecute<int>("getScanlineStride"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SinglePixelPackedSampleModel.html#getOffset(int,int)
        /// </summary>
        public int GetOffset(int arg0, int arg1)
        {
            return IExecute<int>("getOffset", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}