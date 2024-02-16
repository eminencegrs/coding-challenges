namespace LeetCode.Challenges.MedianOfTwoSortedArrays;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int m = nums1.Length;
        int n = nums2.Length;

        if (m > n)
        {
            return this.FindMedianSortedArrays(nums2, nums1);
        }

        int leftHalfLength = (m + n + 1) / 2;
        int minCut = 0;
        int maxCut = m;

        while (minCut <= maxCut)
        {
            int i = (minCut + maxCut) / 2;
            int j = leftHalfLength - i;

            if (i < maxCut && nums2[j - 1] > nums1[i])
            {
                minCut = i + 1;
            }
            else if (i > minCut && nums1[i - 1] > nums2[j])
            {
                maxCut = i - 1;
            }
            else
            {
                int leftHalfEnd;
                if (i == 0)
                {
                    leftHalfEnd = nums2[j - 1];
                }
                else if (j == 0)
                {
                    leftHalfEnd = nums1[i - 1];
                } 
                else
                {
                    leftHalfEnd = Math.Max(nums1[i - 1], nums2[j - 1]);
                }

                if ((m + n) % 2 == 1)
                {
                    return leftHalfEnd;
                }

                int rightHalfStart;
                if (i == m)
                {
                    rightHalfStart = nums2[j];
                }
                else if (j == n)
                {
                    rightHalfStart = nums1[i];
                }
                else
                {
                    rightHalfStart = Math.Min(nums1[i], nums2[j]);
                }

                return (leftHalfEnd + rightHalfStart) / 2.0;
            }
        }

        return default;
    }
}
