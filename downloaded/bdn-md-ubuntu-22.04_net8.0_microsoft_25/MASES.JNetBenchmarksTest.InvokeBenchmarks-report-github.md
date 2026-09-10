```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
INTEL XEON PLATINUM 8573C 2.99GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 294.5 ns | 1.68 ns | 1.49 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 282.6 ns | 2.71 ns | 2.40 ns |  0.96 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 594.1 ns | 4.50 ns | 4.21 ns |  2.02 |    0.02 | 0.0038 |     344 B |          NA |
| InvokeInstanceEmpty            | 300.0 ns | 1.83 ns | 1.71 ns |  1.02 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 586.3 ns | 4.28 ns | 4.00 ns |  1.99 |    0.02 | 0.0038 |     344 B |          NA |
