https://leetcode.com/problems/binary-tree-inorder-traversal/?envType=study-plan&id=data-structure-i

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
    public IList<int> InorderTraversal(TreeNode root) {
        if(root == null) return route;
        InorderTraversal(root.left);
        route.Add(root.val);
        InorderTraversal(root.right);
        return route;
    }
}
