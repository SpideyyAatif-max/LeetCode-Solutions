public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count = 0;
        int maxcount = 0;
        foreach(int x in nums)
        {
            if(x == 1)
            {
                count++;
            }else{
                count = 0;
            }
            maxcount = Math.Max(maxcount,count);
        }
        return maxcount;
    }
}