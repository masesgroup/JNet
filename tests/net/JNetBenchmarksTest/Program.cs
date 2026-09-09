/*
*  Copyright (c) 2022-2026 MASES s.r.l.
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

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using MASES.JCOBridge.C2JBridge;
using System;

namespace Org.Mases.JNet
{
    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Predicate.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public abstract class Predicate : JVMBridgeListener
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;

        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.Predicate";
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Predicate.html"/>. Extends <see cref="Predicate"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    public class Predicate<TObject> : Predicate
    {
        readonly bool _test1;
        readonly bool _test2;
        /// <summary>
        /// The <see cref="Func{TObject, Boolean}"/> to be executed
        /// </summary>
        public virtual Func<TObject, bool> OnTest { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="Predicate{TObject}"/>
        /// </summary>
        public Predicate(bool test1, bool test2) : base()
        {
            if (InitHandlers)
            {
                AddEventHandler("test", new EventHandler<CLRListenerEventArgs<CLREventData<TObject>>>(TestEventHandler)); OnTest = Test;
            }
            _test1 = test1;
            _test2 = test2;
        }

        protected override bool ListenerShallManageEvent(int eventIndex)
        {
            return _test1;
        }

        protected override bool ListenerShallManageEvent(int eventIndex, object data)
        {
            return _test2;
        }

        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<TObject>> data)
        {
            var retVal = OnTest(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the Predicate action in the CLR
        /// </summary>
        /// <param name="obj">The Predicate object</param>
        /// <returns>The test evaluation</returns>
        public virtual bool Test(TObject obj) { return false; }
    }
}

namespace MASES.JNetBenchmarksTest
{
    class FastPrJobConfig : ManualConfig
    {
        public FastPrJobConfig()
        {
            AddJob(Job.Default.WithWarmupCount(1).WithIterationCount(3));
            AddDiagnoser(MemoryDiagnoser.Default);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var config = DefaultConfig.Instance.AddDiagnoser(MemoryDiagnoser.Default);
            config = Environment.GetEnvironmentVariable("BDN_FAST") != null ? new FastPrJobConfig() : config;
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, config);
        }
    }
}
