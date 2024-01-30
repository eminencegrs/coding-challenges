namespace HackerRank.Week1;

public class SparseArrays
{
    public List<int> MatchStrings(List<string> strings, List<string> queries)
    {
        var result = new int[queries.Count];
        for (var i = 0; i < queries.Count; i++)
        {
            result[i] = strings.Count(x => x.Equals(queries[i]));
        }
        
        return result.ToList();
    }
}
