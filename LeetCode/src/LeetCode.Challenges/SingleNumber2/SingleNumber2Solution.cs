namespace LeetCode.Challenges.SingleNumber2;

// Time Complexity: O(n).
// Space Complexity: O(1).
//
// Explanation:
// The goal is to find the number that appears exactly once,
// while all other numbers appear three times.
// This approach uses bitwise operations to maintain the counts of bits
// and ensure that each bit is counted modulo 3.
//
// Key Concept:
// - Bitwise XOR (`^`):
//   Toggles the bits. Its properties: `x ^ x = 0` and `x ^ 0 = x`.
//   These properties help to track the occurrence of bits across the numbers.
// - Bitwise AND (`&`):
//   Compares two bits and results in `1` only when both bits are `1`.
//   This is used to mask bits based on conditions.
// - Bitwise NOT (`~`):
//   Inverts the bits. This is used to reset bits.
//
// The main idea:
// Iterating through the array:
// - it updates `ones` to store bits that have appeared once,
//   excluding the bits that have already appeared twice (`twos`).
// - it updates `twos` to store bits that have appeared twice,
//   excluding the bits that have appeared once (`ones`).
//
// Why it works:
// - The bits of numbers that appear 3 times will eventually be cleared from both `ones` and `twos`
//   because the modulo 3 effect will cause the bits to cancel out after appearing three times.
// - The bits of the number that appears once will remain in `ones`
//   because they will not be canceled by the modulo 3 operation.
public class SingleNumber2Solution
{
    public static int Get(int[] numbers)
    {
        // It holds the bits that have appeared exactly once so far.
        int ones = 0;

        // It holds the bits that have appeared exactly twice so far.
        int twos = 0;

        foreach (var num in numbers)
        {
            // Step 1: `ones ^ num`.
            // This XOR operation toggles the bits of `ones` based on the current `num`.
            // If the bit was `0`, it becomes `1`; if it was `1`, it becomes `0`.
            // This part helps in toggling the bits that represent the current `num`.
            // Step 2: `~twos`.
            // This ensures that any bit already tracked in `twos` (bits that have appeared two times)
            // is excluded from `ones`.
            // This is important because we must not keep bits in `ones` that have already appeared twice.
            ones = (ones ^ num) & ~twos;

            // Step 1: `twos ^ num`.
            // This toggles the bits of `twos` based on the current `num`.
            // Similarly to the XOR in `ones`, it helps in updating the bits based on the current number.
            // Step 2: `~ones`.
            // This ensures that any bit already tracked in `ones` (bits that have appeared one time)
            // is excluded from `twos`.
            // This is important because we must not keep bits in `twos`
            // that have already been counted as once-occurring bits.
            twos = (twos ^ num) & ~ones;
        }

        // After processing all numbers, the `ones` variable holds the bits of the number that appears exactly once.
        // This is because any bits that appeared three times will have been cleared from both `ones` and `twos`.
        return ones;
    }
}
