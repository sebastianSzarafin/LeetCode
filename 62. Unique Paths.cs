https://leetcode.com/problems/unique-paths/?envType=study-plan&id=level-1

public class Solution {
    public int UniquePaths(int m, int n) {
        if(m <= 1 || n <= 1) return 1;
        int[,] tab = new int[m,n];
        tab[1,1] = 2;
        for(int i = 1; i < n; i++) tab[0,i] = 1;
        for(int i = 1; i < m; i++) tab[i,0] = 1;
        for(int i = 1; i < m; i++) 
        {
            for(int j = 1; j < n; j++)
            {
                tab[i,j] = tab[i-1,j] + tab[i,j-1];
            }
        }
        return tab[m-1,n-1];
    }
}
