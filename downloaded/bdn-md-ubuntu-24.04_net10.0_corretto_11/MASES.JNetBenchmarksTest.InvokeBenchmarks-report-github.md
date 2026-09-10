```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 326.1 ns | 6.30 ns | 5.58 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 340.3 ns | 5.86 ns | 5.48 ns |  1.04 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 548.7 ns | 5.51 ns | 4.88 ns |  1.68 |    0.03 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 355.0 ns | 4.68 ns | 4.38 ns |  1.09 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 556.7 ns | 6.14 ns | 5.75 ns |  1.71 |    0.03 | 0.0181 |     312 B |          NA |
