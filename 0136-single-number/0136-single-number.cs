public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int,int> book = new Dictionary<int,int>();
        foreach(int num in nums)
        {
            if(book.ContainsKey(num))
            {
                book[num]++;
            }else{
                book[num] = 1;
            }
        }
        foreach(var item in book)
        {
            if(item.Value == 1)
            {
                return item.Key;
            }
        }
        return -1;
    }
}