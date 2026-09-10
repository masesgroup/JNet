```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.98GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 420.1 ns |  8.29 ns |  8.52 ns |  1.00 |    0.03 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 388.7 ns |  7.60 ns |  8.13 ns |  0.93 |    0.03 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 714.1 ns | 12.67 ns | 11.85 ns |  1.70 |    0.04 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 510.4 ns | 10.01 ns |  9.36 ns |  1.22 |    0.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 749.1 ns |  9.77 ns |  9.14 ns |  1.78 |    0.04 | 0.0200 |     344 B |          NA |
