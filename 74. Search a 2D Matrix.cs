https://leetcode.com/problems/search-a-2d-matrix/?envType=study-plan&id=data-structure-i

public class Solution {
    public int BinarySearch(int[] nums, int target) {
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
    
    public bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix.Length, m = matrix[0].Length, row = 0;
        while(row < n && matrix[row][m - 1] < target) row++;
        if(row == n || BinarySearch(matrix[row], target) == -1) return false;
        return true;
    }
}
