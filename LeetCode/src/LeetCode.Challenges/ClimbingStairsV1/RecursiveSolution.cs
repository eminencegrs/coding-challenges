namespace LeetCode.Challenges.ClimbingStairsV1;

// Time Complexity is O(2^n), as it is a recursive algorithm that branches twice each call.
// Space Complexity is O(n).
public static class RecursiveSolution
{
    public static int GetResult(int n)
    {
        return Climb(n);
    }

    private static int Climb(int n)
    {
        if (n < 0)
        {
            return 0;
        }

        if (n == 0)
        {
            return 1;
        }

        return Climb(n - 1) + Climb(n - 2);
    }
}
