```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.61GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 346.0 ns |  5.90 ns | 5.51 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 321.3 ns |  5.03 ns | 4.70 ns |  0.93 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 702.3 ns |  7.05 ns | 5.89 ns |  2.03 |    0.04 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 340.5 ns |  6.74 ns | 6.31 ns |  0.98 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 697.6 ns | 10.28 ns | 9.61 ns |  2.02 |    0.04 | 0.0181 |     312 B |          NA |
