```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 186.3 ns | 2.76 ns | 2.58 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 191.7 ns | 2.45 ns | 2.29 ns |  1.03 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 390.0 ns | 4.04 ns | 3.78 ns |  2.09 |    0.03 | 0.0033 |     312 B |          NA |
| InvokeInstanceEmpty            | 198.9 ns | 3.94 ns | 3.68 ns |  1.07 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 387.3 ns | 7.65 ns | 7.15 ns |  2.08 |    0.05 | 0.0033 |     312 B |          NA |
