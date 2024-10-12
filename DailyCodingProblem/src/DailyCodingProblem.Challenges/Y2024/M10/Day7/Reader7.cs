namespace DailyCodingProblem.Challenges.Y2024.M10.Day7;

public class Reader7
{
    private string contentToRead;

    public Reader7(string contentToRead)
    {
        this.contentToRead = contentToRead;
    }

    public int Read7(char[] outerBuffer)
    {
        var amountToRead = Math.Min(7, this.contentToRead.Length);
        for (int i = 0; i < amountToRead; i++)
        {
            outerBuffer[i] = this.contentToRead[i];
        }

        this.contentToRead = this.contentToRead[amountToRead..];

        return amountToRead;
    }
}
