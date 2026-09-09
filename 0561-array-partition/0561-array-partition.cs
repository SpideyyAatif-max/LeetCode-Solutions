public class Solution {
    public int ArrayPairSum(int[] nums) {
        // Step 1: Sort the array in ascending order
        Array.Sort(nums);
        int maxSum = 0;
        // Step 2: Sum every element at even indices (0, 2, 4, ...)
        for (int i = 0; i < nums.Length; i += 2) {
            maxSum += nums[i];
        }
        return maxSum;
    }
}