public class Solution {
    int currentMin = 2147483647; // MAX int value
    private Dictionary<string, int> stairValue = [];
    public int MinCostClimbingStairs(int[] cost)
    {
        // Set initiall cases
        stairValue.Add("1",cost[0]);
        stairValue.Add("2", cost[1]);
        SearchSolutions(cost, -1, "");
        return currentMin;
    }
    private int GetCost(int[] array, int i, string path)
    {
        int cost;
        if (path == "")
        {
            return 0;
        }
        if (!stairValue.ContainsKey(path))
        {
            int currPos = array[i];
            i -= (int)char.GetNumericValue(path[^1]);
            cost = GetCost(array, i, path[..^1]) + currPos;
            if (cost < currentMin){
                stairValue.Add(path, cost);
            }
            return cost;
        }
        return stairValue[path];
    }

    private void SearchSolutions(int[] array, int i, string path)
    {
        int cost = GetCost(array, i, path);
        if (cost > currentMin)
        {
            return;
        }
        if (i >= array.Length - 2)
        {
            if (cost < currentMin)
            {
                currentMin = cost;
            }
            return;
        }
        SearchSolutions(array, i + 1, path + "1");
        SearchSolutions(array, i + 2, path + "2");
    }
}