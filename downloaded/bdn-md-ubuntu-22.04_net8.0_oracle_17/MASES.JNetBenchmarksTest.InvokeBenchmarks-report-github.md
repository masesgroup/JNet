```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
INTEL XEON PLATINUM 8573C 3.50GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 266.7 ns | 3.77 ns | 3.53 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 238.4 ns | 2.48 ns | 2.20 ns |  0.89 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 528.7 ns | 2.95 ns | 2.62 ns |  1.98 |    0.03 | 0.0038 |     344 B |          NA |
| InvokeInstanceEmpty            | 257.6 ns | 2.62 ns | 2.32 ns |  0.97 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 529.8 ns | 4.31 ns | 4.03 ns |  1.99 |    0.03 | 0.0038 |     344 B |          NA |
