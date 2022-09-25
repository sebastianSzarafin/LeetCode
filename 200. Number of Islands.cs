https://leetcode.com/problems/number-of-islands/?envType=study-plan&id=level-1

public class Solution {
    public void MarkIsland(char[][] grid, int w, int h)
    {
        if(!(w >= 0 && w < grid.Length && h >= 0 && h < grid[0].Length)) 
            return;
        if(grid[w][h] == '0') return;
        grid[w][h] = '0';
        MarkIsland(grid, w + 1, h);
        MarkIsland(grid, w - 1, h);
        MarkIsland(grid, w, h + 1);
        MarkIsland(grid, w, h - 1);
    }
    
    public int NumIslands(char[][] grid) {
        int islandCount = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == '1') 
                {
                    islandCount++;
                    MarkIsland(grid, i, j);
                }
            }
        }
        return islandCount;
    }
}
