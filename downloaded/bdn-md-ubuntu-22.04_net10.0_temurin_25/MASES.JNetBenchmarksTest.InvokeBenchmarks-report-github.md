```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
INTEL XEON PLATINUM 8573C 3.04GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 264.8 ns | 3.24 ns | 3.03 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 266.4 ns | 1.78 ns | 1.67 ns |  1.01 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 541.5 ns | 6.24 ns | 5.83 ns |  2.04 |    0.03 | 0.0029 |     312 B |          NA |
| InvokeInstanceEmpty            | 283.4 ns | 1.36 ns | 1.21 ns |  1.07 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 552.3 ns | 4.20 ns | 3.93 ns |  2.09 |    0.03 | 0.0029 |     312 B |          NA |
