namespace LeetCode.Challenges.SquareRoot;

// Time Complexity: O(logn).
// In every step of the binary search, the size of the problem is reduced by half.
public class BinarySearchSolution
{
    public static int GetResult(int x)
    {
        if (x < 2)
        {
            return x;
        }

        var result = 0;

        // These are the bounds for the binary search.
        long left = 0;
        long right = x;

        while (left <= right)
        {
            long mid = (left + right) / 2;
            long squaredMid = mid * mid;

            // If `squaredMid` is greater than `x`, it means `mid` is too large, so `right` is adjusted to `mid - 1`.
            if (squaredMid > x)
            {
                right = mid - 1;
                continue;
            }

            // If `squaredMid` is less than `x`, it means `mid` is too small, so `left` is adjusted to `mid + 1`,
            // and `result` is updated to `mid`, since `mid` might potentially be the nearest rounded-down integer.  
            if (squaredMid < x)
            {
                left = mid + 1;
                result = (int)mid;
                continue;
            }

            // The most obvious case: when `squaredMid` equals `x`, then `mid` is the exact integer square root.
            if (squaredMid == x)
            {
                return (int)mid;
            }
        }

        return result;
    }
}
