https://leetcode.com/problems/reshape-the-matrix/?envType=study-plan&id=data-structure-i

public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        int n = mat.Length, m = mat[0].Length;
        if(n * m != r * c) return mat;
        int[][] newMat = new int[r][];
        for(int i = 0; i < r; i++) newMat[i] = new int[c];
        int _r = 0, _c = 0;
        for(int i = 0; i < n; i++) 
        {
            for(int j = 0; j < m; j++) 
            {
                if(_c == c)
                {
                    _r++;
                    _c = 0;
                }
                newMat[_r][_c] = mat[i][j];
                _c++;
            }
        }
        return newMat;
    }
}
