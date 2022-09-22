https://leetcode.com/problems/max-area-of-island/?envType=study-plan&id=algorithm-i

public class Solution {
    public int CountArea(int[][] grid, int w, int h, int area)
    {
        if(!(w >= 0 && w < grid.Length && h >= 0 && h < grid[0].Length)) 
            return area;
        if(grid[w][h] == 0) return area;
        grid[w][h] = 0;
        area++;
        area = CountArea(grid, w + 1, h, area);
        area = CountArea(grid, w - 1, h, area);
        area = CountArea(grid, w, h + 1, area);
        area = CountArea(grid, w, h - 1, area);
        return area;
    }
    
    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                int area;
                if(grid[i][j] == 1) 
                {
                    area = CountArea(grid, i, j, 0);
                    if(area > maxArea) maxArea = area;
                }
            }
        }
        return maxArea;
    }
}
