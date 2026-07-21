public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> records = new Dictionary<char,int>();
        Dictionary<char,int> Set = new Dictionary<char,int>();
        records.Add('I',1);
        records.Add('V',5);
        records.Add('X',10);
        records.Add('L',50);
        records.Add('C',100);
        records.Add('D',500);
        records.Add('M',1000);
        char[] arr = s.ToCharArray();
        int sum = 0;
        int k=0;
        for(int i=0;i<arr.Length;i++)
        {
            int current = records[arr[i]];
            if(i+1<s.Length && current < records[arr[i+1]])
            {
                sum -= current;
            }else{
                sum += current;
            }
        }
        return sum;
    }
}