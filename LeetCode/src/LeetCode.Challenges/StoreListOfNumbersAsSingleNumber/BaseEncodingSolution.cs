namespace LeetCode.Challenges.StoreListOfNumbersAsSingleNumber;

public class BaseEncodingSolution
{
    private const int BaseSeparator = 1_000_000;

    public long Encode(int[] numbers)
    {
        // Step 1: Determine the base (max number in the list + 1).
        long b = numbers.Max() + 1;

        // Step 2: Calculate the encoded number using positional encoding.
        long result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i] * (long)Math.Pow(b, i);
        }

        // Step 3: Shift the result and embed the base as a separator.
        return result * BaseSeparator + b;
    }

    public int[] Decode(long encodedNumber)
    {
        // Step 1: Extract the base number from the least significant digits.
        int baseNumber = (int)(encodedNumber % BaseSeparator);
        long result = encodedNumber / BaseSeparator;

        // Step 2: Decode the original list by reversing the positional encoding.
        var decodedNumbers = new List<int>();
        if (result == 0)
        {
            decodedNumbers.Add((int)result);
        }

        while (result > 0)
        {
            decodedNumbers.Add((int)(result % baseNumber));
            result /= baseNumber;
        }

        return decodedNumbers.ToArray();
    }
}
