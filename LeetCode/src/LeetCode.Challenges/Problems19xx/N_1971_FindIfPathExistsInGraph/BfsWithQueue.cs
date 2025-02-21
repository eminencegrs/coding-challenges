namespace LeetCode.Challenges.Problems19xx.N_1971_FindIfPathExistsInGraph;

public static class BfsWithQueue
{
    public static bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        if (source == destination)
        {
            return true;
        }

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

        var visited = new HashSet<int> { source };
        var queue = new Queue<int>();
        queue.Enqueue(source);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node == destination)
            {
                return true;
            }

            foreach (var neighbor in graph[node])
            {
                if (visited.Contains(neighbor))
                {
                    continue;
                }

                visited.Add(neighbor);
                queue.Enqueue(neighbor);
            }
        }

        return false;
    }
}
