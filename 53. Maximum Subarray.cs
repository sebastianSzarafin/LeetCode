https://leetcode.com/problems/maximum-subarray/?envType=study-plan&id=data-structure-i

public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums.Length == 1) return nums[0];
        int sum = Int32.MinValue / 2;
        for(int i = 0; i < nums.Length; i++)
        {
            if(sum < 0 && nums[i] > 0) sum = nums[i];
            else if(sum + nums[i] > 0) sum += nums[i];
            else if(sum < nums[i]) sum = nums[i];
            else sum = Int32.MinValue / 2;
            if(sum > maxSum) maxSum = sum;
        }
        return maxSum;
    }
    
    
}
