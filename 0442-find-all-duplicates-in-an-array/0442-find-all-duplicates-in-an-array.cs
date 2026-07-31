public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        List<int> enlist = new List<int>();
        foreach(int num in nums)
        {
            if(!set.Add(num))
            {
                enlist.Add(num);
            }
        }
        return enlist;
    }
}