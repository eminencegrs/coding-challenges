namespace LeetCode.Challenges.Assessments.Range_Sum_Query___Mutable;

// A NumArray object will be instantiated and called as such:
//  - NumArray obj = new NumArray(nums);
//  - obj.Update(index,val);
//  - int param_2 = obj.SumRange(left,right);
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
        // Initialize leaves of the segment tree.
        for (var i = 0; i < this.n; i++)
        {
            this.segmentTree[this.n + i] = nums[i];
        }

        // Build the rest of the tree by calculating parents.
        for (var i = this.n - 1; i > 0; i--)
        {
            this.segmentTree[i] = this.segmentTree[2 * i] + this.segmentTree[2 * i + 1];
        }
    }

    public void Update(int index, int val)
    {
        // Update the value at the leaf.
        var pos = index + this.n;
        this.segmentTree[pos] = val;

        // Recalculate the sum for the parent nodes.
        while (pos > 1)
        {
            pos /= 2;
            this.segmentTree[pos] = this.segmentTree[2 * pos] + this.segmentTree[2 * pos + 1];
        }
    }

    public int SumRange(int left, int right)
    {
        var sum = 0;
        left += n;
        right += n;

        while (left <= right)
        {
            if (left % 2 == 1)
            {
                sum += this.segmentTree[left];
                left++;
            }

            if (right % 2 == 0)
            {
                sum += this.segmentTree[right];
                right--;
            }

            left /= 2;
            right /= 2;
        }

        return sum;
    }
}
