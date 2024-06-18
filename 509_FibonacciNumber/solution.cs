// Time: 17 ms Beats 89.29%
// Memory 26.71 Mb Beats 76.65%
public class Solution {
    public int Fib(int n) {
        var sqrt5 = Math.Sqrt(5);
		var goldenRatio = (1 + sqrt5) / 2;
        return (int)((Math.Pow(goldenRatio, n) - Math.Pow(1-goldenRatio, n)) / sqrt5);
    }
}