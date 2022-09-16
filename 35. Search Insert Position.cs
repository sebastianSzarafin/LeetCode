https://leetcode.com/problems/search-insert-position/

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int start = 0, end = nums.Length - 1, middle = (start + end)/2;
        if(target > nums[end]) return end + 1;
        if(target < nums[start]) return start;
        while(start < end && target != nums[middle])
        {
            if(middle - 1 >= 0 && 
               target > nums[middle - 1] && 
               target < nums[middle])
            {
                return middle;
            }
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
        
        return middle;
    }
}
