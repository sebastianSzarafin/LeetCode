https://leetcode.com/problems/triangle/?envType=study-plan&id=algorithm-i

public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
                List<List<int>> sum = new List<List<int>>();
                sum.Add(new List<int>());
                sum[0].Add(triangle[0][0]);
                for(int i = 1; i < triangle.Count; i++)
                {
                    sum.Add(new List<int>());
                    for(int j = 0; j < triangle[i].Count; j++)
                    {
                        if(j == 0) 
                        {
                            sum[i].Add(triangle[i][j] + sum[i - 1][j]);
                        }
                        else if(j == triangle[i].Count - 1)
                        {
                            sum[i].Add(triangle[i][j] + sum[i - 1][j - 1]);
                        }
                        else
                        {                            
                            sum[i].Add(Math.Min(triangle[i][j] + sum[i - 1][j - 1], 
                                triangle[i][j] + sum[i - 1][j]));   
                        }
                    }
                }

                return sum[sum.Count - 1].Min();
            }
}
