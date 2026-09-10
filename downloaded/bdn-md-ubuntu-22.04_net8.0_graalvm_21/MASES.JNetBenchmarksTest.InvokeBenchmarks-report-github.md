```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.63GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 343.8 ns |  6.55 ns |  6.13 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 314.4 ns |  5.35 ns |  5.00 ns |  0.91 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 710.4 ns | 14.09 ns | 13.18 ns |  2.07 |    0.05 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 369.8 ns |  7.18 ns |  7.06 ns |  1.08 |    0.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 699.6 ns | 11.00 ns | 10.29 ns |  2.04 |    0.05 | 0.0200 |     344 B |          NA |
