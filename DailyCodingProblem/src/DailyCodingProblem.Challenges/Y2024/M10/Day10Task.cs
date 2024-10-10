using System.Diagnostics;

namespace DailyCodingProblem.Challenges.Y2024.M10;

// This problem was asked by Facebook.
//
// Given three 32-bit integers `x`, `y`, and `b`.
// Return:
//  -- `x` if `b` is `1`
//  -- `y` if `b` is `0`
// Only mathematical or bit operations are allowed.
// You can assume `b` can only be `1` or `0`.
public static class Day10Task
{
    public static int GetXorY(int x, int y, int b)
    {
        Debug.WriteLine($"x: {Convert.ToString(x, 2)}");
        Debug.WriteLine($"y: {Convert.ToString(y, 2)}");
        Debug.WriteLine($"b: {Convert.ToString(b, 2)}");

        // If `b` is 1, then mask will be `-1` (all bits set to `1`), otherwise `0`.
        // When `b` is `0`, the complement of `b` will be `1` (all bits set to `1` for `~b`).

        // This creates a mask of either `0` (if `b` is `0`) or `-1` (if `b` is `1`).
        var mask = b * -1;

        Debug.WriteLine(Convert.ToString(mask, 2));

        var xAndMask = x & mask;
        Debug.WriteLine(Convert.ToString(xAndMask, 2));

        var yAndNotMask = y & ~mask;
        Debug.WriteLine(Convert.ToString(yAndNotMask, 2));

        // (mask & x) keeps x when b = 1, and (mask & ~b & y) keeps y when b = 0.
        return (x & mask) | (y & ~mask);

        // Example 1:
        // x is 5: 0101
        // y is 7: 0111
        // b is 1
        // mask: (b * -1) is `-1` (int32: 11111111 11111111 11111111 11111111)
        // ~mask: ~(-1) (int32: 00000000 00000000 00000000 00000000)
        // 0101 & (-1) --> 0101
        // 0111 & (0) --> 0000
        // Result: x.

        // Example 2:
        // x is 5: 0101
        // y is 7: 0111
        // b is 0
        // mask: (b * -1) is `0`
        // ~mask: ~(0) (int32: 11111111 11111111 11111111 11111111)
        // 0101 & (0) --> 0000
        // 0111 & (1) --> 0111
        // Result: y.
    }
}
