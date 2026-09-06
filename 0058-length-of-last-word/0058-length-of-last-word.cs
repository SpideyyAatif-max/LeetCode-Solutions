public class Solution {
    public int LengthOfLastWord(string s) {
        // StringSplitOptions.RemoveEmptyEntries ignores extra/trailing spaces automatically
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        // Return length of the last word in the array
        return words[words.Length - 1].Length;
    }
}