https://leetcode.com/problems/house-robber/?envType=study-plan&id=algorithm-i

public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 1) return nums[0];
        int[] profit = new int[nums.Length];
        bool[] robbed = new bool[nums.Length];
        profit[0] = nums[0];
        if(nums[1] > nums[0])
        {
            profit[1] = nums[1];
            robbed[1] = true;
        }
        else
        {
            profit[1] = nums[0];
            robbed[0] = true;
        }
        for(int i = 2; i < nums.Length; i++)
        {
            if(!robbed[i - 1]) 
            {
                profit[i] = profit[i - 1] + nums[i];
                robbed[i] = true;
            }
            else if(nums[i] > nums[i - 1]) 
            {
                robbed[i - 1] = false;
                robbed[i] = true;
                profit[i] = profit[i - 2] + nums[i];
            }
            else
            {
                if(profit[i - 1] > profit[i - 2] + nums[i])
                {
                    profit[i] = profit[i - 1];
                }
                else
                {
                    profit[i] = profit[i - 2] + nums[i];
                    robbed[i] = true;
                    robbed[i - 1] = false;
                }
            }
        }
        return profit[profit.Length - 1];
    }
}
