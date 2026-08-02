using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> matrix = new List<IList<int>>();

        for (int i = 0; i < numRows; i++) {
            List<int> row = new List<int>();

            for (int j = 0; j <= i; j++) {
                // First and last elements of each row are always 1
                if (j == 0 || j == i) {
                    row.Add(1);
                } else {
                    // Sum of the two numbers directly above it
                    int val = matrix[i - 1][j - 1] + matrix[i - 1][j];
                    row.Add(val);
                }
            }

            matrix.Add(row);
        }

        return matrix;
    }
}