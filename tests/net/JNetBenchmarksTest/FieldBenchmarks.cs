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
public class FieldBenchmarks
{
    IJavaObject _instance;
    IJavaType _staticClass;

    [GlobalSetup]
    public void Setup()
    {
        JNetTestCore.ApplicationWriteEventOrExceptionOnCmdLine = true;
        JNetTestCore.ApplicationHeapSize = "4G";
        JNetTestCore.ApplicationInitialHeapSize = "256M";
        JNetTestCore.CreateGlobalInstance();

        _staticClass = JNetTestCore.GlobalInstance.JVM.GetClass("org.mases.jnet.TestPerformance");
        _instance = JNetTestCore.GlobalInstance.JVM.New("org.mases.jnet.TestPerformance") as IJavaObject;
    }

    [Benchmark(Baseline = true)]
    public void GetInstanceIntField() => _instance.GetField("counter");

    [Benchmark]
    public void SetInstanceIntField() => _instance.SetField("counter", 42);

    [Benchmark]
    public void GetInstanceStringField() => _instance.GetField("label");

    [Benchmark]
    public void SetInstanceStringField() => _instance.SetField("label", "hello");

    [Benchmark]
    public void GetStaticIntField() => _staticClass.GetField("staticCounter");

    [Benchmark]
    public void SetStaticIntField() => _staticClass.SetField("staticCounter", 42);

    [Benchmark]
    public void GetStaticStringField() => _staticClass.GetField("staticLabel");

    [Benchmark]
    public void SetStaticStringField() => _staticClass.SetField("staticLabel", "hello");

    [Benchmark]
    public int GetInstanceIntFieldGeneric() => _instance.GetField<int>("counter");
}