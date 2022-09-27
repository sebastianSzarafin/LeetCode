https://leetcode.com/problems/maximum-depth-of-binary-tree/?envType=study-plan&id=data-structure-i

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
    public int SearchForMaxDepth(TreeNode root, int depth)
    {
        if(root == null) return depth;
        depth = 1 + Math.Max(
            SearchForMaxDepth(root.left, depth), 
            SearchForMaxDepth(root.right, depth));
        return depth;
    }
    
    public int MaxDepth(TreeNode root) {
        return SearchForMaxDepth(root, 0);
    }
}
