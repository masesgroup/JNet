```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.78GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 389.9 ns |  6.17 ns |  5.77 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 314.6 ns |  3.12 ns |  2.92 ns |  0.81 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 706.4 ns | 10.19 ns |  9.04 ns |  1.81 |    0.03 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 372.2 ns |  6.92 ns |  6.47 ns |  0.95 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 722.8 ns | 13.56 ns | 12.69 ns |  1.85 |    0.04 | 0.0200 |     344 B |          NA |
