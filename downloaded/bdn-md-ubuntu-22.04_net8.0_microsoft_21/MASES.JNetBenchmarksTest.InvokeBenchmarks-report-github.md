```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 3.13GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 350.4 ns |  3.86 ns |  3.61 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 333.2 ns |  4.89 ns |  4.57 ns |  0.95 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 731.0 ns | 10.98 ns | 10.27 ns |  2.09 |    0.04 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 367.6 ns |  5.98 ns |  5.59 ns |  1.05 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 738.8 ns |  7.89 ns |  6.99 ns |  2.11 |    0.03 | 0.0200 |     344 B |          NA |
