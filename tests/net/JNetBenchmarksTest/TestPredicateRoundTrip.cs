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

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using MASES.JCOBridge.C2JBridge.JVMInterop;
using MASES.JNetTest.Common;
using Org.Mases.JNet;

namespace MASES.JNetBenchmarksTest;

[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.Net80)]
[SimpleJob(RuntimeMoniker.Net10_0)]
public class PredicateRoundTripBenchmarks
{
    [Params(false, true)]
    public bool ByIndex;

    [Params(false, true)]
    public bool ContinueFirstCheck;

    [Params(false, true)]
    public bool ContinueSecondCheck;

    Predicate<object> _predicate;
    IJavaObject _jClass;
    string _method;

    [GlobalSetup]
    public void Setup()
    {
        JNetTestCore.ApplicationWriteEventOrExceptionOnCmdLine = true;
        JNetTestCore.ApplicationHeapSize = "4G";
        JNetTestCore.ApplicationInitialHeapSize = "256M";
        JNetTestCore.CreateGlobalInstance();

        _method = ByIndex ? "executePredicateIndex" : "executePredicate";

        _predicate = new Predicate<object>(ContinueFirstCheck, ContinueSecondCheck)
        {
            OnTest = (o) => true
        };

        _jClass = JNetTestCore.GlobalInstance.JVM.New("org.mases.jnet.TestPerformance", _predicate) as IJavaObject;
    }

    [GlobalCleanup]
    public void Cleanup()
    {
        _predicate?.Dispose();
    }

    // Round-trip: una call .NET->Java->.NET per iterazione BDN.
    // Corrisponde a TestPredicateRoundTrip nel Program.cs originale.
    [Benchmark]
    public void PredicateRoundTrip()
    {
        _jClass.InvokeWithSignature(_method, "()Z");
    }
}