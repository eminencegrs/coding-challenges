using System.Collections;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M11.Day18;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return ["10", true];
        yield return ["-10", true];
        yield return ["10.1", true];
        yield return ["-10.1", true];
        yield return ["1e5", true];
        yield return ["-1e-5", true];
        yield return [".5", true];
        yield return ["3.", true];
        yield return ["0.1", true];

        yield return ["a", false];
        yield return ["x 1", false];
        yield return ["a -2", false];
        yield return ["-", false];
        yield return ["1e", false];
        yield return ["1..1", false];
        yield return ["e5", false];
        yield return [".", false];
        yield return ["", false];
        yield return ["   ", false];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
