```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 3.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 263.1 ns | 5.13 ns | 4.80 ns |  1.00 |    0.03 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 238.2 ns | 3.62 ns | 3.20 ns |  0.91 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 508.8 ns | 3.91 ns | 3.05 ns |  1.93 |    0.04 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 265.8 ns | 3.58 ns | 3.35 ns |  1.01 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 505.4 ns | 5.60 ns | 5.24 ns |  1.92 |    0.04 | 0.0200 |     344 B |          NA |
