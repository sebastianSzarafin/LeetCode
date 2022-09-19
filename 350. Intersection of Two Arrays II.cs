https://leetcode.com/problems/intersection-of-two-arrays-ii/?envType=study-plan&id=data-structure-i

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        int[] map = new int[1001];
        for(int i = 0; i < nums2.Length; i++) map[nums2[i]]++;
        List<int> inters = new List<int>();
        for(int i = 0; i < nums1.Length; i++) 
        {
            if(map[nums1[i]] > 0)
            {
                inters.Add(nums1[i]);
                map[nums1[i]]--;
            }
        }
        return inters.ToArray();
    }
}
