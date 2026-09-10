```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.59GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 350.9 ns | 5.35 ns | 5.01 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 304.5 ns | 3.93 ns | 3.67 ns |  0.87 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 723.3 ns | 6.11 ns | 5.42 ns |  2.06 |    0.03 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 363.2 ns | 7.15 ns | 6.68 ns |  1.04 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 741.9 ns | 5.34 ns | 4.17 ns |  2.11 |    0.03 | 0.0200 |     344 B |          NA |
