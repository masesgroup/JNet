```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V45 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 138.5 ns | 1.33 ns | 1.18 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 136.5 ns | 1.14 ns | 1.07 ns |  0.99 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 252.4 ns | 4.22 ns | 3.74 ns |  1.82 |    0.03 | 0.0186 |     312 B |          NA |
| InvokeInstanceEmpty            | 136.8 ns | 1.36 ns | 1.06 ns |  0.99 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 282.1 ns | 3.62 ns | 3.21 ns |  2.04 |    0.03 | 0.0186 |     312 B |          NA |
