namespace HackerRank.Week1;

public class XorStrings
{
    public string Process(string first, string second)
    {
        string result = string.Empty;
        for (int i = 0; i < first.Length; i++)
        {
            result += first[i] == second[i] ? '0' : '1';
        }

        return result;
    }
}
