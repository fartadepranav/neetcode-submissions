public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++)
        {
            map[nums[i]] = i;
        }

        for(int i=0; i<nums.Length; i++)
        {
            int compliment = target - nums[i];
            if(map.ContainsKey(compliment) && map[compliment] != i)
            {
                return new int[]{i, map[compliment]};
            }
        }
        return new int[]{0,0};
    }
}
