namespace HackerRank.Week1;

public class PermutingTwoArrays
{
    // The issue description:
    //     There are two n-element arrays of integers, A and B. Permute them into some A' and B' such that
    //     the relation A'[i] + B'[i] >= k holds for all i where 0 <= i <= n.
    //     There will be q queries consisting of A, B, and k.
    //     For each query, return YES if some permutation A', B' satisfying the relation exists.
    //     Otherwise, return NO.

    public string CheckIfSatisfyTheRelationV3(int k, List<int> first, List<int> second)
    {
        // The algorithm time complexity (Big O).
        //
        // 1. Sorting:
        //    Both the `first` and `second` lists are sorted. The sorting operation has a time complexity of O(n log n)
        //    for each list. Since there are two lists, the overall time complexity for sorting is O(2n log n),
        //    but the constant factor is typically dropped in big O notation, so we express it as O(n log n).
        // 2. Iteration and Comparison:
        //    - The `Where` method is used to filter elements based on the condition `t + second[i] < k`.
        //    - The condition is checked for each element in the `first` list, and the corresponding element in the `second` list.
        //    - This operation has a time complexity of O(n) because each element is checked once.
        // 3. Any() Method:
        //    - The `Any` method is used to determine if there are any elements that satisfy the condition.
        //    - The time complexity of `Any` is O(n) in the worst case, as it needs to iterate through the filtered elements
        //      to check if any element satisfies the condition.
        // 4. Overall Time Complexity:
        //    - The dominant factor in terms of time complexity is the sorting step, which is O(n log n).
        //    - The filtering, comparison, and `Any` method contribute additional linear time complexities,
        //      but they are dominated by the sorting step.
        //    - Therefore, the overall time complexity is O(n log n).
        //
        // To sum up:
        //    The algorithm has a time complexity of O(n log n) due to the sorting operations.
        //    The subsequent iteration, filtering, and comparison steps contribute additional linear time complexities,
        //    but they do not change the overall big O notation.
        
        first.Sort();
        second.Sort((a, b) => b.CompareTo(a));
        return first.Where((t, i) => t + second[i] < k).Any() ? "NO" : "YES";
    }

    public string CheckIfSatisfyTheRelationV2(int k, List<int> first, List<int> second)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(k, 1, nameof(k));
        ArgumentOutOfRangeException.ThrowIfNotEqual(first.Count, second.Count, $"{nameof(first)} and/or {nameof(second)}");

        var maxPermutations = CalculateFactorial(first.Count);
        for (var iteration = 1; iteration <= maxPermutations; iteration++)
        {
            var stack = new Stack<KeyValuePair<int, int>>();
            for (var i = 0; i < first.Count; i++)
            {
                if (first[i] + second[i] < k)
                {
                    MoveArrayRight(second);
                    break;
                }

                stack.Push(new KeyValuePair<int, int>(first[i], second[i]));
            }

            if (stack.Count == first.Count)
            {
                return "YES";
            }
        }

        return "NO";
    }

    public string CheckIfSatisfyTheRelationV1(int k, List<int> first, List<int> second)
    {
        var stack = new Stack<KeyValuePair<int, int>>();
        var iteration = 0;
        var maxPermutations = CalculateFactorial(first.Count);
        while (true)
        {
            iteration++;
            for (var i = 0; i < first.Count; i++)
            {
                if (first[i] + second[i] >= k)
                {
                    stack.Push(new KeyValuePair<int, int>(first[i], second[i]));
                }
                else
                {
                    stack.Clear();
                    break;
                }
            }

            if (stack.Count == first.Count)
            {
                break;
            }

            if (iteration >= maxPermutations)
            {
                return "NO";
            }

            MoveArrayRight(second);
        }

        return "YES";
    }

    private static long CalculateFactorial(int n)
    {
        long factorial = 1;
        for (var x = 1; x <= n; x++)
        {
            factorial *= x;
        }

        return factorial * factorial;
    }

    private static void MoveArrayRight(List<int> array)
    {
        var lastElement = array[^1];
        for (var i = array.Count - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }

        array[0] = lastElement;
    }

    private static void MoveArrayLeft(List<int> array)
    {
        var firstElement = array[0];
        for (var i = 0; i < array.Count - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[^1] = firstElement;
    }
}
