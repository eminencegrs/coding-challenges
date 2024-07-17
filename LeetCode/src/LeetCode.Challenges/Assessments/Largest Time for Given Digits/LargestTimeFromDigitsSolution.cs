namespace LeetCode.Challenges.Assessments.Largest_Time_for_Given_Digits;

public static class LargestTimeFromDigitsSolution
{
    public static string GetResult(int[] arr)
    {
        var permutations = new List<int[]>();
        GetPermutations(arr, 0, permutations);

        string latestTime = "";
        foreach (var perm in permutations)
        {
            string time = $"{perm[0]}{perm[1]}:{perm[2]}{perm[3]}";
            if (IsValidTime(time) && string.Compare(time, latestTime) > 0)
            {
                latestTime = time;
            }
        }

        return latestTime;
    }

    private static void GetPermutations(int[] arr, int start, List<int[]> result)
    {
        if (start == arr.Length - 1)
        {
            result.Add((int[])arr.Clone());
            return;
        }

        for (int i = start; i < arr.Length; i++)
        {
            Swap(arr, start, i);
            GetPermutations(arr, start + 1, result);
            Swap(arr, start, i);
        }
    }

    private static void Swap(int[] arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }

    private static bool IsValidTime(string time)
    {
        int hours = int.Parse(time.Substring(0, 2));
        int minutes = int.Parse(time.Substring(3, 2));
        return hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59;
    }
}
