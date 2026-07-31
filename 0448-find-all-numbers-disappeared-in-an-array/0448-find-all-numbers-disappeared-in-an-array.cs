public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        List<int> enlist = new List<int>();
        for(int i=1;i<=nums.Length;i++)
        {
            if(!set.Contains(i))
            {
                enlist.Add(i);
            }
        }
        return enlist;
    }
}