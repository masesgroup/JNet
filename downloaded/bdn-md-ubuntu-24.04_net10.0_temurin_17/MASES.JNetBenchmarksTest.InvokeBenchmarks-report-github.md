```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 273.7 ns | 1.91 ns | 1.79 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 267.6 ns | 3.97 ns | 3.71 ns |  0.98 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 531.4 ns | 5.96 ns | 5.58 ns |  1.94 |    0.02 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 280.2 ns | 3.06 ns | 2.71 ns |  1.02 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 537.7 ns | 4.51 ns | 4.22 ns |  1.96 |    0.02 | 0.0181 |     312 B |          NA |
