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

namespace Javax.Accessibility
{
    #region AccessibleTableModelChange
    public partial class AccessibleTableModelChange
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#DELETE"/>
        /// </summary>
        public static int DELETE => LocalClazz.GetField<int>("DELETE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#INSERT"/>
        /// </summary>
        public static int INSERT => LocalClazz.GetField<int>("INSERT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#UPDATE"/>
        /// </summary>
        public static int UPDATE => LocalClazz.GetField<int>("UPDATE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getFirstColumn()"/> 
        /// </summary>
        public int FirstColumn
        {
            get { return IExecute<int>("getFirstColumn"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getFirstRow()"/> 
        /// </summary>
        public int FirstRow
        {
            get { return IExecute<int>("getFirstRow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getLastColumn()"/> 
        /// </summary>
        public int LastColumn
        {
            get { return IExecute<int>("getLastColumn"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getLastRow()"/> 
        /// </summary>
        public int LastRow
        {
            get { return IExecute<int>("getLastRow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecute<int>("getType"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}