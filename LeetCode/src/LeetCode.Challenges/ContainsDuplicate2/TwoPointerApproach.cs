namespace LeetCode.Challenges.ContainsDuplicate2;

// Time Complexity: O(n * k), where:
// `n` is the length of the array `nums`.
// `k` is the maximum allowed difference between indices `i` and `j`.
// Space Complexity: O(1).
public class TwoPointerApproach
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if (nums.Length < 1)
        {
            return false;
        }

        if (k <= 0)
        {
            return false;
        }

        var left = 0;
        var right = 0;
        while (left < nums.Length - 1 && right < nums.Length)
        {
            if (left == right)
            {
                right++;
            }

            if (Math.Abs(left - right) <= k)
            {
                if (nums[left] == nums[right])
                {
                    return true;
                }

                if (right == nums.Length - 1)
                {
                    left++;
                    right = left;
                }
                else
                {
                    right++;
                }
            }
            else
            {
                left++;
                right = left;
            }
        }

        return false;
    }
}
