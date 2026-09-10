```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 286.5 ns | 3.85 ns | 3.60 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 264.8 ns | 2.69 ns | 2.51 ns |  0.92 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 560.8 ns | 6.41 ns | 5.99 ns |  1.96 |    0.03 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 311.9 ns | 3.85 ns | 3.60 ns |  1.09 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 591.7 ns | 5.28 ns | 4.68 ns |  2.07 |    0.03 | 0.0200 |     344 B |          NA |
