https://leetcode.com/problems/binary-tree-preorder-traversal/?envType=study-plan&id=data-structure-i

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
    public List<int> route = new List<int>();
    public IList<int> PreorderTraversal(TreeNode root) {
        if(root == null) return route;
        route.Add(root.val);        
        PreorderTraversal(root.left);        
        PreorderTraversal(root.right);
        return route;
    }
}
