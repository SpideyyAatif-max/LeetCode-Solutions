public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> records = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            int complement = target - nums[i];
            if(records.ContainsKey(complement))
            {
                return new int[] {records[complement],i};
            }
            if(!records.ContainsKey(nums[i]))
            {
                records.Add(nums[i],i);
            }
        }
        return new int[]{-1,-1};
    }
}