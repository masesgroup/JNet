```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.88GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 289.5 ns | 4.67 ns | 4.37 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 255.2 ns | 3.55 ns | 3.32 ns |  0.88 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 582.7 ns | 6.19 ns | 5.79 ns |  2.01 |    0.04 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 304.8 ns | 4.39 ns | 4.11 ns |  1.05 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 573.1 ns | 6.16 ns | 5.76 ns |  1.98 |    0.04 | 0.0200 |     344 B |          NA |
