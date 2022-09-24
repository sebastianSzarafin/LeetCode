https://leetcode.com/problems/01-matrix/?envType=study-plan&id=algorithm-i

public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        List<(int i, int j)> zeros = new List<(int, int)>();
        int[][] tab = new int[mat.Length][];
        for(int i = 0; i < mat.Length; i++)
        {
            tab[i] = new int[mat[i].Length];
            for(int j = 0; j < mat[0].Length; j++)
            {
                if(mat[i][j] == 0) zeros.Add((i, j));
            }
        }
        for(int i = 0; i < mat.Length; i++)
        {
            for(int j = 0; j < mat[0].Length; j++)
            {
                if(mat[i][j] == 0) tab[i][j] = 0;
                else
                {
                    int minLen = Int32.MaxValue;
                    foreach(var zero in zeros)
                    {
                        int len = Math.Abs(zero.i - i) + Math.Abs(zero.j - j);
                        if(minLen > len) minLen = len;
                    }
                    tab[i][j] = minLen;
                }
            }
        }
        return tab;
    }
}
