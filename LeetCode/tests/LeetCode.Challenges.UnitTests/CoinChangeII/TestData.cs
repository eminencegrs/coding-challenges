using System.Collections;

namespace LeetCode.Challenges.UnitTests.CoinChangeII;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        //                      (5)
        //                    /    \
        //               -1 (4)     -2 (3)
        //              /    \         \
        //          -1 (3)   -2 (2)     -2 (1)
        //         /    \       |          |
        //     -1 (2)  -2 (0)   (0)        (X)
        //    /    \
        // -1 (1)  -2 (X)
        //  /
        // (0)
        // 
        // Valid Paths:
        // [1, 1, 1, 1, 1], [1, 1, 1, 2], [1, 2, 2]
        yield return [5, new[] { 1, 2 }, 3];

        //                      (5)
        //                    /  |   \
        //               -1 (4) -2 (3) -5 (0)
        //              /  |        |
        //          -1 (3) -2 (2)  -2 (1)
        //         /  |        |      |
        //     -1 (2)-2 (0)    (0)    (X)
        //    /  |
        // -1 (1)-2 (X)
        //  /
        // (0)
        // 
        // Valid Paths:
        // [1, 1, 1, 1, 1], [1, 1, 1, 2], [1, 2, 2], [5]
        yield return [5, new[] { 1, 2, 5 }, 4];

        yield return [3, new[] { 2 }, 0];
        yield return [10, new[] { 10 }, 1];
        yield return [6, new[] { 1, 3, 4 }, 4];
        yield return [5, new[] { 5 }, 1];
        yield return [2, new[] { 5 }, 0];
        yield return [1, new[] { 2, 5, 10 }, 0];
        yield return [20, new[] { 10, 5 }, 3];
        yield return [30, new[] { 1, 5, 10, 25 }, 18];
        yield return [7, new[] { 2, 3 }, 1];
        yield return [100, new[] { 1, 2, 5 }, 541];
        yield return [8, new[] { 7, 3, 2 }, 2];
        yield return [14, new[] { 1, 7, 10 }, 4];
        yield return [15, new[] { 1, 3, 4, 7 }, 22];
        yield return [30, new[] { 25, 50, 100 }, 0];
        yield return [11, new[] { 9, 6, 5, 1 }, 6];

        // LeetCode: Time Limit Exceeded
        yield return [500, new[] { 3, 5, 7, 8, 9, 10, 11 }, 35502874];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
