using System.Collections;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M10.Day13;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        // Zero dividend.
        yield return [0, 10, 0];

        // Divisor of 1.
        yield return [10, 1, 10];

        // General case.
        yield return [10, 3, 3];

        // Dividend equals divisor.
        yield return [5, 5, 1];

        // Divisor > dividend.
        yield return [2, 10, 0];

        // Larger numbers.
        yield return [100, 5, 20];
        yield return [1000, 10, 100];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
