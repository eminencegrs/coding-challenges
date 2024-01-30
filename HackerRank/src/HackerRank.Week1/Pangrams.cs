namespace HackerRank.Week1;

public class Pangrams
{
    public string CheckIfPangramsV1(string input)
    {
        input = input.ToUpper();
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        return alphabet.All(letter => input.Contains(letter)) ? "pangram" : "not pangram";
    }

    public string CheckIfPangramV2(string input)
    {
        input = input.ToUpper();
        char[] uniqueLetters = input.Where(char.IsLetter).Distinct().ToArray();
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        return alphabet.Except(uniqueLetters).Any() ? "not pangram" : "pangram";
    }
}
