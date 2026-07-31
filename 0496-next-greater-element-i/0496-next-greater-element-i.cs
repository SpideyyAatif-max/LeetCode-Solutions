public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.Length];

        // Loop 1: Iterate through each element in nums1
        for (int i = 0; i < nums1.Length; i++) {
            int target = nums1[i];
            bool foundTarget = false;
            int nextGreater = -1;

            // Loop 2: Scan through nums2
            for (int j = 0; j < nums2.Length; j++) {
                // First, find the target element in nums2
                if (nums2[j] == target) {
                    foundTarget = true;
                }
                
                // Once found, look for the first element strictly greater than target
                if (foundTarget && nums2[j] > target) {
                    nextGreater = nums2[j];
                    break; // Stop at the first greater element
                }
            }

            result[i] = nextGreater;
        }

        return result;
    }
}