https://leetcode.com/problems/symmetric-tree/?envType=study-plan&id=data-structure-i

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
    public bool IsSymmetric(TreeNode root) {
        if(root == null || (root.left == null && root.right == null)) return true;
        if(root.left == null ^ root.right == null) return false;
        Stack<TreeNode> S1 = new Stack<TreeNode>();
        Stack<TreeNode> S2 = new Stack<TreeNode>();
        S1.Push(root.left);
        S2.Push(root.right);
        while(S1.Count > 0 && S2.Count > 0)
        {
            TreeNode p1 = S1.Pop();
            TreeNode p2 = S2.Pop();
            
            if(p1.val != p2.val) return false;
            if(!((p1.left != null && p2.right != null) || 
               (p1.left == null && p2.right == null))) return false;
            else if(p1.left != null && p2.right != null)
            {
                S1.Push(p1.left);
                S2.Push(p2.right);
            }
            if(!((p1.right != null && p2.left != null) || 
               (p1.right == null && p2.left == null))) return false;
            else if(p1.right != null && p2.left != null)
            {
                S1.Push(p1.right);
                S2.Push(p2.left);
            }
        }
        if(S1.Count != S2.Count) return false;
        return true;
    }
}
