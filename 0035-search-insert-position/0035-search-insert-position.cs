public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int count = 0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i] == target)
            {
                return i;
            }
            if(nums[i] < target)
            {
                count++;
            }
            else{
                return count;
            }
        }
        return nums.Length;
    }
}