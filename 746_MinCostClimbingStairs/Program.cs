//RT: 0ms beats 100%, Memory: 43.25MB beats 74.56%
public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int[] stairCost = new int[cost.Length];
        stairCost[0] = cost[0];
        stairCost[1] = cost[1];
        for (int i = 2; i < cost.Length; i++)
        {
            stairCost[i] = cost[i] + Math.Min(stairCost[i - 1], stairCost[i - 2]);
        }
        return Math.Min(stairCost[cost.Length - 1], stairCost[cost.Length - 2]);
    }
}