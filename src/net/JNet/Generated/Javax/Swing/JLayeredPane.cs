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
    #region JLayeredPane
    public partial class JLayeredPane
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JLayeredPane"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JLayeredPane t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#DEFAULT_LAYER"/>
        /// </summary>
        public static int? DEFAULT_LAYER => Clazz.GetField<int?>("DEFAULT_LAYER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#DRAG_LAYER"/>
        /// </summary>
        public static int? DRAG_LAYER => Clazz.GetField<int?>("DRAG_LAYER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#FRAME_CONTENT_LAYER"/>
        /// </summary>
        public static int? FRAME_CONTENT_LAYER => Clazz.GetField<int?>("FRAME_CONTENT_LAYER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#MODAL_LAYER"/>
        /// </summary>
        public static int? MODAL_LAYER => Clazz.GetField<int?>("MODAL_LAYER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#PALETTE_LAYER"/>
        /// </summary>
        public static int? PALETTE_LAYER => Clazz.GetField<int?>("PALETTE_LAYER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#POPUP_LAYER"/>
        /// </summary>
        public static int? POPUP_LAYER => Clazz.GetField<int?>("POPUP_LAYER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#LAYER_PROPERTY"/>
        /// </summary>
        public static string LAYER_PROPERTY => Clazz.GetField<string>("LAYER_PROPERTY");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#getLayer(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <returns><see langword="int"/></returns>
        public static int GetLayer(Javax.Swing.JComponent arg0)
        {
            return SExecute<int>("getLayer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#getLayeredPaneAbove(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Javax.Swing.JLayeredPane"/></returns>
        public static Javax.Swing.JLayeredPane GetLayeredPaneAbove(Java.Awt.Component arg0)
        {
            return SExecute<Javax.Swing.JLayeredPane>("getLayeredPaneAbove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#putLayer(javax.swing.JComponent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public static void PutLayer(Javax.Swing.JComponent arg0, int arg1)
        {
            SExecute("putLayer", arg0, arg1);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#getComponentCountInLayer(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetComponentCountInLayer(int arg0)
        {
            return IExecute<int>("getComponentCountInLayer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#getIndexOf(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetIndexOf(Java.Awt.Component arg0)
        {
            return IExecute<int>("getIndexOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#getLayer(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetLayer(Java.Awt.Component arg0)
        {
            return IExecute<int>("getLayer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#getPosition(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetPosition(Java.Awt.Component arg0)
        {
            return IExecute<int>("getPosition", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#highestLayer()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int HighestLayer()
        {
            return IExecute<int>("highestLayer");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#lowestLayer()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int LowestLayer()
        {
            return IExecute<int>("lowestLayer");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#getComponentsInLayer(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component[] GetComponentsInLayer(int arg0)
        {
            return IExecuteArray<Java.Awt.Component>("getComponentsInLayer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#moveToBack(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void MoveToBack(Java.Awt.Component arg0)
        {
            IExecute("moveToBack", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#moveToFront(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void MoveToFront(Java.Awt.Component arg0)
        {
            IExecute("moveToFront", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#setLayer(java.awt.Component,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetLayer(Java.Awt.Component arg0, int arg1, int arg2)
        {
            IExecute("setLayer", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#setLayer(java.awt.Component,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLayer(Java.Awt.Component arg0, int arg1)
        {
            IExecute("setLayer", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#setPosition(java.awt.Component,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetPosition(Java.Awt.Component arg0, int arg1)
        {
            IExecute("setPosition", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}