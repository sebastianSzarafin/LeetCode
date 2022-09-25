https://leetcode.com/problems/implement-queue-using-stacks/?envType=study-plan&id=data-structure-i

public class MyQueue {

    private Stack<int> S1;
    private Stack<int> S2;
    
    public MyQueue() {
        S1 = new Stack<int>();
        S2 = new Stack<int>();
    }
    
    public void Push(int x) {
        S1.Push(x);
    }
    
    public int Pop() {
        while(S1.Count != 0) S2.Push(S1.Pop());
        int x = S2.Pop();
        while(S2.Count != 0) S1.Push(S2.Pop());
        return x;
    }
    
    public int Peek() {
        while(S1.Count != 0) S2.Push(S1.Pop());
        int x = S2.Peek();
        while(S2.Count != 0) S1.Push(S2.Pop());
        return x;
    }
    
    public bool Empty() {
        return S1.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
