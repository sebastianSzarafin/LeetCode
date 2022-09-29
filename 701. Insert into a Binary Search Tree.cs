https://leetcode.com/problems/insert-into-a-binary-search-tree/?envType=study-plan&id=data-structure-i

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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if(root == null) return new TreeNode(val);
        TreeNode node = root, prev = root;
        while(node != null)
        {
            prev = node;
            if(node.val < val) node = node.right;
            else node = node.left;
        }
        if(prev.val < val) prev.right = new TreeNode(val);
        else prev.left = new TreeNode(val);
        return root;
    }
}
