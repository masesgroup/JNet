```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 253.6 ns | 3.01 ns | 2.67 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 246.1 ns | 3.40 ns | 3.18 ns |  0.97 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 520.4 ns | 5.18 ns | 4.59 ns |  2.05 |    0.03 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 288.9 ns | 4.11 ns | 3.64 ns |  1.14 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 519.6 ns | 5.81 ns | 5.44 ns |  2.05 |    0.03 | 0.0181 |     312 B |          NA |
