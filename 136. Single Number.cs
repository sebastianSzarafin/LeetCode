https://leetcode.com/problems/single-number/?envType=study-plan&id=algorithm-i

public class Solution {
    public int SingleNumber(int[] nums) {
        int a = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            a ^= nums[i];
        }
        return a;
    }
}
