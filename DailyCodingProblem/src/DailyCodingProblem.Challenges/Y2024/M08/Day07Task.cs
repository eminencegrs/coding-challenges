namespace DailyCodingProblem.Challenges.Y2024.M08;

// This problem was asked by Snapchat.
// 
// Given an array of time intervals (start, end) for classroom lectures (possibly overlapping),
// find the minimum number of rooms required.
// 
// For example, given [(30, 75), (0, 50), (60, 150)], you should return 2.
//
// Time Complexity: O(nlog(n)).
public static class Day07Task
{
    public static int GetMinNumberOfRooms(int[][] intervals)
    {
        var starts = new int[intervals.Length];
        var ends = new int[intervals.Length];

        for (var i = 0; i < intervals.Length; i++)
        {
            starts[i] = intervals[i].First();
            ends[i] = intervals[i].Last();
        }

        Array.Sort(starts);
        Array.Sort(ends);

        var result = 0;
        var groups = 0;
        var p1 = 0;
        var p2 = 0;

        while (p1 < intervals.Length && p2 < intervals.Length)
        {
            if (starts[p1] < ends[p2])
            {
                groups++;
                p1++;
            }
            else
            {
                groups--;
                p2++;
            }

            result = Math.Max(result, groups);
        }

        return result;
    }
}
