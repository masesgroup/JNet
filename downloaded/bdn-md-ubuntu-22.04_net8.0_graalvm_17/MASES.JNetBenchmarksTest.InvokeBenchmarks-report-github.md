```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 353.0 ns |  4.51 ns |  4.00 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 320.6 ns |  5.57 ns |  5.21 ns |  0.91 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 717.2 ns | 12.21 ns | 11.43 ns |  2.03 |    0.04 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 372.9 ns |  5.98 ns |  5.60 ns |  1.06 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 720.7 ns |  9.92 ns |  8.79 ns |  2.04 |    0.03 | 0.0200 |     344 B |          NA |
