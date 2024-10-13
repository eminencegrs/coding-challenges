using Shouldly;
using Xunit;

namespace HackerRank.UnitTests;

public class MaximumPerimeterTriangleTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenSticks_WhenGetSides_ThenResultAsExpected(List<int> array, List<int> expectedResult)
    {
        var actualResult = MaximumPerimeterTriangle.GetSides(array);
        actualResult.SequenceEqual(expectedResult).ShouldBeTrue();
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new List<int> { 1, 2, 3, 4, 5, 10 }, new List<int> { 3, 4, 5 }];
        yield return [new List<int> { 1, 1, 1, 3, 3 }, new List<int> { 1, 3, 3 }];
        yield return [new List<int> { 1, 2, 3 }, new List<int> { -1 }];
        yield return [new List<int> { 1, 1, 1, 2, 3, 5 }, new List<int> { 1, 1, 1 }];
        yield return [new List<int> { 3, 9, 2, 15, 3 }, new List<int> { 2, 3, 3 }];
        yield return
        [
            new List<int> { 50, 2430, 134, 6373, 215, 1502, 926, 10312, 351, 74, 572, 3938 },
            new List<int> { -1 }
        ];
        yield return
        [
            new List<int>
            {
                9, 2015, 5294, 58768, 285, 477, 72, 13867, 97, 22445,
                48, 36318, 764, 8573, 183, 3270, 81, 1251, 59, 95094
            },
            new List<int> { 72, 81, 97 }
        ];
        yield return
        [
            new List<int>
            {
                34, 1924, 565, 80, 848, 2913, 819, 732, 431, 32981, 195, 86340, 688, 563, 7763,
                314, 12608, 401, 4845, 439, 353, 52, 208, 20372, 626, 805, 19, 984, 939, 53354
            },
            new List<int> { 848, 939, 984 }
        ];
        yield return
        [
            new List<int>
            {
                537, 6494, 4166, 7388, 19855, 6023, 6599, 6264, 2139, 9468,
                129280, 29846, 546999, 7067, 208844, 885139, 79558, 2257, 49705,
                9553, 3869, 6354, 7911, 5672, 914, 9990, 7701, 4744, 2399, 1432139,
                6177, 5645, 4732, 7987, 6181, 1440, 8695, 9855, 338136, 4845
            },
            new List<int> { 9553, 9855, 9990 }
        ];
        yield return
        [
            new List<int>
            {
                1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000,
                1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000,
                1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000,
                1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000,
                1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000,
                1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000,
                1000000000, 1000000000
            },
            new List<int> { 1000000000, 1000000000, 1000000000 }
        ];
    }
}
