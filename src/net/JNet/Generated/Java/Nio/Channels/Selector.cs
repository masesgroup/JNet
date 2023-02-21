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

namespace Java.Nio.Channels
{
    #region Selector
    public partial class Selector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Io.Closeable(Java.Nio.Channels.Selector t) => t.Cast<Java.Io.Closeable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#open() throws java.io.IOException
        /// </summary>
        public static Java.Nio.Channels.Selector Open()
        {
            return SExecute<Java.Nio.Channels.Selector>("open");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#isOpen()
        /// </summary>
        public bool IsOpen()
        {
            return IExecute<bool>("isOpen");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#select() throws java.io.IOException
        /// </summary>
        public int Select()
        {
            return IExecute<int>("select");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#select(long) throws java.io.IOException
        /// </summary>
        public int Select(long arg0)
        {
            return IExecute<int>("select", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#selectNow() throws java.io.IOException
        /// </summary>
        public int SelectNow()
        {
            return IExecute<int>("selectNow");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#wakeup()
        /// </summary>
        public Java.Nio.Channels.Selector Wakeup()
        {
            return IExecute<Java.Nio.Channels.Selector>("wakeup");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#provider()
        /// </summary>
        public Java.Nio.Channels.Spi.SelectorProvider Provider()
        {
            return IExecute<Java.Nio.Channels.Spi.SelectorProvider>("provider");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#close() throws java.io.IOException
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}