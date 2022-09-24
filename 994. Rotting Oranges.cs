https://leetcode.com/problems/rotting-oranges/?envType=study-plan&id=algorithm-i

public class Solution {
public int OrangesRotting(int[][] grid) {
            int n = grid.Length, m = grid[0].Length;
            int fresh = 0, rotten = 0;
            Queue<(int i, int j)> Q = new Queue<(int, int)>();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(grid[i][j] == 1) fresh++;
                    if(grid[i][j] == 2) 
                    {
                        Q.Enqueue((i, j));
                        rotten++;
                    }
                }
            }
            int minutes = 0;
            while(fresh != 0)
            {
                minutes++;
                while(rotten != 0)
                {
                    (int i, int j) rO = Q.Dequeue();    
                    if(rO.i < n && rO.j  + 1 < m && grid[rO.i][rO.j + 1] == 1)
                    {
                        grid[rO.i][rO.j + 1] = 2;
                        fresh--;
                        Q.Enqueue((rO.i,rO.j + 1));
                    }
                    if(rO.i < n && rO.j  - 1 >= 0 && grid[rO.i][rO.j - 1] == 1)
                    {
                        grid[rO.i][rO.j - 1] = 2;
                        fresh--;
                        Q.Enqueue((rO.i, rO.j - 1));
                    }
                    if(rO.i + 1 < n && rO.j < m && grid[rO.i + 1][rO.j] == 1)
                    {
                        grid[rO.i + 1][rO.j] = 2;
                        fresh--;
                        Q.Enqueue((rO.i + 1, rO.j));
                    }
                    if(rO.i - 1 >= 0 && rO.j < m && grid[rO.i - 1][rO.j] == 1)
                    {
                        grid[rO.i - 1][rO.j] = 2;
                        fresh--;
                        Q.Enqueue((rO.i - 1, rO.j));
                    }
                    if(fresh == 0) return minutes;
                    rotten--;
                }
                rotten = Q.Count;
                if(rotten == 0) return -1;
            }
            return minutes;
        }
}
