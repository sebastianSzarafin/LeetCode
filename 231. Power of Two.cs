https://leetcode.com/problems/power-of-two/?envType=study-plan&id=algorithm-i

public class Solution {
    // loop
    // public bool IsPowerOfTwo(int n) {
    //     if(n <= 0) return false;
    //     while(n > 1)
    //     {
    //         if(n % 2 == 0) n /= 2;
    //         else return false;
    //     }
    //     return true;
    // }
    
    // bit manipulation
    public bool IsPowerOfTwo(int n) {
        return n > 0 && (n & n - 1) == 0;
    }
}
