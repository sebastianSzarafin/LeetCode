https://leetcode.com/problems/binary-tree-level-order-traversal/?envType=study-plan&id=level-1

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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> route = new List<IList<int>>();
        if(root == null) return route;
        Queue<TreeNode> Q = new Queue<TreeNode>();
        Q.Enqueue(root);
        while(Q.Count > 0)
        {
            TreeNode p;
            int levelLength = Q.Count;
            List<int> level = new List<int>();
            for(int i = 0; i < levelLength; i++)
            {
                p = Q.Dequeue();
                level.Add(p.val);
                if(p.left != null) Q.Enqueue(p.left);
                if(p.right != null) Q.Enqueue(p.right);
            }
            route.Add(level);
        }
        return route;
    }
}
