https://leetcode.com/problems/valid-sudoku/?envType=study-plan&id=data-structure-i

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int[] hashR = new int[10];
        int[] hashC = new int[10];
        
        for(int i = 0; i < board.Length; i++)
        {
            Array.Clear(hashR, 0, hashR.Length);
            Array.Clear(hashC, 0, hashC.Length);
            for(int j = 0; j < board[0].Length; j++)
            {
                if(board[i][j] != '.' && hashR[board[i][j] - '0'] > 0) return false;
                if(board[i][j] != '.') hashR[board[i][j] - '0']++;
                
                if(board[j][i] != '.' && hashC[board[j][i] - '0'] > 0) return false;
                if(board[j][i] != '.') hashC[board[j][i] - '0']++;
            }
        }
        
        int[] hashSB = new int[10];
        int _i = 0, _j = 0, k = 0;
        while(k++ < 81)
        {
            if(board[_i][_j] != '.' && hashSB[board[_i][_j] - '0'] > 0) 
                    return false;
            if(board[_i][_j] != '.') hashSB[board[_i][_j] - '0']++;
            if((_j + 1) % 3 != 0) _j++;
            else if((_i + 1) % 3 != 0 && (_j + 1) % 3 == 0)
            {
                _i++;
                _j -= 2;
            }
            else
            {
                Array.Clear(hashSB, 0, hashSB.Length);
                if((_i + 1) % 3 == 0 && (_j + 1) % 9 == 0)
                {
                    _i++;
                    _j = 0;
                }
                else
                {
                    _i -= 2;
                    _j++;   
                }
            }
        }
        
        return true;
    }
}
