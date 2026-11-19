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
using System;

namespace MASES.JNetBenchmarksTest;

[MemoryDiagnoser]
[BenchmarkCategory("Core")]
public class ArrayVarArgsBenchmarks
{
    // Standard steps stay small for the routine CI matrix. 100_000 is
    // added specifically to make the per-element JNI reference cost
    // (NewGlobalRef/DeleteGlobalRef vs local-ref-in-frame) dominate over
    // the fixed call overhead, so the effect becomes visible above the
    // measurement noise floor seen at Length=10/1000.
    [Params(10, 1_000, 100_000)]
    public int Length;

    IJavaObject _instance;
    int[] _intArray;
    string[] _stringArray;
    object[] _boxedIntElements;

    // Added fields in ArrayVarArgsBenchmarks
    int _segOffset, _segCount;
    ArraySegment<int> _intSegment;      // partial segment: what the JVM must receive
    ArraySegment<int> _intSegmentFull;  // segment covering the whole array
    int[] _intSlicedCopy;               // plain int[] with the same content as _intSegment
    int _expectedSegmentSum;

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

        // Added at the end of the existing Setup(), after _intArray has been created.
        // IMPORTANT: _intArray must contain distinct values (e.g. _intArray[i] = i),
        // otherwise the sum cannot tell a correct segment from a wrong one.
        _segOffset = Length / 4;
        _segCount = Length / 2;
        _intSegment = new ArraySegment<int>(_intArray, _segOffset, _segCount);
        _intSegmentFull = new ArraySegment<int>(_intArray);
        _intSlicedCopy = new int[_segCount];
        Array.Copy(_intArray, _segOffset, _intSlicedCopy, 0, _segCount);

        // unchecked: Java int addition wraps on overflow, so C# must wrap the same way
        int fullSum = 0, segSum = 0;
        unchecked
        {
            for (int i = 0; i < _intArray.Length; i++) fullSum += _intArray[i];
            for (int i = 0; i < _segCount; i++) segSum += _intArray[_segOffset + i];
        }
        _expectedSegmentSum = segSum;

        if (segSum == fullSum)
            throw new InvalidOperationException("Segment sum equals full-array sum: the check cannot distinguish them.");

        // Correctness check, done once here and not in the measured path.
        // executeIntArrayMethod returns the sum of the array the JVM actually received.
        if (_instance.Invoke<int>("executeIntArrayMethod", _intSegment) != segSum)
            throw new InvalidOperationException("JVM received an array different from the sent segment.");
        if (_instance.Invoke<int>("executeIntArrayMethod", _intSlicedCopy) != segSum)
            throw new InvalidOperationException("Sliced copy does not match the expected sum.");
        if (_instance.Invoke<int>("executeIntArrayMethod", _intSegmentFull) != fullSum)
            throw new InvalidOperationException("Full-array segment does not match the full-array sum.");
    }

    [Benchmark(Baseline = true)]
    public void InvokeIntParam() => _instance.Invoke("executeIntMethod", 42);

    [Benchmark]
    public void InvokeStringArrayFixed() => _instance.Invoke("executeStringArrayMethod", (object)_stringArray);

    [Benchmark]
    public void InvokeIntArrayFixed() => _instance.Invoke("executeIntArrayMethod", _intArray);

    [Benchmark]
    public void InvokeVarArgsWholeArray() => _instance.Invoke("executeVarArgsMethod", _intArray);

    [Benchmark]
    public void InvokeVarArgsSpreadElements() => _instance.Invoke("executeVarArgsObjectMethod", _boxedIntElements);

    // New benchmarks
    [Benchmark]
    public void InvokeIntArrayFixedSegment() => _instance.Invoke("executeIntArrayMethod", _intSegment);

    [Benchmark]
    public void InvokeIntArrayFixedSlicedCopy() => _instance.Invoke("executeIntArrayMethod", _intSlicedCopy);

    [Benchmark]
    public void InvokeIntArrayFixedSegmentFull() => _instance.Invoke("executeIntArrayMethod", _intSegmentFull);
}