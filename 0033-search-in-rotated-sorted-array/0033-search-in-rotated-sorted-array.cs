public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right) 
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target) 
            {
                return mid;
            }

            // Left half is sorted
            if (nums[left] <= nums[mid]) 
            {
                // Notice the <= on both sides: nums[left] <= target AND target <= nums[mid]
                if (nums[left] <= target && target <= nums[mid]) 
                {
                    right = mid - 1;
                } 
                else 
                {
                    left = mid + 1;
                }
            } 
            // Right half is sorted
            else 
            {
                // Notice the <= on both sides: nums[mid] <= target AND target <= nums[right]
                if (nums[mid] <= target && target <= nums[right]) 
                {
                    left = mid + 1;
                } 
                else 
                {
                    right = mid - 1;
                }
            }
        }
        return -1;
    }
}