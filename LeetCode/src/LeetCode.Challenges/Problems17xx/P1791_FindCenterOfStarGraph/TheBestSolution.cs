namespace LeetCode.Challenges.Problems17xx.P1791_FindCenterOfStarGraph;

// Time Complexity: O(1).
// Space Complexity: O(1).
public static class TheBestSolution
{
    public static int FindCenter(int[][] edges)
    {
        // Check the source node of the 1st edge - edges[0][0]:
        // -- If it appears in the 2nd edge as a source or destination node (edges[1][0] or edges[1][1]),
        //    then `edges[0][0]` is the center of the star graph.
        // -- Otherwise, the destination node of the 1st edge (`edges[0][1]`) is the center of the star graph.
        return edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1]
            ? edges[0][0]
            : edges[0][1];
    }
}
