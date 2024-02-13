namespace LeetCode.Challenges.MergeSortedArray;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var nums1Index = m - 1;
        var nums2Index = n - 1;
        var current = m + n - 1;

        while (nums1Index >= 0 && nums2Index >= 0)
        {
            if (nums1[nums1Index] > nums2[nums2Index])
            {
                nums1[current] = nums1[nums1Index];
                nums1Index--;
            }
            else
            {
                nums1[current] = nums2[nums2Index];
                nums2Index--;
            }

            current--;
        }

        while (nums2Index >= 0)
        {
            nums1[current] = nums2[nums2Index];
            nums2Index--;
            current--;
        }
    }
}
