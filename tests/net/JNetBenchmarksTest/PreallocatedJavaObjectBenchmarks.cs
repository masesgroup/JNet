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
using MASES.JCOBridge.C2JBridge.JVMInterop;
using MASES.JNetTest.Common;

namespace MASES.JNetBenchmarksTest;

[MemoryDiagnoser]
[BenchmarkCategory("Core")]
public class PreallocatedJavaObjectBenchmarks
{
    [Params(10, 1_000)]
    public int Length;

    IJavaObject _instance;

    Java.Lang.String[] _preallocatedStringArray;
    Java.Lang.String _preallocatedSingleString;

    [GlobalSetup]
    public void Setup()
    {
        JNetTestCore.ApplicationWriteEventOrExceptionOnCmdLine = true;
        JNetTestCore.ApplicationHeapSize = "4G";
        JNetTestCore.ApplicationInitialHeapSize = "256M";
        JNetTestCore.CreateGlobalInstance();

        _instance = JNetTestCore.GlobalInstance.JVM.New("org.mases.jnet.TestPerformance") as IJavaObject;

        _preallocatedStringArray = new Java.Lang.String[Length];
        for (int i = 0; i < Length; i++)
        {
            _preallocatedStringArray[i] = new Java.Lang.String("s" + i);
        }

        _preallocatedSingleString = new Java.Lang.String("hello");
    }

    [GlobalCleanup]
    public void Cleanup()
    {
        foreach (var s in _preallocatedStringArray) s?.Dispose();
        _preallocatedSingleString?.Dispose();
        _instance?.Dispose();
    }

    [Benchmark(Baseline = true)]
    public void InvokeStringArrayPreallocated() => _instance.Invoke("executeStringArrayMethod", (object)_preallocatedStringArray);

    [Benchmark]
    public void InvokeSingleStringPreallocated() => _instance.Invoke("executeStringMethod", _preallocatedSingleString);
}
