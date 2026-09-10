```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 219.7 ns | 1.20 ns | 1.00 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 224.1 ns | 1.52 ns | 1.35 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 380.4 ns | 1.16 ns | 1.03 ns |  1.73 | 0.0186 |     312 B |          NA |
| InvokeInstanceEmpty            | 230.2 ns | 3.07 ns | 2.87 ns |  1.05 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 387.4 ns | 2.45 ns | 2.17 ns |  1.76 | 0.0186 |     312 B |          NA |
