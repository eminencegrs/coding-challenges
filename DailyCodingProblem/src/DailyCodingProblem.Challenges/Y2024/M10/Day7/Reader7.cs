namespace DailyCodingProblem.Challenges.Y2024.M10.Day7;

public class Reader7
{
    private string initialContent;

    public Reader7(string initialContent)
    {
        this.initialContent = initialContent;
    }

    public int Read7(char[] outerBuffer)
    {
        var charsToRead = Math.Min(7, this.initialContent.Length);
        for (int i = 0; i < charsToRead; i++)
        {
            outerBuffer[i] = this.initialContent[i];
        }

        this.initialContent = this.initialContent[charsToRead..];

        return charsToRead;
    }
}
