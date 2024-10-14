namespace HackerRank.BasicProblemSolvingCert;

public static class SubArraySumProblem
{
    public static List<long> Solve(List<int> numbers, List<List<int>> queries)
    {
        List<long> result = [];
        var length = numbers.Count;
        var precalculated = new long[length + 1];
        for (var i = 1; i <= length; i++)
        {
            precalculated[i] = precalculated[i - 1] + numbers[i - 1];
        }

        var zeroPositions = new List<int>();
        for (var i = 0; i < length; i++)
        {
            if (numbers[i] == 0)
            {
                zeroPositions.Add(i);
            }
        }

        foreach (var query in queries)
        {
            var start = query[0] - 1;
            var end = query[1] - 1;
            var x = query[2];

            var sum = precalculated[end + 1] - precalculated[start];
            foreach (var zeroIndex in zeroPositions)
            {
                if (zeroIndex >= start && zeroIndex <= end)
                {
                    sum += x;
                }
            }

            result.Add(sum);
        }

        return result;
    }
}
