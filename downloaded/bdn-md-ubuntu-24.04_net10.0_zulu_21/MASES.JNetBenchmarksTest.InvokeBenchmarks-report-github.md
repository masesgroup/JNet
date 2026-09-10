```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 242.6 ns | 2.84 ns | 2.65 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 243.5 ns | 2.65 ns | 2.48 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 485.0 ns | 4.27 ns | 4.00 ns |  2.00 |    0.03 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 248.2 ns | 1.88 ns | 1.76 ns |  1.02 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 477.4 ns | 4.26 ns | 3.78 ns |  1.97 |    0.03 | 0.0186 |     312 B |          NA |
