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
    #region UIManager
    public partial class UIManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.UIManager"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.UIManager t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getAuxiliaryLookAndFeels()"/> 
        /// </summary>
        public static Javax.Swing.LookAndFeel[] AuxiliaryLookAndFeels
        {
            get { return SExecuteArray<Javax.Swing.LookAndFeel>("getAuxiliaryLookAndFeels"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getCrossPlatformLookAndFeelClassName()"/> 
        /// </summary>
        public static string CrossPlatformLookAndFeelClassName
        {
            get { return SExecute<string>("getCrossPlatformLookAndFeelClassName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getInstalledLookAndFeels()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#setInstalledLookAndFeels(javax.swing.UIManager$LookAndFeelInfo[])"/>
        /// </summary>
        public static Javax.Swing.UIManager.LookAndFeelInfo[] InstalledLookAndFeels
        {
            get { return SExecuteArray<Javax.Swing.UIManager.LookAndFeelInfo>("getInstalledLookAndFeels"); } set { SExecute("setInstalledLookAndFeels", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getLookAndFeel()"/> 
        /// </summary>
        public static Javax.Swing.LookAndFeel LookAndFeel
        {
            get { return SExecute<Javax.Swing.LookAndFeel>("getLookAndFeel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getPropertyChangeListeners()"/> 
        /// </summary>
        public static Java.Beans.PropertyChangeListener[] PropertyChangeListeners
        {
            get { return SExecuteArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getSystemLookAndFeelClassName()"/> 
        /// </summary>
        public static string SystemLookAndFeelClassName
        {
            get { return SExecute<string>("getSystemLookAndFeelClassName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getBoolean(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see langword="bool"/></returns>
        public static bool GetBoolean(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<bool>("getBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getBoolean(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public static bool GetBoolean(object arg0)
        {
            return SExecute<bool>("getBoolean", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#removeAuxiliaryLookAndFeel(javax.swing.LookAndFeel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.LookAndFeel"/></param>
        /// <returns><see langword="bool"/></returns>
        public static bool RemoveAuxiliaryLookAndFeel(Javax.Swing.LookAndFeel arg0)
        {
            return SExecute<bool>("removeAuxiliaryLookAndFeel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getInt(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see langword="int"/></returns>
        public static int GetInt(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<int>("getInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getInt(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="int"/></returns>
        public static int GetInt(object arg0)
        {
            return SExecute<int>("getInt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getColor(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public static Java.Awt.Color GetColor(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Awt.Color>("getColor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getColor(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public static Java.Awt.Color GetColor(object arg0)
        {
            return SExecute<Java.Awt.Color>("getColor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getDimension(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public static Java.Awt.Dimension GetDimension(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Awt.Dimension>("getDimension", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getDimension(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public static Java.Awt.Dimension GetDimension(object arg0)
        {
            return SExecute<Java.Awt.Dimension>("getDimension", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getFont(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public static Java.Awt.Font GetFont(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Awt.Font>("getFont", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getFont(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public static Java.Awt.Font GetFont(object arg0)
        {
            return SExecute<Java.Awt.Font>("getFont", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getInsets(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Insets"/></returns>
        public static Java.Awt.Insets GetInsets(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Awt.Insets>("getInsets", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getInsets(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see cref="Java.Awt.Insets"/></returns>
        public static Java.Awt.Insets GetInsets(object arg0)
        {
            return SExecute<Java.Awt.Insets>("getInsets", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#get(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see langword="object"/></returns>
        public static object Get(object arg0, Java.Util.Locale arg1)
        {
            return SExecute("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="object"/></returns>
        public static object Get(object arg0)
        {
            return SExecute("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#put(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see langword="object"/></param>
        /// <returns><see langword="object"/></returns>
        public static object Put(object arg0, object arg1)
        {
            return SExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getString(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see langword="string"/></returns>
        public static string GetString(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<string>("getString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getString(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="string"/></returns>
        public static string GetString(object arg0)
        {
            return SExecute<string>("getString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getBorder(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border GetBorder(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<Javax.Swing.Border.Border>("getBorder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getBorder(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border GetBorder(object arg0)
        {
            return SExecute<Javax.Swing.Border.Border>("getBorder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getIcon(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public static Javax.Swing.Icon GetIcon(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<Javax.Swing.Icon>("getIcon", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getIcon(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public static Javax.Swing.Icon GetIcon(object arg0)
        {
            return SExecute<Javax.Swing.Icon>("getIcon", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#createLookAndFeel(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see cref="Javax.Swing.LookAndFeel"/></returns>
        /// <exception cref="Javax.Swing.UnsupportedLookAndFeelException"/>
        public static Javax.Swing.LookAndFeel CreateLookAndFeel(string arg0)
        {
            return SExecute<Javax.Swing.LookAndFeel>("createLookAndFeel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getUI(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <returns><see cref="Javax.Swing.Plaf.ComponentUI"/></returns>
        public static Javax.Swing.Plaf.ComponentUI GetUI(Javax.Swing.JComponent arg0)
        {
            return SExecute<Javax.Swing.Plaf.ComponentUI>("getUI", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#addAuxiliaryLookAndFeel(javax.swing.LookAndFeel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.LookAndFeel"/></param>
        public static void AddAuxiliaryLookAndFeel(Javax.Swing.LookAndFeel arg0)
        {
            SExecute("addAuxiliaryLookAndFeel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public static void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            SExecute("addPropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#installLookAndFeel(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see langword="string"/></param>
        public static void InstallLookAndFeel(string arg0, string arg1)
        {
            SExecute("installLookAndFeel", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#installLookAndFeel(javax.swing.UIManager$LookAndFeelInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.UIManager.LookAndFeelInfo"/></param>
        public static void InstallLookAndFeel(Javax.Swing.UIManager.LookAndFeelInfo arg0)
        {
            SExecute("installLookAndFeel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public static void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            SExecute("removePropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#setLookAndFeel(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Java.Lang.InstantiationException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        /// <exception cref="Javax.Swing.UnsupportedLookAndFeelException"/>
        public static void SetLookAndFeel(string arg0)
        {
            SExecute("setLookAndFeel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#setLookAndFeel(javax.swing.LookAndFeel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.LookAndFeel"/></param>
        /// <exception cref="Javax.Swing.UnsupportedLookAndFeelException"/>
        public static void SetLookAndFeel(Javax.Swing.LookAndFeel arg0)
        {
            SExecute("setLookAndFeel", arg0);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region LookAndFeelInfo
        public partial class LookAndFeelInfo
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.LookAndFeelInfo.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see langword="string"/></param>
            /// <param name="arg1"><see langword="string"/></param>
            public LookAndFeelInfo(string arg0, string arg1)
                : base(arg0, arg1)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.LookAndFeelInfo.html#getName()"/> 
            /// </summary>
            public string Name
            {
                get { return IExecute<string>("getName"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.LookAndFeelInfo.html#getClassName()"/>
            /// </summary>
            
            /// <returns><see langword="string"/></returns>
            public string GetClassName()
            {
                return IExecute<string>("getClassName");
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