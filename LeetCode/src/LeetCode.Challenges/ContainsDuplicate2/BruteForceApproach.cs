namespace LeetCode.Challenges.ContainsDuplicate2;

// Time Complexity: O(n^2).
// Space Complexity: O(1).
public class BruteForceApproach
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

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j] && Math.Abs(i - j) <= k)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
