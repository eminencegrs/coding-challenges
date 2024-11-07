using System.Collections;
using LeetCode.Challenges.TreeSerializationDeserialization;

namespace LeetCode.Challenges.UnitTests.TreeSerializationDeserialization;

public class TestTree : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        // The test tree:
        //       5
        //     /   \
        //    3     2
        //   / \   / \
        //  @  4  @   @
        //    / \
        //   @   @

        var root = new TreeNode
        {
            Value = 5,
            Left = new TreeNode
            {
                Value = 3,
                Left = null,
                Right = new TreeNode { Value = 4 }
            },
            Right = new TreeNode { Value = 2 }
        };

        yield return [ root, "5;3;@;4;@;@;2;@;@" ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
