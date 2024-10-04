using BenchmarkDotNet.Running;
using LeetCode.Challenges.Benchmark;

var summary = BenchmarkRunner.Run<TribonacciBenchmark>();
