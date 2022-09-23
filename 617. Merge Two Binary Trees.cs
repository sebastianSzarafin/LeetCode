https://leetcode.com/problems/merge-two-binary-trees/?envType=study-plan&id=algorithm-i

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
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        if(root1 == null) return root2;
        if(root2 == null) return root1;
        else root1.val += root2.val;
        if(root1.left == null && root2.left != null) root1.left = new TreeNode();
        if(root1.right == null && root2.right != null) root1.right = new TreeNode();
        MergeTrees(root1.left, root2.left);
        MergeTrees(root1.right, root2.right);
        return root1;
    }
}
