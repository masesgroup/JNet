```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 240.8 ns | 4.71 ns | 4.63 ns |  1.00 |    0.03 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 223.3 ns | 2.78 ns | 2.46 ns |  0.93 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 430.1 ns | 5.70 ns | 5.33 ns |  1.79 |    0.04 | 0.0033 |     312 B |          NA |
| InvokeInstanceEmpty            | 222.2 ns | 3.27 ns | 3.05 ns |  0.92 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 447.0 ns | 7.47 ns | 6.98 ns |  1.86 |    0.04 | 0.0033 |     312 B |          NA |
