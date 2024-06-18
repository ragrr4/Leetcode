//Note too slow on edge cases
public class Solution {

    List<int> solutions = new List<int>();
    int currentMin = 2147483647; // MAX int value

    public int MinCostClimbingStairs(int[] cost) {
        SearchSolutions(cost, -1, 0);
        return currentMin;
    }

    private void SearchSolutions(int[] array, int i, int cost) {
        if (cost > currentMin) {
            return;
        }
        if(i >= array.Length -2) {
            if (cost < currentMin){
                currentMin = cost;
            }
            return;
        }
        int newCost = cost + array[i + 1];
        SearchSolutions(array, i + 1, newCost);
        newCost = cost + array[i + 2];
        SearchSolutions(array, i + 2, newCost);
    }
}