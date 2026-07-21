public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)
        {
            return false;
        }
        List<int> arr = new List<int>();
        int pop;
        while(x!=0)
        {
            pop = x % 10;
            x/=10;
            arr.Add(pop);
        }
        int[] anotherarr = arr.ToArray();
        for(int i=0;i<anotherarr.Length;i++)
        {
            if(anotherarr[i]!=anotherarr[anotherarr.Length-1-i])
            {
                return false;
            }
        }
        return true;
}}