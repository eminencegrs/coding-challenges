namespace HackerRank.Week1;

public class SubarrayDivision
{
    // Task:
    // Two children, Lily and Ron, want to share a chocolate bar. Each of the squares has an integer on it.
    // Lily decides to share a contiguous segment of the bar selected such that:
    //  - The length of the segment matches Ron's birth month, and,
    //  - The sum of the integers on the squares is equal to his birth day.
    // Determine how many ways she can divide the chocolate.
    //
    // Example:
    // chocolateBar = [ 2, 2, 1, 3, 2 ]
    //          day = 4
    //        month = 2
    // Lily wants to find segments summing to Ron's birth day (day = 4) with a length equalling his birth month (month = 2).
    // In this case, there are two segments meeting her criteria: [ 2, 2 ] and [ 1, 3 ].
    
    public int GetNumber(List<int> chocolateBar, int day, int month)
    {
        var result = 0;
        for (var i = 0; i <= chocolateBar.Count - month; i++)
        {
            var subarray = chocolateBar.GetRange(i, month);
            var sum = subarray.Aggregate((acc, x) => acc + x);
            if (sum == day)
            {
                result++;
            }
        }

        return result;
    }
}
