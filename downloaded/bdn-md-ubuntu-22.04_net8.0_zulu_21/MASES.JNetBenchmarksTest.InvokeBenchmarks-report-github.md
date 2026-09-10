```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.80GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 331.8 ns |  6.49 ns |  6.67 ns |  1.00 |    0.03 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 313.1 ns |  5.87 ns |  5.49 ns |  0.94 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 689.9 ns | 10.77 ns | 10.08 ns |  2.08 |    0.05 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 351.3 ns |  6.88 ns |  8.95 ns |  1.06 |    0.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 721.9 ns |  8.62 ns |  8.07 ns |  2.18 |    0.05 | 0.0200 |     344 B |          NA |
