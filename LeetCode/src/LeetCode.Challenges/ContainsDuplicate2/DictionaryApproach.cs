namespace LeetCode.Challenges.ContainsDuplicate2;

// Time Complexity: O(n).
// Space Complexity: O(min(n, k)), where:
// `n` is the length of the array `nums`,
// `k` is the maximum allowed difference between indices `i` and `j`.
// Thus, the space usage is bounded by `k` but never exceeds `n`.
public class DictionaryApproach
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dictionary = new Dictionary<int, int>();

        for (var currentIndex = 0; currentIndex < nums.Length; currentIndex++)
        {
            if (dictionary.TryGetValue(nums[currentIndex], out int previousIndex))
            {
                if (currentIndex - previousIndex <= k)
                {
                    return true;
                }
            }

            // Update the last seen index of the current element.
            dictionary[nums[currentIndex]] = currentIndex;
        }

        return false;
    }
}
