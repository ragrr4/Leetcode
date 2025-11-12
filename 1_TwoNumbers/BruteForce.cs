public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++)
        {
            int remain = target - nums[i];
            for(int j = i + 1; j < nums.Length; j++) 
            {
                if(nums[j] == remain)
                {
                    return [i,j];
                }
            }
        }
        return [];
    }
}