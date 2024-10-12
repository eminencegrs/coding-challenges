namespace DailyCodingProblem.Challenges.Y2024.M10.Day7;

public class ReaderN : Reader7
{
    private char[] buffer = new char[7];
    private int bufferIndex = 0;
    private int bufferSize = 0;

    public ReaderN(string contentToRead) : base(contentToRead)
    {
    }

    public int ReadN(char[] outerBuffer, int n)
    {
        var totalRead = 0;

        while (totalRead < n)
        {
            if (this.bufferIndex == 0)
            {
                this.bufferSize = this.Read7(this.buffer);
            }

            if (this.bufferSize == 0)
            {
                break;
            }

            while (this.bufferIndex < this.bufferSize && totalRead < n)
            {
                outerBuffer[totalRead++] = this.buffer[this.bufferIndex++];
            }

            if (this.bufferIndex >= this.bufferSize)
            {
                this.bufferIndex = 0;
            }
        }

        return totalRead;
    }
}
