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
    #region Menu
    public partial class Menu
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#%3Cinit%3E(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Menu(string arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Menu(string arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Menu"/> to <see cref="Java.Awt.MenuContainer"/>
        /// </summary>
        public static implicit operator Java.Awt.MenuContainer(Java.Awt.Menu t) => t.Cast<Java.Awt.MenuContainer>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Menu"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Java.Awt.Menu t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#getItemCount()"/> 
        /// </summary>
        public int ItemCount
        {
            get { return IExecute<int>("getItemCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#isTearOff()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsTearOff()
        {
            return IExecute<bool>("isTearOff");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#add(java.awt.MenuItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.MenuItem"/></param>
        /// <returns><see cref="Java.Awt.MenuItem"/></returns>
        public Java.Awt.MenuItem Add(Java.Awt.MenuItem arg0)
        {
            return IExecute<Java.Awt.MenuItem>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#getItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.MenuItem"/></returns>
        public Java.Awt.MenuItem GetItem(int arg0)
        {
            return IExecute<Java.Awt.MenuItem>("getItem", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#add(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void Add(string arg0)
        {
            IExecute("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#addSeparator()"/>
        /// </summary>
        public void AddSeparator()
        {
            IExecute("addSeparator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#insert(java.awt.MenuItem,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.MenuItem"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Insert(Java.Awt.MenuItem arg0, int arg1)
        {
            IExecute("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#insert(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Insert(string arg0, int arg1)
        {
            IExecute("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#insertSeparator(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void InsertSeparator(int arg0)
        {
            IExecute("insertSeparator", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Remove(int arg0)
        {
            IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#remove(java.awt.MenuComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.MenuComponent"/></param>
        public void Remove(Java.Awt.MenuComponent arg0)
        {
            IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#removeAll()"/>
        /// </summary>
        public void RemoveAll()
        {
            IExecute("removeAll");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}