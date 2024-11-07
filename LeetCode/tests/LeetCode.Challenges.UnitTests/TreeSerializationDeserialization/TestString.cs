using System.Collections;
using LeetCode.Challenges.TreeSerializationDeserialization;

namespace LeetCode.Challenges.UnitTests.TreeSerializationDeserialization;

public class TestString : IEnumerable<object[]>
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

        yield return [ "5;3;@;4;@;@;2;@;@", root ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
