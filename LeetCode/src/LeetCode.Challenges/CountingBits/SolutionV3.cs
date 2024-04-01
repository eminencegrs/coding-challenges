namespace LeetCode.Challenges.CountingBits;

public class SolutionV3
{
    public int[] CountBits(int n)
    {
        var result = new int[n + 1];

        for (var item = 1; item <= n; item++)
        {
            // This part of the expression calculates the count of set bits for the number formed
            // by removing the least significant bit (LSB) of i.
            // We use the right shift operator >> to shift the bits of i to the right by one position, effectively removing the LSB.
            // For example, if i is 6 (110 in binary), then i >> 1 would be 3 (11 in binary),
            // which represents the number formed by removing the LSB.
            result[item] = result[item >> 1] + (item & 1);
        }

        return result;
    }
}
