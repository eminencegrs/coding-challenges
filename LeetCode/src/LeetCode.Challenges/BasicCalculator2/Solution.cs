namespace LeetCode.Challenges.BasicCalculator2;

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

            // If the current char is a digit, build the number.
            if (char.IsDigit(currentChar))
            {
                currentNumber = currentNumber * 10 + (currentChar - '0');
            }

            if ((char.IsDigit(currentChar) || currentChar == ' ') && i != input.Length - 1)
            {
                continue;
            }

            if (operation == '+')
            {
                stack.Push(currentNumber);
            }
            else if (operation == '-')
            {
                stack.Push(-currentNumber);
            }
            else if (operation == '*')
            {
                stack.Push(stack.Pop() * currentNumber);
            }
            else if (operation == '/')
            {
                stack.Push(stack.Pop() / currentNumber);
            }

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
