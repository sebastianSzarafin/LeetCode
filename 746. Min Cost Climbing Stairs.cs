https://leetcode.com/problems/min-cost-climbing-stairs/?envType=study-plan&id=level-1

public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;
        int[] tab = new int[n + 1];
        tab[0] = cost[0];
        tab[1] = cost[1];
        for(int i = 2; i < n; i++)
        {
            tab[i] = tab[i - 1] > tab[i - 2] ? 
                tab[i - 2] + cost[i] : tab[i - 1] + cost[i];
        }
        tab[n] = tab[n - 1] > tab[n - 2] ? tab[n - 2] : tab[n - 1];
        return tab[cost.Length];
    }
}
