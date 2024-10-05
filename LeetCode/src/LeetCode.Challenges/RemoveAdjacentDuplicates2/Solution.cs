using System.Text;

namespace LeetCode.Challenges.RemoveAdjacentDuplicates2;

public class Solution
{
    private record CharacterGroup(char Character, int Count);

    public static string RemoveDuplicates(string str, int length)
    {
        var processedChars = ProcessCharacters(str, length);
        return GetFinalString(processedChars);
    }

    private static Stack<CharacterGroup> ProcessCharacters(string str, int length)
    {
        var stack = new Stack<CharacterGroup>();
        foreach (var character in str)
        {
            if (stack.TryPeek(out var existing) && existing.Character == character)
            {
                stack.Pop();
                var newCount = existing.Count + 1;
                if (newCount < length)
                {
                    stack.Push(existing with { Count = newCount });
                }
            }
            else
            {
                stack.Push(new CharacterGroup(character, 1));
            }
        }

        return stack;
    }

    private static string GetFinalString(Stack<CharacterGroup> processedChars)
    {
        var sb = new StringBuilder();
        while (processedChars.Count > 0)
        {
            var value = processedChars.Pop();
            sb.Append(value.Character, value.Count);
        }

        var resultedChars = sb.ToString().ToCharArray();
        Array.Reverse(resultedChars);
        return new string(resultedChars);
    }
}
