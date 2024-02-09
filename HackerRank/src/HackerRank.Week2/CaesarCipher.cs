namespace HackerRank.Week2;

public class CaesarCipher
{
    public string Encrypt(string input, int key)
    {
        var result = string.Empty;
        var letters = input.ToCharArray();
        foreach (var letter in letters)
        {
            result += this.EncodeLetter(key, letter);
        }

        return result;
    }

    public string Decrypt(string input, int key)
    {
        var result = string.Empty;
        foreach (var letter in input)
        {
            result += this.DecodeLetter(key, letter);
        }

        return result;
    }

    private char EncodeLetter(int key, char letter)
    {
        if (char.IsLetter(letter))
        {
            var offset = char.IsUpper(letter) ? 'A' : 'a';
            return (char)((letter + key - offset) % 26 + offset);
        }

        return letter;
    }

    private char DecodeLetter(int key, char letter)
    {
        if (char.IsLetter(letter))
        {
            var offset = char.IsUpper(letter) ? 'A' : 'a';
            return (char)((letter - key - offset + 26) % 26 + offset);
        }

        return letter;
    }
}
