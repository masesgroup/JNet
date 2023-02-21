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

namespace Javax.Swing
{
    #region SizeSequence
    public partial class SizeSequence
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeSequence.html#<init>(int[])
        /// </summary>
        public SizeSequence(int[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeSequence.html#<init>(int,int)
        /// </summary>
        public SizeSequence(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeSequence.html#<init>(int)
        /// </summary>
        public SizeSequence(int arg0)
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeSequence.html#getSizes() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeSequence.html#setSizes(int[])
        /// </summary>
        public int[] Sizes
        {
            get { return IExecuteArray<int>("getSizes"); } set { IExecute("setSizes", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeSequence.html#getIndex(int)
        /// </summary>
        public int GetIndex(int arg0)
        {
            return IExecute<int>("getIndex", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeSequence.html#getPosition(int)
        /// </summary>
        public int GetPosition(int arg0)
        {
            return IExecute<int>("getPosition", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeSequence.html#getSize(int)
        /// </summary>
        public int GetSize(int arg0)
        {
            return IExecute<int>("getSize", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeSequence.html#insertEntries(int,int,int)
        /// </summary>
        public void InsertEntries(int arg0, int arg1, int arg2)
        {
            IExecute("insertEntries", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeSequence.html#removeEntries(int,int)
        /// </summary>
        public void RemoveEntries(int arg0, int arg1)
        {
            IExecute("removeEntries", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SizeSequence.html#setSize(int,int)
        /// </summary>
        public void SetSize(int arg0, int arg1)
        {
            IExecute("setSize", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}