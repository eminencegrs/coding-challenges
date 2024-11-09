using FluentAssertions;
using LeetCode.Challenges.Problems0XX.P074_Search2DMatrix;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems0XX.P074_Search2DMatrix;

public class SolutionTests
{
    [Fact]
    public void Given_When_Then()
    {
        var action = () => Solution.SearchMatrix([[1, 2], [3, 4], [5, 6]], 4);
        action.Should().Throw<NotImplementedException>();
    }
}
