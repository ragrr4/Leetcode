public class Solution {
    public int Rob(int[] nums) {
        int a, b;
        a = b = 0; 
        for(int i = 0; i < nums.Length; i++) {
            if(i % 2 == 0){
                a += nums[i];
            }
            else {
                b += nums[i];
            }
        }
        if (a > b) {
            return a;
        }
        else {
            return b;
        }
    }
}
