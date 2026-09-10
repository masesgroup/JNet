```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V45 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 139.0 ns | 1.32 ns | 1.10 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 139.6 ns | 2.70 ns | 2.77 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 273.6 ns | 3.80 ns | 3.37 ns |  1.97 |    0.03 | 0.0186 |     312 B |          NA |
| InvokeInstanceEmpty            | 136.7 ns | 1.34 ns | 1.12 ns |  0.98 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 294.6 ns | 4.75 ns | 3.97 ns |  2.12 |    0.03 | 0.0186 |     312 B |          NA |
