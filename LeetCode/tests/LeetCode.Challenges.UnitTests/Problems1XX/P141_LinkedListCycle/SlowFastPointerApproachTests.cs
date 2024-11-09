using LeetCode.Challenges.Problems1XX.P141_LinkedListCycle;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems1XX.P141_LinkedListCycle;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenLinkedList_WhenCallHasCycle_ThenResultAsExpected(ListNode head, bool expectedResult)
    {
        SlowFastPointerApproach.HasCycle(head).ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [null!, false];
        yield return [new ListNode(1), false];
        yield return [GetListWithCycle(), true];
        yield return [GetListWithoutCycle(), false];
        yield return [GetSingleNodeListWithCycle(), true];
        yield return [GetListWithCycleAtTheBeginning(), true];
        yield return [GetListWithCycleAtTheEnd(), true];
    }

    private static ListNode GetListWithCycle()
    {
        var second = new ListNode(2);
        var third = new ListNode(0);
        var fourth = new ListNode(-4);
        second.Next = third;
        third.Next = fourth;
        fourth.Next = second;
        var listWithCycle = new ListNode(3) { Next = second };
        return listWithCycle;
    }

    private static ListNode GetListWithoutCycle()
    {
        var listWithoutCycle = new ListNode(1)
        {
            Next = new ListNode(2)
            {
                Next = new ListNode(3)
                {
                    Next = new ListNode(4)
                    {
                        Next = new ListNode(5)
                    }
                }
            }
        };

        return listWithoutCycle;
    }

    private static ListNode GetSingleNodeListWithCycle()
    {
        var singleNodeCycle = new ListNode(1);
        singleNodeCycle.Next = singleNodeCycle;
        return singleNodeCycle;
    }

    private static ListNode GetListWithCycleAtTheBeginning()
    {
        var list = new ListNode(1);
        var node2 = new ListNode(2);
        var node3 = new ListNode(3);
        var node4 = new ListNode(4);
        var node5 = new ListNode(5);

        list.Next = node2;
        node2.Next = node3;
        node3.Next = node4;
        node4.Next = node5;
        node5.Next = node2;

        return list;
    }

    private static ListNode GetListWithCycleAtTheEnd()
    {
        var list = new ListNode(1);
        var secondNode = new ListNode(2);
        var thirdNode = new ListNode(3);
        var fourthNode = new ListNode(4);
        var fifthNode = new ListNode(5);
        var sixthNode = new ListNode(6);

        list.Next = secondNode;
        secondNode.Next = thirdNode;
        thirdNode.Next = fourthNode;
        fourthNode.Next = fifthNode;
        fifthNode.Next = sixthNode;
        sixthNode.Next = fourthNode;

        return list;
    }
}
