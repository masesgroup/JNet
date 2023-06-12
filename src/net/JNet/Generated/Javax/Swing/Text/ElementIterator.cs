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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region ElementIterator
    public partial class ElementIterator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/ElementIterator.html#%3Cinit%3E(javax.swing.text.Document)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Document"/></param>
        public ElementIterator(Javax.Swing.Text.Document arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/ElementIterator.html#%3Cinit%3E(javax.swing.text.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
        public ElementIterator(Javax.Swing.Text.Element arg0)
            : base(arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/ElementIterator.html#depth()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Depth()
        {
            return IExecute<int>("depth");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/ElementIterator.html#current()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.Text.Element"/></returns>
        public Javax.Swing.Text.Element Current()
        {
            return IExecute<Javax.Swing.Text.Element>("current");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/ElementIterator.html#first()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.Text.Element"/></returns>
        public Javax.Swing.Text.Element First()
        {
            return IExecute<Javax.Swing.Text.Element>("first");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/ElementIterator.html#next()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.Text.Element"/></returns>
        public Javax.Swing.Text.Element Next()
        {
            return IExecute<Javax.Swing.Text.Element>("next");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/ElementIterator.html#previous()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.Text.Element"/></returns>
        public Javax.Swing.Text.Element Previous()
        {
            return IExecute<Javax.Swing.Text.Element>("previous");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}