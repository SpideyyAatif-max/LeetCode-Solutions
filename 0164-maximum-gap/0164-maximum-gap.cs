public class Solution {
    public int MaximumGap(int[] nums) {
        Array.Sort(nums);
        int current = 0;
        int max = 0;
        for(int i=1;i<nums.Length;i++)
        {
            current = Math.Abs(nums[i]-nums[i-1]);
            if(current>max)
            {
                max = current;
            }
        }
        return max;
    }
}