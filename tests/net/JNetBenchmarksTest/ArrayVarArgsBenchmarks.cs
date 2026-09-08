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

namespace MASES.JNetBenchmarksTest;

[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.Net80)]
[SimpleJob(RuntimeMoniker.Net10_0)]
public class ArrayVarArgsBenchmarks
{
    [Params(10, 1000)]
    public int Length;

    IJavaObject _instance;
    int[] _intArray;
    string[] _stringArray;
    object[] _boxedIntElements;

    [GlobalSetup]
    public void Setup()
    {
        JNetTestCore.ApplicationWriteEventOrExceptionOnCmdLine = true;
        JNetTestCore.ApplicationHeapSize = "4G";
        JNetTestCore.ApplicationInitialHeapSize = "256M";
        JNetTestCore.CreateGlobalInstance();

        _instance = JNetTestCore.GlobalInstance.JVM.New("org.mases.jnet.TestPerformance") as IJavaObject;

        _intArray = new int[Length];
        _stringArray = new string[Length];
        for (int i = 0; i < Length; i++) _stringArray[i] = "s" + i;

        _boxedIntElements = new object[Length];
        for (int i = 0; i < Length; i++) _boxedIntElements[i] = i;
    }

    [Benchmark(Baseline = true)]
    public void InvokeIntParam() => _instance.Invoke("executeIntMethod", 42);

    [Benchmark]
    public void InvokeStringArrayFixed() => _instance.Invoke("executeStringArrayMethod", _stringArray);

    [Benchmark]
    public void InvokeIntArrayFixed() => _instance.Invoke("executeIntArrayMethod", _intArray);

    [Benchmark]
    public void InvokeVarArgsWholeArray() => _instance.Invoke("executeVarArgsMethod", _intArray);

    [Benchmark]
    public void InvokeVarArgsSpreadElements() => _instance.Invoke("executeVarArgsObjectMethod", _boxedIntElements);
}