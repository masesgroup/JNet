```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Intel Xeon 6973P-C 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 207.7 ns | 1.94 ns | 1.72 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 194.8 ns | 1.89 ns | 1.58 ns |  0.94 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 346.4 ns | 5.37 ns | 4.19 ns |  1.67 |    0.02 | 0.0038 |     344 B |          NA |
| InvokeInstanceEmpty            | 218.5 ns | 1.36 ns | 1.07 ns |  1.05 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 358.3 ns | 6.36 ns | 9.32 ns |  1.73 |    0.05 | 0.0038 |     344 B |          NA |
