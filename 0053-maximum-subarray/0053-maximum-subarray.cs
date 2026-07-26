public class Solution {
    public int MaxSubArray(int[] nums) {
        int currentsum = 0;
        int maxsum = nums[0];
        foreach(int x in nums)
        {
            currentsum+=x;
            if(currentsum>maxsum)
            {
                maxsum = currentsum;
            }
            if(currentsum<0)
            {
                currentsum = 0;
            }
        }
        return maxsum;
    }
}