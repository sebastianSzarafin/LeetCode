https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/?envType=study-plan&id=level-1

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public List<TreeNode> GetPath(TreeNode root, TreeNode x, List<TreeNode> path)
    {
        path.Add(root);    
        if(root == x) return path;
        if(root.val > x.val) return GetPath(root.left, x, path);
        else return GetPath(root.right, x, path);
           
    }
    
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        List<TreeNode> pathToP = GetPath(root, p, new List<TreeNode>());
        List<TreeNode> pathToQ = GetPath(root, q, new List<TreeNode>());
        TreeNode LCA = root;
        for(int i = 0; i < pathToP.Count; i++)
        {
            for(int j = 0; j < pathToQ.Count; j++)
            {
                if(pathToP[i] == pathToQ[j]) LCA = pathToP[i];
            }
        }
        return LCA;
    }
}
