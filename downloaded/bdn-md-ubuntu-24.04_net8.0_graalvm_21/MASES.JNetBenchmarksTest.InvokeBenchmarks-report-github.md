```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Intel Xeon 6973P-C 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 165.9 ns | 0.96 ns | 0.80 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 156.5 ns | 1.95 ns | 2.00 ns |  0.94 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 332.8 ns | 2.07 ns | 1.83 ns |  2.01 |    0.01 | 0.0038 |     344 B |          NA |
| InvokeInstanceEmpty            | 174.6 ns | 1.36 ns | 1.27 ns |  1.05 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 352.3 ns | 6.86 ns | 6.73 ns |  2.12 |    0.04 | 0.0038 |     344 B |          NA |
