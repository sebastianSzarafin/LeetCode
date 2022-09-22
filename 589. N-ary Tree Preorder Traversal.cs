https://leetcode.com/problems/n-ary-tree-preorder-traversal/?envType=study-plan&id=level-1

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    // recursive
    // public List<int> route = new List<int>();
    // public IList<int> Preorder(Node root) {
    //     if(root == null) return route;
    //     route.Add(root.val);
    //     foreach(var child in root.children) Preorder(child);
    //     return route;
    // }
    
    // iterative
    public IList<int> Preorder(Node root) {
        List<int> route = new List<int>();
        if(root == null) return route;
        Stack<Node> S = new Stack<Node>();
        S.Push(root);
        while(S.Count > 0)
        {
            Node p = S.Pop();
            route.Add(p.val);
            for(int i = p.children.Count - 1; i >= 0; i--)
            {
                S.Push(p.children[i]);
            }
        }
        return route;
    }
}
