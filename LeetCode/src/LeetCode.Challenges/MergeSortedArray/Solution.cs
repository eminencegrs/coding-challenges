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

        double result = 0.0;
        if (nums1.Length % 2 == 0)
        {
            int mid2 = nums1.Length / 2;
            int mid1 = mid2 - 1;
            result = (mid1 + mid2) / 2.0;
        }
        else
        {
            int mid = nums1.Length / 2;
            result = mid;
        }
    }
}
