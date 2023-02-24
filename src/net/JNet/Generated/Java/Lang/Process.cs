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

namespace Java.Lang
{
    #region Process
    public partial class Process
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#getErrorStream()"/> 
        /// </summary>
        public Java.Io.InputStream ErrorStream
        {
            get { return IExecute<Java.Io.InputStream>("getErrorStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#getInputStream()"/> 
        /// </summary>
        public Java.Io.InputStream InputStream
        {
            get { return IExecute<Java.Io.InputStream>("getInputStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#getOutputStream()"/> 
        /// </summary>
        public Java.Io.OutputStream OutputStream
        {
            get { return IExecute<Java.Io.OutputStream>("getOutputStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#exitValue()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int ExitValue()
        {
            return IExecute<int>("exitValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#waitFor()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public int WaitFor()
        {
            return IExecute<int>("waitFor");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#destroy()"/>
        /// </summary>
        public void Destroy()
        {
            IExecute("destroy");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#isAlive()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsAlive()
        {
            return IExecute<bool>("isAlive");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#supportsNormalTermination()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool SupportsNormalTermination()
        {
            return IExecute<bool>("supportsNormalTermination");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#destroyForcibly()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Lang.Process"/></returns>
        public Java.Lang.Process DestroyForcibly()
        {
            return IExecute<Java.Lang.Process>("destroyForcibly");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#toHandle()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Lang.ProcessHandle"/></returns>
        public Java.Lang.ProcessHandle ToHandle()
        {
            return IExecute<Java.Lang.ProcessHandle>("toHandle");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#info()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Lang.ProcessHandle.Info"/></returns>
        public Java.Lang.ProcessHandle.Info Info()
        {
            return IExecute<Java.Lang.ProcessHandle.Info>("info");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#pid()"/>
        /// </summary>
        
        /// <returns><see langword="long"/></returns>
        public long Pid()
        {
            return IExecute<long>("pid");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}