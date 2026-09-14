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
using MASES.JCOBridge.C2JBridge;
using MASES.JCOBridge.C2JBridge.JVMInterop;
using MASES.JNetTest.Common;
using System;
using System.Collections.Generic;

namespace MASES.JNetBenchmarksTest;

[MemoryDiagnoser]
[BenchmarkCategory("BulkTransfer")]
public class ByteArrayTransferBenchmarks
{
    // Size steps match the ones already published in performance.md
    // (AsSpan latency table), so results here are directly comparable
    // to the existing documentation instead of introducing a new scale.
    // NOTE: 100 MB is heavy (large Java-side array + shared buffer +
    // any .NET-side copy); consider restricting the upper end to a
    // smaller subset for the fast PR-check job and reserving the full
    // sweep for the scheduled/full-matrix run.
    [ParamsSource(nameof(LengthValues))]
    public int Length;

    public static IEnumerable<int> LengthValues =>
        Environment.GetEnvironmentVariable("BDN_FULL_SWEEP") == "1"
            ? new[] { 10, 100, 1_024, 10_240, 102_400, 1_048_576, 10_485_760, 104_857_600 }
            : new[] { 1_024, 1_048_576, 104_857_600 }; // representative: small / medium / large


    [Params(false, true)]
    public bool ForceRawMemory;

    [Params(false, true)]
    public bool UseCriticalMethods;

    IJavaObject _jClass;
    byte[] _expected;

    [GlobalSetup]
    public void Setup()
    {
        JNetTestCore.ApplicationWriteEventOrExceptionOnCmdLine = true;
        JNetTestCore.ApplicationHeapSize = "4G";
        JNetTestCore.ApplicationInitialHeapSize = "256M";
        JNetTestCore.CreateGlobalInstance();

        var management = JNetTestCore.GlobalInstance.Management;
        management.EnableCriticalMethods = UseCriticalMethods;
        management.EnableCriticalMethodsOnGetThreshold = UseCriticalMethods ? 0 : management.EnableCriticalMethodsOnGetThreshold;
        management.EnableCriticalMethodsOnSetThreshold = UseCriticalMethods ? 0 : management.EnableCriticalMethodsOnSetThreshold;

        _expected = new byte[Length];
        for (int i = 0; i < Length; i++)
        {
            _expected[i] = (byte)(i % sbyte.MaxValue); // signed in JVM
        }

        _jClass = JNetTestCore.GlobalInstance.JVM.New("org.mases.jnet.TestArrayAndByteBuffer", Length) as IJavaObject;
    }

    [GlobalCleanup]
    public void Cleanup()
    {
        _jClass?.Dispose();
    }

    [Benchmark(Baseline = true)]
    public void InvokeByteArrayDirect()
    {
        var res = _jClass.Invoke<byte[]>("getArray");
        if (!res.SequenceEqual(_expected)) throw new System.Exception("Mismatch in InvokeByteArrayDirect.");
    }

    [Benchmark]
    public void GetArrayViaStreamChunked()
    {
        using var res = _jClass.Invoke("getArray") is IJavaArray array ? array : throw new System.InvalidOperationException("getArray did not return an IJavaArray.");
        using JCOBridgeStream<byte> stream = res.ToStream<byte>(forceRawMemory: ForceRawMemory);
        if (!stream.AreEqualChunked(_expected)) throw new System.Exception("Mismatch in GetArrayViaStreamChunked.");
    }

    [Benchmark]
    public void GetArrayViaStreamSpan()
    {
        using var res = _jClass.Invoke("getArray") is IJavaArray array ? array : throw new System.InvalidOperationException("getArray did not return an IJavaArray.");
        using JCOBridgeStream<byte> stream = res.ToStream<byte>(forceRawMemory: ForceRawMemory);
        if (!stream.AsSpan().SequenceEqual(_expected)) throw new System.Exception("Mismatch in GetArrayViaStreamSpan.");
    }
}