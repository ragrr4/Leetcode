// RT: 1ms beats 99.04; Mem: 49.19
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new();
        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (map.ContainsKey(diff))
            {
                return [i, map[diff]];
            }
            map[nums[i]] = i;
        }
        return [];
    }
}