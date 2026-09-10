```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 335.3 ns | 2.08 ns | 1.94 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 304.6 ns | 2.16 ns | 1.81 ns |  0.91 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 546.5 ns | 3.19 ns | 2.98 ns |  1.63 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 362.4 ns | 2.97 ns | 2.77 ns |  1.08 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 548.3 ns | 3.06 ns | 2.72 ns |  1.64 | 0.0200 |     344 B |          NA |
