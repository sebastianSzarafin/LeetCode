https://leetcode.com/problems/binary-search/

public class Solution {
    public int Search(int[] nums, int target) {
        int start = 0, end = nums.Length - 1, middle = (start + end)/2;
        while(start < end && target != nums[middle])
        {
            if(target < nums[middle])
            {
                end = middle - 1;
            }
            else
            {
                start = middle + 1;
            }
            middle = (start + end)/2;
        }
        
        if(target == nums[middle]) return middle;
        else return -1;
    }
}
