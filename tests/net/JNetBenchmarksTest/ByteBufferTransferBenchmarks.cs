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
using Java.Nio;
using MASES.JCOBridge.C2JBridge;
using MASES.JCOBridge.C2JBridge.JVMInterop;
using MASES.JNetTest.Common;
using System;

namespace MASES.JNetBenchmarksTest;

[MemoryDiagnoser]
public class ByteBufferTransferBenchmarks
{
    [Params(1_000, 1_000_000)]
    public int Length;

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
            _expected[i] = (byte)(i % sbyte.MaxValue);
        }

        _jClass = JNetTestCore.GlobalInstance.JVM.New("org.mases.jnet.TestArrayAndByteBuffer", Length) as IJavaObject;
    }

    [GlobalCleanup]
    public void Cleanup()
    {
        _jClass?.Dispose();
    }

    [Benchmark(Baseline = true)]
    public void GetByteBufferToArray()
    {
        using var res = _jClass.Invoke<ByteBuffer>("getByteBuffer");
        var array = res.ToArray();
        if (array.Length != Length || !array.SequenceEqual(_expected)) throw new System.Exception("Mismatch in GetByteBufferToArray.");
    }

    [Benchmark]
    public void GetByteBufferStreamNaive()
    {
        using var res = _jClass.Invoke<ByteBuffer>("getByteBuffer");
        using var stream = res.ToStream();
        if (!stream.AreEqualNaive(_expected)) throw new System.Exception("Mismatch in GetByteBufferStreamNaive.");
    }

    [Benchmark]
    public void GetByteBufferStreamChunked()
    {
        using var res = _jClass.Invoke<ByteBuffer>("getByteBuffer");
        using var stream = res.ToStream();
        if (!stream.AreEqualChunked(_expected)) throw new System.Exception("Mismatch in GetByteBufferStreamChunked.");
    }

    [Benchmark]
    public void GetByteBufferDirectSpan()
    {
        using var res = _jClass.Invoke<ByteBuffer>("getByteBuffer");
        JCOBridgeDirectBuffer<byte> db = res.ToDirectBuffer(false);
        var span = db.AsSpan();
        if (span.Length != Length || !span.SequenceEqual(_expected)) throw new System.Exception("Mismatch in GetByteBufferDirectSpan.");
    }
}