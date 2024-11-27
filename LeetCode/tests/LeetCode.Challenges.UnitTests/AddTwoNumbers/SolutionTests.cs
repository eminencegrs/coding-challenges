using LeetCode.Challenges.AddTwoNumbers;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.AddTwoNumbers;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenAddTwoNumbers_ThenResultAsExpected(int[] first, int[] second, int[] total)
    {
        var a = GetListNodeFromArray(first);
        var b = GetListNodeFromArray(second);
        var expectedResult = GetListNodeFromArray(total);

        var actualResult = Solution.GetResult(a, b);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    // TODO: It's a helper method. Improve it.
    private static ListNode? GetListNodeFromArray(int[] num1)
    {
        ListNode? node = null;
        for (var i = num1.Length - 1; i >= 0; i--)
        {
            if (node == null)
            {
                node = new ListNode(num1[i]);
            }
            else
            {
                var temp = node;
                node = new ListNode(num1[i], temp);
            }
        }

        return node;
    }

    // TODO: verify if it works properly.
    private static ListNode ConvertArrayIntoListNode(int[] num)
    {
        // Create a dummy node to simplify list construction.
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        // Iterate through the array in reverse order to ensure consistency with the problem requirements,
        // where the digits are stored in reverse order within the linked lists.
        for (int i = num.Length - 1; i >= 0; i--)
        {
            // Create a new node with the current value.
            current.Next = new ListNode(num[i]);

            // Move to the next node
            current = current.Next;
        }

        // Skip the dummy node and return the actual head of the list.
        return dummy.Next!;
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[] { 2, 4, 3 },
            new[] { 5, 6, 4 },
            new[] { 7, 0, 8 }
        ];
        yield return
        [
            new[] { 2, 0, 9 },
            new[] { 9, 9 },
            new[] { 1, 0, 0, 1 }
        ];
        yield return
        [
            new[] { 0 },
            new[] { 0 },
            new[] { 0 }
        ];
        yield return
        [
            new[] { 9, 9, 9, 9, 9, 9, 9 },
            new[] { 9, 9, 9, 9 },
            new[] { 8, 9, 9, 9, 0, 0, 0, 1 }
        ];
    }
}
