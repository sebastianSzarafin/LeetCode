https://leetcode.com/problems/path-sum/?envType=study-plan&id=data-structure-i

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
    public bool FindSum(TreeNode root, int sum, int targetSum)
    {
        if(root == null) return false;
        if(root.left == null && root.right == null) 
            return sum + root.val == targetSum;
        
        return FindSum(root.left, sum + root.val, targetSum) ||
            FindSum(root.right, sum + root.val, targetSum);
    }
    
    public bool HasPathSum(TreeNode root, int targetSum) {
        return FindSum(root, 0, targetSum);
    }
}
