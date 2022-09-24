https://leetcode.com/problems/validate-binary-search-tree/?envType=study-plan&id=level-1

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
    
    public bool IsValidBST(TreeNode root) {
        List<int> route = new List<int>();
        Inorder(root, route);
        for(int i = 0; i < route.Count - 1; i++)
        {
            if(route[i] >= route[i + 1]) return false;
        }
        return true;
    }
}
