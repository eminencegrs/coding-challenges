namespace HackerRank.BasicProblemSolvingCert;

public static class MaxCostProblem
{
    public static int Solve(List<int> cost, List<string> labels, int dailyCount)
    {
        var tempCost = 0;
        var tempCount = 0;
        var maxCost = 0;

        for (var i = 0; i < cost.Count; i++)
        {
            if (tempCount == dailyCount)
            {
                maxCost = Math.Max(maxCost, tempCost);
                tempCost = 0;
                tempCount = 0;
            }

            if (labels[i] == "illegal")
            {
                tempCost += cost[i];
            }
            else
            {
                tempCost += cost[i];
                tempCount++;
            }
        }

        return maxCost;
    }
}
