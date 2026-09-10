```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
INTEL XEON PLATINUM 8573C 2.96GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 293.5 ns | 1.44 ns | 1.34 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 275.8 ns | 2.67 ns | 2.23 ns |  0.94 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 585.8 ns | 4.86 ns | 4.55 ns |  2.00 |    0.02 | 0.0038 |     344 B |          NA |
| InvokeInstanceEmpty            | 310.2 ns | 2.84 ns | 2.37 ns |  1.06 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 608.2 ns | 6.37 ns | 5.95 ns |  2.07 |    0.02 | 0.0038 |     344 B |          NA |
