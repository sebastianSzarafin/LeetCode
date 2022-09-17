https://leetcode.com/problems/contains-duplicate/?envType=study-plan&id=data-structure-i

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(d.ContainsKey(nums[i])) d[nums[i]]++;
            else d.Add(nums[i], 1);
        }
        foreach(var item in d)
        {
            if(item.Value >= 2) return true;
        }
        return false;
    }
}
