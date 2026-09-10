```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 237.2 ns | 2.11 ns | 1.98 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 241.4 ns | 1.60 ns | 1.50 ns |  1.02 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 373.1 ns | 2.67 ns | 2.50 ns |  1.57 |    0.02 | 0.0033 |     312 B |          NA |
| InvokeInstanceEmpty            | 241.5 ns | 2.53 ns | 2.37 ns |  1.02 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 379.1 ns | 1.99 ns | 1.86 ns |  1.60 |    0.02 | 0.0033 |     312 B |          NA |
