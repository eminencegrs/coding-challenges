using LeetCode.Challenges.Problems1XX.P142_LinkedListCycle2;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems1XX.P142_LinkedListCycle2;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenLinkedList_WhenDetectCycle_ThenResultAsExpected(ListNode listHead, ListNode loopHead)
    {
        FloydCycleDetection.DetectCycle(listHead).ShouldBe(loopHead);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [null!, null!];
        yield return [new ListNode(1), null!];
        
        var (listHead, loopHead) = GetListWithCycle();
        yield return [listHead, loopHead];
        
        yield return [GetListWithoutCycle(), null!];
        
        var singleNodeCycle = new ListNode(1);
        singleNodeCycle.Next = singleNodeCycle;
        yield return [singleNodeCycle, singleNodeCycle];
        
        var listWithCycleAtTheBeginning = GetListWithCycleAtTheBeginning();
        yield return [listWithCycleAtTheBeginning.listHead, listWithCycleAtTheBeginning.loopHead];
        
        var listWithCycleAtTheEnd = GetListWithCycleAtTheEnd();
        yield return [listWithCycleAtTheEnd.listHead, listWithCycleAtTheEnd.loopHead];
    }

    private static (ListNode head, ListNode loopStart) GetListWithCycle()
    {
        var second = new ListNode(2);
        var third = new ListNode(0);
        var fourth = new ListNode(-4);
        second.Next = third;
        third.Next = fourth;
        fourth.Next = second;
        var listWithCycle = new ListNode(3) { Next = second };
        return (listWithCycle, second);
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

    private static (ListNode listHead, ListNode loopHead) GetListWithCycleAtTheBeginning()
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

        return (list, node2);
    }

    private static (ListNode listHead, ListNode loopHead) GetListWithCycleAtTheEnd()
    {
        var list = new ListNode(1);
        var node2 = new ListNode(2);
        var node3 = new ListNode(3);
        var node4 = new ListNode(4);
        var node5 = new ListNode(5);
        var node6 = new ListNode(6);

        list.Next = node2;
        node2.Next = node3;
        node3.Next = node4;
        node4.Next = node5;
        node5.Next = node6;
        node6.Next = node4;

        return (list, node4);
    }
}
