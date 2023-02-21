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

namespace Java.Awt
{
    #region Toolkit
    public partial class Toolkit
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getDefaultToolkit() 
        /// </summary>
        public static Java.Awt.Toolkit DefaultToolkit
        {
            get { return SExecute<Java.Awt.Toolkit>("getDefaultToolkit"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getProperty(java.lang.String,java.lang.String)
        /// </summary>
        public static string GetProperty(string arg0, string arg1)
        {
            return SExecute<string>("getProperty", arg0, arg1);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getAWTEventListeners() 
        /// </summary>
        public Java.Awt.EventNs.AWTEventListener[] AWTEventListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.AWTEventListener>("getAWTEventListeners"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getColorModel() throws java.awt.HeadlessException 
        /// </summary>
        public Java.Awt.ImageNs.ColorModel ColorModel
        {
            get { return IExecute<Java.Awt.ImageNs.ColorModel>("getColorModel"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getMaximumCursorColors() throws java.awt.HeadlessException 
        /// </summary>
        public int MaximumCursorColors
        {
            get { return IExecute<int>("getMaximumCursorColors"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getMenuShortcutKeyMaskEx() throws java.awt.HeadlessException 
        /// </summary>
        public int MenuShortcutKeyMaskEx
        {
            get { return IExecute<int>("getMenuShortcutKeyMaskEx"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getPropertyChangeListeners() 
        /// </summary>
        public Java.Beans.PropertyChangeListener[] PropertyChangeListeners
        {
            get { return IExecuteArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getScreenResolution() throws java.awt.HeadlessException 
        /// </summary>
        public int ScreenResolution
        {
            get { return IExecute<int>("getScreenResolution"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getScreenSize() throws java.awt.HeadlessException 
        /// </summary>
        public Java.Awt.Dimension ScreenSize
        {
            get { return IExecute<Java.Awt.Dimension>("getScreenSize"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getSystemClipboard() throws java.awt.HeadlessException 
        /// </summary>
        public Java.Awt.Datatransfer.Clipboard SystemClipboard
        {
            get { return IExecute<Java.Awt.Datatransfer.Clipboard>("getSystemClipboard"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getSystemEventQueue() 
        /// </summary>
        public Java.Awt.EventQueue SystemEventQueue
        {
            get { return IExecute<Java.Awt.EventQueue>("getSystemEventQueue"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getSystemSelection() throws java.awt.HeadlessException 
        /// </summary>
        public Java.Awt.Datatransfer.Clipboard SystemSelection
        {
            get { return IExecute<Java.Awt.Datatransfer.Clipboard>("getSystemSelection"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#prepareImage(java.awt.Image,int,int,java.awt.image.ImageObserver)
        /// </summary>
        public bool PrepareImage(Java.Awt.Image arg0, int arg1, int arg2, Java.Awt.ImageNs.ImageObserver arg3)
        {
            return IExecute<bool>("prepareImage", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#checkImage(java.awt.Image,int,int,java.awt.image.ImageObserver)
        /// </summary>
        public int CheckImage(Java.Awt.Image arg0, int arg1, int arg2, Java.Awt.ImageNs.ImageObserver arg3)
        {
            return IExecute<int>("checkImage", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#createImage(byte[],int,int)
        /// </summary>
        public Java.Awt.Image CreateImage(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Awt.Image>("createImage", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#createImage(java.awt.image.ImageProducer)
        /// </summary>
        public Java.Awt.Image CreateImage(Java.Awt.ImageNs.ImageProducer arg0)
        {
            return IExecute<Java.Awt.Image>("createImage", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#createImage(java.lang.String)
        /// </summary>
        public Java.Awt.Image CreateImage(string arg0)
        {
            return IExecute<Java.Awt.Image>("createImage", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#createImage(java.net.URL)
        /// </summary>
        public Java.Awt.Image CreateImage(Java.Net.URL arg0)
        {
            return IExecute<Java.Awt.Image>("createImage", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getImage(java.lang.String)
        /// </summary>
        public Java.Awt.Image GetImage(string arg0)
        {
            return IExecute<Java.Awt.Image>("getImage", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getImage(java.net.URL)
        /// </summary>
        public Java.Awt.Image GetImage(Java.Net.URL arg0)
        {
            return IExecute<Java.Awt.Image>("getImage", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#beep()
        /// </summary>
        public void Beep()
        {
            IExecute("beep");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#sync()
        /// </summary>
        public void Sync()
        {
            IExecute("sync");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#areExtraMouseButtonsEnabled() throws java.awt.HeadlessException
        /// </summary>
        public bool AreExtraMouseButtonsEnabled()
        {
            return IExecute<bool>("areExtraMouseButtonsEnabled");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getLockingKeyState(int) throws java.lang.UnsupportedOperationException
        /// </summary>
        public bool GetLockingKeyState(int arg0)
        {
            return IExecute<bool>("getLockingKeyState", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#isAlwaysOnTopSupported()
        /// </summary>
        public bool IsAlwaysOnTopSupported()
        {
            return IExecute<bool>("isAlwaysOnTopSupported");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#isDynamicLayoutActive() throws java.awt.HeadlessException
        /// </summary>
        public bool IsDynamicLayoutActive()
        {
            return IExecute<bool>("isDynamicLayoutActive");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#isFrameStateSupported(int) throws java.awt.HeadlessException
        /// </summary>
        public bool IsFrameStateSupported(int arg0)
        {
            return IExecute<bool>("isFrameStateSupported", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getDesktopProperty(java.lang.String)
        /// </summary>
        public object GetDesktopProperty(string arg0)
        {
            return IExecute("getDesktopProperty", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#createCustomCursor(java.awt.Image,java.awt.Point,java.lang.String) throws java.lang.IndexOutOfBoundsException,java.awt.HeadlessException
        /// </summary>
        public Java.Awt.Cursor CreateCustomCursor(Java.Awt.Image arg0, Java.Awt.Point arg1, string arg2)
        {
            return IExecute<Java.Awt.Cursor>("createCustomCursor", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getBestCursorSize(int,int) throws java.awt.HeadlessException
        /// </summary>
        public Java.Awt.Dimension GetBestCursorSize(int arg0, int arg1)
        {
            return IExecute<Java.Awt.Dimension>("getBestCursorSize", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getAWTEventListeners(long)
        /// </summary>
        public Java.Awt.EventNs.AWTEventListener[] GetAWTEventListeners(long arg0)
        {
            return IExecuteArray<Java.Awt.EventNs.AWTEventListener>("getAWTEventListeners", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#createImage(byte[])
        /// </summary>
        public Java.Awt.Image CreateImage(byte[] arg0)
        {
            return IExecute<Java.Awt.Image>("createImage", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getScreenInsets(java.awt.GraphicsConfiguration) throws java.awt.HeadlessException
        /// </summary>
        public Java.Awt.Insets GetScreenInsets(Java.Awt.GraphicsConfiguration arg0)
        {
            return IExecute<Java.Awt.Insets>("getScreenInsets", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getPrintJob(java.awt.Frame,java.lang.String,java.awt.JobAttributes,java.awt.PageAttributes)
        /// </summary>
        public Java.Awt.PrintJob GetPrintJob(Java.Awt.Frame arg0, string arg1, Java.Awt.JobAttributes arg2, Java.Awt.PageAttributes arg3)
        {
            return IExecute<Java.Awt.PrintJob>("getPrintJob", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getPropertyChangeListeners(java.lang.String)
        /// </summary>
        public Java.Beans.PropertyChangeListener[] GetPropertyChangeListeners(string arg0)
        {
            return IExecuteArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#addAWTEventListener(java.awt.event.AWTEventListener,long)
        /// </summary>
        public void AddAWTEventListener(Java.Awt.EventNs.AWTEventListener arg0, long arg1)
        {
            IExecute("addAWTEventListener", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#addPropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)
        /// </summary>
        public void AddPropertyChangeListener(string arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("addPropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#removeAWTEventListener(java.awt.event.AWTEventListener)
        /// </summary>
        public void RemoveAWTEventListener(Java.Awt.EventNs.AWTEventListener arg0)
        {
            IExecute("removeAWTEventListener", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#removePropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)
        /// </summary>
        public void RemovePropertyChangeListener(string arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("removePropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#setDynamicLayout(boolean) throws java.awt.HeadlessException
        /// </summary>
        public void SetDynamicLayout(bool arg0)
        {
            IExecute("setDynamicLayout", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#setLockingKeyState(int,boolean) throws java.lang.UnsupportedOperationException
        /// </summary>
        public void SetLockingKeyState(int arg0, bool arg1)
        {
            IExecute("setLockingKeyState", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}