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
    #region JComponent
    public partial class JComponent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JComponent"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.JComponent t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#UNDEFINED_CONDITION"/>
        /// </summary>
        public static int UNDEFINED_CONDITION { get { return LocalClazz.GetField<int>("UNDEFINED_CONDITION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#WHEN_ANCESTOR_OF_FOCUSED_COMPONENT"/>
        /// </summary>
        public static int WHEN_ANCESTOR_OF_FOCUSED_COMPONENT { get { return LocalClazz.GetField<int>("WHEN_ANCESTOR_OF_FOCUSED_COMPONENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#WHEN_FOCUSED"/>
        /// </summary>
        public static int WHEN_FOCUSED { get { return LocalClazz.GetField<int>("WHEN_FOCUSED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#WHEN_IN_FOCUSED_WINDOW"/>
        /// </summary>
        public static int WHEN_IN_FOCUSED_WINDOW { get { return LocalClazz.GetField<int>("WHEN_IN_FOCUSED_WINDOW"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#TOOL_TIP_TEXT_KEY"/>
        /// </summary>
        public static string TOOL_TIP_TEXT_KEY { get { return LocalClazz.GetField<string>("TOOL_TIP_TEXT_KEY"); } }
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getDefaultLocale()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setDefaultLocale(java.util.Locale)"/>
        /// </summary>
        public static Java.Util.Locale DefaultLocale
        {
            get { return SExecute<Java.Util.Locale>(LocalClazz, "getDefaultLocale"); } set { SExecute(LocalClazz, "setDefaultLocale", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#isLightweightComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsLightweightComponent(Java.Awt.Component arg0)
        {
            return SExecute<bool>(LocalClazz, "isLightweightComponent", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getActionMap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setActionMap(javax.swing.ActionMap)"/>
        /// </summary>
        public Javax.Swing.ActionMap ActionMap
        {
            get { return IExecute<Javax.Swing.ActionMap>("getActionMap"); } set { IExecute("setActionMap", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getAncestorListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.AncestorListener[] AncestorListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.AncestorListener>("getAncestorListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getAutoscrolls()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setAutoscrolls(boolean)"/>
        /// </summary>
        public bool Autoscrolls
        {
            get { return IExecute<bool>("getAutoscrolls"); } set { IExecute("setAutoscrolls", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setBorder(javax.swing.border.Border)"/>
        /// </summary>
        public Javax.Swing.Border.Border Border
        {
            get { return IExecute<Javax.Swing.Border.Border>("getBorder"); } set { IExecute("setBorder", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getComponentPopupMenu()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setComponentPopupMenu(javax.swing.JPopupMenu)"/>
        /// </summary>
        public Javax.Swing.JPopupMenu ComponentPopupMenu
        {
            get { return IExecute<Javax.Swing.JPopupMenu>("getComponentPopupMenu"); } set { IExecute("setComponentPopupMenu", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#createToolTip()"/> 
        /// </summary>
        public Javax.Swing.JToolTip CreateToolTip
        {
            get { return IExecute<Javax.Swing.JToolTip>("createToolTip"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getDebugGraphicsOptions()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setDebugGraphicsOptions(int)"/>
        /// </summary>
        public int DebugGraphicsOptions
        {
            get { return IExecute<int>("getDebugGraphicsOptions"); } set { IExecute("setDebugGraphicsOptions", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getInheritsPopupMenu()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setInheritsPopupMenu(boolean)"/>
        /// </summary>
        public bool InheritsPopupMenu
        {
            get { return IExecute<bool>("getInheritsPopupMenu"); } set { IExecute("setInheritsPopupMenu", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getInputMap()"/> 
        /// </summary>
        public Javax.Swing.InputMap InputMap
        {
            get { return IExecute<Javax.Swing.InputMap>("getInputMap"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getInputVerifier()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setInputVerifier(javax.swing.InputVerifier)"/>
        /// </summary>
        public Javax.Swing.InputVerifier InputVerifier
        {
            get { return IExecute<Javax.Swing.InputVerifier>("getInputVerifier"); } set { IExecute("setInputVerifier", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#isOptimizedDrawingEnabled()"/> 
        /// </summary>
        public bool IsOptimizedDrawingEnabled
        {
            get { return IExecute<bool>("isOptimizedDrawingEnabled"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#isPaintingForPrint()"/> 
        /// </summary>
        public bool IsPaintingForPrint
        {
            get { return IExecute<bool>("isPaintingForPrint"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#isPaintingTile()"/> 
        /// </summary>
        public bool IsPaintingTile
        {
            get { return IExecute<bool>("isPaintingTile"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#isRequestFocusEnabled()"/> 
        /// </summary>
        public bool IsRequestFocusEnabled
        {
            get { return IExecute<bool>("isRequestFocusEnabled"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getRegisteredKeyStrokes()"/> 
        /// </summary>
        public Javax.Swing.KeyStroke[] RegisteredKeyStrokes
        {
            get { return IExecuteArray<Javax.Swing.KeyStroke>("getRegisteredKeyStrokes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getRootPane()"/> 
        /// </summary>
        public Javax.Swing.JRootPane RootPane
        {
            get { return IExecute<Javax.Swing.JRootPane>("getRootPane"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getToolTipText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setToolTipText(java.lang.String)"/>
        /// </summary>
        public string ToolTipText
        {
            get { return IExecute<string>("getToolTipText"); } set { IExecute("setToolTipText", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getTopLevelAncestor()"/> 
        /// </summary>
        public Java.Awt.Container TopLevelAncestor
        {
            get { return IExecute<Java.Awt.Container>("getTopLevelAncestor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getTransferHandler()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setTransferHandler(javax.swing.TransferHandler)"/>
        /// </summary>
        public Javax.Swing.TransferHandler TransferHandler
        {
            get { return IExecute<Javax.Swing.TransferHandler>("getTransferHandler"); } set { IExecute("setTransferHandler", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getUI()"/> 
        /// </summary>
        public Javax.Swing.Plaf.ComponentUI UI
        {
            get { return IExecute<Javax.Swing.Plaf.ComponentUI>("getUI"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getUIClassID()"/> 
        /// </summary>
        public string UIClassID
        {
            get { return IExecute<string>("getUIClassID"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getVerifyInputWhenFocusTarget()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setVerifyInputWhenFocusTarget(boolean)"/>
        /// </summary>
        public bool VerifyInputWhenFocusTarget
        {
            get { return IExecute<bool>("getVerifyInputWhenFocusTarget"); } set { IExecute("setVerifyInputWhenFocusTarget", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getVetoableChangeListeners()"/> 
        /// </summary>
        public Java.Beans.VetoableChangeListener[] VetoableChangeListeners
        {
            get { return IExecuteArray<Java.Beans.VetoableChangeListener>("getVetoableChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getVisibleRect()"/> 
        /// </summary>
        public Java.Awt.Rectangle VisibleRect
        {
            get { return IExecute<Java.Awt.Rectangle>("getVisibleRect"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#requestFocus(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RequestFocus(bool arg0)
        {
            return IExecute<bool>("requestFocus", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getClientProperty(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetClientProperty(object arg0)
        {
            return IExecute("getClientProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getInputMap(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.InputMap"/></returns>
        public Javax.Swing.InputMap GetInputMap(int arg0)
        {
            return IExecute<Javax.Swing.InputMap>("getInputMap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#putClientProperty(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void PutClientProperty(object arg0, object arg1)
        {
            IExecute("putClientProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setInputMap(int,javax.swing.InputMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.InputMap"/></param>
        public void SetInputMap(int arg0, Javax.Swing.InputMap arg1)
        {
            IExecute("setInputMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getConditionForKeyStroke(javax.swing.KeyStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetConditionForKeyStroke(Javax.Swing.KeyStroke arg0)
        {
            return IExecute<int>("getConditionForKeyStroke", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getActionForKeyStroke(javax.swing.KeyStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <returns><see cref="Java.Awt.EventNs.ActionListener"/></returns>
        public Java.Awt.EventNs.ActionListener GetActionForKeyStroke(Javax.Swing.KeyStroke arg0)
        {
            return IExecute<Java.Awt.EventNs.ActionListener>("getActionForKeyStroke", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getInsets(java.awt.Insets)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Insets"/></param>
        /// <returns><see cref="Java.Awt.Insets"/></returns>
        public Java.Awt.Insets GetInsets(Java.Awt.Insets arg0)
        {
            return IExecute<Java.Awt.Insets>("getInsets", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getPopupLocation(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <returns><see cref="Java.Awt.Point"/></returns>
        public Java.Awt.Point GetPopupLocation(Java.Awt.EventNs.MouseEvent arg0)
        {
            return IExecute<Java.Awt.Point>("getPopupLocation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getToolTipLocation(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <returns><see cref="Java.Awt.Point"/></returns>
        public Java.Awt.Point GetToolTipLocation(Java.Awt.EventNs.MouseEvent arg0)
        {
            return IExecute<Java.Awt.Point>("getToolTipLocation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#getToolTipText(java.awt.event.MouseEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.MouseEvent"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetToolTipText(Java.Awt.EventNs.MouseEvent arg0)
        {
            return IExecute<string>("getToolTipText", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#addVetoableChangeListener(java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void AddVetoableChangeListener(Java.Beans.VetoableChangeListener arg0)
        {
            IExecute("addVetoableChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#removeVetoableChangeListener(java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void RemoveVetoableChangeListener(Java.Beans.VetoableChangeListener arg0)
        {
            IExecute("removeVetoableChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#addAncestorListener(javax.swing.event.AncestorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.AncestorListener"/></param>
        public void AddAncestorListener(Javax.Swing.Event.AncestorListener arg0)
        {
            IExecute("addAncestorListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#computeVisibleRect(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        public void ComputeVisibleRect(Java.Awt.Rectangle arg0)
        {
            IExecute("computeVisibleRect", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#firePropertyChange(java.lang.String,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void FirePropertyChange(string arg0, bool arg1, bool arg2)
        {
            IExecute("firePropertyChange", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#firePropertyChange(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void FirePropertyChange(string arg0, int arg1, int arg2)
        {
            IExecute("firePropertyChange", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#grabFocus()"/>
        /// </summary>
        public void GrabFocus()
        {
            IExecute("grabFocus");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#paintImmediately(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void PaintImmediately(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("paintImmediately", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#paintImmediately(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        public void PaintImmediately(Java.Awt.Rectangle arg0)
        {
            IExecute("paintImmediately", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#registerKeyboardAction(java.awt.event.ActionListener,java.lang.String,javax.swing.KeyStroke,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void RegisterKeyboardAction(Java.Awt.EventNs.ActionListener arg0, string arg1, Javax.Swing.KeyStroke arg2, int arg3)
        {
            IExecute("registerKeyboardAction", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#registerKeyboardAction(java.awt.event.ActionListener,javax.swing.KeyStroke,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void RegisterKeyboardAction(Java.Awt.EventNs.ActionListener arg0, Javax.Swing.KeyStroke arg1, int arg2)
        {
            IExecute("registerKeyboardAction", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#removeAncestorListener(javax.swing.event.AncestorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.AncestorListener"/></param>
        public void RemoveAncestorListener(Javax.Swing.Event.AncestorListener arg0)
        {
            IExecute("removeAncestorListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#repaint(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        public void Repaint(Java.Awt.Rectangle arg0)
        {
            IExecute("repaint", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#resetKeyboardActions()"/>
        /// </summary>
        public void ResetKeyboardActions()
        {
            IExecute("resetKeyboardActions");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#scrollRectToVisible(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        public void ScrollRectToVisible(Java.Awt.Rectangle arg0)
        {
            IExecute("scrollRectToVisible", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setAlignmentX(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetAlignmentX(float arg0)
        {
            IExecute("setAlignmentX", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setAlignmentY(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetAlignmentY(float arg0)
        {
            IExecute("setAlignmentY", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setDoubleBuffered(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDoubleBuffered(bool arg0)
        {
            IExecute("setDoubleBuffered", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setOpaque(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetOpaque(bool arg0)
        {
            IExecute("setOpaque", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#setRequestFocusEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRequestFocusEnabled(bool arg0)
        {
            IExecute("setRequestFocusEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#unregisterKeyboardAction(javax.swing.KeyStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        public void UnregisterKeyboardAction(Javax.Swing.KeyStroke arg0)
        {
            IExecute("unregisterKeyboardAction", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.html#updateUI()"/>
        /// </summary>
        public void UpdateUI()
        {
            IExecute("updateUI");
        }
        
        #endregion

        #region Nested classes
        #region AccessibleJComponent
        public partial class AccessibleJComponent
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.JComponent.AccessibleJComponent"/> to <see cref="Javax.Accessibility.AccessibleExtendedComponent"/>
            /// </summary>
            public static implicit operator Javax.Accessibility.AccessibleExtendedComponent(Javax.Swing.JComponent.AccessibleJComponent t) => t.Cast<Javax.Accessibility.AccessibleExtendedComponent>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.AccessibleJComponent.html#getAccessibleKeyBinding()"/> 
            /// </summary>
            public Javax.Accessibility.AccessibleKeyBinding AccessibleKeyBinding
            {
                get { return IExecute<Javax.Accessibility.AccessibleKeyBinding>("getAccessibleKeyBinding"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.AccessibleJComponent.html#getTitledBorderText()"/> 
            /// </summary>
            public string TitledBorderText
            {
                get { return IExecute<string>("getTitledBorderText"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JComponent.AccessibleJComponent.html#getToolTipText()"/> 
            /// </summary>
            public string ToolTipText
            {
                get { return IExecute<string>("getToolTipText"); }
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}