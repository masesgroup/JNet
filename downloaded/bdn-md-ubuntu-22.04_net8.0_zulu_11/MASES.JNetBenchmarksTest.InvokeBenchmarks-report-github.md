```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 3.68GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 307.1 ns | 5.78 ns | 5.40 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 276.0 ns | 4.87 ns | 4.55 ns |  0.90 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 522.5 ns | 2.90 ns | 2.57 ns |  1.70 |    0.03 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 319.6 ns | 5.33 ns | 4.98 ns |  1.04 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 520.7 ns | 9.18 ns | 8.59 ns |  1.70 |    0.04 | 0.0200 |     344 B |          NA |
