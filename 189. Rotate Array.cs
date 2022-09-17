https://leetcode.com/problems/rotate-array/

public class Solution {
    // // Slower but with O(1) mem complexity
    // public void Rotate(int[] nums, int k) {
    //     int i = 0, n = nums.Length;
    //     while(i < k)
    //     {
    //         int last = nums[n - 1];
    //         for(int j = nums.Length - 1; j > 0; j--)
    //         {
    //             nums[j] = nums[j - 1];
    //         }
    //         nums[0] = last;
    //         i++;
    //     }
    // }
    
    // Faster but with O(n) mem complexity
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        int[] rotatedNums = new int[n];
        for(int i = 0; i < n; i++)
        {
            rotatedNums[(i + k) % n] = nums[i];
        }
        Array.Copy(rotatedNums, nums, n);
    }

}
