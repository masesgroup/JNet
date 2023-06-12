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

using MASES.JCOBridge.C2JBridge;

namespace MASES.JNet.Specific
{
    /// <summary>
    /// Public interface to identify a class which is a Main-Class
    /// </summary>
    /// <remarks>Used from JNetReflector to mark a type to be identified as a Main-Class</remarks>
    public interface IJNetBridgeMain
    {
    }
    /// <summary>
    /// The class implementing <see cref="IJNetBridgeMain"/> usable to create runnable 
    /// </summary>
    /// <typeparam name="TClass"></typeparam>
    public abstract class JNetBridgeMain<TClass> : JVMBridgeBase<TClass>, IJNetBridgeMain
        where TClass : JNetBridgeMain<TClass>, new()
    {
        /// <summary>
        /// Expected method to execute the class
        /// </summary>
        /// <param name="args"><see cref="string"/>Main arguments</param>
        /// <remarks>Can be used to define a Main-Class</remarks>
#pragma warning disable CS0402 // 'JNetBridgeMain<TClass>.Main(string[])': warning disabled
        public static void Main(string[] args)
#pragma warning restore CS0402 // 'JNetBridgeMain<TClass>.Main(string[])': warning disabled
        {
            SExecute(BridgeClazz, "main", new object[] { args });
        }
    }
}
