namespace LeetCode.Challenges.BasicCalculator2;

// Time Complexity: O(n).
public class Solution
{
    public int Calculate(string input)
    {
        ArgumentException.ThrowIfNullOrEmpty(input);

        var stack = new Stack<int>();
        var currentNumber = 0;
        var operation = '+';

        for (var i = 0; i < input.Length; i++)
        {
            var currentChar = input[i];
            if (char.IsDigit(currentChar))
            {
                currentNumber = currentNumber * 10 + (currentChar - '0');
            }

            if ((char.IsDigit(currentChar) || currentChar == ' ') && i != input.Length - 1)
            {
                continue;
            }

            var tempResult = operation switch
            {
                '+' => currentNumber,
                '-' => -currentNumber,
                '*' => stack.Pop() * currentNumber,
                '/' => stack.Pop() / currentNumber,
                _ => throw new InvalidOperationException($"Unknown operation '{operation}'.")
            };

            stack.Push(tempResult);

            operation = currentChar;
            currentNumber = 0;
        }

        var result = 0;
        while (stack.Count > 0)
        {
            result += stack.Pop();
        }

        return result;
    }
}
