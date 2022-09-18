https://leetcode.com/problems/two-sum/?envType=study-plan&id=data-structure-i

public class Solution {
    public int BinarySearch(int[] nums, int start, int end, int target) {
        int middle = (start + end)/2;
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
    
    public int[] Fun(int[] numsSorted, int[] nums, int n, int i, int _i)
    {
        int i1 = -1, i2 = -1;
        for(int j = 0; j < n; j++) 
            if(nums[j] == numsSorted[i]) 
            {
                i1 = j;
                break;
            }
        for(int j = 0; j < n; j++) if(nums[j] == numsSorted[_i]) i2 = j;
        return new [] {i1, i2};
    }
    
    public int[] TwoSum(int[] nums, int target) {
        int n = nums.Length, _i;
        int[] numsSorted = new int[n];
        Array.Copy(nums, numsSorted, n);
        Array.Sort(numsSorted);
        for(int i = 0; i < n; i++)
        {
            if(target - numsSorted[i] > numsSorted[i]) 
            {
                _i = BinarySearch(numsSorted, i + 1, n - 1, target - numsSorted[i]);
                if(_i != -1) return Fun(numsSorted, nums, n, i, _i);
            }
            else
            {
                _i = BinarySearch(numsSorted, 0, i - 1, target - numsSorted[i]);
                if(_i != -1) return Fun(numsSorted, nums, n, i, _i);
            }
        }
        return null;
    }
}



// alteriative solution
// public class Solution {
//     public int[] TwoSum(int[] nums, int target) {
//         List<(int val, int index)> map = new List<(int, int)>();
//         for(int i = 0; i < nums.Length; i++)
//         {
//             int i2 = map.FindIndex(t => t.val == target - nums[i]);
//             if(i2 != -1) return new [] {i, map[i2].index};
//             else map.Add((nums[i], i));
//         }
//         return null;
//     }
// }


