# LeetCode

This folder contains my solutions to challenges on LeetCode.  
It also includes a benchmarking setup to measure and compare the performance of different solutions.  
Currently, the following benchmarks are available:

- **PermutationsBenchmark**
- **TribonacciBenchmark**

---

### How to Run Benchmarks

1. Go to the benchmark project directory:

   ```bash
   cd LeetCode/tests/LeetCode.Challenges.Benchmark
   ```

2. Choose the target benchmark, execute the following command:

   ```bash
   dotnet run -c Release --filter "*<benchmark_name>*"
   ```

   Replace `<benchmark_name>` with one of the available benchmarks (**PermutationsBenchmark** or **TribonacciBenchmark**)  
   OR  
   to select all benchmarks, run the following command:

   ```bash
   dotnet run -c Release --filter "*"
   ```
