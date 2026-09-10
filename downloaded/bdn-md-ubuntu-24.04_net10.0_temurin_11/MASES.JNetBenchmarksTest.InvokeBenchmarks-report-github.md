```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 252.1 ns | 4.84 ns | 4.05 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 239.5 ns | 2.52 ns | 2.36 ns |  0.95 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 385.9 ns | 3.60 ns | 3.01 ns |  1.53 |    0.03 | 0.0033 |     312 B |          NA |
| InvokeInstanceEmpty            | 256.0 ns | 3.50 ns | 3.28 ns |  1.02 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 393.8 ns | 4.41 ns | 4.13 ns |  1.56 |    0.03 | 0.0033 |     312 B |          NA |
