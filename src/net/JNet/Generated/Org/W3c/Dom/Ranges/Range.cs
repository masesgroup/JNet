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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Ranges
{
    #region Range
    public partial class Range
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#END_TO_END"/>
        /// </summary>
        public static short END_TO_END => Clazz.GetField<short>("END_TO_END");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#END_TO_START"/>
        /// </summary>
        public static short END_TO_START => Clazz.GetField<short>("END_TO_START");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#START_TO_END"/>
        /// </summary>
        public static short START_TO_END => Clazz.GetField<short>("START_TO_END");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#START_TO_START"/>
        /// </summary>
        public static short START_TO_START => Clazz.GetField<short>("START_TO_START");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getCollapsed()"/> 
        /// </summary>
        public bool Collapsed
        {
            get { return IExecute<bool>("getCollapsed"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getCommonAncestorContainer()"/> 
        /// </summary>
        public Org.W3c.Dom.Node CommonAncestorContainer
        {
            get { return IExecute<Org.W3c.Dom.Node>("getCommonAncestorContainer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getEndContainer()"/> 
        /// </summary>
        public Org.W3c.Dom.Node EndContainer
        {
            get { return IExecute<Org.W3c.Dom.Node>("getEndContainer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getEndOffset()"/> 
        /// </summary>
        public int EndOffset
        {
            get { return IExecute<int>("getEndOffset"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getStartContainer()"/> 
        /// </summary>
        public Org.W3c.Dom.Node StartContainer
        {
            get { return IExecute<Org.W3c.Dom.Node>("getStartContainer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getStartOffset()"/> 
        /// </summary>
        public int StartOffset
        {
            get { return IExecute<int>("getStartOffset"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#cloneContents()"/>
        /// </summary>
        
        /// <returns><see cref="Org.W3c.Dom.DocumentFragment"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.DocumentFragment CloneContents()
        {
            return IExecute<Org.W3c.Dom.DocumentFragment>("cloneContents");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#extractContents()"/>
        /// </summary>
        
        /// <returns><see cref="Org.W3c.Dom.DocumentFragment"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.DocumentFragment ExtractContents()
        {
            return IExecute<Org.W3c.Dom.DocumentFragment>("extractContents");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#cloneRange()"/>
        /// </summary>
        
        /// <returns><see cref="Org.W3c.Dom.Ranges.Range"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Ranges.Range CloneRange()
        {
            return IExecute<Org.W3c.Dom.Ranges.Range>("cloneRange");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#compareBoundaryPoints(short,org.w3c.dom.ranges.Range)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Ranges.Range"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public short CompareBoundaryPoints(short arg0, Org.W3c.Dom.Ranges.Range arg1)
        {
            return IExecute<short>("compareBoundaryPoints", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#collapse(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void Collapse(bool arg0)
        {
            IExecute("collapse", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#deleteContents()"/>
        /// </summary>
        
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void DeleteContents()
        {
            IExecute("deleteContents");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#detach()"/>
        /// </summary>
        
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void Detach()
        {
            IExecute("detach");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#insertNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        public void InsertNode(Org.W3c.Dom.Node arg0)
        {
            IExecute("insertNode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#selectNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SelectNode(Org.W3c.Dom.Node arg0)
        {
            IExecute("selectNode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#selectNodeContents(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SelectNodeContents(Org.W3c.Dom.Node arg0)
        {
            IExecute("selectNodeContents", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setEnd(org.w3c.dom.Node,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetEnd(Org.W3c.Dom.Node arg0, int arg1)
        {
            IExecute("setEnd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setEndAfter(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetEndAfter(Org.W3c.Dom.Node arg0)
        {
            IExecute("setEndAfter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setEndBefore(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetEndBefore(Org.W3c.Dom.Node arg0)
        {
            IExecute("setEndBefore", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setStart(org.w3c.dom.Node,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetStart(Org.W3c.Dom.Node arg0, int arg1)
        {
            IExecute("setStart", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setStartAfter(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetStartAfter(Org.W3c.Dom.Node arg0)
        {
            IExecute("setStartAfter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setStartBefore(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetStartBefore(Org.W3c.Dom.Node arg0)
        {
            IExecute("setStartBefore", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#surroundContents(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        public void SurroundContents(Org.W3c.Dom.Node arg0)
        {
            IExecute("surroundContents", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}