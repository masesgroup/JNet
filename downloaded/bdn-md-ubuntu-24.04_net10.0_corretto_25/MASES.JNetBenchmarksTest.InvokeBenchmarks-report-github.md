```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 274.8 ns | 4.13 ns | 3.86 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 270.8 ns | 2.19 ns | 2.05 ns |  0.99 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 526.3 ns | 4.08 ns | 3.61 ns |  1.92 |    0.03 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 275.0 ns | 3.33 ns | 3.12 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 533.6 ns | 5.95 ns | 5.56 ns |  1.94 |    0.03 | 0.0181 |     312 B |          NA |
