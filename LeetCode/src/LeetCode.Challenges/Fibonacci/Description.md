# Fibonacci

The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, 
such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,

`F(0) = 0, F(1) = 1`
`F(n) = F(n - 1) + F(n - 2), for n > 1.`

Given `n`, calculate `F(n)`.

## Examples

### Example 1:

Input: `n = 2`
Output: `1`
Explanation: `F(2) = F(1) + F(0) = 1 + 0 = 1`.

### Example 2:

Input: `n = 3`
Output: `2`
Explanation: `F(3) = F(2) + F(1) = 1 + 1 = 2`.

### Example 3:

Input: `n = 4`
Output: `3`
Explanation: `F(4) = F(3) + F(2) = 2 + 1 = 3`.

## Solutions

### V1:

Time Complexity:

- The algorithm uses memoization to avoid redundant calculations of Fibonacci numbers.
- Each Fibonacci number is computed only once and stored in the cache.
- The time complexity depends on the number of Fibonacci numbers computed, which is proportional to the input `n`.
- Since each Fibonacci number is computed once, the time complexity is linear in terms of `n`.
- Therefore, the time complexity of the algorithm is O(n).

Memory Complexity (Space Complexity):

- The algorithm uses memoization to store previously computed Fibonacci numbers.
- It creates a dictionary `cache` to store these values, which grows as Fibonacci numbers are computed.
- The space required to store the dictionary grows with the input `n`, but it does not grow proportionally to `n`. Instead, it grows proportionally to the number of unique Fibonacci numbers computed.
- In the worst case, the dictionary `cache` stores all Fibonacci numbers from 0 up to `n`.
- Therefore, the space complexity of the algorithm is O(n) due to the space required for the `cache`.

### V2:

To achieve a space complexity of O(1), we need to eliminate the dependency on the size of the input `n` for the memory usage.  
This means we cannot use any data structure that grows with the input size.

One approach to achieve O(1) space complexity is to use constant space by only keeping track of the last two Fibonacci numbers 
instead of storing all computed Fibonacci numbers.  
We can calculate the next Fibonacci number based on the last two computed numbers.

The modified algorithm:

- We initialize `prev1` and `prev2` to represent the first two Fibonacci numbers.
- We iterate from `i = 2` to `n`, calculating the next Fibonacci number `current` by adding `prev1` and `prev2`.
- After each iteration, we update `prev1` to be the value of `prev2`, and `prev2` to be the value of `current`.
- Finally, we return `prev2`, which holds the nth Fibonacci number.

This approach only requires constant space for storing `prev1`, `prev2`, and `current`, regardless of the input `n`.  
Therefore, the space complexity is O(1).
