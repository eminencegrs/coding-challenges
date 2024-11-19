namespace LeetCode.Challenges.Problems17xx.N_1791_FindCenterOfStarGraph;

public static class BruteForceSolution
{
    public static int FindCenter(int[][] edges)
    {
        var graph = new Dictionary<int, List<int>>();
        foreach (var edge in edges)
        {
            if (!graph.ContainsKey(edge[0]))
            {
                graph[edge[0]] = [];
            }

            if (!graph.ContainsKey(edge[1]))
            {
                graph[edge[1]] = [];
            }

            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        var nodes = graph.Keys.ToArray();

        foreach (var node in graph)
        {
            if (node.Value.Count < 2)
            {
                continue;
            }

            var except = nodes.Except(node.Value).ToList();
            if (except.Count == 1 && except.First() == node.Key)
            {
                return node.Key;
            }
        }

        throw new InvalidOperationException("The graph is not a star.");
    }
}
