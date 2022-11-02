/*
*  Copyright 2022 MASES s.r.l.
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

namespace MASES.JNet
{
    public abstract class JNetBase<TClass> : JVMBridgeBase<TClass>
        where TClass : IJVMBridgeBase, new()
    {
        /// <summary>
        /// Used to create instance of <see cref="IJVMBridgeDefinition.ClassName"/>
        /// </summary>
        /// <param name="args">The arguments of constructor</param>
        public JNetBase() : base() { }
        /// <summary>
        /// Used to create instance of <see cref="IJVMBridgeDefinition.ClassName"/>
        /// </summary>
        /// <param name="args">The arguments of constructor</param>
        public JNetBase(params object[] args) : base(args) { }
    }

    public abstract class JNetBase<TClass, TInterface> : JVMBridgeBase<TClass, TInterface>
        where TClass : TInterface, IJVMBridgeBase, new()
    {
        /// <summary>
        /// Used to create instance of <see cref="IJVMBridgeDefinition.ClassName"/>
        /// </summary>
        public JNetBase() : base() { }
        /// <summary>
        /// Used to create instance of <see cref="IJVMBridgeDefinition.ClassName"/>
        /// </summary>
        /// <param name="args">The arguments of constructor</param>
        public JNetBase(params object[] args) : base(args) { }
    }

    /// <summary>
    /// Generic class to launch a main method in a Java class
    /// </summary>
    public class GenericCommand : JCOBridge.C2JBridge.JVMBridgeMain<GenericCommand>
    {
        static object _classNameLock = new object();
        static string _className;

        /// <summary>
        /// Creates and launch the <see cref="GenericCommand"/> class based on <paramref name="className"/>
        /// </summary>
        /// <param name="className">The class to be instantiated having the main method</param>
        /// <param name="args">Arguments to send to main method</param>
        public static void CreateAndLaunch(string className, params object[] args)
        {
            lock (_classNameLock)
            {
                try
                {
                    _className = className;
                    var command = new GenericCommand();
                    command.Execute(args);
                }
                finally
                {
                    _className = null;
                }
            }
        }

        /// <remarks>
        /// Not use directly
        /// </remarks>
        public GenericCommand() : base(_className) { }
    }
}
