using BenchmarkDotNet.Running;
using LeetCode.Challenges.Benchmark;
using LeetCode.Challenges.Benchmark.N_0046_Permutations;

var switcher = new BenchmarkSwitcher(
[
    typeof(PermutationsBenchmark),
    typeof(TribonacciBenchmark)
]);

switcher.Run(args);
