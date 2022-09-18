https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/

public class Solution {
    public int BinarySearch(int[] numbers, int start, int end, int target)
        {
            int mid = -1;
            while(start <= end)
            {
                mid = start + (end - start) / 2;
                if(numbers[mid] == target) return mid;
                if(numbers[mid] < target) start = mid + 1;
                else end = mid - 1;
            }
            return -1;
        }
    
    public int[] TwoSum(int[] numbers, int target) {
        for(int i = 0; i < numbers.Length - 1; i++)
        {
            int i2 = BinarySearch(numbers, i + 1, numbers.Length - 1, target - numbers[i]);
            if(i2 != -1) return new [] {i + 1, i2 + 1};
        }
        return new [] {-1,-1};
    }
}
