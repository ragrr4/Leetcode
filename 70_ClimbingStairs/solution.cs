// Time: 14 ms Beats 92.29%
// Memory 26.85 Mb Beats 53.21
public class Solution {
    public int ClimbStairs(int n) {
        n++;
		var sqrt5 = Math.Sqrt(5);
		var goldenRatio = (1 + sqrt5) / 2;
        return (int)((Math.Pow(goldenRatio, n) - Math.Pow(1-goldenRatio, n)) / sqrt5);
    }
}