namespace LeetCode.Challenges.NextPermutation;

public class Solution
{
    public void NextPermutation(int[] nums)
    {
        if (nums.Length is < 1 or > 100)
        {
            throw new ArgumentOutOfRangeException();
        }

        if (nums.Length is 1)
        {
            return;
        }

        var k = nums.Length - 2;
        while (k >= 0 && nums[k] >= nums[k + 1])
        {
            k--;
        }

        var pivotIndex = k;
        if (pivotIndex >= 0)
        {
            k = nums.Length - 1;
            while (k >= 0 && nums[pivotIndex] >= nums[k])
            {
                k--;
            }

            this.Swap(nums, pivotIndex, k);
        }

        int left = pivotIndex + 1;
        int right = nums.Length - 1;
        while (left < right)
        {
            this.Swap(nums, left++, right--); 
        }
    }

    private void Swap(int [] nums, int left, int right)
    {
        (nums[left], nums[right]) = (nums[right], nums[left]);
    }
}
