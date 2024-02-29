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

namespace Javax.Swing
{
    #region IScrollable
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IScrollable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Scrollable.html#getPreferredScrollableViewportSize()"/> 
        /// </summary>
        Java.Awt.Dimension PreferredScrollableViewportSize { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Scrollable.html#getScrollableTracksViewportHeight()"/> 
        /// </summary>
        bool ScrollableTracksViewportHeight { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Scrollable.html#getScrollableTracksViewportWidth()"/> 
        /// </summary>
        bool ScrollableTracksViewportWidth { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Scrollable.html#getScrollableBlockIncrement(java.awt.Rectangle,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        int GetScrollableBlockIncrement(Java.Awt.Rectangle arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Scrollable.html#getScrollableUnitIncrement(java.awt.Rectangle,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        int GetScrollableUnitIncrement(Java.Awt.Rectangle arg0, int arg1, int arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Scrollable
    public partial class Scrollable : Javax.Swing.IScrollable
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Scrollable.html#getPreferredScrollableViewportSize()"/> 
        /// </summary>
        public Java.Awt.Dimension PreferredScrollableViewportSize
        {
            get { return IExecuteWithSignature<Java.Awt.Dimension>("getPreferredScrollableViewportSize", "()Ljava/awt/Dimension;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Scrollable.html#getScrollableTracksViewportHeight()"/> 
        /// </summary>
        public bool ScrollableTracksViewportHeight
        {
            get { return IExecuteWithSignature<bool>("getScrollableTracksViewportHeight", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Scrollable.html#getScrollableTracksViewportWidth()"/> 
        /// </summary>
        public bool ScrollableTracksViewportWidth
        {
            get { return IExecuteWithSignature<bool>("getScrollableTracksViewportWidth", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Scrollable.html#getScrollableBlockIncrement(java.awt.Rectangle,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetScrollableBlockIncrement(Java.Awt.Rectangle arg0, int arg1, int arg2)
        {
            return IExecute<int>("getScrollableBlockIncrement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Scrollable.html#getScrollableUnitIncrement(java.awt.Rectangle,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetScrollableUnitIncrement(Java.Awt.Rectangle arg0, int arg1, int arg2)
        {
            return IExecute<int>("getScrollableUnitIncrement", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}