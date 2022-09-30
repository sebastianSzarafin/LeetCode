https://leetcode.com/problems/two-sum-iv-input-is-a-bst/?envType=study-plan&id=data-structure-i

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public List<int> Inorder(TreeNode root, List<int> route)
    {
        if(root == null) return null;
        Inorder(root.left, route);
        route.Add(root.val);
        Inorder(root.right, route);
        return route;
    }
    
    public bool TwoSum(int[] nums, int target) 
    {
         List<(int val, int index)> map = new List<(int, int)>();
         for(int i = 0; i < nums.Length; i++)
         {
             int i2 = map.FindIndex(t => t.val == target - nums[i]);
             if(i2 != -1) return true;
             else map.Add((nums[i], i));
         }
         return false;
     }
 
    public bool FindTarget(TreeNode root, int k) {
        List<int> route = new List<int>();
        Inorder(root, route);    
        return TwoSum(route.ToArray(), k);
    }
}
