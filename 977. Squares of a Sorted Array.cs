https://leetcode.com/problems/squares-of-a-sorted-array/?envType=study-plan&id=algorithm-i

public class Solution {
    public int[] SortedSquares(int[] nums) {
        int i = 0, j = nums.Length - 1;
            for(i = 0; i < nums.Length; i++) nums[i] = nums[i] * nums[i];
            List<int> numsSquared = new List<int>(nums);
            i = 0;
            while(i < j)
            {
                if(numsSquared[i] > numsSquared[j])
                {
                    numsSquared.Insert(j + 1, numsSquared[i]);
                    numsSquared.RemoveAt(i);
                }
                j--;
            }
        
            return numsSquared.ToArray();
        }
}
