//Note too slow on edge cases
public class Solution {
    int value = 0;
    int pathCount = 0;

    public int ClimbStairs(int n) {
        CountPaths(value, n);
        return pathCount;
    }

    private void CountPaths(int value, int limit){
        if (value == limit) {
            pathCount++;
            return;
        }
        if (value + 1 <= limit){
            CountPaths(value + 1, limit);
        }
        if (value + 2 <= limit){
            CountPaths(value + 2, limit);
        }
    }
}