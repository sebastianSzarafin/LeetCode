https://leetcode.com/problems/permutations/?envType=study-plan&id=algorithm-i

public class Solution {
    public List<IList<int>> permutations = new List<IList<int>>();
    public void GeneratePermutations(int k, int[] perm, int[] nums, bool[] used)
    {
        if(k == nums.Length)
        {
            permutations.Add(perm.ToList());
            return;
        }
        for(int m = 0; m < nums.Length; m++)
        {
            if(!used[m])
            {
                used[m] = true;
                perm[k] = nums[m];
                GeneratePermutations(k + 1, perm, nums, used);
                used[m] = false;
            }
        }
    }
    
    public IList<IList<int>> Permute(int[] nums) {
        int[] perm = new int[nums.Length];
        bool[] used = new bool[nums.Length];
        GeneratePermutations(0, perm, nums, used);
        return permutations;
    }
}
