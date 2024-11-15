using LeetCode.Challenges.StoreListOfNumbersAsSingleNumber;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.StoreListOfNumbersAsSingleNumber;

public class BaseEncodingSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void Encode_ShouldReturnCorrectEncodedValue(int[] input, long expectedResult)
    {
        new BaseEncodingSolution().Encode(input).ShouldBe(expectedResult);
    }

    [Theory]
    [ClassData(typeof(TestData))]
    public void Decode_ShouldReturnCorrectDecodedArray(int[] expectedResult, long input)
    {
        new BaseEncodingSolution().Decode(input).ShouldBe(expectedResult);
    }
}
