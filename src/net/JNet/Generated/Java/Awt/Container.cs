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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region Container
    public partial class Container
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#getComponentCount()"/> 
        /// </summary>
        public int ComponentCount
        {
            get { return IExecuteWithSignature<int>("getComponentCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#getComponents()"/> 
        /// </summary>
        public Java.Awt.Component[] Components
        {
            get { return IExecuteWithSignatureArray<Java.Awt.Component>("getComponents", "()[Ljava/awt/Component;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#getContainerListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ContainerListener[] ContainerListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.ContainerListener>("getContainerListeners", "()[Ljava/awt/event/ContainerListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#getFocusTraversalPolicy()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#setFocusTraversalPolicy(java.awt.FocusTraversalPolicy)"/>
        /// </summary>
        public Java.Awt.FocusTraversalPolicy FocusTraversalPolicy
        {
            get { return IExecuteWithSignature<Java.Awt.FocusTraversalPolicy>("getFocusTraversalPolicy", "()Ljava/awt/FocusTraversalPolicy;"); } set { IExecuteWithSignature("setFocusTraversalPolicy", "(Ljava/awt/FocusTraversalPolicy;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#getInsets()"/> 
        /// </summary>
        public Java.Awt.Insets Insets
        {
            get { return IExecuteWithSignature<Java.Awt.Insets>("getInsets", "()Ljava/awt/Insets;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#getLayout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#setLayout(java.awt.LayoutManager)"/>
        /// </summary>
        public Java.Awt.LayoutManager Layout
        {
            get { return IExecuteWithSignature<Java.Awt.LayoutManager>("getLayout", "()Ljava/awt/LayoutManager;"); } set { IExecuteWithSignature("setLayout", "(Ljava/awt/LayoutManager;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#isAncestorOf(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAncestorOf(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<bool>("isAncestorOf", "(Ljava/awt/Component;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#isFocusCycleRoot()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFocusCycleRoot()
        {
            return IExecuteWithSignature<bool>("isFocusCycleRoot", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#isFocusTraversalPolicySet()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFocusTraversalPolicySet()
        {
            return IExecuteWithSignature<bool>("isFocusTraversalPolicySet", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#isValidateRoot()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsValidateRoot()
        {
            return IExecuteWithSignature<bool>("isValidateRoot", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#isFocusTraversalPolicyProvider()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFocusTraversalPolicyProvider()
        {
            return IExecuteWithSignature<bool>("isFocusTraversalPolicyProvider", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#setFocusTraversalPolicyProvider(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFocusTraversalPolicyProvider(bool arg0)
        {
            IExecuteWithSignature("setFocusTraversalPolicyProvider", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#getComponentZOrder(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetComponentZOrder(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<int>("getComponentZOrder", "(Ljava/awt/Component;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#add(java.awt.Component,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component Add(Java.Awt.Component arg0, int arg1)
        {
            return IExecute<Java.Awt.Component>("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#add(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component Add(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<Java.Awt.Component>("add", "(Ljava/awt/Component;)Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#add(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component Add(Java.Lang.String arg0, Java.Awt.Component arg1)
        {
            return IExecute<Java.Awt.Component>("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#findComponentAt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component FindComponentAt(int arg0, int arg1)
        {
            return IExecute<Java.Awt.Component>("findComponentAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#findComponentAt(java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component FindComponentAt(Java.Awt.Point arg0)
        {
            return IExecuteWithSignature<Java.Awt.Component>("findComponentAt", "(Ljava/awt/Point;)Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#getComponent(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetComponent(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.Component>("getComponent", "(I)Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#getMousePosition(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Awt.Point"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Java.Awt.Point GetMousePosition(bool arg0)
        {
            return IExecuteWithSignature<Java.Awt.Point>("getMousePosition", "(Z)Ljava/awt/Point;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#addContainerListener(java.awt.event.ContainerListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ContainerListener"/></param>
        public void AddContainerListener(Java.Awt.EventNs.ContainerListener arg0)
        {
            IExecuteWithSignature("addContainerListener", "(Ljava/awt/event/ContainerListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#removeContainerListener(java.awt.event.ContainerListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ContainerListener"/></param>
        public void RemoveContainerListener(Java.Awt.EventNs.ContainerListener arg0)
        {
            IExecuteWithSignature("removeContainerListener", "(Ljava/awt/event/ContainerListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#add(java.awt.Component,java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void Add(Java.Awt.Component arg0, object arg1, int arg2)
        {
            IExecute("add", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#add(java.awt.Component,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Add(Java.Awt.Component arg0, object arg1)
        {
            IExecute("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#paintComponents(java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        public void PaintComponents(Java.Awt.Graphics arg0)
        {
            IExecuteWithSignature("paintComponents", "(Ljava/awt/Graphics;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#printComponents(java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        public void PrintComponents(Java.Awt.Graphics arg0)
        {
            IExecuteWithSignature("printComponents", "(Ljava/awt/Graphics;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Remove(int arg0)
        {
            IExecuteWithSignature("remove", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#remove(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void Remove(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("remove", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#removeAll()"/>
        /// </summary>
        public void RemoveAll()
        {
            IExecuteWithSignature("removeAll", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#setComponentZOrder(java.awt.Component,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetComponentZOrder(Java.Awt.Component arg0, int arg1)
        {
            IExecute("setComponentZOrder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#setFocusCycleRoot(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFocusCycleRoot(bool arg0)
        {
            IExecuteWithSignature("setFocusCycleRoot", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Container.html#transferFocusDownCycle()"/>
        /// </summary>
        public void TransferFocusDownCycle()
        {
            IExecuteWithSignature("transferFocusDownCycle", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}