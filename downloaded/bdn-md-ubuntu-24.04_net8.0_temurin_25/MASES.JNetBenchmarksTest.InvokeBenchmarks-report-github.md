```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 208.9 ns | 3.73 ns | 3.49 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 191.9 ns | 3.12 ns | 2.77 ns |  0.92 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 417.3 ns | 4.94 ns | 4.38 ns |  2.00 |    0.04 | 0.0038 |     344 B |          NA |
| InvokeInstanceEmpty            | 222.8 ns | 2.01 ns | 1.88 ns |  1.07 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 430.2 ns | 6.26 ns | 5.23 ns |  2.06 |    0.04 | 0.0038 |     344 B |          NA |
