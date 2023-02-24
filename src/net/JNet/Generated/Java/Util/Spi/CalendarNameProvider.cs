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

namespace Java.Util.Spi
{
    #region CalendarNameProvider
    public partial class CalendarNameProvider
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/spi/CalendarNameProvider.html#getDisplayName(java.lang.String,int,int,int,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <param name="arg3"><see langword="int"/></param>
        /// <param name="arg4"><see cref="Java.Util.Locale"/></param>
        /// <returns><see langword="string"/></returns>
        public string GetDisplayName(string arg0, int arg1, int arg2, int arg3, Java.Util.Locale arg4)
        {
            return IExecute<string>("getDisplayName", arg0, arg1, arg2, arg3, arg4);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}