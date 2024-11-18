namespace DailyCodingProblem.Challenges.Y2024.M11.Day18;

public static class BruteForceSolution
{
    public static bool CheckIfNumber(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        var hasDigit = false;
        var hasDot = false;
        var hasExponent = false;

        for (var i = 0; i < input.Length; i++)
        {
            var c = input[i];

            if (char.IsDigit(c))
            {
                hasDigit = true;
            }
            else if (c == '+' || c == '-')
            {
                // The sign is valid only at the start or right after 'e/E'.
                if (i > 0 && input[i - 1] != 'e' && input[i - 1] != 'E')
                {
                    return false;
                }
            }
            else if (c == '.')
            {
                // Dot is invalid if it appears after 'e/E' or if it already exists.
                if (hasDot || hasExponent)
                {
                    return false;
                }

                hasDot = true;
            }
            else if (c == 'e' || c == 'E')
            {
                // The exponent is invalid if it appears more than once or without a digit before it.
                if (hasExponent || !hasDigit)
                {
                    return false;
                }

                hasExponent = true;

                // Reset digit check because the exponent must be followed by a digit.
                hasDigit = false;
            }
            else
            {
                // Any other character is invalid.
                return false;
            }
        }

        return hasDigit;
    }
}
