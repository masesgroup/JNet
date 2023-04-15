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

namespace Java.Awt
{
    public partial class Container
    {
        // can be extended with methods not reflected or not available in Java;

        /// <summary>
        /// Finalizer of <see cref="Container"/>
        /// </summary>
        ~Container()
        {
            Dispose();
        }

        IJCGraphicContainer _container = null;
        /// <summary>
        /// Creates the <see cref="HostedContainer"/> and returns <see cref="IJCGraphicContainer.GraphicObject"/>
        /// </summary>
        /// <param name="isWPF"><see langword="true"/> if the object will be inserted in a WPF layout, <see langword="false"/> if the object will be inserted in a Windows Forms layout</param>
        /// <param name="manager">The <see cref="JCWindowsManager"/> to use, <see langref="null"/> to use <see cref="JCWindowsManager.Default"/></param>
        /// <returns>The <see cref="object"/> in the <see cref="IJCGraphicContainer.GraphicObject"/> property</returns>
        public object CreateHostedContainer(bool isWPF, JCWindowsManager manager = null)
        {
            lock (this)
            {
                if (_container == null)
                {
                    _container = Management.GetJCGraphicContainer(Instance, isWPF);
                    _container.Initialize(manager != null ? manager : JCWindowsManager.Default);
                }
                return _container.GraphicObject;
            }
        }

        /// <summary>
        /// Returns the hostable <see cref="IJCGraphicContainer"/>
        /// </summary>
        public IJCGraphicContainer HostedContainer => _container;
        /// <summary>
        /// Dispose this resource
        /// </summary>
        public override void Dispose()
        {
            lock (this)
            {
                if (_container != null)
                {
                    Management.ReleaseJCGraphicContainer(_container);
                    _container = null;
                }
            }
            base.Dispose();
        }

        // TODO: complete the class
    }
}
