https://leetcode.com/problems/find-pivot-index/?envType=study-plan&id=level-1

public class Solution {
    public int PivotIndex(int[] nums) {
        int pivot = 0, leftSum = 0, rightSum = nums.Sum() - nums[pivot];
        while(leftSum != rightSum)
        {
            leftSum += nums[pivot];
            if(++pivot == nums.Length) break;
            rightSum -= nums[pivot];
        }
        if(pivot < nums.Length) return pivot;
        else return -1;
    }
}
