public class Solution {
    public int MinMoves(int[] nums) {
        //formula is sum - (min * n)
        int sum = 0;
        foreach(int x in nums)
        {
            sum+=x;
        }
        int min = nums[0];
        foreach(int x in nums)
        {
            if(x<min)
            {
                min = x;
            }
        }
        return sum - (nums.Length * min);
    }
}