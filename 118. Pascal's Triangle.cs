https://leetcode.com/problems/pascals-triangle/?envType=study-plan&id=data-structure-i

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> pascal = new List<IList<int>>();
        if(numRows == 0) return pascal;
        pascal.Add(new List<int>() {1});
        if(numRows == 1) return pascal; 
        pascal.Add(new List<int>() {1, 1});
        int n = 2;
        while(n < numRows)
        {
            List<int> row = new List<int>(n + 1);
            row.Add(1);
            for(int i = 1; i < n; i++)
            {
                row.Add(pascal[n - 1][i - 1] + pascal[n - 1][i]);
            }
            row.Add(1);
            pascal.Add(row);
            n++;
        }
        return pascal;
    }
}
