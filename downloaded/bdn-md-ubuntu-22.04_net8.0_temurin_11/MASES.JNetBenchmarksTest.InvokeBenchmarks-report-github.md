```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.59GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 413.9 ns |  4.11 ns | 3.64 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 377.4 ns |  4.40 ns | 3.90 ns |  0.91 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 706.4 ns | 10.07 ns | 9.42 ns |  1.71 |    0.03 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 454.1 ns |  7.47 ns | 6.99 ns |  1.10 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 749.2 ns |  7.81 ns | 6.92 ns |  1.81 |    0.02 | 0.0200 |     344 B |          NA |
