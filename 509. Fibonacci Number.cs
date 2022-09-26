https://leetcode.com/problems/fibonacci-number/?envType=study-plan&id=level-1

public class Solution {
    public int Fib(int n) {
        if(n == 0) return 0;
        if(n == 1) return 1;
        int f1 = 0, f2 = 1, temp;
        while(--n > 0)
        {
            temp = f2;
            f2 += f1;
            f1 = temp;
        }
        return f2;
    }
}
