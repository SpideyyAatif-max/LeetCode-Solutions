public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++) {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            HashSet<int> seen = new HashSet<int>();
            for (int j = i + 1; j < nums.Length; j++) {
                int complement = -nums[i] - nums[j];
                if (seen.Contains(complement)) {
                    result.Add(new List<int> { nums[i], complement, nums[j] });
                    // Skip duplicates for the second element
                    while (j + 1 < nums.Length && nums[j] == nums[j + 1]) j++;
                }
                seen.Add(nums[j]);
            }
        }
        return result;
    }
}