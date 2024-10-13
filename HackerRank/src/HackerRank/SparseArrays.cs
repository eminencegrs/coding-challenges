namespace HackerRank;

// There is a collection of input strings and a collection of query strings.
// For each query string, determine how many times it occurs in the list of input strings.
// Return an array of the results.

// Time Complexity: O(n + m).
// Space Complexity: O(n + m).
public static class SparseArrays
{
    public static List<int> MatchingStrings(List<string> stringList, List<string> queries)
    {
        var dictionary = new Dictionary<string, int>();
        foreach (var str in stringList)
        {
            if (dictionary.TryGetValue(str, out var _))
            {
                dictionary[str]++;
            }
            else
            {
                dictionary[str] = 1;
            }
        }

        return queries.Select(query => dictionary.GetValueOrDefault(query, 0)).ToList();
    }
}
