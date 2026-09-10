```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.63GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 363.3 ns |  5.05 ns |  4.72 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 317.9 ns |  5.53 ns |  5.17 ns |  0.88 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 731.3 ns | 10.02 ns |  9.37 ns |  2.01 |    0.04 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 359.8 ns |  7.21 ns |  7.08 ns |  0.99 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 747.7 ns | 14.23 ns | 13.31 ns |  2.06 |    0.04 | 0.0200 |     344 B |          NA |
