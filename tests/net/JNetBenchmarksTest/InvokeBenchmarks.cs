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
public class InvokeBenchmarks
{
    IJavaType _staticClass;
    IJavaObject _instance;

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

    // Caso critico: nessun parametro, statico — il più sensibile
    // all'overhead fisso introdotto da push/pop.
    [Benchmark(Baseline = true)]
    public void InvokeStaticEmpty() => _staticClass.Invoke("executeStaticEmptyMethod");

    [Benchmark]
    public void InvokeStaticEmptyWithSignature() => _staticClass.InvokeWithSignature("executeStaticEmptyMethod", "()V");

    // Un parametro primitivo (bool) — non dovrebbe generare ref JNI.
    [Benchmark]
    public void InvokeStaticWithFeedback() => _staticClass.Invoke("executeStaticFeedbackMethod", true);

    // Stesso confronto lato istanza.
    [Benchmark]
    public void InvokeInstanceEmpty() => _instance.Invoke("executeEmptyMethod");

    [Benchmark]
    public void InvokeInstanceWithFeedback() => _instance.Invoke("executeFeedbackMethod", true);
}