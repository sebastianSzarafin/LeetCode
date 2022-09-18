https://leetcode.com/problems/move-zeroes/

public class Solution {
    public void MoveZeroes(int[] nums) {
        int nonzeros = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0)
            {
                nums[nonzeros] = nums[i];
                nonzeros++;
            }
        }
        for(int i = nonzeros; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}


// alteriative solution
// public class Solution {
//      public void MoveZeroes(int[] nums) {
//         int zeros = 0;
//         for(int i = 0; i < nums.Length - zeros; i++)
//         {
//             if(nums[i] == 0)
//             {
//                 for(int j = i; j < nums.Length - zeros - 1; j++)
//                 {
//                     (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
//                 }
//                 zeros++;
//                 i--;
//             }
//         }
//     }
// }
