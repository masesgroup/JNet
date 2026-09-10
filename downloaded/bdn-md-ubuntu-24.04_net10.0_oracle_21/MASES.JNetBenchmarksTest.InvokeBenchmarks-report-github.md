```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 245.8 ns | 1.63 ns | 1.36 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 247.1 ns | 3.28 ns | 3.07 ns |  1.01 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 470.9 ns | 5.38 ns | 4.77 ns |  1.92 |    0.02 | 0.0186 |     312 B |          NA |
| InvokeInstanceEmpty            | 246.0 ns | 2.03 ns | 1.80 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 468.9 ns | 3.07 ns | 2.87 ns |  1.91 |    0.02 | 0.0186 |     312 B |          NA |
