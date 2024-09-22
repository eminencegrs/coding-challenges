namespace DailyCodingProblem.Challenges.Y2024.M09;

// This problem was asked by Square.
// 
// Assume we have access to a function toss_biased()
// which returns 0 or 1 with a probability that's not 50-50 (but also not 0-100 or 100-0).
// We do not know the bias of the coin.
// 
// Write a function to simulate an unbiased coin toss.
public class Day21Task
{
    private readonly Random random = new();
    private readonly double biasProbability;

    /// <summary>
    /// Constructor to set the bias level (0 to 1), where the probability of returning `1` is `biasProbability`. 
    /// </summary>
    /// <param name="biasProbability">
    /// A double value between 0 (inclusive) and 1 (exclusive) that specifies the probability of returning `1`. 
    /// A value of 0 indicates always returning `0`.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="biasProbability"/> is less than 0 or greater than or equal to 1.
    /// </exception>
    public Day21Task(double biasProbability)
    {
        if (biasProbability is < 0 or >= 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(biasProbability), "Bias probability must be between 0 and 1.");
        }

        this.biasProbability = biasProbability;
    }

    private byte TossCoinBiased() => this.random.NextDouble() < this.biasProbability ? (byte)1 : (byte)0;

    public byte TossCoinUnbiased()
    {
        while (true)
        {
            var firstToss = this.TossCoinBiased();
            var secondToss = this.TossCoinBiased();

            // Return `0` if the first toss is `0` and the second toss is `1`.
            if (firstToss == 0 && secondToss == 1)
            {
                return 0;
            }

            // Return `1` if the first toss is `1` and the second toss is `0`.
            if (firstToss == 1 && secondToss == 0)
            {
                return 1;
            }

            // If both tosses are the same (`00` or `11`) - discard and repeat.
        }
    }

    public (double zerosPercentage, double onesPercentage) MonteCarlo(int trials)
    {
        int zerosCount = 0;
        int onesCount = 0;

        for (int i = 0; i < trials; i++)
        {
            int result = this.TossCoinUnbiased();
            if (result == 0)
            {
                zerosCount++;
            }
            else
            {
                onesCount++;
            }
        }

        return ((double)zerosCount / trials, (double)onesCount / trials);
    }
}
