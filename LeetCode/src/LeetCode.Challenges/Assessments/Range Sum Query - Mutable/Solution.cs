namespace LeetCode.Challenges.Assessments.Range_Sum_Query___Mutable;

public class NumArray
{
    private readonly int[] segmentTree;
    private readonly int n;

    public NumArray(int[] nums)
    {
        this.n = nums.Length;
        this.segmentTree = new int[2 * n];
        this.BuildSegmentTree(nums);
    }

    private void BuildSegmentTree(int[] nums)
    {
        // Initialize leaves of the segment tree
        for (int i = 0; i < this.n; i++)
        {
            this.segmentTree[this.n + i] = nums[i];
        }

        // Build the rest of the tree by calculating parents
        for (int i = this.n - 1; i > 0; i--)
        {
            this.segmentTree[i] = this.segmentTree[2 * i] + this.segmentTree[2 * i + 1];
        }
    }

    public void Update(int index, int val)
    {
        // Update the value at the leaf
        int pos = index + n;
        segmentTree[pos] = val;

        // Recalculate the sum for the parent nodes
        while (pos > 1)
        {
            pos /= 2;
            segmentTree[pos] = segmentTree[2 * pos] + segmentTree[2 * pos + 1];
        }
    }

    public int SumRange(int left, int right)
    {
        int sum = 0;
        left += n;
        right += n;

        while (left <= right)
        {
            if (left % 2 == 1)
            {
                sum += segmentTree[left];
                left++;
            }

            if (right % 2 == 0)
            {
                sum += segmentTree[right];
                right--;
            }

            left /= 2;
            right /= 2;
        }

        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(index,val);
 * int param_2 = obj.SumRange(left,right);
 */
 