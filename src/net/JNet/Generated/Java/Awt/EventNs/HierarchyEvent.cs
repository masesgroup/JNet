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

namespace Java.Awt.EventNs
{
    #region HierarchyEvent
    public partial class HierarchyEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#%3Cinit%3E(java.awt.Component,int,java.awt.Component,java.awt.Container,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg4"><see langword="long"/></param>
        public HierarchyEvent(Java.Awt.Component arg0, int arg1, Java.Awt.Component arg2, Java.Awt.Container arg3, long arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#%3Cinit%3E(java.awt.Component,int,java.awt.Component,java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Container"/></param>
        public HierarchyEvent(Java.Awt.Component arg0, int arg1, Java.Awt.Component arg2, Java.Awt.Container arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#ANCESTOR_MOVED"/>
        /// </summary>
        public static int ANCESTOR_MOVED => Clazz.GetField<int>("ANCESTOR_MOVED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#ANCESTOR_RESIZED"/>
        /// </summary>
        public static int ANCESTOR_RESIZED => Clazz.GetField<int>("ANCESTOR_RESIZED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#DISPLAYABILITY_CHANGED"/>
        /// </summary>
        public static int DISPLAYABILITY_CHANGED => Clazz.GetField<int>("DISPLAYABILITY_CHANGED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#HIERARCHY_CHANGED"/>
        /// </summary>
        public static int HIERARCHY_CHANGED => Clazz.GetField<int>("HIERARCHY_CHANGED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#HIERARCHY_FIRST"/>
        /// </summary>
        public static int HIERARCHY_FIRST => Clazz.GetField<int>("HIERARCHY_FIRST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#HIERARCHY_LAST"/>
        /// </summary>
        public static int HIERARCHY_LAST => Clazz.GetField<int>("HIERARCHY_LAST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#PARENT_CHANGED"/>
        /// </summary>
        public static int PARENT_CHANGED => Clazz.GetField<int>("PARENT_CHANGED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#SHOWING_CHANGED"/>
        /// </summary>
        public static int SHOWING_CHANGED => Clazz.GetField<int>("SHOWING_CHANGED");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#getChanged()"/> 
        /// </summary>
        public Java.Awt.Component Changed
        {
            get { return IExecute<Java.Awt.Component>("getChanged"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#getChangedParent()"/> 
        /// </summary>
        public Java.Awt.Container ChangedParent
        {
            get { return IExecute<Java.Awt.Container>("getChangedParent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#getChangeFlags()"/> 
        /// </summary>
        public long ChangeFlags
        {
            get { return IExecute<long>("getChangeFlags"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#getComponent()"/> 
        /// </summary>
        public Java.Awt.Component Component
        {
            get { return IExecute<Java.Awt.Component>("getComponent"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}