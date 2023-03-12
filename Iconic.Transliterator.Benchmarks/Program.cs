
using BenchmarkDotNet.Running;
using Iconic.Transliterator.Benchmarks;

var summary1 = BenchmarkRunner.Run<ConversionBenchmarks>();
var summary2 = BenchmarkRunner.Run<CapitalizeBenchmarks>();
