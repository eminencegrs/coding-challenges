namespace LeetCode.Challenges;

public class TwoSum
{
    public int[] GetResult(int[] numbers, int target)
    {
        var result = new int[2];
        for (var i = 1; i < numbers.Length; i++)
        {
            if (numbers[i - 1] + numbers[i] == target)
            {
                result = [i - 1, i];
                break;
            }
        }

        return result;
    }
}
