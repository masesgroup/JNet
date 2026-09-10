```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 3.24GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 355.8 ns |  6.81 ns |  6.37 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 334.7 ns |  6.43 ns |  6.02 ns |  0.94 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 713.3 ns | 11.65 ns | 10.90 ns |  2.01 |    0.05 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 375.4 ns |  5.11 ns |  4.78 ns |  1.06 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 732.2 ns | 10.81 ns | 10.11 ns |  2.06 |    0.04 | 0.0200 |     344 B |          NA |
