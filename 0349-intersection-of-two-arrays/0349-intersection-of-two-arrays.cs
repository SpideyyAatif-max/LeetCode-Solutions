using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> resultSet = new HashSet<int>();

        foreach (int num in nums2) {
            if (set1.Contains(num)) {
                resultSet.Add(num);
            }
        }

        return resultSet.ToArray();
    }
}