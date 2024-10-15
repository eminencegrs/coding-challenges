namespace DailyCodingProblem.Challenges.Y2024.M10.Day13;

public class BitwiseShiftingSolution
{
    public static int Divide2PositiveIntegers(int dividend, int divisor)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(dividend, nameof(dividend));
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(divisor, nameof(divisor));

        if (dividend == 0)
        {
            return dividend;
        }

        if (divisor == 1)
        {
            return dividend;
        }

        if (divisor > dividend)
        {
            return 0;
        }

        var quotient = 0;

        while (dividend >= divisor)
        {
            var tempDivisor = divisor;
            var multiple = 1;

            // Double the divisor value until it exceeds the dividend. Check to avoid overflow.
            while (dividend >= (tempDivisor << 1) && (tempDivisor << 1) > 0)
            {
                // Shift left by 1 -- equivalent to multiplying by 2.
                tempDivisor <<= 1;

                // Multiply `multiple` by 2 as well.
                multiple <<= 1; 
            }

            dividend -= tempDivisor;
            quotient += multiple;
        }

        return quotient;
    }
}
