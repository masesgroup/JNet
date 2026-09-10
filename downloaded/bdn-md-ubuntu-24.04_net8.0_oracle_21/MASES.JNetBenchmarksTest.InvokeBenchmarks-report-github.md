```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 214.6 ns | 0.72 ns | 0.64 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 197.9 ns | 0.68 ns | 0.64 ns |  0.92 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 404.4 ns | 2.13 ns | 1.99 ns |  1.88 | 0.0205 |     344 B |          NA |
| InvokeInstanceEmpty            | 219.3 ns | 1.21 ns | 1.14 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 413.3 ns | 3.44 ns | 2.87 ns |  1.93 | 0.0205 |     344 B |          NA |
