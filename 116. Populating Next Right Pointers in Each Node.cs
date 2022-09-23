https://leetcode.com/problems/populating-next-right-pointers-in-each-node/?envType=study-plan&id=algorithm-i

/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public List<Node> LevelOrderTraversial(Node root, List<Node> path)
    {
        Queue<Node> Q = new Queue<Node>();
        Q.Enqueue(root);
        while(Q.Count > 0)
        {
            Node p = Q.Dequeue();
            path.Add(p);
            if(p.left != null) Q.Enqueue(p.left);
            if(p.right != null) Q.Enqueue(p.right);
        }
        return path;
    }
    
    public Node Connect(Node root) {
        if(root == null) return null;
        List<Node> path = LevelOrderTraversial(root, new List<Node>());
        int onLevel = 2, which = 1;
        for(int i = 1; i < path.Count - 1; i++)
        {
            if(which % onLevel != 0) 
            {
                path[i].next = path[i + 1];
                which++;
            }
            else 
            {
                onLevel *= 2;
                which = 1;
            }
        }
        return root;
    }
}
