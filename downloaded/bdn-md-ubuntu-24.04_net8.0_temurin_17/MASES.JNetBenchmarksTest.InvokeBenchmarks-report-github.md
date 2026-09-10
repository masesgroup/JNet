```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Intel Xeon 6973P-C 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 165.7 ns | 3.16 ns | 3.10 ns |  1.00 |    0.03 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 146.9 ns | 1.25 ns | 1.04 ns |  0.89 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 345.9 ns | 2.19 ns | 2.05 ns |  2.09 |    0.04 | 0.0038 |     344 B |          NA |
| InvokeInstanceEmpty            | 169.4 ns | 3.20 ns | 2.99 ns |  1.02 |    0.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 332.0 ns | 2.50 ns | 2.34 ns |  2.00 |    0.04 | 0.0038 |     344 B |          NA |
