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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region MBeanFeatureInfo
    public partial class MBeanFeatureInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanFeatureInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Descriptor"/></param>
        public MBeanFeatureInfo(string arg0, string arg1, Javax.Management.Descriptor arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanFeatureInfo.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public MBeanFeatureInfo(string arg0, string arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.MBeanFeatureInfo"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Management.MBeanFeatureInfo t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.MBeanFeatureInfo"/> to <see cref="Javax.Management.DescriptorRead"/>
        /// </summary>
        public static implicit operator Javax.Management.DescriptorRead(Javax.Management.MBeanFeatureInfo t) => t.Cast<Javax.Management.DescriptorRead>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanFeatureInfo.html#getDescription()"/> 
        /// </summary>
        public string Description
        {
            get { return IExecute<string>("getDescription"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanFeatureInfo.html#getDescriptor()"/> 
        /// </summary>
        public Javax.Management.Descriptor Descriptor
        {
            get { return IExecute<Javax.Management.Descriptor>("getDescriptor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanFeatureInfo.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}