// Time: 14 ms Beats 95.20%
// Memory 26.90 Mb Beats 60.18%
public class Solution {
    public int Tribonacci(int n) {
        int t1, t2, t3, res;
        t1 = t2 = res = 0;
        t3 = 1;
        if (n == 1) { 
            return 1;
        }
        for (int i = 1; i < n; i++) {
            res = t1 + t2 + t3;
            t1 = t2;
            t2 = t3;
            t3 = res; 
        }
        return res;
    }
}