using DailyCodingProblem.Challenges.Y2024.M09;
using FluentAssertions.Execution;
using Shouldly;
using xRetry;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M09;

public class Day21Tests
{
    [RetryTheory(10)]
    [MemberData(nameof(GetMidBiasedTestDataWithFewTrials))]
    public void GivenFewTrialsAndMidBias_WhenCallMonteCarlo_ThenResultAsExpected(TestData testData)
    {
        var sut = new Day21Task(biasProbability: testData.Bias);
        var actualResult = sut.MonteCarlo(testData.Trials);

        using (new AssertionScope())
        {
            actualResult.zerosPercentage.ShouldBeInRange(
                TestData.Expected - testData.Tolerance,
                TestData.Expected + testData.Tolerance);

            actualResult.onesPercentage.ShouldBeInRange(
                TestData.Expected - testData.Tolerance,
                TestData.Expected + testData.Tolerance);
        }
    }

    [RetryTheory(10)]
    [MemberData(nameof(GetMidBiasedTestDataWithManyTrials))]
    public void GivenManyTrialsAndMidBias_WhenCallMonteCarlo_ThenResultAsExpected(TestData testData)
    {
        var sut = new Day21Task(biasProbability: testData.Bias);
        var actualResult = sut.MonteCarlo(testData.Trials);

        using (new AssertionScope())
        {
            actualResult.zerosPercentage.ShouldBeInRange(
                TestData.Expected - testData.Tolerance,
                TestData.Expected + testData.Tolerance);

            actualResult.onesPercentage.ShouldBeInRange(
                TestData.Expected - testData.Tolerance,
                TestData.Expected + testData.Tolerance);
        }
    }

    [RetryTheory(10)]
    [MemberData(nameof(GetHighlyBiasedTestDataWithFewTrials))]
    public void GivenFewTrialsAndHighBias_WhenCallMonteCarlo_ThenResultAsExpected(TestData testData)
    {
        var sut = new Day21Task(biasProbability: testData.Bias);
        var actualResult = sut.MonteCarlo(testData.Trials);

        using (new AssertionScope())
        {
            actualResult.zerosPercentage.ShouldBeInRange(
                TestData.Expected - testData.Tolerance,
                TestData.Expected + testData.Tolerance);

            actualResult.onesPercentage.ShouldBeInRange(
                TestData.Expected - testData.Tolerance,
                TestData.Expected + testData.Tolerance);
        }
    }

    [RetryTheory(10)]
    [MemberData(nameof(GetHighlyBiasedTestDataWithManyTrials))]
    public void GivenManyTrialsAndHighBias_WhenCallMonteCarlo_ThenResultAsExpected(TestData testData)
    {
        var sut = new Day21Task(biasProbability: testData.Bias);
        var actualResult = sut.MonteCarlo(testData.Trials);

        using (new AssertionScope())
        {
            actualResult.zerosPercentage.ShouldBeInRange(
                TestData.Expected - testData.Tolerance,
                TestData.Expected + testData.Tolerance);

            actualResult.onesPercentage.ShouldBeInRange(
                TestData.Expected - testData.Tolerance,
                TestData.Expected + testData.Tolerance);
        }
    }

    public static IEnumerable<object[]> GetMidBiasedTestDataWithFewTrials()
    {
        yield return [new TestData(0.3, 10, 0.1)];
        yield return [new TestData(0.3, 1_000, 0.05)];
        yield return [new TestData(0.7, 10, 0.1)];
        yield return [new TestData(0.7, 1_000, 0.05)];
    }

    public static IEnumerable<object[]> GetMidBiasedTestDataWithManyTrials()
    {
        yield return [new TestData(0.3, 1_000_000, 0.0005)];
        yield return [new TestData(0.7, 1_000_000, 0.0005)];
    }

    public static IEnumerable<object[]> GetHighlyBiasedTestDataWithFewTrials()
    {
        yield return [new TestData(0.01, 10, 0.1)];
        yield return [new TestData(0.01, 1_000, 0.05)];
        yield return [new TestData(0.99, 10, 0.1)];
        yield return [new TestData(0.99, 1_000, 0.05)];
    }

    public static IEnumerable<object[]> GetHighlyBiasedTestDataWithManyTrials()
    {
        yield return [new TestData(0.01, 1_000_000, 0.0005)];
        yield return [new TestData(0.99, 1_000_000, 0.0005)];
    }

    public record TestData(double Bias, int Trials, double Tolerance)
    {
        public static double Expected => 0.5;
    }
}
