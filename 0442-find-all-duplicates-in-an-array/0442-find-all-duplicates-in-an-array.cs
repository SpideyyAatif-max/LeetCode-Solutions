public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach(int num in nums)
        {
            if(map.ContainsKey(num))
            {
                map[num]++;
            }else{
                map[num] = 1;
            }
        }
        List<int> enlist = new List<int>();
        foreach(var x in map)
        {
            if(x.Value == 2)
            {
                enlist.Add(x.Key);
            }
        }
        return enlist;
    }
}