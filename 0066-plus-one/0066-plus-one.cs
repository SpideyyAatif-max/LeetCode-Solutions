public class Solution {
    public int[] PlusOne(int[] digits) {
        // Iterate from the last digit to the first
        for (int i = digits.Length - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i] += 1;
                return digits; // No carry needed, return updated array
            }
            
            digits[i] = 0; // Carry over to the next digit
        }

        // If the loop completes, all digits were 9 (e.g., 999 -> 1000)
        int[] newarr = new int[digits.Length + 1];
        newarr[0] = 1; // Default C# int array elements are already 0
        return newarr;
    }
}