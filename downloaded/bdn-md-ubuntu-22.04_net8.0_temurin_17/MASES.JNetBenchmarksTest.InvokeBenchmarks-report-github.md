```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.65GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 340.0 ns |  6.27 ns |  5.86 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 310.3 ns |  4.65 ns |  4.35 ns |  0.91 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 711.7 ns |  4.33 ns |  3.84 ns |  2.09 |    0.04 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 354.1 ns |  6.02 ns |  5.63 ns |  1.04 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 735.3 ns | 11.73 ns | 10.97 ns |  2.16 |    0.05 | 0.0200 |     344 B |          NA |
