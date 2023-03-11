
using BenchmarkDotNet.Running;
using Iconic.Transliterator.Benchmarks;

var summary = BenchmarkRunner.Run<GreekToEnglishBenchmarks>();